using System;
using System.IO;
using System.Windows.Forms;

namespace NameList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_button_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
                item_textBox.Text = fb.SelectedPath;
        }

        private void OpenListFileName(string itemList)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(itemList);
                FileInfo[] fi = dir.GetFiles();

                SaveFileDialog saveFile = new SaveFileDialog
                {
                    FileName = "Название",
                    DefaultExt = "*.txt",
                    Filter = "Текстовый файл|*.txt"
                };

                if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
                {
                    using (StreamWriter sw = new StreamWriter(saveFile.FileName, true))
                    {
                        progressBar1.Minimum = 1;
                        progressBar1.Maximum = fi.Length;
                        progressBar1.Value = 1;
                        progressBar1.Step = 1;

                        for (int i = 0; i < fi.Length; ++i)
                        {
                            sw.WriteLine(fi[i].ToString());
                            progressBar1.PerformStep();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Выберите папку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            OpenListFileName(item_textBox.Text);
        }
    }
}