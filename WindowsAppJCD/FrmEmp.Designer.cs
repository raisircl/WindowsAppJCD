namespace WindowsAppJCD
{
    partial class FrmEmp
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
            this.txteno = new System.Windows.Forms.TextBox();
            this.txtename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtjob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHiredate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.dgvemp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENo";
            // 
            // txteno
            // 
            this.txteno.Location = new System.Drawing.Point(222, 56);
            this.txteno.Name = "txteno";
            this.txteno.Size = new System.Drawing.Size(270, 41);
            this.txteno.TabIndex = 1;
            // 
            // txtename
            // 
            this.txtename.Location = new System.Drawing.Point(222, 115);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(270, 41);
            this.txtename.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "EName";
            // 
            // txtjob
            // 
            this.txtjob.Location = new System.Drawing.Point(222, 180);
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(270, 41);
            this.txtjob.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Job";
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(222, 239);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(270, 41);
            this.txtsal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hiredate";
            // 
            // dtpHiredate
            // 
            this.dtpHiredate.CustomFormat = "dd/MM/yyyy";
            this.dtpHiredate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHiredate.Location = new System.Drawing.Point(222, 300);
            this.dtpHiredate.Name = "dtpHiredate";
            this.dtpHiredate.Size = new System.Drawing.Size(270, 41);
            this.dtpHiredate.TabIndex = 9;
            this.dtpHiredate.Value = new System.DateTime(2023, 9, 7, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Department";
            // 
            // cmbdept
            // 
            this.cmbdept.FormattingEnabled = true;
            this.cmbdept.Location = new System.Drawing.Point(222, 376);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(298, 44);
            this.cmbdept.TabIndex = 11;
            this.cmbdept.SelectedIndexChanged += new System.EventHandler(this.cmbdept_SelectedIndexChanged);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(31, 447);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(180, 53);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dgvemp
            // 
            this.dgvemp.AllowUserToAddRows = false;
            this.dgvemp.AllowUserToDeleteRows = false;
            this.dgvemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemp.Location = new System.Drawing.Point(605, 38);
            this.dgvemp.Name = "dgvemp";
            this.dgvemp.ReadOnly = true;
            this.dgvemp.RowHeadersWidth = 51;
            this.dgvemp.RowTemplate.Height = 24;
            this.dgvemp.Size = new System.Drawing.Size(1109, 618);
            this.dgvemp.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 684);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvemp);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cmbdept);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpHiredate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtjob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txteno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmEmp";
            this.Text = "FrmEmp";
            this.Load += new System.EventHandler(this.FrmEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txteno;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtjob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHiredate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbdept;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgvemp;
        private System.Windows.Forms.Button button1;
    }
}