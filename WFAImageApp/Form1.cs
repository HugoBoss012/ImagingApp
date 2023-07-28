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

namespace WFAImageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImageExtractor im = new ImageExtractor();
           // im.ShowDialog();
           
        }

        // Populate With imgs and index
        private void populate(string input)
        {
            // imgLisr to hold imgs
            //ImageList imgs = new ImageList();
            //imgs.ImageSize = new Size(50,50);

            

            // load imgs from file 
            FileInfo[] paths = new DirectoryInfo(input).GetFiles("*",SearchOption.AllDirectories);

            try
            {
                foreach (var path in paths)
                {
                   dgv_Files.Rows.Add(path.FullName,path.Length/1024+"KB",path.Extension);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

           
        }

        private void btn_Populate_Click(object sender, EventArgs e)
        {
            populate(tb_Folder.Text);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dgv_Files.Rows.Clear();
        }

        // this saves all the records to a csv file on your desktop.
        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create),
                        Encoding.UTF8))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Image Name, DPI, Dimensions, Size, Format");

                        foreach (DataGridViewRow row in dgv_Files.Rows)
                        {
                            sb.AppendLine(string.Format("{0},{1},{2},{3},{4}", row.Cells[0].Value, 
                                row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value));
                        }
                        sw.WriteLine(sb.ToString());
                        MessageBox.Show("Your Data has been successfully saved.","Message",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.ShowDialog();

            if (!string.IsNullOrEmpty(fbd.SelectedPath))
            {
                tb_Folder.Text = fbd.SelectedPath;
            }

            //if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            //{
            //    string[] files = Directory.GetFiles(fbd.SelectedPath);

            //    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

            //}
        }
    }
}
