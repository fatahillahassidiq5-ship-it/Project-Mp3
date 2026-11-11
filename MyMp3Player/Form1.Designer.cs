namespace MyMp3Player
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnClose = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnFiles = new Button();
            button2 = new Button();
            btnPlay = new Button();
            button4 = new Button();
            btnStop = new Button();
            trackBar = new TrackBar();
            playlistBox = new ListBox();
            lblDuration = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OliveDrab;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 86);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(471, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 86);
            btnClose.TabIndex = 7;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(288, 36);
            label1.TabIndex = 0;
            label1.Text = "My Mp3 PLayer ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_1;
            pictureBox1.Location = new Point(90, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnFiles
            // 
            btnFiles.FlatAppearance.BorderSize = 0;
            btnFiles.FlatStyle = FlatStyle.Flat;
            btnFiles.Image = Properties.Resources.Folder1;
            btnFiles.Location = new Point(0, 414);
            btnFiles.Name = "btnFiles";
            btnFiles.Size = new Size(101, 71);
            btnFiles.TabIndex = 2;
            btnFiles.UseVisualStyleBackColor = true;
            btnFiles.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(107, 414);
            button2.Name = "button2";
            button2.Size = new Size(103, 71);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnPlay
            // 
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Image = (Image)resources.GetObject("btnPlay.Image");
            btnPlay.Location = new Point(233, 411);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(98, 77);
            btnPlay.TabIndex = 4;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(337, 414);
            button4.Name = "button4";
            button4.Size = new Size(124, 71);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnStop
            // 
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Image = (Image)resources.GetObject("btnStop.Image");
            btnStop.Location = new Point(458, 408);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(124, 82);
            btnStop.TabIndex = 6;
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += button5_Click;
            // 
            // trackBar
            // 
            trackBar.BackColor = Color.FromArgb(255, 128, 128);
            trackBar.Location = new Point(12, 353);
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(546, 56);
            trackBar.TabIndex = 7;
            trackBar.Scroll += GetLength;
            // 
            // playlistBox
            // 
            playlistBox.BackColor = Color.FromArgb(255, 192, 128);
            playlistBox.Font = new Font("Swis721 BlkCn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playlistBox.FormattingEnabled = true;
            playlistBox.Location = new Point(12, 509);
            playlistBox.Name = "playlistBox";
            playlistBox.Size = new Size(546, 144);
            playlistBox.TabIndex = 8;
            playlistBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.BackColor = Color.FromArgb(255, 128, 128);
            lblDuration.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDuration.ForeColor = SystemColors.ButtonHighlight;
            lblDuration.Location = new Point(502, 386);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(52, 23);
            lblDuration.TabIndex = 9;
            lblDuration.Text = "00:00";
            lblDuration.Click += lblDuration_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(570, 681);
            Controls.Add(lblDuration);
            Controls.Add(playlistBox);
            Controls.Add(trackBar);
            Controls.Add(btnStop);
            Controls.Add(button4);
            Controls.Add(btnPlay);
            Controls.Add(button2);
            Controls.Add(btnFiles);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnFiles;
        private Button button2;
        private Button btnPlay;
        private Button button4;
        private Button btnStop;
        private Button btnClose;
        private TrackBar trackBar;
        private ListBox playlistBox;
        private Label lblDuration;
        private System.Windows.Forms.Timer timer1;
    }
}
