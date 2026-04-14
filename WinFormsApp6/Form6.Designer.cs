namespace WinFormsApp6
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            Playlist = new ListBox();
            button1 = new Button();
            button2 = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Playlist
            // 
            Playlist.FormattingEnabled = true;
            Playlist.Location = new Point(26, 88);
            Playlist.Name = "Playlist";
            Playlist.Size = new Size(268, 604);
            Playlist.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(26, 41);
            button1.Name = "button1";
            button1.Size = new Size(111, 41);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(183, 41);
            button2.Name = "button2";
            button2.Size = new Size(111, 41);
            button2.TabIndex = 2;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(337, 41);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(804, 722);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Gemini_Generated_Image_axsvn0axsvn0axsv__1__removebg_preview__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1162, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 80);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1232, 712);
            button3.Name = "button3";
            button3.Size = new Size(132, 33);
            button3.TabIndex = 5;
            button3.Text = "Voltar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(26, 712);
            button4.Name = "button4";
            button4.Size = new Size(132, 33);
            button4.TabIndex = 6;
            button4.Text = "Tocar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(174, 712);
            button5.Name = "button5";
            button5.Size = new Size(130, 33);
            button5.TabIndex = 7;
            button5.Text = "Parar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HD_Black_Essence_wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1391, 775);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Playlist);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6";
            Text = "DRYLOUD 0.2 BETA";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox Playlist;
        private Button button1;
        private Button button2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}