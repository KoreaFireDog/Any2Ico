using ImageMagick;
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

namespace Any2Ico
{
    public partial class ConvertView : Form
    {
        //public new Any2IcoForm Owner;
        public ConvertView()
        {
            InitializeComponent();
        }

        public void PreviewRanderring(string imgPath)
        {
            
            MagickImage image = new MagickImage(imgPath);
            image.Format = MagickFormat.Png;
            ConvertPreview.SizeMode = PictureBoxSizeMode.CenterImage;
            byte[] imageSource = image.ToByteArray();
            Bitmap preview;
            using (MemoryStream stream = new MemoryStream(imageSource))
            {
                preview = new Bitmap(stream);
            }
            ConvertPreview.Image = preview;
            

        }

        private void ConvertView_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConvertPreview.Image.Dispose();
            ConvertPreview.Image = null;
        }
    }
}
