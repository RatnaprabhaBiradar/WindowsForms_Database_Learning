namespace WindowsForms_Database_Learning
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_ProdID = new System.Windows.Forms.TextBox();
            this.textBox2_ProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3_ProdPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1_AddNew = new System.Windows.Forms.Button();
            this.button2_Save = new System.Windows.Forms.Button();
            this.button3_Update = new System.Windows.Forms.Button();
            this.button4_Search = new System.Windows.Forms.Button();
            this.button5_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1_showProductAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Id";
            // 
            // textBox1_ProdID
            // 
            this.textBox1_ProdID.Location = new System.Drawing.Point(231, 51);
            this.textBox1_ProdID.Name = "textBox1_ProdID";
            this.textBox1_ProdID.Size = new System.Drawing.Size(100, 20);
            this.textBox1_ProdID.TabIndex = 1;
            // 
            // textBox2_ProdName
            // 
            this.textBox2_ProdName.Location = new System.Drawing.Point(231, 110);
            this.textBox2_ProdName.Name = "textBox2_ProdName";
            this.textBox2_ProdName.Size = new System.Drawing.Size(100, 20);
            this.textBox2_ProdName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "producrt Name";
            // 
            // textBox3_ProdPrice
            // 
            this.textBox3_ProdPrice.Location = new System.Drawing.Point(231, 162);
            this.textBox3_ProdPrice.Name = "textBox3_ProdPrice";
            this.textBox3_ProdPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox3_ProdPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Price";
            // 
            // button1_AddNew
            // 
            this.button1_AddNew.Location = new System.Drawing.Point(79, 239);
            this.button1_AddNew.Name = "button1_AddNew";
            this.button1_AddNew.Size = new System.Drawing.Size(75, 23);
            this.button1_AddNew.TabIndex = 6;
            this.button1_AddNew.Text = "Add New";
            this.button1_AddNew.UseVisualStyleBackColor = true;
            this.button1_AddNew.Click += new System.EventHandler(this.button1_AddNew_Click);
            // 
            // button2_Save
            // 
            this.button2_Save.Location = new System.Drawing.Point(175, 239);
            this.button2_Save.Name = "button2_Save";
            this.button2_Save.Size = new System.Drawing.Size(75, 23);
            this.button2_Save.TabIndex = 7;
            this.button2_Save.Text = "Save";
            this.button2_Save.UseVisualStyleBackColor = true;
            this.button2_Save.Click += new System.EventHandler(this.button2_Save_Click);
            // 
            // button3_Update
            // 
            this.button3_Update.Location = new System.Drawing.Point(284, 239);
            this.button3_Update.Name = "button3_Update";
            this.button3_Update.Size = new System.Drawing.Size(75, 23);
            this.button3_Update.TabIndex = 8;
            this.button3_Update.Text = "Update";
            this.button3_Update.UseVisualStyleBackColor = true;
            this.button3_Update.Click += new System.EventHandler(this.button3_Update_Click);
            // 
            // button4_Search
            // 
            this.button4_Search.Location = new System.Drawing.Point(126, 314);
            this.button4_Search.Name = "button4_Search";
            this.button4_Search.Size = new System.Drawing.Size(75, 23);
            this.button4_Search.TabIndex = 9;
            this.button4_Search.Text = "Search";
            this.button4_Search.UseVisualStyleBackColor = true;
            this.button4_Search.Click += new System.EventHandler(this.button4_Search_Click);
            // 
            // button5_Delete
            // 
            this.button5_Delete.Location = new System.Drawing.Point(231, 314);
            this.button5_Delete.Name = "button5_Delete";
            this.button5_Delete.Size = new System.Drawing.Size(75, 23);
            this.button5_Delete.TabIndex = 10;
            this.button5_Delete.Text = "Delete";
            this.button5_Delete.UseVisualStyleBackColor = true;
            this.button5_Delete.Click += new System.EventHandler(this.button5_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(402, 167);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button1_showProductAll
            // 
            this.button1_showProductAll.Location = new System.Drawing.Point(520, 251);
            this.button1_showProductAll.Name = "button1_showProductAll";
            this.button1_showProductAll.Size = new System.Drawing.Size(75, 23);
            this.button1_showProductAll.TabIndex = 12;
            this.button1_showProductAll.Text = "Show All Product";
            this.button1_showProductAll.UseVisualStyleBackColor = true;
            this.button1_showProductAll.Click += new System.EventHandler(this.button1_showProductAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 380);
            this.Controls.Add(this.button1_showProductAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5_Delete);
            this.Controls.Add(this.button4_Search);
            this.Controls.Add(this.button3_Update);
            this.Controls.Add(this.button2_Save);
            this.Controls.Add(this.button1_AddNew);
            this.Controls.Add(this.textBox3_ProdPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2_ProdName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_ProdID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_ProdID;
        private System.Windows.Forms.TextBox textBox2_ProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3_ProdPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1_AddNew;
        private System.Windows.Forms.Button button2_Save;
        private System.Windows.Forms.Button button3_Update;
        private System.Windows.Forms.Button button4_Search;
        private System.Windows.Forms.Button button5_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1_showProductAll;
    }
}

