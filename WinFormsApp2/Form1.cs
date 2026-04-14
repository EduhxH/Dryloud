using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class DryLoud : Form
    {
        public DryLoud()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // iniciar sessão

            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // o botão "Já tenho uma conta" deve levar o usuário para a tela de login (Form4)
            Form4 loginForm = new Form4();
            loginForm.Show();
        }

        private void DryLoud_Load(object sender, EventArgs e)
        {
        }
    }
}
