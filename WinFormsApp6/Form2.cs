
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form2 : Form
    {
        private readonly string usersFilePath;

        public Form2()
        {
            InitializeComponent();
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WinFormsApp2");
            Directory.CreateDirectory(folder);
            usersFilePath = Path.Combine(folder, "users.json");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                textBox2.UseSystemPasswordChar = true;
            }
            catch
            {
            }

            // Permitir submeter com Enter
            try
            {
                AcceptButton = button1;
            }
            catch
            {
            }

            // Caso o Designer tenha deixado UseWaitCursor, garantir cursor normal
            try
            {
                UseWaitCursor = false;
            }
            catch
            {
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // ícone também dispara o mesmo fluxo de login
            Login();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // botão "Entrar" chama a mesma rotina de login
            Login();
        }

        private void Login()
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text ?? string.Empty;

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

            if (string.IsNullOrEmpty(user.Salt) || string.IsNullOrEmpty(user.PasswordHash))
            {
                MessageBox.Show("Dados de utilizador inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] salt;
            byte[] expectedHash;
            try
            {
                salt = Convert.FromBase64String(user.Salt);
                expectedHash = Convert.FromBase64String(user.PasswordHash);
            }
            catch
            {
                MessageBox.Show("Dados de autenticação corrompidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] actualHash = Pbkdf2Hash(password, salt, 100_000, expectedHash.Length);

            if (!CryptographicOperations.FixedTimeEquals(actualHash, expectedHash))
            {
                MessageBox.Show("Senha incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Login bem-sucedido: abrir Form4
            try
            {
                MessageBox.Show("Login efetuado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Esconde o form de login enquanto o Form4 está aberto
                Hide();

                using var form4 = new Form4();
                form4.ShowDialog(this);
            }
            finally
            {
                // sinaliza sucesso ao chamador e fecha o Form2
                DialogResult = DialogResult.OK;
                Close();
            }
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
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                return JsonSerializer.Deserialize<List<StoredUser>>(json, options) ?? new List<StoredUser>();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // abrir form4 apos login bem-sucedido 
    }
}

