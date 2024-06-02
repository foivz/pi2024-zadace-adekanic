namespace Zadaca_03
{
    partial class FrmChange
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(515, 271);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Odustani";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(49, 163);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtDriver
            // 
            this.txtDriver.Location = new System.Drawing.Point(172, 163);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(131, 22);
            this.txtDriver.TabIndex = 3;
            this.txtDriver.TextChanged += new System.EventHandler(this.txtDriver_TextChanged);
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(331, 163);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(100, 22);
            this.txtLine.TabIndex = 4;
            this.txtLine.TextChanged += new System.EventHandler(this.txtLine_TextChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(471, 163);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 22);
            this.txtStatus.TabIndex = 5;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(614, 163);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(77, 144);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 16);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID Bus";
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Location = new System.Drawing.Point(214, 144);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(45, 16);
            this.lblDriver.TabIndex = 8;
            this.lblDriver.Text = "Vozač";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(364, 144);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(38, 16);
            this.lblLine.TabIndex = 9;
            this.lblLine.Text = "Linija";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(499, 144);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(643, 144);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Naziv";
            // 
            // FrmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(739, 315);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.txtDriver);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.button1);
            this.Name = "FrmChange";
            this.Text = "FrmChange";
            this.Load += new System.EventHandler(this.FrmChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblName;
    }
}