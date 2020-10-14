namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxsayı = new System.Windows.Forms.TextBox();
            this.listBoxhesap = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxsayı
            // 
            this.textBoxsayı.Location = new System.Drawing.Point(13, 13);
            this.textBoxsayı.Name = "textBoxsayı";
            this.textBoxsayı.Size = new System.Drawing.Size(120, 20);
            this.textBoxsayı.TabIndex = 0;
            // 
            // listBoxhesap
            // 
            this.listBoxhesap.FormattingEnabled = true;
            this.listBoxhesap.Location = new System.Drawing.Point(13, 40);
            this.listBoxhesap.Name = "listBoxhesap";
            this.listBoxhesap.Size = new System.Drawing.Size(120, 95);
            this.listBoxhesap.TabIndex = 1;
            this.listBoxhesap.SelectedIndexChanged += new System.EventHandler(this.listBoxhesap_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 95);
            this.button2.TabIndex = 3;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxhesap);
            this.Controls.Add(this.textBoxsayı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxsayı;
        private System.Windows.Forms.ListBox listBoxhesap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

