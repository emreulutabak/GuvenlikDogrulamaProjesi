namespace Güvelik_Dogrulamasi
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
            this.PbxFormResim = new System.Windows.Forms.PictureBox();
            this.BtnDogrulamaKodu = new System.Windows.Forms.Button();
            this.BtnVazgec = new System.Windows.Forms.Button();
            this.LblBaslik = new System.Windows.Forms.Label();
            this.TxtDogrulamaKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFormResim)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxFormResim
            // 
            this.PbxFormResim.Image = ((System.Drawing.Image)(resources.GetObject("PbxFormResim.Image")));
            this.PbxFormResim.Location = new System.Drawing.Point(49, 12);
            this.PbxFormResim.Name = "PbxFormResim";
            this.PbxFormResim.Size = new System.Drawing.Size(64, 64);
            this.PbxFormResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbxFormResim.TabIndex = 21;
            this.PbxFormResim.TabStop = false;
            // 
            // BtnDogrulamaKodu
            // 
            this.BtnDogrulamaKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDogrulamaKodu.Location = new System.Drawing.Point(49, 150);
            this.BtnDogrulamaKodu.Name = "BtnDogrulamaKodu";
            this.BtnDogrulamaKodu.Size = new System.Drawing.Size(208, 32);
            this.BtnDogrulamaKodu.TabIndex = 18;
            this.BtnDogrulamaKodu.Text = "Doğrulama Kodu Al";
            this.BtnDogrulamaKodu.UseVisualStyleBackColor = true;
            this.BtnDogrulamaKodu.Click += new System.EventHandler(this.BtnDogrulamaKodu_Click);
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVazgec.Location = new System.Drawing.Point(263, 150);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(208, 32);
            this.BtnVazgec.TabIndex = 19;
            this.BtnVazgec.Text = "Vazgeç";
            this.BtnVazgec.UseVisualStyleBackColor = true;
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // LblBaslik
            // 
            this.LblBaslik.AutoSize = true;
            this.LblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBaslik.ForeColor = System.Drawing.Color.Red;
            this.LblBaslik.Location = new System.Drawing.Point(119, 29);
            this.LblBaslik.Name = "LblBaslik";
            this.LblBaslik.Size = new System.Drawing.Size(303, 33);
            this.LblBaslik.TabIndex = 20;
            this.LblBaslik.Text = "Güvenlik Doğrulaması";
            // 
            // TxtDogrulamaKodu
            // 
            this.TxtDogrulamaKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDogrulamaKodu.Location = new System.Drawing.Point(267, 97);
            this.TxtDogrulamaKodu.Name = "TxtDogrulamaKodu";
            this.TxtDogrulamaKodu.PasswordChar = '*';
            this.TxtDogrulamaKodu.Size = new System.Drawing.Size(204, 29);
            this.TxtDogrulamaKodu.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Doğrulama Kodunuz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 200);
            this.Controls.Add(this.PbxFormResim);
            this.Controls.Add(this.BtnDogrulamaKodu);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.LblBaslik);
            this.Controls.Add(this.TxtDogrulamaKodu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Güvenlik Doğrulaması";
            ((System.ComponentModel.ISupportInitialize)(this.PbxFormResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxFormResim;
        private System.Windows.Forms.Button BtnDogrulamaKodu;
        private System.Windows.Forms.Button BtnVazgec;
        public System.Windows.Forms.Label LblBaslik;
        public System.Windows.Forms.TextBox TxtDogrulamaKodu;
        private System.Windows.Forms.Label label1;
    }
}

