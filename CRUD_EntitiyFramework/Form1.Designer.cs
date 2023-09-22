namespace CRUD_EntitiyFramework
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
            this.btnFInd = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtDeptNo = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtdoj = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFInd
            // 
            this.btnFInd.Location = new System.Drawing.Point(428, 339);
            this.btnFInd.Name = "btnFInd";
            this.btnFInd.Size = new System.Drawing.Size(80, 36);
            this.btnFInd.TabIndex = 97;
            this.btnFInd.Text = "Find";
            this.btnFInd.UseVisualStyleBackColor = true;
            this.btnFInd.Click += new System.EventHandler(this.btnFInd_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(493, 379);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(80, 36);
            this.Clear.TabIndex = 96;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(361, 379);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 36);
            this.btnDelete.TabIndex = 95;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(493, 297);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 36);
            this.btnUpdate.TabIndex = 94;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(361, 297);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 36);
            this.btnInsert.TabIndex = 93;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtDeptNo
            // 
            this.txtDeptNo.Location = new System.Drawing.Point(375, 240);
            this.txtDeptNo.Name = "txtDeptNo";
            this.txtDeptNo.Size = new System.Drawing.Size(147, 26);
            this.txtDeptNo.TabIndex = 92;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(375, 201);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(147, 26);
            this.txtSal.TabIndex = 91;
            // 
            // txtdoj
            // 
            this.txtdoj.Location = new System.Drawing.Point(375, 162);
            this.txtdoj.Name = "txtdoj";
            this.txtdoj.Size = new System.Drawing.Size(147, 26);
            this.txtdoj.TabIndex = 90;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(375, 119);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(147, 26);
            this.txtDesignation.TabIndex = 89;
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(375, 80);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(147, 26);
            this.txtEname.TabIndex = 88;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(375, 36);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(147, 26);
            this.txtEmpId.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(259, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 30);
            this.label6.TabIndex = 86;
            this.label6.Text = "Enter Deptno";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(259, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 30);
            this.label5.TabIndex = 85;
            this.label5.Text = "Enter Salary";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(259, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 30);
            this.label4.TabIndex = 84;
            this.label4.Text = "Enter DOJ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(228, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 30);
            this.label3.TabIndex = 83;
            this.label3.Text = "Enter Designation";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(259, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 30);
            this.label2.TabIndex = 82;
            this.label2.Text = "Enter EName";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(259, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 81;
            this.label1.Text = "Enter EmpId";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFInd);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtDeptNo);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtdoj);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFInd;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtDeptNo;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.TextBox txtdoj;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

