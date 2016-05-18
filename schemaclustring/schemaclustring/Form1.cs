using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDotNet;
using System.IO;
using columnClustering;
using System.Data.SqlClient;

namespace schemaclustring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'testDBDataSet4.伝票' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.伝票TableAdapter.Fill(this.testDBDataSet4.伝票);
            
            //スキーマ取得
            System.Data.SqlClient.SqlConnection con
            = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = "Data Source=HK-HP\\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"; //接続情報を入れる
            con.Open();

            
            DataTable dt = con.GetSchema("Tables");

            foreach (DataRow row in dt.Rows)
            {
                cmbTable.Items.Add(row["table_name"]);
            }

            //var dtColumns = con.GetSchema("Columns");

            
            //String[] str = { null, null, "伝票" };
            //var sColumns = con.GetSchema("Columns", str);
            //var dview = new DataView(sColumns);
            //shemaDataTabel.DataSource = dview;


            //var listCol = sColumns.Rows[3];

            //var dview = new DataView(sColumns);
            //foreach (DataRow row in sColumns.Rows)
            //{
            //    shemaDataTabel. .Add(row["Columns"]);
            //}

            
            con.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Rの前準備
            var envPath = Environment.GetEnvironmentVariable("PATH");
            var rBinPath = @"C:\Program Files\R\R-3.2.3\bin\x64";
            Environment.SetEnvironmentVariable("PATH", envPath + Path.PathSeparator + rBinPath);
            //using (REngine engine = REngine.CreateInstance("RDotNet"))
            //{
            //    engine.Initialize();

            //    double[] xs, ys;
            //    CreateNoisedSine(out xs, out ys);

            //    NumericVector x = engine.CreateNumericVector(xs);
            //    engine.SetSymbol("x", x);
            //    NumericVector y = engine.CreateNumericVector(ys);
            //    engine.SetSymbol("y", y);

            //    GenericVector response = engine.Evaluate("smooth.spline(x, y, df=5, all.knots=TRUE)").AsList();
            //    NumericVector smoothed = response["y"].AsNumeric();
            //}
            int i = 0;
            using (REngine engine = REngine.CreateInstance("RDotNet"))
            {
                engine.Initialize();

                engine.Evaluate("setwd('c:/work')");
                engine.Evaluate("getwd()").AsCharacter();
                engine.Evaluate("y <- read.csv('datasnull.csv')");
                engine.Evaluate("y").AsCharacter();
                engine.Evaluate("km =kmeans(y,2)");
                CharacterVector text =engine.Evaluate("km$cluster").AsCharacter();

                CharacterVector table = engine.Evaluate("table(km$cluster)").AsCharacter();

                string mins;
                if (int.Parse(table[0]) < int.Parse(table[1]))
                {
                    mins = "1";
                }
                else
                {
                    mins = "2";
                }
                foreach (string t in text) {
                    i++;
                    richTextBox2.Text += i+"列目　"+ t+ "\n";

                    if(t == mins)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                    }
                }
                //CharacterVector table = engine.Evaluate("table(km$cluster)").AsCharacter();
                richTextBox2.Text += "クラスタ1  "+table[0] +" クラスタ2　" +table[1]+"\n";
            }
            //Rの呼び出し
            //nullクラスタリング

            //列名クラスタリング

            //候補列の色を変える
        }

        static void CreateNoisedSine(out double[] degrees, out double[] values)
        {
            var rnd = new Random(Environment.TickCount);
            degrees = new double[360];
            values = new double[degrees.Length];
            for (int i = 0; i < degrees.Length; ++i)
            {
                degrees[i] = i;
                values[i] = Math.Sin(degrees[i] * Math.PI / 180.0) + rnd.NextDouble() / 10.0;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //各列カラム名取得
            var col = dataGridView1.ColumnCount;
            
            var colNames = new List<string>();
            for(int i =0;i< dataGridView1.ColumnCount; i++)
            {
                colNames.Add(dataGridView1.Columns[i].HeaderCell.Value.ToString());
            }
            //関連度を測定
            List<float> 関連度リスト = new List<float>();

            var 関連度クラス = new Cluster();
            for(int i = 0; i< colNames.Count; i++ )
            {
                //関連度リスト.Add(関連度クラス.get関連語数(colNames[i], colNames[i + 1]));
                関連度リスト.Add(関連度クラス.get関連語数("受注", colNames[i]));
            }

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if(関連度リスト[i] == 0)
                {
                    //dataGridView1.Columns[i].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Columns[i].HeaderCell.Style.ForeColor = Color.Red; ;
                }
                
            }
            
            //高い列を従属推定

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //スキーマ取得
            SqlConnection con
            = new SqlConnection();
            con.ConnectionString = "Data Source=HK-HP\\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"; //接続情報を入れる
            con.Open();

            //クエリーの生成
            SqlCommand sqlCom = new SqlCommand();

            //クエリー送信先及びトランザクションの指定
            sqlCom.Connection = con;
            //sqlCom.Transaction = this.sqlTran;

            //クエリー文の指定
            sqlCom.CommandText = "SELECT * FROM " +cmbTable.Text+ ";";

            //データテーブルを作成するためのアダプタ
            SqlDataAdapter sqlAda = new SqlDataAdapter();
            sqlAda.SelectCommand = sqlCom;


            //dsにテーブルデータを代入
            DataTable ds = new DataTable();
            sqlAda.Fill(ds);

            dataGridView1.DataSource = ds;

            DataTable dt = con.GetSchema("Tables");

            //foreach (DataRow row in dt.Rows)
            //{
            //    cmbTable.Items.Add(row["table_name"]);
            //}

            var dtColumns = con.GetSchema("Columns");


            String[] str = { null, null, cmbTable.Text };
            var sColumns = con.GetSchema("Columns", str);
            var dview = new DataView(sColumns);
            shemaDataTabel.DataSource = dview;


            var listCol = sColumns.Rows[3];

            //var dview = new DataView(sColumns);
            //foreach (DataRow row in sColumns.Rows)
            //{
            //    shemaDataTabel. .Add(row["Columns"]);
            //}


            con.Close();
        }
    }
}
