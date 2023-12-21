namespace WinTest01_Base
{
    partial class frmTest
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
            this.btnTest = new System.Windows.Forms.Button();
            this.tbTest01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTest02 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTest03 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTest04 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTest1 = new System.Windows.Forms.CheckBox();
            this.cbTest2 = new System.Windows.Forms.CheckBox();
            this.cbTest3 = new System.Windows.Forms.CheckBox();
            this.cbTest4 = new System.Windows.Forms.CheckBox();
            this.cmbTest1 = new System.Windows.Forms.ComboBox();
            this.cmbTest2 = new System.Windows.Forms.ComboBox();
            this.cmbTest3 = new System.Windows.Forms.ComboBox();
            this.cmbTest4 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Popup1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuUpper = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLower = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Popup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(537, 35);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(81, 21);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tbTest01
            // 
            this.tbTest01.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbTest01.Location = new System.Drawing.Point(115, 35);
            this.tbTest01.Name = "tbTest01";
            this.tbTest01.Size = new System.Drawing.Size(89, 23);
            this.tbTest01.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text 1";
            this.label1.Visible = false;
            // 
            // tbTest02
            // 
            this.tbTest02.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbTest02.Location = new System.Drawing.Point(115, 62);
            this.tbTest02.Name = "tbTest02";
            this.tbTest02.Size = new System.Drawing.Size(89, 23);
            this.tbTest02.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text 2";
            this.label2.Visible = false;
            // 
            // tbTest03
            // 
            this.tbTest03.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbTest03.Location = new System.Drawing.Point(115, 89);
            this.tbTest03.Name = "tbTest03";
            this.tbTest03.Size = new System.Drawing.Size(89, 23);
            this.tbTest03.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(748, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Text 3";
            this.label3.Visible = false;
            // 
            // tbTest04
            // 
            this.tbTest04.ContextMenuStrip = this.Popup1;
            this.tbTest04.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbTest04.Location = new System.Drawing.Point(115, 145);
            this.tbTest04.Multiline = true;
            this.tbTest04.Name = "tbTest04";
            this.tbTest04.Size = new System.Drawing.Size(183, 110);
            this.tbTest04.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(748, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Text 4";
            this.label4.Visible = false;
            // 
            // cbTest1
            // 
            this.cbTest1.AutoSize = true;
            this.cbTest1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbTest1.Location = new System.Drawing.Point(50, 38);
            this.cbTest1.Name = "cbTest1";
            this.cbTest1.Size = new System.Drawing.Size(59, 16);
            this.cbTest1.TabIndex = 4;
            this.cbTest1.Text = "Test 1";
            this.cbTest1.UseVisualStyleBackColor = true;
            this.cbTest1.CheckedChanged += new System.EventHandler(this.cbTest1_CheckedChanged);
            // 
            // cbTest2
            // 
            this.cbTest2.AutoSize = true;
            this.cbTest2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbTest2.Location = new System.Drawing.Point(50, 65);
            this.cbTest2.Name = "cbTest2";
            this.cbTest2.Size = new System.Drawing.Size(59, 16);
            this.cbTest2.TabIndex = 5;
            this.cbTest2.Text = "Test 2";
            this.cbTest2.UseVisualStyleBackColor = true;
            this.cbTest2.CheckedChanged += new System.EventHandler(this.cbTest2_CheckedChanged);
            // 
            // cbTest3
            // 
            this.cbTest3.AutoSize = true;
            this.cbTest3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbTest3.Location = new System.Drawing.Point(50, 93);
            this.cbTest3.Name = "cbTest3";
            this.cbTest3.Size = new System.Drawing.Size(59, 16);
            this.cbTest3.TabIndex = 4;
            this.cbTest3.Text = "Test 3";
            this.cbTest3.UseVisualStyleBackColor = true;
            this.cbTest3.CheckedChanged += new System.EventHandler(this.cbTest3_CheckedChanged);
            // 
            // cbTest4
            // 
            this.cbTest4.AutoSize = true;
            this.cbTest4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbTest4.Location = new System.Drawing.Point(50, 119);
            this.cbTest4.Name = "cbTest4";
            this.cbTest4.Size = new System.Drawing.Size(59, 16);
            this.cbTest4.TabIndex = 5;
            this.cbTest4.Text = "Test 4";
            this.cbTest4.UseVisualStyleBackColor = true;
            this.cbTest4.CheckedChanged += new System.EventHandler(this.cbTest4_CheckedChanged);
            // 
            // cmbTest1
            // 
            this.cmbTest1.Enabled = false;
            this.cmbTest1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbTest1.FormattingEnabled = true;
            this.cmbTest1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하세요",
            "반갑습니다"});
            this.cmbTest1.Location = new System.Drawing.Point(210, 35);
            this.cmbTest1.Name = "cmbTest1";
            this.cmbTest1.Size = new System.Drawing.Size(88, 21);
            this.cmbTest1.TabIndex = 6;
            this.cmbTest1.SelectedIndexChanged += new System.EventHandler(this.cmbTest1_SelectedIndexChanged);
            // 
            // cmbTest2
            // 
            this.cmbTest2.Enabled = false;
            this.cmbTest2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbTest2.FormattingEnabled = true;
            this.cmbTest2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하세요"});
            this.cmbTest2.Location = new System.Drawing.Point(210, 62);
            this.cmbTest2.Name = "cmbTest2";
            this.cmbTest2.Size = new System.Drawing.Size(88, 21);
            this.cmbTest2.TabIndex = 6;
            // 
            // cmbTest3
            // 
            this.cmbTest3.Enabled = false;
            this.cmbTest3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbTest3.FormattingEnabled = true;
            this.cmbTest3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하세요"});
            this.cmbTest3.Location = new System.Drawing.Point(210, 89);
            this.cmbTest3.Name = "cmbTest3";
            this.cmbTest3.Size = new System.Drawing.Size(88, 21);
            this.cmbTest3.TabIndex = 6;
            // 
            // cmbTest4
            // 
            this.cmbTest4.Enabled = false;
            this.cmbTest4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbTest4.FormattingEnabled = true;
            this.cmbTest4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하세요"});
            this.cmbTest4.Location = new System.Drawing.Point(210, 116);
            this.cmbTest4.Name = "cmbTest4";
            this.cmbTest4.Size = new System.Drawing.Size(88, 21);
            this.cmbTest4.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(180, 22);
            this.mnuNew.Text = "New";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(180, 22);
            this.mnuSave.Text = "Save";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // Popup1
            // 
            this.Popup1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpper,
            this.mnuLower});
            this.Popup1.Name = "Popup1";
            this.Popup1.Size = new System.Drawing.Size(107, 48);
            // 
            // mnuUpper
            // 
            this.mnuUpper.Name = "mnuUpper";
            this.mnuUpper.Size = new System.Drawing.Size(106, 22);
            this.mnuUpper.Text = "Upper";
            this.mnuUpper.Click += new System.EventHandler(this.mnuUpper_Click);
            // 
            // mnuLower
            // 
            this.mnuLower.Name = "mnuLower";
            this.mnuLower.Size = new System.Drawing.Size(106, 22);
            this.mnuLower.Text = "Lower";
            this.mnuLower.Click += new System.EventHandler(this.mnuLower_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbFileName
            // 
            this.tbFileName.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbFileName.Location = new System.Drawing.Point(115, 277);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(530, 23);
            this.tbFileName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Select File";
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTest4);
            this.Controls.Add(this.cmbTest3);
            this.Controls.Add(this.cmbTest2);
            this.Controls.Add(this.cmbTest1);
            this.Controls.Add(this.cbTest4);
            this.Controls.Add(this.cbTest3);
            this.Controls.Add(this.cbTest2);
            this.Controls.Add(this.cbTest1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTest04);
            this.Controls.Add(this.tbTest03);
            this.Controls.Add(this.tbTest02);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.tbTest01);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinFormTest  ver 2.13";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Popup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox tbTest01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTest02;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTest03;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTest04;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbTest1;
        private System.Windows.Forms.CheckBox cbTest2;
        private System.Windows.Forms.CheckBox cbTest3;
        private System.Windows.Forms.CheckBox cbTest4;
        private System.Windows.Forms.ComboBox cmbTest1;
        private System.Windows.Forms.ComboBox cmbTest2;
        private System.Windows.Forms.ComboBox cmbTest3;
        private System.Windows.Forms.ComboBox cmbTest4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Popup1;
        private System.Windows.Forms.ToolStripMenuItem mnuUpper;
        private System.Windows.Forms.ToolStripMenuItem mnuLower;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label5;
    }
}

