using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form4 : Form
    {
        private readonly string usersFilePath;

        public Form4()
        {
            InitializeComponent();
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WinFormsApp2");
            Directory.CreateDirectory(folder);
            usersFilePath = Path.Combine(folder, "users.json");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // o usuario deve inserir o nome de utilizador nesta caixa de texto

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Insira o nome de utilizador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Insira a senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var users = LoadUsers();

            var user = users.Find(u => string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));
            if (user == null)
            {
                MessageBox.Show("Nome de utilizador não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] salt = Convert.FromBase64String(user.Salt);
            byte[] expectedHash = Convert.FromBase64String(user.PasswordHash);
            byte[] actualHash = Pbkdf2Hash(password, salt, 100_000, expectedHash.Length);

            if (!CryptographicOperations.FixedTimeEquals(actualHash, expectedHash))
            {
                MessageBox.Show("Senha incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Login efetuado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Aqui pode abrir a próxima janela ou definir DialogResult
            this.Close();
        }

        private static byte[] Pbkdf2Hash(string password, byte[] salt, int iterations, int outputBytes)
        {
            using var rfc = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256);
            return rfc.GetBytes(outputBytes);
        }

        private List<StoredUser> LoadUsers()
        {
            try
            {
                if (!File.Exists(usersFilePath))
                    return new List<StoredUser>();

                string json = File.ReadAllText(usersFilePath, Encoding.UTF8);
                return JsonSerializer.Deserialize<List<StoredUser>>(json) ?? new List<StoredUser>();
            }
            catch
            {
                return new List<StoredUser>();
            }
        }

        private class StoredUser
        {
            public string Username { get; set; } = string.Empty;
            public string PasswordHash { get; set; } = string.Empty;
            public string Salt { get; set; } = string.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
