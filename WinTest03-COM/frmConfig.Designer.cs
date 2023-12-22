namespace WinTest03_COM
{
    partial class frmConfig
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
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBCr = new System.Windows.Forms.TextBox();
            this.tbBCg = new System.Windows.Forms.TextBox();
            this.tbBCb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFCr = new System.Windows.Forms.TextBox();
            this.tbFCg = new System.Windows.Forms.TextBox();
            this.tbFCb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFontName = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBC = new System.Windows.Forms.Button();
            this.btnFC = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(214, 339);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 328);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 328);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbStop);
            this.tabPage1.Controls.Add(this.cbData);
            this.tabPage1.Controls.Add(this.cbParity);
            this.tabPage1.Controls.Add(this.cbBaud);
            this.tabPage1.Controls.Add(this.cbCom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Port 설정";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFC);
            this.tabPage2.Controls.Add(this.btnBC);
            this.tabPage2.Controls.Add(this.btnFont);
            this.tabPage2.Controls.Add(this.tbFCb);
            this.tabPage2.Controls.Add(this.tbBCb);
            this.tabPage2.Controls.Add(this.tbFCg);
            this.tabPage2.Controls.Add(this.tbBCg);
            this.tabPage2.Controls.Add(this.tbFontName);
            this.tabPage2.Controls.Add(this.tbFCr);
            this.tabPage2.Controls.Add(this.tbBCr);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "환경 설정";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbCom
            // 
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(200, 70);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(121, 20);
            this.cbCom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "576000",
            "115200",
            "57600",
            "38400",
            "19200",
            "9600"});
            this.cbBaud.Location = new System.Drawing.Point(200, 96);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(121, 20);
            this.cbBaud.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbParity.Location = new System.Drawing.Point(200, 122);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 20);
            this.cbParity.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parity";
            // 
            // cbData
            // 
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "8",
            "7"});
            this.cbData.Location = new System.Drawing.Point(200, 148);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(121, 20);
            this.cbData.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data Bits";
            // 
            // cbStop
            // 
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "0 - None",
            "1 - One",
            "2 - Two"});
            this.cbStop.Location = new System.Drawing.Point(200, 174);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(121, 20);
            this.cbStop.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stop Bit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Back Color";
            // 
            // tbBCr
            // 
            this.tbBCr.Location = new System.Drawing.Point(181, 78);
            this.tbBCr.Name = "tbBCr";
            this.tbBCr.Size = new System.Drawing.Size(44, 21);
            this.tbBCr.TabIndex = 1;
            // 
            // tbBCg
            // 
            this.tbBCg.Location = new System.Drawing.Point(231, 78);
            this.tbBCg.Name = "tbBCg";
            this.tbBCg.Size = new System.Drawing.Size(44, 21);
            this.tbBCg.TabIndex = 1;
            // 
            // tbBCb
            // 
            this.tbBCb.Location = new System.Drawing.Point(281, 78);
            this.tbBCb.Name = "tbBCb";
            this.tbBCb.Size = new System.Drawing.Size(44, 21);
            this.tbBCb.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fore Color";
            // 
            // tbFCr
            // 
            this.tbFCr.Location = new System.Drawing.Point(181, 110);
            this.tbFCr.Name = "tbFCr";
            this.tbFCr.Size = new System.Drawing.Size(44, 21);
            this.tbFCr.TabIndex = 1;
            // 
            // tbFCg
            // 
            this.tbFCg.Location = new System.Drawing.Point(231, 110);
            this.tbFCg.Name = "tbFCg";
            this.tbFCg.Size = new System.Drawing.Size(44, 21);
            this.tbFCg.TabIndex = 1;
            // 
            // tbFCb
            // 
            this.tbFCb.Location = new System.Drawing.Point(281, 110);
            this.tbFCb.Name = "tbFCb";
            this.tbFCb.Size = new System.Drawing.Size(44, 21);
            this.tbFCb.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Font";
            // 
            // tbFontName
            // 
            this.tbFontName.Location = new System.Drawing.Point(181, 143);
            this.tbFontName.Name = "tbFontName";
            this.tbFontName.Size = new System.Drawing.Size(144, 21);
            this.tbFontName.TabIndex = 1;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(331, 143);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(33, 21);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "...";
            this.btnFont.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Red";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Green";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "Blue";
            // 
            // btnBC
            // 
            this.btnBC.Location = new System.Drawing.Point(331, 78);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(33, 21);
            this.btnBC.TabIndex = 2;
            this.btnBC.Text = "...";
            this.btnBC.UseVisualStyleBackColor = true;
            // 
            // btnFC
            // 
            this.btnFC.Location = new System.Drawing.Point(331, 110);
            this.btnFC.Name = "btnFC";
            this.btnFC.Size = new System.Drawing.Size(33, 21);
            this.btnFC.TabIndex = 2;
            this.btnFC.Text = "...";
            this.btnFC.UseVisualStyleBackColor = true;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "myPutty Configuration";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBCr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFCb;
        private System.Windows.Forms.TextBox tbBCb;
        private System.Windows.Forms.TextBox tbFCg;
        private System.Windows.Forms.TextBox tbBCg;
        private System.Windows.Forms.TextBox tbFontName;
        private System.Windows.Forms.TextBox tbFCr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFC;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.FontDialog fontDialog1;
        public System.Windows.Forms.ComboBox cbStop;
        public System.Windows.Forms.ComboBox cbData;
        public System.Windows.Forms.ComboBox cbParity;
        public System.Windows.Forms.ComboBox cbBaud;
        public System.Windows.Forms.ComboBox cbCom;
    }
}