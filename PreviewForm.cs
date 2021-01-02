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
    public partial class PreViewForm : Form
    {
        public new Any2IcoForm Owner;
        public PreViewForm()
        {
            InitializeComponent();
            previewBox.Dock = DockStyle.Fill;

            
        }

        public void PreviewRanderring(string imgPath)
        {

            previewBox.Image = null;
            int width = previewBox.Width;
            int height = previewBox.Height;
            MagickImage image = new MagickImage(imgPath);
            MagickGeometry size = new MagickGeometry(width, height);
            size.IgnoreAspectRatio = true;
            image.Resize(size);
            image.Format = MagickFormat.Png;
            previewBox.SizeMode = PictureBoxSizeMode.StretchImage;
            // previewBox.Image = (Bitmap)image.ToByteArray();

            byte[] imageSource = image.ToByteArray();
            Bitmap preview;
            using (MemoryStream stream = new MemoryStream(imageSource))
            {
                preview = new Bitmap(stream);
            }
            previewBox.Image = preview;

        }

        private void PreViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            previewBox.Image.Dispose();
            previewBox.Image = null;
        }

    }
}
