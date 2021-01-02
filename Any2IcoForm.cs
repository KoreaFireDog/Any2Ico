using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;
using Microsoft.WindowsAPICodePack.Dialogs;



namespace Any2Ico
{
    public partial class Any2IcoForm : Form
    {
        private BackgroundWorker cBackWorker;
        public List<string> fileList = new List<string>();
        public List<string> convertFileList = new List<string>();
        public string outFoler = "";
        public int imgSize = 16;
        public PreViewForm pfrm = new PreViewForm();
        public ConvertView cfrm = new ConvertView();
        public bool oriState = true;
        public bool covState = true;


        public Any2IcoForm()
        {
            InitializeComponent();
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            openFile.Filter = "eps (*.eps)|*.eps|tif (*.tif)|*.tif|pcx (*.pcx)|*.pcx|psd (*.psd)|*.psd|bmp (*.bmp)|*.bmp|jpeg (*.jpeg)|*.jpeg|jpg (*.jpg)|*.jpg|gif (*.gif)|*.gif|png (*.png)|*.png|svg (*.svg)|*.svg|All files (*.*)|*.*".ToUpper();
            openFile.FilterIndex = 11;
            openFile.Title = "choose image type file";
            openFile.ShowDialog();
        }

        private void OpenFolderBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                String FolderName = dialog.FileName;
                DirectoryInfo di = new DirectoryInfo(FolderName);
                foreach (FileInfo File in di.GetFiles())
                {
                    string ext = Path.GetExtension(File.FullName).ToLower();
                    if(ext == ".png" || ext == ".gif" || ext == ".jpg" || ext == ".jpeg" || ext == ".svg" || ext == ".bmp" || ext == ".psd" || ext == ".pcx" || ext == ".tif" || ext == ".eps")
                    {
                        if (!fileList.Contains(File.FullName))
                        {
                            string fullPath = File.FullName;
                            string fileName = Path.GetFileName(fullPath);
                            fileList.Add(fullPath);
                            OriginalFileList.Items.Add(fileName);
                        }
                    }
                }
            }



        }

        private void ConvertActionBtn_Click(object sender, EventArgs e)
        {

            ConvertFileListBox.Items.Clear();

            if (outFoler == "")
            {
                MessageBox.Show("Please choose out folder...");
                return;
            }

            if (OriginalFileList.Items.Count == 0) {
                MessageBox.Show("Please choose original file or folder...");
                return;
            }

            List<string> tmpList = new List<string>();
            for (int i = OriginalFileList.Items.Count - 1; i >= 0; i--)
            {
                if (OriginalFileList.GetItemChecked(i))
                {
                    tmpList.Add(fileList[i]);
                }
            }

            if(tmpList.Count == 0)
            {
                MessageBox.Show("Please check original files ...");
                return;
            }

           
            cBackWorker = new BackgroundWorker();
            imgSize =  Int32.Parse(IconSize.Text.Substring(0,2) );

            if (cBackWorker.IsBusy != true)
            {

                convertFileList = tmpList;
                OpenFileBtn.Enabled = false;
                OpenFolderBtn.Enabled = false;
                SelectAllBtn.Enabled = false;
                DeselectBtn.Enabled = false;
                DeleteBtn.Enabled = false;
                ClearBtn.Enabled = false;
                SaveFolderBtn.Enabled = false;
                ConvertActionBtn.Enabled = false;
                ConvertProgress.Visible = true;

                cBackWorker.DoWork += new DoWorkEventHandler(cBackWorker_DoWork);
                cBackWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(cBackWorker_RunWorkerCompleted);
                cBackWorker.RunWorkerAsync();

                ConvertProgress.Value = 0;
                ConvertProgress.Step = 1;
                ConvertProgress.Maximum = convertFileList.Count;
            }

  

        }


        private void cBackWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate ()
            {
                foreach (var filename in convertFileList)
                {
                    var info = new FileInfo(filename);
                    int nextInterval = (int)(info.Length / 1000 * 20);
                    ConvertProgress.PerformStep();
                    ConvertProgress.Update();
                    convertPng2Ico(filename);
                    Thread.Sleep(nextInterval);
                }
            }));
        }
 
        private void cBackWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            OpenFileBtn.Enabled = true;
            OpenFolderBtn.Enabled = true;
            SelectAllBtn.Enabled = true;
            DeselectBtn.Enabled = true;
            DeleteBtn.Enabled = true;
            ClearBtn.Enabled = true;
            SaveFolderBtn.Enabled = true;

            ConvertProgress.Visible = false;
            ConvertActionBtn.Enabled = true;
            cBackWorker.Dispose();
            cBackWorker = null;
            GC.Collect();
        }


        private void convertPng2Ico(string inPath)
        {
            string orginFileName = Path.GetFileName(inPath);
            string convertFile = outFoler + "\\" + imgSize +"x" + imgSize + "_" + orginFileName;

            string ext = extType.Text;
            string fileName = Path.ChangeExtension(convertFile, ext);


            

            using (MagickImage mimg = new MagickImage(inPath)){

                MagickGeometry size = new MagickGeometry(imgSize, imgSize);
                size.IgnoreAspectRatio = true;
                mimg.Resize(size);
                mimg.Sharpen();

                if(tp.Checked == true) {
                    mimg.Alpha(AlphaOption.Set);
                    mimg.ColorFuzz = new Percentage(10);
                    // -fill none
                    mimg.Settings.FillColor = MagickColors.None;
                    mimg.FloodFill(MagickColors.White, 0, 0);
                    mimg.Transparent(MagickColors.White);
                }



                if (ext == "ico")
                    mimg.Write(fileName, MagickFormat.Icon);
                else
                    mimg.Write(fileName, MagickFormat.Png);
                mimg.Dispose();
            }
            
           
            ConvertFileListBox.Items.Add(Path.GetFileName(fileName));
            ConvertFileListBox.Update();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            if (!fileList.Contains(openFile.FileName))
            {
                string fullPath = openFile.FileName;
                string fileName = Path.GetFileName(fullPath);
                fileList.Add(openFile.FileName);
                OriginalFileList.Items.Add(fileName);
            }

            
        }

        private void SaveFolderBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                outFoler = dialog.FileName;
                SavePathBox.Text = outFoler;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            oriState = false;
            for (int i = OriginalFileList.Items.Count - 1; i >= 0; i--)
            {
                if (OriginalFileList.GetItemChecked(i))
                {
                    OriginalFileList.Items.Remove(OriginalFileList.Items[i]);
                    fileList.RemoveAt(i);
                }
            }
            oriState = true;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            oriState = false;
            fileList.Clear();
            convertFileList.Clear();
            OriginalFileList.Items.Clear();
            ConvertFileListBox.Items.Clear();
            outFoler = "";
            SavePathBox.Text = "Save Path";
            oriState = true;
        }

        private void SelectAllBtn_Click(object sender, EventArgs e)
        {
            oriState = false;

            for (int i = OriginalFileList.Items.Count - 1; i >= 0; i--)
            {
                if (!OriginalFileList.GetItemChecked(i))
                {
                    OriginalFileList.SetItemChecked(i, true);
                }
            }

            oriState = true;
        }

        private void DeselectBtn_Click(object sender, EventArgs e)
        {
            oriState = false;
            for (int i = OriginalFileList.Items.Count - 1; i >= 0; i--)
            {
                if (OriginalFileList.GetItemChecked(i))
                {
                    OriginalFileList.SetItemChecked(i, false);

                }
            }
            oriState = true;
        }

        private void Any2IcoForm_Load(object sender, EventArgs e)
        {
            this.IconSize.Items.AddRange(new object[] {
            "16x16",
            "32x32",
            "40x40",
            "60x60",
            "80x80"});
            this.IconSize.SelectedIndex = 0;

            this.extType.Items.AddRange(new object[] {
            "ico",
            "png"});
            this.extType.SelectedIndex = 0;

        }

        private void OriginalFileList_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (oriState == true)
            {
                string oriFile = fileList[OriginalFileList.SelectedIndex];
                Point parentPoint = this.Location;
                Form fc = Application.OpenForms["PreViewForm"];
                if (fc != null)
                {
                    fc.Close();
                }
                pfrm = new PreViewForm();
                pfrm.StartPosition = FormStartPosition.Manual;
                pfrm.Location = new Point(parentPoint.X - pfrm.Size.Width + 15, parentPoint.Y);
                pfrm.Owner = this;
                pfrm.Show();

                //pfrm.BringToFront();
                pfrm.PreviewRanderring(oriFile);

            }
            this.Focus();
            /*else
            {
                Form fc = Application.OpenForms["PreViewForm"];
                if (fc != null)
                {
                    fc.Close();
                }
                //pfrm.Close();
            }*/



        }

        private void Any2IcoForm_LocationChanged(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["PreViewForm"];
            if (fc != null)
            {
                Point parentPoint = this.Location; // 메인폼(현재폼)의 위치
                pfrm.StartPosition = FormStartPosition.Manual;
                pfrm.Location = new Point(parentPoint.X - pfrm.Size.Width + 15, parentPoint.Y);
            }

            Form fc2 = Application.OpenForms["ConvertView"];
            if (fc2 != null)
            {
                Point parentPoint = this.Location;
                cfrm.StartPosition = FormStartPosition.Manual;
                cfrm.Location = new Point(parentPoint.X + this.Size.Width - 15, parentPoint.Y);
            }
        }

        private void ConvertFileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConvertFileListBox.SelectedIndices.Count > 0)
            {
                
                string oriFile = SavePathBox.Text + "\\" + ConvertFileListBox.SelectedItems[0].ToString();
                Point parentPoint = this.Location;
                Form fc = Application.OpenForms["ConvertView"];
                if (fc != null)
                {
                    fc.Close();
                }
                cfrm = new ConvertView();
                cfrm.StartPosition = FormStartPosition.Manual;
                cfrm.Location = new Point(parentPoint.X + this.Size.Width - 15, parentPoint.Y);
                cfrm.Owner = this;
                cfrm.Show();
                //cfrm.BringToFront();
                cfrm.PreviewRanderring(oriFile);
                ConvertFileListBox.Focus();


            }
            this.Focus();
        }

        private void OriginalFileList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (oriState == true )
            {
                string oriFile = fileList[OriginalFileList.SelectedIndex];
                Point parentPoint = this.Location;
                Form fc = Application.OpenForms["PreViewForm"];
                if (fc != null)
                {
                    fc.Close();
                }
                pfrm = new PreViewForm();
                pfrm.StartPosition = FormStartPosition.Manual;
                pfrm.Location = new Point(parentPoint.X - pfrm.Size.Width + 15, parentPoint.Y);
                pfrm.Owner = this;
                pfrm.Show();

                //pfrm.BringToFront();
                pfrm.PreviewRanderring(oriFile);

            }

            this.Focus();

        }
    }
}
