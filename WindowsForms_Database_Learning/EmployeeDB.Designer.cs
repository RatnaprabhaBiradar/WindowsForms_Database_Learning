namespace WindowsForms_Database_Learning
{
    partial class EmployeeDB
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
            this.textBox1_EmpID = new System.Windows.Forms.TextBox();
            this.textBox2_EmpName = new System.Windows.Forms.TextBox();
            this.textBox3_EmpDesignation = new System.Windows.Forms.TextBox();
            this.textBox4_EmpSalary = new System.Windows.Forms.TextBox();
            this.button1_Create = new System.Windows.Forms.Button();
            this.button2_Update = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.button4_Delete = new System.Windows.Forms.Button();
            this.button5_Save = new System.Windows.Forms.Button();
            this.button1_ShowAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salary";
            // 
            // textBox1_EmpID
            // 
            this.textBox1_EmpID.Location = new System.Drawing.Point(231, 46);
            this.textBox1_EmpID.Name = "textBox1_EmpID";
            this.textBox1_EmpID.Size = new System.Drawing.Size(100, 20);
            this.textBox1_EmpID.TabIndex = 4;
            // 
            // textBox2_EmpName
            // 
            this.textBox2_EmpName.Location = new System.Drawing.Point(231, 94);
            this.textBox2_EmpName.Name = "textBox2_EmpName";
            this.textBox2_EmpName.Size = new System.Drawing.Size(100, 20);
            this.textBox2_EmpName.TabIndex = 5;
            // 
            // textBox3_EmpDesignation
            // 
            this.textBox3_EmpDesignation.Location = new System.Drawing.Point(231, 158);
            this.textBox3_EmpDesignation.Name = "textBox3_EmpDesignation";
            this.textBox3_EmpDesignation.Size = new System.Drawing.Size(100, 20);
            this.textBox3_EmpDesignation.TabIndex = 6;
            // 
            // textBox4_EmpSalary
            // 
            this.textBox4_EmpSalary.Location = new System.Drawing.Point(231, 223);
            this.textBox4_EmpSalary.Name = "textBox4_EmpSalary";
            this.textBox4_EmpSalary.Size = new System.Drawing.Size(100, 20);
            this.textBox4_EmpSalary.TabIndex = 7;
            // 
            // button1_Create
            // 
            this.button1_Create.Location = new System.Drawing.Point(32, 281);
            this.button1_Create.Name = "button1_Create";
            this.button1_Create.Size = new System.Drawing.Size(75, 23);
            this.button1_Create.TabIndex = 8;
            this.button1_Create.Text = "Create";
            this.button1_Create.UseVisualStyleBackColor = true;
            this.button1_Create.Click += new System.EventHandler(this.button1_Create_Click);
            // 
            // button2_Update
            // 
            this.button2_Update.Location = new System.Drawing.Point(128, 281);
            this.button2_Update.Name = "button2_Update";
            this.button2_Update.Size = new System.Drawing.Size(75, 23);
            this.button2_Update.TabIndex = 9;
            this.button2_Update.Text = "Update";
            this.button2_Update.UseVisualStyleBackColor = true;
            this.button2_Update.Click += new System.EventHandler(this.button2_Update_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(231, 281);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 10;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button4_Delete
            // 
            this.button4_Delete.Location = new System.Drawing.Point(354, 281);
            this.button4_Delete.Name = "button4_Delete";
            this.button4_Delete.Size = new System.Drawing.Size(75, 23);
            this.button4_Delete.TabIndex = 11;
            this.button4_Delete.Text = "Delete";
            this.button4_Delete.UseVisualStyleBackColor = true;
            this.button4_Delete.Click += new System.EventHandler(this.button4_Delete_Click);
            // 
            // button5_Save
            // 
            this.button5_Save.Location = new System.Drawing.Point(473, 281);
            this.button5_Save.Name = "button5_Save";
            this.button5_Save.Size = new System.Drawing.Size(75, 23);
            this.button5_Save.TabIndex = 12;
            this.button5_Save.Text = "Save";
            this.button5_Save.UseVisualStyleBackColor = true;
            this.button5_Save.Click += new System.EventHandler(this.button5_Save_Click);
            // 
            // button1_ShowAll
            // 
            this.button1_ShowAll.Location = new System.Drawing.Point(607, 281);
            this.button1_ShowAll.Name = "button1_ShowAll";
            this.button1_ShowAll.Size = new System.Drawing.Size(75, 23);
            this.button1_ShowAll.TabIndex = 13;
            this.button1_ShowAll.Text = "Show All";
            this.button1_ShowAll.UseVisualStyleBackColor = true;
            this.button1_ShowAll.Click += new System.EventHandler(this.button1_ShowAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(437, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(294, 178);
            this.dataGridView1.TabIndex = 14;
            // 
            // EmployeeDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1_ShowAll);
            this.Controls.Add(this.button5_Save);
            this.Controls.Add(this.button4_Delete);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button2_Update);
            this.Controls.Add(this.button1_Create);
            this.Controls.Add(this.textBox4_EmpSalary);
            this.Controls.Add(this.textBox3_EmpDesignation);
            this.Controls.Add(this.textBox2_EmpName);
            this.Controls.Add(this.textBox1_EmpID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeDB";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.EmployeeDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_EmpID;
        private System.Windows.Forms.TextBox textBox2_EmpName;
        private System.Windows.Forms.TextBox textBox3_EmpDesignation;
        private System.Windows.Forms.TextBox textBox4_EmpSalary;
        private System.Windows.Forms.Button button1_Create;
        private System.Windows.Forms.Button button2_Update;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button4_Delete;
        private System.Windows.Forms.Button button5_Save;
        private System.Windows.Forms.Button button1_ShowAll;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}