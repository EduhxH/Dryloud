using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form6 : Form
    {
        private readonly string configPath;

        public Form6()
        {
            InitializeComponent();

            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WinFormsApp2");
            Directory.CreateDirectory(folder);
            configPath = Path.Combine(folder, "playlist.json");

            // Carregar playlist salva
            LoadPlaylist();

            // Garantir persistência ao fechar
            FormClosing += Form6_FormClosing;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        // Adiciona músicas à playlist (permite múltiplas seleções)
        private void button1_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Áudio|*.mp3;*.wav;*.wma;*.m4a|Todos os ficheiros|*.*",
                Multiselect = true,
                Title = "Selecionar músicas"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in ofd.FileNames)
                {
                    Playlist.Items.Add(file);
                }

                SavePlaylist();
            }
        }

        // Remove a música selecionada da playlist
        private void button2_Click(object sender, EventArgs e)
        {
            if (Playlist.SelectedIndex >= 0)
            {
                Playlist.Items.RemoveAt(Playlist.SelectedIndex);
                SavePlaylist();
            }
            else
            {
                MessageBox.Show("Selecione uma música para remover.", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Toca a música selecionada (ou a primeira se nada estiver selecionado)
        private void button4_Click(object sender, EventArgs e)
        {
            if (Playlist.Items.Count == 0)
            {
                MessageBox.Show("A playlist está vazia.", "Tocar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string path = Playlist.SelectedItem?.ToString() ?? Playlist.Items[0].ToString();
            try
            {
                axWindowsMediaPlayer1.URL = path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível tocar o ficheiro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Para a reprodução atual
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            catch (Exception)
            {
                // silencioso — se o player não estiver iniciado, nada a fazer
            }
        }

        // Volta para o Form4
        private void button3_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.Show();
            Close();
        }

        private void Form6_FormClosing(object? sender, FormClosingEventArgs e)
        {
            SavePlaylist();
        }

        private void LoadPlaylist()
        {
            try
            {
                if (!File.Exists(configPath))
                    return;

                string json = File.ReadAllText(configPath, Encoding.UTF8);
                var items = JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();

                Playlist.Items.Clear();
                foreach (var item in items)
                {
                    Playlist.Items.Add(item);
                }
            }
            catch
            {
                // falha ao carregar, ignorar para não quebrar a UI
            }
        }

        private void SavePlaylist()
        {
            try
            {
                var items = Playlist.Items.Cast<string>().ToList();
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(items, options);
                File.WriteAllText(configPath, json, Encoding.UTF8);
            }
            catch
            {
                // falha ao salvar; poderia registar/logar se necessário
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
