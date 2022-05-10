namespace WindowsForms_Database_Learning
{
    partial class Student
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1_Create = new System.Windows.Forms.Button();
            this.button2_Save = new System.Windows.Forms.Button();
            this.button3_Update = new System.Windows.Forms.Button();
            this.button4_Delete = new System.Windows.Forms.Button();
            this.button5_Search = new System.Windows.Forms.Button();
            this.button6_ShowAll = new System.Windows.Forms.Button();
            this.textBox1_RollNo = new System.Windows.Forms.TextBox();
            this.textBox2_Name = new System.Windows.Forms.TextBox();
            this.textBox3_Branch = new System.Windows.Forms.TextBox();
            this.textBox4_Percentage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roll Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Percentage";
            // 
            // button1_Create
            // 
            this.button1_Create.Location = new System.Drawing.Point(59, 306);
            this.button1_Create.Name = "button1_Create";
            this.button1_Create.Size = new System.Drawing.Size(75, 23);
            this.button1_Create.TabIndex = 4;
            this.button1_Create.Text = "Create";
            this.button1_Create.UseVisualStyleBackColor = true;
            this.button1_Create.Click += new System.EventHandler(this.button1_Create_Click);
            // 
            // button2_Save
            // 
            this.button2_Save.Location = new System.Drawing.Point(181, 306);
            this.button2_Save.Name = "button2_Save";
            this.button2_Save.Size = new System.Drawing.Size(75, 23);
            this.button2_Save.TabIndex = 5;
            this.button2_Save.Text = "Save";
            this.button2_Save.UseVisualStyleBackColor = true;
            this.button2_Save.Click += new System.EventHandler(this.button2_Save_Click);
            // 
            // button3_Update
            // 
            this.button3_Update.Location = new System.Drawing.Point(289, 306);
            this.button3_Update.Name = "button3_Update";
            this.button3_Update.Size = new System.Drawing.Size(75, 23);
            this.button3_Update.TabIndex = 6;
            this.button3_Update.Text = "Update";
            this.button3_Update.UseVisualStyleBackColor = true;
            this.button3_Update.Click += new System.EventHandler(this.button3_Update_Click);
            // 
            // button4_Delete
            // 
            this.button4_Delete.Location = new System.Drawing.Point(430, 306);
            this.button4_Delete.Name = "button4_Delete";
            this.button4_Delete.Size = new System.Drawing.Size(75, 23);
            this.button4_Delete.TabIndex = 7;
            this.button4_Delete.Text = "Delete";
            this.button4_Delete.UseVisualStyleBackColor = true;
            this.button4_Delete.Click += new System.EventHandler(this.button4_Delete_Click);
            // 
            // button5_Search
            // 
            this.button5_Search.Location = new System.Drawing.Point(548, 306);
            this.button5_Search.Name = "button5_Search";
            this.button5_Search.Size = new System.Drawing.Size(75, 23);
            this.button5_Search.TabIndex = 8;
            this.button5_Search.Text = "Search";
            this.button5_Search.UseVisualStyleBackColor = true;
            this.button5_Search.Click += new System.EventHandler(this.button5_Search_Click);
            // 
            // button6_ShowAll
            // 
            this.button6_ShowAll.Location = new System.Drawing.Point(676, 306);
            this.button6_ShowAll.Name = "button6_ShowAll";
            this.button6_ShowAll.Size = new System.Drawing.Size(75, 23);
            this.button6_ShowAll.TabIndex = 9;
            this.button6_ShowAll.Text = "Show All";
            this.button6_ShowAll.UseVisualStyleBackColor = true;
            this.button6_ShowAll.Click += new System.EventHandler(this.button6_ShowAll_Click);
            // 
            // textBox1_RollNo
            // 
            this.textBox1_RollNo.Location = new System.Drawing.Point(181, 118);
            this.textBox1_RollNo.Name = "textBox1_RollNo";
            this.textBox1_RollNo.Size = new System.Drawing.Size(100, 20);
            this.textBox1_RollNo.TabIndex = 10;
            // 
            // textBox2_Name
            // 
            this.textBox2_Name.Location = new System.Drawing.Point(181, 163);
            this.textBox2_Name.Name = "textBox2_Name";
            this.textBox2_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox2_Name.TabIndex = 11;
            // 
            // textBox3_Branch
            // 
            this.textBox3_Branch.Location = new System.Drawing.Point(181, 206);
            this.textBox3_Branch.Name = "textBox3_Branch";
            this.textBox3_Branch.Size = new System.Drawing.Size(100, 20);
            this.textBox3_Branch.TabIndex = 12;
            // 
            // textBox4_Percentage
            // 
            this.textBox4_Percentage.Location = new System.Drawing.Point(181, 249);
            this.textBox4_Percentage.Name = "textBox4_Percentage";
            this.textBox4_Percentage.Size = new System.Drawing.Size(100, 20);
            this.textBox4_Percentage.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(290, 174);
            this.dataGridView1.TabIndex = 14;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4_Percentage);
            this.Controls.Add(this.textBox3_Branch);
            this.Controls.Add(this.textBox2_Name);
            this.Controls.Add(this.textBox1_RollNo);
            this.Controls.Add(this.button6_ShowAll);
            this.Controls.Add(this.button5_Search);
            this.Controls.Add(this.button4_Delete);
            this.Controls.Add(this.button3_Update);
            this.Controls.Add(this.button2_Save);
            this.Controls.Add(this.button1_Create);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Student";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1_Create;
        private System.Windows.Forms.Button button2_Save;
        private System.Windows.Forms.Button button3_Update;
        private System.Windows.Forms.Button button4_Delete;
        private System.Windows.Forms.Button button5_Search;
        private System.Windows.Forms.Button button6_ShowAll;
        private System.Windows.Forms.TextBox textBox1_RollNo;
        private System.Windows.Forms.TextBox textBox2_Name;
        private System.Windows.Forms.TextBox textBox3_Branch;
        private System.Windows.Forms.TextBox textBox4_Percentage;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}