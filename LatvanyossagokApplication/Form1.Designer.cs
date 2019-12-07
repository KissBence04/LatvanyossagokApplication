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
            ((System.ComponentModel.ISupportInitialize)(this.nUDLakossag)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVarosHozzaAd);
            this.Controls.Add(this.lblLakossag);
            this.Controls.Add(this.nUDLakossag);
            this.Controls.Add(this.lblVnev);
            this.Controls.Add(this.tbVnev);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUDLakossag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVnev;
        private System.Windows.Forms.Label lblVnev;
        private System.Windows.Forms.NumericUpDown nUDLakossag;
        private System.Windows.Forms.Label lblLakossag;
        private System.Windows.Forms.Button btnVarosHozzaAd;
    }
}

