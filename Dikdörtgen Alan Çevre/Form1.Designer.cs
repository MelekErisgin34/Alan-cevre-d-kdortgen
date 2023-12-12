namespace Dikdörtgen_Alan_Çevre
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
            this.lblKısakenar = new System.Windows.Forms.Label();
            this.lblUzunkenar = new System.Windows.Forms.Label();
            this.lblCevre = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.txtKısakenar = new System.Windows.Forms.TextBox();
            this.txtUzunkenar = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtCevre = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKısakenar
            // 
            this.lblKısakenar.AutoSize = true;
            this.lblKısakenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKısakenar.Location = new System.Drawing.Point(34, 41);
            this.lblKısakenar.Name = "lblKısakenar";
            this.lblKısakenar.Size = new System.Drawing.Size(72, 13);
            this.lblKısakenar.TabIndex = 0;
            this.lblKısakenar.Text = "Kısa Kenar:";
            // 
            // lblUzunkenar
            // 
            this.lblUzunkenar.AutoSize = true;
            this.lblUzunkenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzunkenar.Location = new System.Drawing.Point(34, 73);
            this.lblUzunkenar.Name = "lblUzunkenar";
            this.lblUzunkenar.Size = new System.Drawing.Size(77, 13);
            this.lblUzunkenar.TabIndex = 1;
            this.lblUzunkenar.Text = "Uzun Kenar:";
            // 
            // lblCevre
            // 
            this.lblCevre.AutoSize = true;
            this.lblCevre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCevre.Location = new System.Drawing.Point(311, 44);
            this.lblCevre.Name = "lblCevre";
            this.lblCevre.Size = new System.Drawing.Size(44, 13);
            this.lblCevre.TabIndex = 2;
            this.lblCevre.Text = "Çevre:";
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlan.Location = new System.Drawing.Point(311, 80);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(36, 13);
            this.lblAlan.TabIndex = 3;
            this.lblAlan.Text = "Alan:";
            // 
            // txtKısakenar
            // 
            this.txtKısakenar.Location = new System.Drawing.Point(117, 41);
            this.txtKısakenar.Name = "txtKısakenar";
            this.txtKısakenar.Size = new System.Drawing.Size(100, 20);
            this.txtKısakenar.TabIndex = 4;
            // 
            // txtUzunkenar
            // 
            this.txtUzunkenar.Location = new System.Drawing.Point(117, 73);
            this.txtUzunkenar.Name = "txtUzunkenar";
            this.txtUzunkenar.Size = new System.Drawing.Size(100, 20);
            this.txtUzunkenar.TabIndex = 5;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.Black;
            this.btnHesapla.Location = new System.Drawing.Point(187, 126);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(202, 50);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtCevre
            // 
            this.txtCevre.Location = new System.Drawing.Point(369, 38);
            this.txtCevre.Name = "txtCevre";
            this.txtCevre.Size = new System.Drawing.Size(100, 20);
            this.txtCevre.TabIndex = 7;
          
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(369, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(575, 242);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtCevre);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtUzunkenar);
            this.Controls.Add(this.txtKısakenar);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.lblCevre);
            this.Controls.Add(this.lblUzunkenar);
            this.Controls.Add(this.lblKısakenar);
            this.Name = "Form1";
            this.Text = "Form1";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKısakenar;
        private System.Windows.Forms.Label lblUzunkenar;
        private System.Windows.Forms.Label lblCevre;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.TextBox txtKısakenar;
        private System.Windows.Forms.TextBox txtUzunkenar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtCevre;
        private System.Windows.Forms.TextBox textBox2;
    }
}

