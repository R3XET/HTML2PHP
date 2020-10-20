using System;
using System.IO;
using System.Windows.Forms;

namespace HTML2PHP
{
    public partial class html2php_form : Form
    {
        private int fileNumer = 0;
        private string directoryPath;

        public html2php_form()
        {
            InitializeComponent();
        }


        private void select_html_folder_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.fileNumer = 0;
                this.directoryPath = folderDlg.SelectedPath;
                foreach (string file in Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories))
                {
                    if (file.EndsWith(".html"))
                    {
                        this.fileNumer++;
                    }
                }
                html_files_lbl.Text = "Loaded HTML files: " + fileNumer;
            }
        }

        private void convert_to_php_btn_Click(object sender, EventArgs e)
        {
            if (directoryPath == null || fileNumer == 0)
            {
                MessageBox.Show("Invalid directory / no files with .html extension found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (string file in Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories))
            {
                if (file.EndsWith(".html"))
                {
                    File.Move(file, Path.ChangeExtension(file, ".php"));
                }
            }
            MessageBox.Show("Successfully replaced " + fileNumer + "files from .html to .php", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
