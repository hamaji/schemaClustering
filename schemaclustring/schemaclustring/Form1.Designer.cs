﻿namespace schemaclustring
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.伝票BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.shemaDataTabel = new System.Windows.Forms.DataGridView();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.伝票BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shemaDataTabel)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "スキーマ選択";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(53, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(842, 132);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 伝票BindingSource
            // 
            this.伝票BindingSource.DataMember = "伝票";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 19);
            this.textBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 18);
            this.button2.TabIndex = 4;
            this.button2.Text = "データベース選択";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(578, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 26);
            this.button3.TabIndex = 5;
            this.button3.Text = "スキーマ分析クラスタリング";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 28);
            this.button4.TabIndex = 6;
            this.button4.Text = "リファクタリングDML作成";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(39, 556);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "実行";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // cmbTable
            // 
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(53, 66);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(329, 20);
            this.cmbTable.TabIndex = 9;
            // 
            // shemaDataTabel
            // 
            this.shemaDataTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shemaDataTabel.Location = new System.Drawing.Point(39, 324);
            this.shemaDataTabel.Name = "shemaDataTabel";
            this.shemaDataTabel.RowTemplate.Height = 21;
            this.shemaDataTabel.Size = new System.Drawing.Size(841, 113);
            this.shemaDataTabel.TabIndex = 10;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(39, 459);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(824, 91);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(742, 60);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 26);
            this.button6.TabIndex = 12;
            this.button6.Text = "カラム分析クラスタリング";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 607);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.shemaDataTabel);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "スキーマリファクタリング推薦システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.伝票BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shemaDataTabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.DataGridView shemaDataTabel;
        private System.Windows.Forms.RichTextBox richTextBox2;
        
        private System.Windows.Forms.BindingSource 伝票BindingSource;
        private System.Windows.Forms.Button button6;
        
    }
}

