namespace KelimeOyunuProjesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnBasla = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.BtnTahminEt = new System.Windows.Forms.Button();
            this.BtnHarfAl = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBasla
            // 
            this.BtnBasla.Location = new System.Drawing.Point(7, 12);
            this.BtnBasla.Name = "BtnBasla";
            this.BtnBasla.Size = new System.Drawing.Size(151, 63);
            this.BtnBasla.TabIndex = 0;
            this.BtnBasla.Text = "BAŞLA";
            this.BtnBasla.UseVisualStyleBackColor = true;
            this.BtnBasla.Click += new System.EventHandler(this.BtnBasla_Click);
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(210, 495);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(286, 30);
            this.txtTahmin.TabIndex = 2;
            // 
            // BtnTahminEt
            // 
            this.BtnTahminEt.Location = new System.Drawing.Point(931, 412);
            this.BtnTahminEt.Name = "BtnTahminEt";
            this.BtnTahminEt.Size = new System.Drawing.Size(151, 63);
            this.BtnTahminEt.TabIndex = 3;
            this.BtnTahminEt.Text = "Tahmin Et";
            this.BtnTahminEt.UseVisualStyleBackColor = true;
            this.BtnTahminEt.Click += new System.EventHandler(this.BtnTahminEt_Click);
            // 
            // BtnHarfAl
            // 
            this.BtnHarfAl.Location = new System.Drawing.Point(931, 495);
            this.BtnHarfAl.Name = "BtnHarfAl";
            this.BtnHarfAl.Size = new System.Drawing.Size(151, 63);
            this.BtnHarfAl.TabIndex = 4;
            this.BtnHarfAl.Text = "Harf Al";
            this.BtnHarfAl.UseVisualStyleBackColor = true;
            this.BtnHarfAl.Click += new System.EventHandler(this.BtnHarfAl_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(1143, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(54, 29);
            this.btnKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnKapat.TabIndex = 6;
            this.btnKapat.TabStop = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(420, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 55);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kelime Oyunu";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(12, 487);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(0, 38);
            this.lblPuan.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 667);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.BtnHarfAl);
            this.Controls.Add(this.BtnTahminEt);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.BtnBasla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnKapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBasla;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button BtnTahminEt;
        private System.Windows.Forms.Button BtnHarfAl;
        private System.Windows.Forms.PictureBox btnKapat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuan;
    }
}

