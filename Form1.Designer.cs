namespace GIBEFATURA
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXmlDosyaYolu = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPOSKONDosyaYolu = new System.Windows.Forms.TextBox();
            this.txtPOSGENELDosyayolu = new System.Windows.Forms.TextBox();
            this.btnCikar = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstIpList = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.OpenXmlDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderPOSKONdialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folderPOSGENELdialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "XML OKU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 329);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 349);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "E-FATURA\'ya tabi Mükellefler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "\'UserGbList.XML\' Dosya Yolu :";
            // 
            // txtXmlDosyaYolu
            // 
            this.txtXmlDosyaYolu.Location = new System.Drawing.Point(395, 64);
            this.txtXmlDosyaYolu.Name = "txtXmlDosyaYolu";
            this.txtXmlDosyaYolu.Size = new System.Drawing.Size(237, 20);
            this.txtXmlDosyaYolu.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 22);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kasa Nolar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "POSKON Dosya YolU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "POSGENEL Dosya Yolu:";
            // 
            // txtPOSKONDosyaYolu
            // 
            this.txtPOSKONDosyaYolu.Location = new System.Drawing.Point(395, 92);
            this.txtPOSKONDosyaYolu.Name = "txtPOSKONDosyaYolu";
            this.txtPOSKONDosyaYolu.Size = new System.Drawing.Size(237, 20);
            this.txtPOSKONDosyaYolu.TabIndex = 9;
            // 
            // txtPOSGENELDosyayolu
            // 
            this.txtPOSGENELDosyayolu.Location = new System.Drawing.Point(395, 118);
            this.txtPOSGENELDosyayolu.Name = "txtPOSGENELDosyayolu";
            this.txtPOSGENELDosyayolu.Size = new System.Drawing.Size(237, 20);
            this.txtPOSGENELDosyayolu.TabIndex = 10;
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(472, 180);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(19, 23);
            this.btnCikar.TabIndex = 19;
            this.btnCikar.Text = "-";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(354, 180);
            this.txtIp.MaxLength = 3;
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(91, 20);
            this.txtIp.TabIndex = 18;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(451, 180);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(19, 23);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "+";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstIpList
            // 
            this.lstIpList.FormattingEnabled = true;
            this.lstIpList.Location = new System.Drawing.Point(238, 214);
            this.lstIpList.Name = "lstIpList";
            this.lstIpList.Size = new System.Drawing.Size(255, 199);
            this.lstIpList.TabIndex = 16;
            this.lstIpList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstIpList_MouseClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(639, 376);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 37);
            this.button5.TabIndex = 20;
            this.button5.Text = "Kasalara Gönder";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(639, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 20);
            this.button3.TabIndex = 21;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(639, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 20);
            this.button4.TabIndex = 22;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // folderPOSKONdialog
            // 
            this.folderPOSKONdialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // folderPOSGENELdialog
            // 
            this.folderPOSGENELdialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 425);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstIpList);
            this.Controls.Add(this.txtPOSGENELDosyayolu);
            this.Controls.Add(this.txtPOSKONDosyaYolu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtXmlDosyaYolu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "İKİ ELEKTRONİK BİLGİSAYAR BİLİŞİM SİSTEMLERİ SAN.TİC.LTD.ŞTİ.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXmlDosyaYolu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPOSKONDosyaYolu;
        private System.Windows.Forms.TextBox txtPOSGENELDosyayolu;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstIpList;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog OpenXmlDialog;
        private System.Windows.Forms.FolderBrowserDialog folderPOSKONdialog;
        private System.Windows.Forms.FolderBrowserDialog folderPOSGENELdialog;
    }
}

