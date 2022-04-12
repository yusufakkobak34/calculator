namespace HesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sayi1 = new System.Windows.Forms.TextBox();
            this.Sayi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBöl = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sayi1
            // 
            this.Sayi1.Location = new System.Drawing.Point(268, 77);
            this.Sayi1.Name = "Sayi1";
            this.Sayi1.Size = new System.Drawing.Size(190, 27);
            this.Sayi1.TabIndex = 0;
            // 
            // Sayi2
            // 
            this.Sayi2.Location = new System.Drawing.Point(268, 138);
            this.Sayi2.Name = "Sayi2";
            this.Sayi2.Size = new System.Drawing.Size(190, 27);
            this.Sayi2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "1.Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "2.Sayı";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(92, 225);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(94, 29);
            this.btnTopla.TabIndex = 4;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(221, 225);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(94, 29);
            this.btnCikar.TabIndex = 5;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(348, 225);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(94, 29);
            this.btnCarp.TabIndex = 6;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnBöl
            // 
            this.btnBöl.Location = new System.Drawing.Point(480, 225);
            this.btnBöl.Name = "btnBöl";
            this.btnBöl.Size = new System.Drawing.Size(94, 29);
            this.btnBöl.TabIndex = 7;
            this.btnBöl.Text = "Böl";
            this.btnBöl.UseVisualStyleBackColor = true;
            this.btnBöl.Click += new System.EventHandler(this.btnBöl_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.AutoSize = true;
            this.txtSonuc.Location = new System.Drawing.Point(147, 318);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(49, 20);
            this.txtSonuc.TabIndex = 8;
            this.txtSonuc.Text = "Sonuç";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnBöl);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sayi2);
            this.Controls.Add(this.Sayi1);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Sayi1;
        private TextBox Sayi2;
        private Label label1;
        private Label label2;
        private Button btnTopla;
        private Button btnCikar;
        private Button btnCarp;
        private Button btnBöl;
        private Label txtSonuc;
        private TextBox textBox1;
    }
}