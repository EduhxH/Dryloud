namespace WinFormsApp6
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel1 = new Panel();
            button6 = new Button();
            pictureBox2 = new PictureBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            Musicas = new ListBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 86);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(1154, 26);
            button6.Name = "button6";
            button6.Size = new Size(85, 38);
            button6.TabIndex = 5;
            button6.Text = "LogOut";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.fa0e7b992eff03c576727e95c746005c_removebg_preview;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(300, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 60);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Musicas", "Playlist", "Converter Musicas Para MP3" });
            comboBox1.Location = new Point(383, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(518, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Gemini_Generated_Image_axsvn0axsvn0axsv__1__removebg_preview__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 68);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(Musicas);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 665);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.InactiveCaptionText;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(44, 597);
            button5.Name = "button5";
            button5.Size = new Size(123, 33);
            button5.TabIndex = 3;
            button5.Text = "Parar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(54, 9);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "Adicionar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaptionText;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(44, 546);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 1;
            button1.Text = "Selecionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Musicas
            // 
            Musicas.BackColor = SystemColors.InactiveBorder;
            Musicas.FormattingEnabled = true;
            Musicas.Location = new Point(12, 44);
            Musicas.Name = "Musicas";
            Musicas.Size = new Size(182, 484);
            Musicas.TabIndex = 0;
            Musicas.SelectedIndexChanged += Musicas_SelectedIndexChanged;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(254, 110);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(836, 606);
            axWindowsMediaPlayer1.TabIndex = 2;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1127, 198);
            button2.Name = "button2";
            button2.Size = new Size(132, 43);
            button2.TabIndex = 3;
            button2.Text = "Playlist";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1127, 110);
            button3.Name = "button3";
            button3.Size = new Size(132, 43);
            button3.TabIndex = 4;
            button3.Text = "Converter Ficheiro";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HD_Black_Essence_wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1280, 751);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "DRYLOUD 0.2 BETA";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private ListBox Musicas;
        private Button button1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private ComboBox comboBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}