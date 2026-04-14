using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        private readonly string usersFilePath;

        public Form3()
        {
            InitializeComponent();
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WinFormsApp2");
            Directory.CreateDirectory(folder);
            usersFilePath = Path.Combine(folder, "users.json");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // o usuario deve inserir o nome de utilizador nesta caixa de texto 
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;
            string confirm = textBox3.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Insira um nome de utilizador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Insira uma senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var users = LoadUsers();

            if (users.Exists(u => string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Nome de utilizador já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] salt = RandomNumberGenerator.GetBytes(16);
            byte[] hash = Pbkdf2Hash(password, salt, 100_000, 32);

            var newUser = new StoredUser
            {
                Username = username,
                PasswordHash = Convert.ToBase64String(hash),
                Salt = Convert.ToBase64String(salt)
            };

            users.Add(newUser);
            SaveUsers(users);

            MessageBox.Show("Conta criada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SaveUsers(List<StoredUser> users)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(users, options);
            File.WriteAllText(usersFilePath, json, Encoding.UTF8);
        }

        private class StoredUser
        {
            public string Username { get; set; } = string.Empty;
            public string PasswordHash { get; set; } = string.Empty;
            public string Salt { get; set; } = string.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
