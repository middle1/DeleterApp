using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DeleterApp
{
    public partial class MainMenu : Form
    {
        private Timer timer;
        private Timer Timer_Revert;
        private Size startSize = new Size(426, 315);
        private Size targetSize = new Size(900, 600);
        private const int stepSize = 10;
        private const int timerInterval = 20;
        private const int timerInterval_revert = 20;

        private List<string> fileList = new List<string>();
        private int fileCount = 0, folderCount = 0;
        private long totalFileWeight = 0, totalFolderWeight = 0;

        public MainMenu()
        {
            InitializeComponent();
            this.ClientSize = startSize;
            timer = new Timer();
            Timer_Revert = new Timer();
            Timer_Revert.Interval = timerInterval_revert;
            timer.Interval = timerInterval;
            timer.Tick += Timer_Tick;
            Timer_Revert.Tick += Timer_Tick_Revert;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.ClientSize.Width < targetSize.Width || this.ClientSize.Height < targetSize.Height)
            {
                this.ClientSize = new Size(ClientSize.Width + stepSize, this.ClientSize.Height + stepSize);
                CenterToScreen();
            }
            else
            {
                timer.Stop();
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                ClearAllButton.Visible = true;
                ClearAllFull.Visible = true;
                ClearAllDefault.Visible = true;
                progressBar1.Visible = true;
            }
        }

        private void Timer_Tick_Revert(object sender, EventArgs e)
        {
            if (this.ClientSize.Width > startSize.Width || this.ClientSize.Height > startSize.Height)
            {
                this.ClientSize = new Size(ClientSize.Width - stepSize, this.ClientSize.Height - stepSize);
                CenterToScreen();
            }
            else
            {
                Timer_Revert.Stop();
            }
        }
        void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) == true)
            {
                label1.Text = "Отпустите мышь";
                e.Effect = DragDropEffects.Copy;
            }
        }
        void panel1_DragLeave(object sender, EventArgs e)
        {
            label1.Text = "Перетащите файл сюда";
        }

        void panel1_DragDrop(object sender, DragEventArgs e)
        {
            label1.Text = "Перетащите файл сюда";

            timer.Start();
            LoadingGif.Visible = true;
            Cursor.Current = Cursors.WaitCursor;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length > 0)
            {
                StringBuilder fileOutput = new StringBuilder();

                foreach (string path in files)
                {
                    if (File.Exists(path))
                    {
                        if (!fileList.Contains(path))
                        {
                            fileList.Add(path);
                            FileInfo fileInfo = new FileInfo(path);
                            fileOutput.AppendLine($"{path} (файл)");
                            fileCount++;
                            totalFileWeight += fileInfo.Length;
                        }
                    }
                    else if (Directory.Exists(path))
                    {
                        if (!fileList.Contains(path))
                        {
                            fileList.Add(path);
                            DirectoryInfo dirInfo = new DirectoryInfo(path);
                            fileOutput.AppendLine($"{path} (папка)");
                            folderCount++;
                            totalFolderWeight += GetDirectoryWeight(dirInfo, ref fileCount, ref folderCount, ref totalFileWeight, ref totalFolderWeight);
                        }
                    }
                }

                string output = fileOutput.ToString();
                label3.Text += Environment.NewLine + output;
                UpdateCountLabels();
                UpdateTotalWeightLabels();
            }
            Cursor.Current = Cursors.Arrow;
            LoadingGif.Visible = false;
        }


        private void UpdateCountLabels()
        {
            label4.Text = $"Файлы: {fileCount}";
            label5.Text = $"Папки: {folderCount}";
        }

        private void UpdateTotalWeightLabels()
        {
            label6.Text = $"Весь вес папок {(totalFolderWeight / 1024.0 / 1024.0):F2} MB\nВесь вес файлов: {(totalFileWeight / 1024.0 / 1024.0):F2} MB";
        }

        private long GetDirectoryWeight(DirectoryInfo dirInfo, ref int fileCount, ref int folderCount, ref long totalFileWeight, ref long totalFolderWeight)
        {
            long weight = 0;
            FileInfo[] fileInfos = dirInfo.GetFiles();

            foreach (FileInfo fileInfo in fileInfos)
            {
                weight += fileInfo.Length;
                fileCount++;
                totalFileWeight += fileInfo.Length;
            }

            DirectoryInfo[] subDirs = dirInfo.GetDirectories();

            foreach (DirectoryInfo subDir in subDirs)
            {
                weight += GetDirectoryWeight(subDir, ref fileCount, ref folderCount, ref totalFileWeight, ref totalFolderWeight);
                folderCount++;
                totalFolderWeight += weight;
            }

            return weight;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            float[] dashes = { 3, 1 };
            Pen pen = new Pen(Color.Black, 2);
            pen.DashPattern = dashes;
            e.Graphics.DrawRectangle(pen, 1, 1, panel1.Width - 2, panel1.Height - 2);
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CleanListFiles();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private bool Warning()
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить эти файлы?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    return true;
                case DialogResult.No:
                    return false;
                default:
                    return false;
            }
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            MinimizeForm.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            CloseForm.BackColor = Color.Maroon;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            CloseForm.BackColor = Color.Transparent;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            MinimizeForm.BackColor = Color.Transparent;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadingGif_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private Point LastPos;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var control = this.GetChildAtPoint(e.Location);
                if (control != null && control != this && !typeof(Label).IsAssignableFrom(control.GetType()))
                {
                    return;
                }

                this.Left += e.X - LastPos.X;
                this.Top += e.Y - LastPos.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPos = e.Location;
        }

        private void ClearAllDefault_Click(object sender, EventArgs e)
        {
            bool result = Warning();
            if (result == false)
            {
                MessageBox.Show("Действие отменено", "Deleter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            progressBar1.Value += 10;
            foreach (string path in fileList)
            {
                try
                {
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    else if (Directory.Exists(path))
                    {
                        Directory.Delete(path, true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления, не все файлы были удалены, код: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            progressBar1.Value += 10;
            Cursor.Current = Cursors.Default;
            MessageBox.Show("Операция удаления прошла успешно", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CleanListFiles();

        }

        private void ClearAllFull_Click(object sender, EventArgs e)
        {
            bool result = Warning();
            if (result == false)
            {
                MessageBox.Show("Действие отменено", "Deleter", MessageBoxButtons.OK);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            progressBar1.Value += 10;
            foreach (string path in fileList)
            {
                fullDelete(path);
            }
            progressBar1.Value += 10;
            Cursor.Current = Cursors.Default;
            MessageBox.Show("Операция удаления прошла успешно", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleanListFiles();
        }
        void fullDelete(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    using (var fs = new FileStream(path, FileMode.Open, FileAccess.Write))
                    {
                        fs.SetLength(0);
                    }
                    File.Delete(path);
                }
                else if (Directory.Exists(path))
                {
                    foreach (string files in Directory.GetFiles(path))
                    {
                        fullDelete(files);
                    }
                    foreach (string dirs in Directory.GetDirectories(path))
                    {
                        fullDelete(dirs);
                    }
                    Directory.Delete(path, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления, не все файлы были удалены, код: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        void CleanListFiles()
        {
            fileList.Clear();
            fileCount = 0;
            folderCount = 0;
            totalFileWeight = 0;
            totalFolderWeight = 0;

            label3.Text = "";
            UpdateCountLabels();
            UpdateTotalWeightLabels();
            Timer_Revert.Start();

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            ClearAllButton.Visible = false;
            ClearAllFull.Visible = false;
            ClearAllDefault.Visible = false;
            progressBar1.Value = progressBar1.Minimum;
            progressBar1.Visible = false;
        }
    }
}
