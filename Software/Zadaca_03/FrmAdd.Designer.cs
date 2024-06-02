namespace Zadaca_03
{
    partial class FrmAdd
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblVozac = new System.Windows.Forms.Label();
            this.lblLinija = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.txtIdBus = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(72, 114);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(46, 16);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID Bus";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVozac
            // 
            this.lblVozac.AutoSize = true;
            this.lblVozac.Location = new System.Drawing.Point(238, 114);
            this.lblVozac.Name = "lblVozac";
            this.lblVozac.Size = new System.Drawing.Size(45, 16);
            this.lblVozac.TabIndex = 3;
            this.lblVozac.Text = "Vozač";
            this.lblVozac.Click += new System.EventHandler(this.lblVozac_Click);
            // 
            // lblLinija
            // 
            this.lblLinija.AutoSize = true;
            this.lblLinija.Location = new System.Drawing.Point(408, 114);
            this.lblLinija.Name = "lblLinija";
            this.lblLinija.Size = new System.Drawing.Size(38, 16);
            this.lblLinija.TabIndex = 4;
            this.lblLinija.Text = "Linija";
            this.lblLinija.Click += new System.EventHandler(this.lblLinija_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(544, 114);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(377, 133);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(100, 22);
            this.txtLine.TabIndex = 6;
            this.txtLine.TextChanged += new System.EventHandler(this.txtLine_TextChanged);
            // 
            // txtDriver
            // 
            this.txtDriver.Location = new System.Drawing.Point(185, 133);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(152, 22);
            this.txtDriver.TabIndex = 7;
            this.txtDriver.TextChanged += new System.EventHandler(this.txtDriver_TextChanged);
            // 
            // txtIdBus
            // 
            this.txtIdBus.Location = new System.Drawing.Point(46, 133);
            this.txtIdBus.Name = "txtIdBus";
            this.txtIdBus.Size = new System.Drawing.Size(100, 22);
            this.txtIdBus.TabIndex = 8;
            this.txtIdBus.TextChanged += new System.EventHandler(this.txtIdBus_TextChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(519, 133);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 22);
            this.txtStatus.TabIndex = 9;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(690, 114);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(41, 16);
            this.lblNaziv.TabIndex = 10;
            this.lblNaziv.Text = "Naziv";
            this.lblNaziv.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(656, 133);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(105, 22);
            this.txtNaziv.TabIndex = 11;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(544, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(686, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(779, 290);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtIdBus);
            this.Controls.Add(this.txtDriver);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLinija);
            this.Controls.Add(this.lblVozac);
            this.Controls.Add(this.lblId);
            this.Name = "FrmAdd";
            this.Text = "FrmAdd";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblVozac;
        private System.Windows.Forms.Label lblLinija;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.TextBox txtIdBus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}