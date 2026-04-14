using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        // button4: adiciona ficheiros de música à ListBox `Musicas`
        private void button4_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Áudio (*.mp3;*.wav;*.wma;*.aac)|*.mp3;*.wav;*.wma;*.aac|Todos os ficheiros (*.*)|*.*",
                Title = "Adicionar músicas"
            };

            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            foreach (var file in dlg.FileNames)
            {
                // evita duplicados
                if (!Musicas.Items.Cast<object>().Any(it => string.Equals(it.ToString(), file, StringComparison.OrdinalIgnoreCase)))
                {
                    Musicas.Items.Add(file);
                }
            }
        }

        // button1: selecionar / tocar ficheiro (se houver seleção na ListBox toca; se não, abre diálogo para escolher e tocar)
        private void button1_Click(object sender, EventArgs e)
        {
            string fileToPlay = null;

            if (Musicas.SelectedItem is string selected && !string.IsNullOrWhiteSpace(selected))
            {
                fileToPlay = selected;
            }
            else
            {
                using var dlg = new OpenFileDialog
                {
                    Multiselect = false,
                    Filter = "Áudio (*.mp3;*.wav;*.wma;*.aac)|*.mp3;*.wav;*.wma;*.aac|Todos os ficheiros (*.*)|*.*",
                    Title = "Selecionar música para tocar"
                };

                if (dlg.ShowDialog(this) != DialogResult.OK)
                    return;

                fileToPlay = dlg.FileName;

                // opcional: adicionar ao Musicas se ainda não existir
                if (!Musicas.Items.Cast<object>().Any(it => string.Equals(it.ToString(), fileToPlay, StringComparison.OrdinalIgnoreCase)))
                {
                    Musicas.Items.Add(fileToPlay);
                    Musicas.SelectedIndex = Musicas.Items.Count - 1;
                }
            }

            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.URL = fileToPlay;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível reproduzir o ficheiro.\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // button5: parar a música
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            catch
            {
            }
        }

        // button6: logout e voltar para Form1 (procura instância aberta de Form1; se não existir cria uma nova)
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            catch
            {
            }

            // Tenta encontrar Form1 aberto
            var main = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (main != null)
            {
                // se Form1 estiver minimizado, restaurar
                if (main.WindowState == FormWindowState.Minimized)
                    main.WindowState = FormWindowState.Normal;

                main.Show();
                main.BringToFront();
            }
            else
            {
                var f1 = new Form1();
                f1.Show();
            }

            Close();
        }

        // Musicas: ao mudar seleção, atualiza o URL mas não inicia reprodução automática (mantive comportamento simples)
        private void Musicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Musicas.SelectedItem is string path && File.Exists(path))
            {
                try
                {
                    axWindowsMediaPlayer1.URL = path;
                }
                catch
                {
                }
            }
        }

        // button2: abrir Form6 (Playlist)
        private void button2_Click(object sender, EventArgs e)
        {
            using var form6 = new Form6();
            form6.ShowDialog(this);
        }

        // comboBox1: permite pesquisar músicas pelo nome; também permite selecionar opções especiais ("Playlist", "Converter Musicas Para MP3")
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = comboBox1.Text?.Trim();
            if (string.IsNullOrEmpty(text))
                return;

            if (text.Equals("Playlist", StringComparison.OrdinalIgnoreCase))
            {
                // abre Form6 (Playlist)
                using var form6 = new Form6();
                form6.ShowDialog(this);
                return;
            }

            if (text.Equals("Converter Musicas Para MP3", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Funcionalidade de conversão ainda não implementada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // pesquisa simples: seleciona o primeiro item cujo nome de ficheiro contém o texto pesquisado
            for (int i = 0; i < Musicas.Items.Count; i++)
            {
                var item = Musicas.Items[i]?.ToString() ?? string.Empty;
                var fileName = Path.GetFileName(item);
                if (fileName.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Musicas.SelectedIndex = i;
                    // opcional: tocar automaticamente
                    try
                    {
                        axWindowsMediaPlayer1.URL = item;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    catch
                    {
                    }
                    return;
                }
            }

            MessageBox.Show("Nenhuma música encontrada para a pesquisa.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // botão "Converter Ficheiro" no Designer (sem requisito detalhado). Placeholder.
            MessageBox.Show("Conversor não implementado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
