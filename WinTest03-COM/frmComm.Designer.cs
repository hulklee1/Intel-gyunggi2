namespace WinTest03_COM
{
    partial class frmComm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbTerminal = new System.Windows.Forms.TextBox();
            this.Popup1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Popup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTerminal
            // 
            this.tbTerminal.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbTerminal.ContextMenuStrip = this.Popup1;
            this.tbTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTerminal.ForeColor = System.Drawing.SystemColors.Info;
            this.tbTerminal.Location = new System.Drawing.Point(0, 0);
            this.tbTerminal.Multiline = true;
            this.tbTerminal.Name = "tbTerminal";
            this.tbTerminal.Size = new System.Drawing.Size(440, 254);
            this.tbTerminal.TabIndex = 0;
            this.tbTerminal.Text = "Test 문자열 색";
            // 
            // Popup1
            // 
            this.Popup1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetup,
            this.mnuRestart});
            this.Popup1.Name = "Popup1";
            this.Popup1.Size = new System.Drawing.Size(111, 48);
            // 
            // mnuSetup
            // 
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(110, 22);
            this.mnuSetup.Text = "Setup";
            this.mnuSetup.Click += new System.EventHandler(this.mnuSetup_Click);
            // 
            // mnuRestart
            // 
            this.mnuRestart.Name = "mnuRestart";
            this.mnuRestart.Size = new System.Drawing.Size(110, 22);
            this.mnuRestart.Text = "Restart";
            this.mnuRestart.Click += new System.EventHandler(this.mnuRestart_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // frmComm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 254);
            this.ContextMenuStrip = this.Popup1;
            this.Controls.Add(this.tbTerminal);
            this.Name = "frmComm";
            this.Text = "myPutty ver 2.1";
            this.Popup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTerminal;
        private System.Windows.Forms.ContextMenuStrip Popup1;
        private System.Windows.Forms.ToolStripMenuItem mnuSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuRestart;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

