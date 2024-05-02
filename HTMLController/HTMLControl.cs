using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace HTMLController
{
    public partial class HTMLControl: UserControl
    {
        string HTMLcode = "";
        string FileName =   "";

        public HTMLControl()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "HTML файл (*.html)|*.html|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog1.Filter = "HTML файл (*.html)|*.html|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void open_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
                // получаем выбранный файл
                FileName = openFileDialog1.FileName;
                string filename = openFileDialog1.FileName;
                //  Process.Start(filename);
                HTMLcode = System.IO.File.ReadAllText(filename);
                richTextBox1.Text = HTMLcode;
                // textBox1.Text = fileText;
                MessageBox.Show("Файл открыт");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
            }
        }

        private void saveas_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text.Length == 0) {
                    MessageBox.Show("Пустое поле");
                    return; 
                }
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, richTextBox1.Text);
                MessageBox.Show("Файл сохранен");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }

        private void read_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text.Length == 0)
                {
                    MessageBox.Show("Пустое поле");
                    return;
                }
                else HTMLcode = richTextBox1.Text.ToString();
                //string tempFilePath = Path.Combine(Path.GetTempPath(), "temp.html");
                string filename = $"\"{FileName}\"";
                File.WriteAllText(FileName, HTMLcode);
                Process.Start("msedge.exe", filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text.Length == 0)
                {
                    MessageBox.Show("Пустое поле");
                    return;
                }
                // получаем выбранный файл
                //string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                System.IO.File.WriteAllText(FileName, richTextBox1.Text);
                MessageBox.Show("Файл сохранен");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }
    }
}
