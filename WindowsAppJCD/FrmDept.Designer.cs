namespace WindowsAppJCD
{
    partial class FrmDept
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
            this.dgvdept = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdept)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdept
            // 
            this.dgvdept.AllowUserToAddRows = false;
            this.dgvdept.AllowUserToDeleteRows = false;
            this.dgvdept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdept.Location = new System.Drawing.Point(65, 295);
            this.dgvdept.Name = "dgvdept";
            this.dgvdept.ReadOnly = true;
            this.dgvdept.RowHeadersWidth = 51;
            this.dgvdept.RowTemplate.Height = 24;
            this.dgvdept.Size = new System.Drawing.Size(639, 290);
            this.dgvdept.TabIndex = 21;
            this.dgvdept.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdept_CellClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(476, 210);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 55);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(339, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 55);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(202, 210);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 55);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(65, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 55);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(161, 140);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(123, 37);
            this.txtLoc.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Loc";
            // 
            // txtDName
            // 
            this.txtDName.Location = new System.Drawing.Point(161, 76);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(203, 37);
            this.txtDName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "DName";
            // 
            // txtDNo
            // 
            this.txtDNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtDNo.Location = new System.Drawing.Point(161, 19);
            this.txtDNo.Name = "txtDNo";
            this.txtDNo.ReadOnly = true;
            this.txtDNo.Size = new System.Drawing.Size(123, 37);
            this.txtDNo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "DNo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 59);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvdept);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmDept";
            this.Text = "FrmDept";
            this.Load += new System.EventHandler(this.FrmDept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdept;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}