namespace Bankomat_bb
{
    partial class PinEingabe
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
            this.lblPW = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.btnPW = new System.Windows.Forms.Button();
            this.lblAnleitung = new System.Windows.Forms.Label();
            this.btnAbbruch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPW
            // 
            this.lblPW.Location = new System.Drawing.Point(12, 127);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(86, 13);
            this.lblPW.TabIndex = 2;
            this.lblPW.Text = "PIN: ";
            this.lblPW.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(113, 120);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(89, 20);
            this.txtPW.TabIndex = 0;
            this.txtPW.UseSystemPasswordChar = true;
            // 
            // btnPW
            // 
            this.btnPW.Location = new System.Drawing.Point(221, 120);
            this.btnPW.Name = "btnPW";
            this.btnPW.Size = new System.Drawing.Size(66, 24);
            this.btnPW.TabIndex = 1;
            this.btnPW.Text = "OK";
            this.btnPW.UseVisualStyleBackColor = true;
            this.btnPW.Click += new System.EventHandler(this.ButtonPW_Click);
            // 
            // lblAnleitung
            // 
            this.lblAnleitung.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAnleitung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnleitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnleitung.ForeColor = System.Drawing.Color.White;
            this.lblAnleitung.Location = new System.Drawing.Point(-2, 9);
            this.lblAnleitung.Name = "lblAnleitung";
            this.lblAnleitung.Size = new System.Drawing.Size(331, 52);
            this.lblAnleitung.TabIndex = 13;
            this.lblAnleitung.Text = "Bitte geben Sie Ihren PIN ein";
            this.lblAnleitung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.Location = new System.Drawing.Point(100, 191);
            this.btnAbbruch.Name = "btnAbbruch";
            this.btnAbbruch.Size = new System.Drawing.Size(164, 37);
            this.btnAbbruch.TabIndex = 14;
            this.btnAbbruch.Text = "Vorgang abbrechen";
            this.btnAbbruch.UseVisualStyleBackColor = true;
            this.btnAbbruch.Click += new System.EventHandler(this.btnAbbruch_Click);
            // 
            // PinEingabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 271);
            this.Controls.Add(this.btnAbbruch);
            this.Controls.Add(this.btnPW);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblAnleitung);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "PinEingabe";
            this.Text = "PinEingabe";
            this.Activated += new System.EventHandler(this.PinEingabe_Load);
            this.Load += new System.EventHandler(this.PinEingabe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Button btnPW;
        private System.Windows.Forms.Label lblAnleitung;
        private System.Windows.Forms.Button btnAbbruch;
    }
}