namespace M17_UpravaTextovehoPole
{
    partial class frmMain
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
            this.txtBasen = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnBarvaPisma = new System.Windows.Forms.Button();
            this.btnBarvaPozadi = new System.Windows.Forms.Button();
            this.btnSmazaniTextovehoPole = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // txtBasen
            // 
            this.txtBasen.Location = new System.Drawing.Point(12, 12);
            this.txtBasen.Multiline = true;
            this.txtBasen.Name = "txtBasen";
            this.txtBasen.Size = new System.Drawing.Size(216, 161);
            this.txtBasen.TabIndex = 0;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(252, 12);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(108, 50);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnBarvaPisma
            // 
            this.btnBarvaPisma.Location = new System.Drawing.Point(366, 12);
            this.btnBarvaPisma.Name = "btnBarvaPisma";
            this.btnBarvaPisma.Size = new System.Drawing.Size(108, 50);
            this.btnBarvaPisma.TabIndex = 2;
            this.btnBarvaPisma.Text = "Barva textu";
            this.btnBarvaPisma.UseVisualStyleBackColor = true;
            this.btnBarvaPisma.Click += new System.EventHandler(this.btnBarvaPisma_Click);
            // 
            // btnBarvaPozadi
            // 
            this.btnBarvaPozadi.Location = new System.Drawing.Point(252, 68);
            this.btnBarvaPozadi.Name = "btnBarvaPozadi";
            this.btnBarvaPozadi.Size = new System.Drawing.Size(108, 50);
            this.btnBarvaPozadi.TabIndex = 3;
            this.btnBarvaPozadi.Text = "Barva pozadí";
            this.btnBarvaPozadi.UseVisualStyleBackColor = true;
            this.btnBarvaPozadi.Click += new System.EventHandler(this.btnBarvaPozadi_Click);
            // 
            // btnSmazaniTextovehoPole
            // 
            this.btnSmazaniTextovehoPole.Location = new System.Drawing.Point(366, 68);
            this.btnSmazaniTextovehoPole.Name = "btnSmazaniTextovehoPole";
            this.btnSmazaniTextovehoPole.Size = new System.Drawing.Size(108, 50);
            this.btnSmazaniTextovehoPole.TabIndex = 4;
            this.btnSmazaniTextovehoPole.Text = "Smazat pole";
            this.btnSmazaniTextovehoPole.UseVisualStyleBackColor = true;
            this.btnSmazaniTextovehoPole.Click += new System.EventHandler(this.btnSmazaniTextovehoPole_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 195);
            this.Controls.Add(this.btnSmazaniTextovehoPole);
            this.Controls.Add(this.btnBarvaPozadi);
            this.Controls.Add(this.btnBarvaPisma);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.txtBasen);
            this.Name = "frmMain";
            this.Text = "Úprava textového pole";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBasen;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnBarvaPisma;
        private System.Windows.Forms.Button btnBarvaPozadi;
        private System.Windows.Forms.Button btnSmazaniTextovehoPole;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

