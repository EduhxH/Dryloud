namespace WinFormsApp6
{
    partial class Form5
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(264, 224);
            label1.Name = "label1";
            label1.Size = new Size(533, 106);
            label1.TabIndex = 0;
            label1.Text = "VERSÃO BETA";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HD_Black_Essence_wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1073, 591);
            Controls.Add(label1);
            Name = "Form5";
            Text = "DRYLOUD 0.2 BETA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}