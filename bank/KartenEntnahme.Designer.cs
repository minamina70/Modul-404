namespace Bankomat_bb
{
    partial class KartenEntnahme
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
            this.btnKarteAus = new System.Windows.Forms.Button();
            this.lblAnleitung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKarteAus
            // 
            this.btnKarteAus.Location = new System.Drawing.Point(108, 123);
            this.btnKarteAus.Name = "btnKarteAus";
            this.btnKarteAus.Size = new System.Drawing.Size(109, 34);
            this.btnKarteAus.TabIndex = 1;
            this.btnKarteAus.Text = "Karte entnehmen";
            this.btnKarteAus.UseVisualStyleBackColor = true;
            this.btnKarteAus.Click += new System.EventHandler(this.KarteAus_Click);
            // 
            // lblAnleitung
            // 
            this.lblAnleitung.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAnleitung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnleitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnleitung.ForeColor = System.Drawing.Color.White;
            this.lblAnleitung.Location = new System.Drawing.Point(-3, 18);
            this.lblAnleitung.Name = "lblAnleitung";
            this.lblAnleitung.Size = new System.Drawing.Size(331, 52);
            this.lblAnleitung.TabIndex = 2;
            this.lblAnleitung.Text = "Bitte entnehmen Sie Ihre Karte.";
            this.lblAnleitung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KartenEntnahme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 271);
            this.Controls.Add(this.lblAnleitung);
            this.Controls.Add(this.btnKarteAus);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "KartenEntnahme";
            this.Text = "KartenEntnahme";
            this.Load += new System.EventHandler(this.KartenEntnahme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKarteAus;
        private System.Windows.Forms.Label lblAnleitung;
    }
}