namespace WinFormsApp2
{
    partial class DryLoud
    {
        /// <summary>
        ///  
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  
        /// </summary>
        /// <param name="disposing" 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(90, 463);
            button1.Name = "button1";
            button1.Size = new Size(309, 46);
            button1.TabIndex = 0;
            button1.Text = "Criar conta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(105, 537);
            button2.Name = "button2";
            button2.Size = new Size(276, 40);
            button2.TabIndex = 1;
            button2.Text = "Já tenho uma conta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Gemini_Generated_Image_axsvn0axsvn0axsv__1__removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(41, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 140);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // DryLoud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._76bc2cdec9c8851e9022732776630772;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(485, 724);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "DryLoud";
            Text = "DryLoud";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // abrir pagina de criar conta em Form3
            Form3 registerForm = new Form3();   
            registerForm.ShowDialog();  
        }
    }
}
