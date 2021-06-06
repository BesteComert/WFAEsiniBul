
namespace WFAEsiniBul
{
    partial class FrmYeniOyun
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
            this.gboSeviye = new System.Windows.Forms.GroupBox();
            this.rbZor = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKolay = new System.Windows.Forms.RadioButton();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.gboSeviye.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSeviye
            // 
            this.gboSeviye.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gboSeviye.Controls.Add(this.rbZor);
            this.gboSeviye.Controls.Add(this.rbOrta);
            this.gboSeviye.Controls.Add(this.rbKolay);
            this.gboSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboSeviye.Location = new System.Drawing.Point(20, 12);
            this.gboSeviye.Name = "gboSeviye";
            this.gboSeviye.Size = new System.Drawing.Size(322, 266);
            this.gboSeviye.TabIndex = 0;
            this.gboSeviye.TabStop = false;
            this.gboSeviye.Text = "Zorluk Seviyesi";
            // 
            // rbZor
            // 
            this.rbZor.AutoSize = true;
            this.rbZor.Location = new System.Drawing.Point(24, 193);
            this.rbZor.Name = "rbZor";
            this.rbZor.Size = new System.Drawing.Size(141, 35);
            this.rbZor.TabIndex = 0;
            this.rbZor.Text = "Zor (8x8)";
            this.rbZor.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(24, 131);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(153, 35);
            this.rbOrta.TabIndex = 0;
            this.rbOrta.Text = "Orta (6x6)";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKolay
            // 
            this.rbKolay.AutoSize = true;
            this.rbKolay.Checked = true;
            this.rbKolay.Location = new System.Drawing.Point(24, 69);
            this.rbKolay.Name = "rbKolay";
            this.rbKolay.Size = new System.Drawing.Size(168, 35);
            this.rbKolay.TabIndex = 0;
            this.rbKolay.TabStop = true;
            this.rbKolay.Text = "Kolay (4x4)";
            this.rbKolay.UseVisualStyleBackColor = true;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(20, 284);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(322, 48);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "OYUNU BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(20, 338);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(322, 48);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "ÇIK";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmYeniOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 398);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.gboSeviye);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmYeniOyun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Oyun";
            this.gboSeviye.ResumeLayout(false);
            this.gboSeviye.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSeviye;
        private System.Windows.Forms.RadioButton rbZor;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKolay;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnKapat;
    }
}