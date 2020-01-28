using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using ImageMagick;

namespace ImageConverter
{
    public partial class MainForm : Form
    {
        private string source_dir = String.Empty; 
        private string dest_dir = String.Empty;
        private string image_format = String.Empty;
        private List<string> image_formats = new List<string>();
        List<string> files = new List<string>();
        List<string> dirs = new List<string>();
        int convert_progress = 1;

        public MainForm()
        {
            InitializeComponent();
            foreach(var item in Enum.GetValues(typeof(MagickFormat)))
            {
                image_formats.Add(item.ToString().ToLower());
                cbFormats.Items.Add(item);
            }
            pBar.Minimum = 0;
            pBar.Maximum = 2;
            pBar.Step = 1;
            pBar.Value = 1;
        }

        private void btChangeFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();
                if(result == DialogResult.OK)
                {
                    lPath.Text = source_dir = folderBrowser.SelectedPath;
                    dest_dir = source_dir + "\\Convert";
                    GetFileTree(source_dir);
                    pBar.Maximum = files.Count;
                }
            }
            CheckControlState();
        }

        private void CheckControlState()
        {
            btConvert.Enabled = !String.IsNullOrEmpty(source_dir) && cbFormats.SelectedIndex >= 0;
        }

        private void GetFileTree(string Path)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(Path))
                {
                    if (dir.Contains("Convert"))
                        continue;
                    dirs.Add(dir);
                    foreach (string file in Directory.GetFiles(dir))
                    {
                        files.Add(file);
                    }
                    GetFileTree(dir);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(String.Format("Can't find files: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertFile(string file)
        {
            try
            {
                string filename = file.Split('\\')[file.Split('\\').Length - 1].Split('.')[0];
                string fileext = file.Split('\\')[file.Split('\\').Length - 1].Split('.')[1].ToLower();
                if (!image_formats.Contains(fileext) && !cbIgnoreErrors.Checked)
                {
                    throw new Exception("Not supportable image format");
                }
                string result_filepath = dest_dir + "\\" + filename + "." + image_format;
                if (File.Exists(result_filepath))
                {
                    if (!cbRewriteFiles.Checked)
                    {
                        return;
                    }
                    File.Delete(result_filepath);
                }
                using (MagickImage image = new MagickImage(file))
                {
                    image.Format = (MagickFormat)Enum.Parse(typeof(MagickFormat), image_format);
                    image.Write(result_filepath);
                }

            }
            catch (Exception ex)
            {
                if (!cbIgnoreErrors.Checked)
                    MessageBox.Show(String.Format("Can't convert file: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateControl();
        }

        delegate void Progress(int value);

        private void UpdateControl()
        {
            lStatus.Invoke(new MethodInvoker(delegate
            {
                convert_progress++;
                lStatus.Text = convert_progress.ToString() + " из " + files.Count.ToString();
                lStatus.Update();
            }));
            pBar.Invoke(new MethodInvoker(delegate
            {
                pBar.PerformStep();
            }));
        }
           
        private async Task ConvertAsync()
        {
            lStatus.Text = "Processing...";

            if (!Directory.Exists(dest_dir))
            {
                Directory.CreateDirectory(dest_dir);
            }

            List<Task> tasks = new List<Task>();
            foreach(var file in files)
            {
                tasks.Add(Task.Run(() =>
                {
                    ConvertFile(file);
                }));
            }
            await Task.WhenAll(tasks.ToArray());
        }

        private async void btConvert_Click(object sender, EventArgs e)
        {
            pBar.Visible = lStatus.Visible = true;
            btConvert.Enabled = false;
            btConvert.Text = "Processing...";
            await ConvertAsync();
            btConvert.Enabled = true;
            btConvert.Text = "Convert";
            pBar.Visible = lStatus.Visible = false;
            pBar.Value = 1;
            convert_progress = 1;
        }

        private void cbFormats_SelectionChangeCommitted(object sender, EventArgs e)
        {
            image_format = cbFormats.SelectedItem.ToString();
            CheckControlState();
        }
    }
}
