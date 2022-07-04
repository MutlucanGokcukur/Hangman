
namespace Hangman
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
            this.lblkonu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKelimeÇizgi = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnÇ = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnĞ = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnÖ = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnİ = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnŞ = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnÜ = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblHakSayac = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkonu
            // 
            this.lblkonu.AutoSize = true;
            this.lblkonu.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblkonu.Location = new System.Drawing.Point(322, 12);
            this.lblkonu.Name = "lblkonu";
            this.lblkonu.Size = new System.Drawing.Size(114, 46);
            this.lblkonu.TabIndex = 0;
            this.lblkonu.Text = "Konu:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hangman.Properties.Resources.adamasmaca1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblKelimeÇizgi
            // 
            this.lblKelimeÇizgi.AutoSize = true;
            this.lblKelimeÇizgi.Font = new System.Drawing.Font("Segoe UI", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKelimeÇizgi.Location = new System.Drawing.Point(331, 118);
            this.lblKelimeÇizgi.Name = "lblKelimeÇizgi";
            this.lblKelimeÇizgi.Size = new System.Drawing.Size(249, 77);
            this.lblKelimeÇizgi.TabIndex = 4;
            this.lblKelimeÇizgi.Text = "Kelime: ";
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnA.Location = new System.Drawing.Point(331, 235);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(51, 48);
            this.btnA.TabIndex = 5;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnB.Location = new System.Drawing.Point(388, 235);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(51, 48);
            this.btnB.TabIndex = 5;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnC.Location = new System.Drawing.Point(445, 235);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(51, 48);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnD.Location = new System.Drawing.Point(559, 235);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(51, 48);
            this.btnD.TabIndex = 5;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnÇ
            // 
            this.btnÇ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnÇ.Location = new System.Drawing.Point(502, 235);
            this.btnÇ.Name = "btnÇ";
            this.btnÇ.Size = new System.Drawing.Size(51, 48);
            this.btnÇ.TabIndex = 5;
            this.btnÇ.Text = "Ç";
            this.btnÇ.UseVisualStyleBackColor = true;
            this.btnÇ.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnE.Location = new System.Drawing.Point(616, 235);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(51, 48);
            this.btnE.TabIndex = 5;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnF
            // 
            this.btnF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnF.Location = new System.Drawing.Point(673, 235);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(51, 48);
            this.btnF.TabIndex = 5;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnG.Location = new System.Drawing.Point(730, 235);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(51, 48);
            this.btnG.TabIndex = 5;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnĞ
            // 
            this.btnĞ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnĞ.Location = new System.Drawing.Point(787, 235);
            this.btnĞ.Name = "btnĞ";
            this.btnĞ.Size = new System.Drawing.Size(51, 48);
            this.btnĞ.TabIndex = 5;
            this.btnĞ.Text = "Ğ";
            this.btnĞ.UseVisualStyleBackColor = true;
            this.btnĞ.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN.Location = new System.Drawing.Point(673, 298);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(51, 48);
            this.btnN.TabIndex = 5;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnH
            // 
            this.btnH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnH.Location = new System.Drawing.Point(844, 235);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(51, 48);
            this.btnH.TabIndex = 5;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnO
            // 
            this.btnO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnO.Location = new System.Drawing.Point(730, 298);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(51, 48);
            this.btnO.TabIndex = 5;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnÖ
            // 
            this.btnÖ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnÖ.Location = new System.Drawing.Point(787, 298);
            this.btnÖ.Name = "btnÖ";
            this.btnÖ.Size = new System.Drawing.Size(51, 48);
            this.btnÖ.TabIndex = 5;
            this.btnÖ.Text = "Ö";
            this.btnÖ.UseVisualStyleBackColor = true;
            this.btnÖ.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnI
            // 
            this.btnI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnI.Location = new System.Drawing.Point(331, 298);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(51, 48);
            this.btnI.TabIndex = 5;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnİ
            // 
            this.btnİ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnİ.Location = new System.Drawing.Point(388, 298);
            this.btnİ.Name = "btnİ";
            this.btnİ.Size = new System.Drawing.Size(51, 48);
            this.btnİ.TabIndex = 5;
            this.btnİ.Text = "İ";
            this.btnİ.UseVisualStyleBackColor = true;
            this.btnİ.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnP
            // 
            this.btnP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnP.Location = new System.Drawing.Point(844, 298);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(51, 48);
            this.btnP.TabIndex = 5;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnJ
            // 
            this.btnJ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJ.Location = new System.Drawing.Point(445, 298);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(51, 48);
            this.btnJ.TabIndex = 5;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnR
            // 
            this.btnR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnR.Location = new System.Drawing.Point(352, 361);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(51, 48);
            this.btnR.TabIndex = 5;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnK
            // 
            this.btnK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnK.Location = new System.Drawing.Point(502, 298);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(51, 48);
            this.btnK.TabIndex = 5;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnS.Location = new System.Drawing.Point(409, 361);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(51, 48);
            this.btnS.TabIndex = 5;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnL.Location = new System.Drawing.Point(559, 298);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(51, 48);
            this.btnL.TabIndex = 5;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnŞ
            // 
            this.btnŞ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnŞ.Location = new System.Drawing.Point(466, 361);
            this.btnŞ.Name = "btnŞ";
            this.btnŞ.Size = new System.Drawing.Size(51, 48);
            this.btnŞ.TabIndex = 5;
            this.btnŞ.Text = "Ş";
            this.btnŞ.UseVisualStyleBackColor = true;
            this.btnŞ.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnM.Location = new System.Drawing.Point(616, 298);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(51, 48);
            this.btnM.TabIndex = 5;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnT
            // 
            this.btnT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnT.Location = new System.Drawing.Point(523, 361);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(51, 48);
            this.btnT.TabIndex = 5;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnU
            // 
            this.btnU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnU.Location = new System.Drawing.Point(580, 361);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(51, 48);
            this.btnU.TabIndex = 5;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnV
            // 
            this.btnV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnV.Location = new System.Drawing.Point(694, 361);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(51, 48);
            this.btnV.TabIndex = 5;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnÜ
            // 
            this.btnÜ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnÜ.Location = new System.Drawing.Point(637, 361);
            this.btnÜ.Name = "btnÜ";
            this.btnÜ.Size = new System.Drawing.Size(51, 48);
            this.btnÜ.TabIndex = 5;
            this.btnÜ.Text = "Ü";
            this.btnÜ.UseVisualStyleBackColor = true;
            this.btnÜ.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnY
            // 
            this.btnY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnY.Location = new System.Drawing.Point(751, 361);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(51, 48);
            this.btnY.TabIndex = 5;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnZ
            // 
            this.btnZ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZ.Location = new System.Drawing.Point(808, 361);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(51, 48);
            this.btnZ.TabIndex = 5;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.HarfOlay);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBaslat.Location = new System.Drawing.Point(12, 340);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(196, 85);
            this.btnBaslat.TabIndex = 6;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblHakSayac
            // 
            this.lblHakSayac.AutoSize = true;
            this.lblHakSayac.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHakSayac.Location = new System.Drawing.Point(671, 12);
            this.lblHakSayac.Name = "lblHakSayac";
            this.lblHakSayac.Size = new System.Drawing.Size(140, 35);
            this.lblHakSayac.TabIndex = 7;
            this.lblHakSayac.Text = "Kalan Hak:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 85);
            this.button1.TabIndex = 8;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHakSayac);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnŞ);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnÇ);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnİ);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnÖ);
            this.Controls.Add(this.btnÜ);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnĞ);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblKelimeÇizgi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblkonu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdamAsmaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkonu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKelimeÇizgi;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnÇ;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnĞ;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnÖ;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnİ;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnŞ;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnÜ;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label lblHakSayac;
        private System.Windows.Forms.Button button1;
    }
}

