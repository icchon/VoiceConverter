namespace AudioPlayX
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.playTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOutputDriver = new System.Windows.Forms.ComboBox();
            this.playTotalTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.convert = new System.Windows.Forms.Label();
            this.btnPlayInput = new System.Windows.Forms.Button();
            this.btnPauseInput = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.playTotalTimeInput = new System.Windows.Forms.Label();
            this.playTimeLabelInput = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mItemFile
            // 
            this.mItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemOpen,
            this.mItemExit});
            this.mItemFile.Name = "mItemFile";
            this.mItemFile.Size = new System.Drawing.Size(82, 24);
            this.mItemFile.Text = "ファイル(F)";
            // 
            // mItemOpen
            // 
            this.mItemOpen.Name = "mItemOpen";
            this.mItemOpen.Size = new System.Drawing.Size(224, 26);
            this.mItemOpen.Text = "開く(O)";
            this.mItemOpen.Click += new System.EventHandler(this.mItemOpen_Click);
            // 
            // mItemExit
            // 
            this.mItemExit.Name = "mItemExit";
            this.mItemExit.Size = new System.Drawing.Size(224, 26);
            this.mItemExit.Text = "終了(X)";
            this.mItemExit.Click += new System.EventHandler(this.mItemExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(803, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(291, 324);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(65, 62);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(445, 324);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(62, 62);
            this.btnPause.TabIndex = 3;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(248, 392);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(304, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // playTimeLabel
            // 
            this.playTimeLabel.AutoSize = true;
            this.playTimeLabel.Location = new System.Drawing.Point(182, 400);
            this.playTimeLabel.Name = "playTimeLabel";
            this.playTimeLabel.Size = new System.Drawing.Size(42, 15);
            this.playTimeLabel.TabIndex = 5;
            this.playTimeLabel.Text = "00:00";
            this.playTimeLabel.Click += new System.EventHandler(this.playTimeLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Web ドライバー";
            // 
            // comboBoxOutputDriver
            // 
            this.comboBoxOutputDriver.FormattingEnabled = true;
            this.comboBoxOutputDriver.Location = new System.Drawing.Point(524, 449);
            this.comboBoxOutputDriver.Name = "comboBoxOutputDriver";
            this.comboBoxOutputDriver.Size = new System.Drawing.Size(233, 23);
            this.comboBoxOutputDriver.TabIndex = 7;
            // 
            // playTotalTime
            // 
            this.playTotalTime.AutoSize = true;
            this.playTotalTime.Location = new System.Drawing.Point(685, 400);
            this.playTotalTime.Name = "playTotalTime";
            this.playTotalTime.Size = new System.Drawing.Size(42, 15);
            this.playTotalTime.TabIndex = 8;
            this.playTotalTime.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "総再生時間";
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trackBar.Location = new System.Drawing.Point(16, 51);
            this.trackBar.Maximum = 20;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(207, 56);
            this.trackBar.TabIndex = 11;
            this.trackBar.Value = 7;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // convert
            // 
            this.convert.AutoSize = true;
            this.convert.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.convert.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.convert.Location = new System.Drawing.Point(334, 72);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(0, 28);
            this.convert.TabIndex = 12;
            // 
            // btnPlayInput
            // 
            this.btnPlayInput.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayInput.Image")));
            this.btnPlayInput.Location = new System.Drawing.Point(291, 176);
            this.btnPlayInput.Name = "btnPlayInput";
            this.btnPlayInput.Size = new System.Drawing.Size(65, 62);
            this.btnPlayInput.TabIndex = 13;
            this.btnPlayInput.UseVisualStyleBackColor = true;
            this.btnPlayInput.Click += new System.EventHandler(this.btnPlayInput_Click);
            // 
            // btnPauseInput
            // 
            this.btnPauseInput.Image = ((System.Drawing.Image)(resources.GetObject("btnPauseInput.Image")));
            this.btnPauseInput.Location = new System.Drawing.Point(445, 177);
            this.btnPauseInput.Name = "btnPauseInput";
            this.btnPauseInput.Size = new System.Drawing.Size(62, 61);
            this.btnPauseInput.TabIndex = 14;
            this.btnPauseInput.UseVisualStyleBackColor = true;
            this.btnPauseInput.Click += new System.EventHandler(this.btnPauseInput_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(248, 244);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(304, 23);
            this.progressBar2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "総再生時間";
            // 
            // playTotalTimeInput
            // 
            this.playTotalTimeInput.AutoSize = true;
            this.playTotalTimeInput.Location = new System.Drawing.Point(685, 252);
            this.playTotalTimeInput.Name = "playTotalTimeInput";
            this.playTotalTimeInput.Size = new System.Drawing.Size(42, 15);
            this.playTotalTimeInput.TabIndex = 17;
            this.playTotalTimeInput.Text = "00:00";
            // 
            // playTimeLabelInput
            // 
            this.playTimeLabelInput.AutoSize = true;
            this.playTimeLabelInput.Location = new System.Drawing.Point(182, 252);
            this.playTimeLabelInput.Name = "playTimeLabelInput";
            this.playTimeLabelInput.Size = new System.Drawing.Size(42, 15);
            this.playTimeLabelInput.TabIndex = 18;
            this.playTimeLabelInput.Text = "00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(83, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "変換前";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(83, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "変換後";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(16, 15);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(146, 19);
            this.checkBox.TabIndex = 21;
            this.checkBox.Text = "サンプル音声を使用";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.trackBar);
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Location = new System.Drawing.Point(537, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 107);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playTimeLabelInput);
            this.Controls.Add(this.playTotalTimeInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.btnPauseInput);
            this.Controls.Add(this.btnPlayInput);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playTotalTime);
            this.Controls.Add(this.comboBoxOutputDriver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playTimeLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Audio プレイX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mItemFile;
        private System.Windows.Forms.ToolStripMenuItem mItemOpen;
        private System.Windows.Forms.ToolStripMenuItem mItemExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label playTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOutputDriver;
        private System.Windows.Forms.Label playTotalTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label convert;
        private System.Windows.Forms.Button btnPlayInput;
        private System.Windows.Forms.Button btnPauseInput;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playTotalTimeInput;
        private System.Windows.Forms.Label playTimeLabelInput;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Panel panel1;
    }
}

