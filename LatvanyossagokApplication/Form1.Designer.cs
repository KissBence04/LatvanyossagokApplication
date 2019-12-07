namespace LatvanyossagokApplication
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
            this.tbVnev = new System.Windows.Forms.TextBox();
            this.lblVnev = new System.Windows.Forms.Label();
            this.nUDLakossag = new System.Windows.Forms.NumericUpDown();
            this.lblLakossag = new System.Windows.Forms.Label();
            this.btnVarosHozzaAd = new System.Windows.Forms.Button();
            this.lblLNev = new System.Windows.Forms.Label();
            this.lblAr = new System.Windows.Forms.Label();
            this.lblLeiras = new System.Windows.Forms.Label();
            this.tBLNev = new System.Windows.Forms.TextBox();
            this.nUDAr = new System.Windows.Forms.NumericUpDown();
            this.LBLeiras = new System.Windows.Forms.ListBox();
            this.btnLatvanyossagHozzaAd = new System.Windows.Forms.Button();
            this.LBVarosok = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLakossag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAr)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVnev
            // 
            this.tbVnev.Location = new System.Drawing.Point(88, 54);
            this.tbVnev.Name = "tbVnev";
            this.tbVnev.Size = new System.Drawing.Size(120, 20);
            this.tbVnev.TabIndex = 0;
            // 
            // lblVnev
            // 
            this.lblVnev.AutoSize = true;
            this.lblVnev.Location = new System.Drawing.Point(12, 57);
            this.lblVnev.Name = "lblVnev";
            this.lblVnev.Size = new System.Drawing.Size(64, 13);
            this.lblVnev.TabIndex = 1;
            this.lblVnev.Text = "Város neve:";
            // 
            // nUDLakossag
            // 
            this.nUDLakossag.Location = new System.Drawing.Point(88, 107);
            this.nUDLakossag.Name = "nUDLakossag";
            this.nUDLakossag.Size = new System.Drawing.Size(120, 20);
            this.nUDLakossag.TabIndex = 2;
            // 
            // lblLakossag
            // 
            this.lblLakossag.AutoSize = true;
            this.lblLakossag.Location = new System.Drawing.Point(12, 109);
            this.lblLakossag.Name = "lblLakossag";
            this.lblLakossag.Size = new System.Drawing.Size(56, 13);
            this.lblLakossag.TabIndex = 3;
            this.lblLakossag.Text = "Lakosság:";
            // 
            // btnVarosHozzaAd
            // 
            this.btnVarosHozzaAd.Location = new System.Drawing.Point(15, 160);
            this.btnVarosHozzaAd.Name = "btnVarosHozzaAd";
            this.btnVarosHozzaAd.Size = new System.Drawing.Size(98, 23);
            this.btnVarosHozzaAd.TabIndex = 4;
            this.btnVarosHozzaAd.Text = "Város hozzáad";
            this.btnVarosHozzaAd.UseVisualStyleBackColor = true;
            this.btnVarosHozzaAd.Click += new System.EventHandler(this.btnVarosHozzaAd_Click);
            // 
            // lblLNev
            // 
            this.lblLNev.AutoSize = true;
            this.lblLNev.Location = new System.Drawing.Point(345, 61);
            this.lblLNev.Name = "lblLNev";
            this.lblLNev.Size = new System.Drawing.Size(103, 13);
            this.lblLNev.TabIndex = 5;
            this.lblLNev.Text = "Látványosság neve:";
            // 
            // lblAr
            // 
            this.lblAr.AutoSize = true;
            this.lblAr.Location = new System.Drawing.Point(345, 114);
            this.lblAr.Name = "lblAr";
            this.lblAr.Size = new System.Drawing.Size(26, 13);
            this.lblAr.TabIndex = 6;
            this.lblAr.Text = "Ára:";
            // 
            // lblLeiras
            // 
            this.lblLeiras.AutoSize = true;
            this.lblLeiras.Location = new System.Drawing.Point(345, 170);
            this.lblLeiras.Name = "lblLeiras";
            this.lblLeiras.Size = new System.Drawing.Size(46, 13);
            this.lblLeiras.TabIndex = 7;
            this.lblLeiras.Text = "Leírása:";
            // 
            // tBLNev
            // 
            this.tBLNev.Location = new System.Drawing.Point(468, 58);
            this.tBLNev.Name = "tBLNev";
            this.tBLNev.Size = new System.Drawing.Size(125, 20);
            this.tBLNev.TabIndex = 8;
            // 
            // nUDAr
            // 
            this.nUDAr.Location = new System.Drawing.Point(468, 107);
            this.nUDAr.Name = "nUDAr";
            this.nUDAr.Size = new System.Drawing.Size(125, 20);
            this.nUDAr.TabIndex = 9;
            // 
            // LBLeiras
            // 
            this.LBLeiras.FormattingEnabled = true;
            this.LBLeiras.Location = new System.Drawing.Point(468, 170);
            this.LBLeiras.Name = "LBLeiras";
            this.LBLeiras.Size = new System.Drawing.Size(125, 95);
            this.LBLeiras.TabIndex = 10;
            // 
            // btnLatvanyossagHozzaAd
            // 
            this.btnLatvanyossagHozzaAd.Location = new System.Drawing.Point(348, 285);
            this.btnLatvanyossagHozzaAd.Name = "btnLatvanyossagHozzaAd";
            this.btnLatvanyossagHozzaAd.Size = new System.Drawing.Size(136, 23);
            this.btnLatvanyossagHozzaAd.TabIndex = 11;
            this.btnLatvanyossagHozzaAd.Text = "Látványosság hozzáad";
            this.btnLatvanyossagHozzaAd.UseVisualStyleBackColor = true;
            this.btnLatvanyossagHozzaAd.Click += new System.EventHandler(this.btnLatvanyossagHozzaAd_Click);
            // 
            // LBVarosok
            // 
            this.LBVarosok.FormattingEnabled = true;
            this.LBVarosok.Location = new System.Drawing.Point(15, 213);
            this.LBVarosok.Name = "LBVarosok";
            this.LBVarosok.Size = new System.Drawing.Size(120, 95);
            this.LBVarosok.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBVarosok);
            this.Controls.Add(this.btnLatvanyossagHozzaAd);
            this.Controls.Add(this.LBLeiras);
            this.Controls.Add(this.nUDAr);
            this.Controls.Add(this.tBLNev);
            this.Controls.Add(this.lblLeiras);
            this.Controls.Add(this.lblAr);
            this.Controls.Add(this.lblLNev);
            this.Controls.Add(this.btnVarosHozzaAd);
            this.Controls.Add(this.lblLakossag);
            this.Controls.Add(this.nUDLakossag);
            this.Controls.Add(this.lblVnev);
            this.Controls.Add(this.tbVnev);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUDLakossag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVnev;
        private System.Windows.Forms.Label lblVnev;
        private System.Windows.Forms.NumericUpDown nUDLakossag;
        private System.Windows.Forms.Label lblLakossag;
        private System.Windows.Forms.Button btnVarosHozzaAd;
        private System.Windows.Forms.Label lblLNev;
        private System.Windows.Forms.Label lblAr;
        private System.Windows.Forms.Label lblLeiras;
        private System.Windows.Forms.TextBox tBLNev;
        private System.Windows.Forms.NumericUpDown nUDAr;
        private System.Windows.Forms.ListBox LBLeiras;
        private System.Windows.Forms.Button btnLatvanyossagHozzaAd;
        private System.Windows.Forms.ListBox LBVarosok;
    }
}

