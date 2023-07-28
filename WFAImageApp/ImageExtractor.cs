using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAImageApp
{
    public partial class ImageExtractor : Form
    {
        NameValueCollection config = ConfigurationManager.AppSettings;
        public ImageExtractor()
        {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                tb_From.Text = fbd.SelectedPath;
                //string[] files = Directory.GetFiles(fbd.SelectedPath);
                //FileInfo[] fi = new DirectoryInfo(fbd.SelectedPath).GetFiles("*",SearchOption.AllDirectories);

                //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

            }
        }

        private void btn_Browse2_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                tb_To.Text = fbd.SelectedPath;
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

            }
        }

        private void btn_Proceed_Click(object sender, EventArgs e)
        {
            String log = String.Empty;
            CheckFiles cf = new CheckFiles();
            cf.ProcessFiles(tb_From.Text,Int32.Parse(tb_Size.Text), Int32.Parse(tb_ThreshSize.Text), tb_To.Text, config["UserValidation"], out log);
            MessageBox.Show(log);
        }

        private void tb_Size_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
