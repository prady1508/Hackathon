namespace SvcBusTestHack
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.txtLn = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFillGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "School Name";
            // 
            // txtStudID
            // 
            this.txtStudID.Location = new System.Drawing.Point(152, 26);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(165, 20);
            this.txtStudID.TabIndex = 6;
            // 
            // txtFn
            // 
            this.txtFn.Location = new System.Drawing.Point(152, 69);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(165, 20);
            this.txtFn.TabIndex = 7;
            // 
            // txtLn
            // 
            this.txtLn.Location = new System.Drawing.Point(152, 112);
            this.txtLn.Name = "txtLn";
            this.txtLn.Size = new System.Drawing.Size(165, 20);
            this.txtLn.TabIndex = 8;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(152, 155);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(165, 20);
            this.txtSex.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(152, 193);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(165, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Location = new System.Drawing.Point(152, 233);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(165, 20);
            this.txtSchoolName.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(242, 282);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(458, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // txtFillGrid
            // 
            this.txtFillGrid.Location = new System.Drawing.Point(690, 281);
            this.txtFillGrid.Name = "txtFillGrid";
            this.txtFillGrid.Size = new System.Drawing.Size(75, 23);
            this.txtFillGrid.TabIndex = 14;
            this.txtFillGrid.Text = "Fill Grid";
            this.txtFillGrid.UseVisualStyleBackColor = true;
            this.txtFillGrid.Click += new System.EventHandler(this.txtFillGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 326);
            this.Controls.Add(this.txtFillGrid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSchoolName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtLn);
            this.Controls.Add(this.txtFn);
            this.Controls.Add(this.txtStudID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.TextBox txtLn;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtFillGrid;
    }
}

