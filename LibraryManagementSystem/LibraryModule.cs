using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public static class LibraryModule
    {
        public static Byte[] ImageToByteArray(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.GetBuffer();
        }

        public static Image ByteArrayToImage(Byte[] buffer)
        {
            MemoryStream ms = new MemoryStream(buffer);
            return Image.FromStream(ms);
        }

        public static void makePictureBoxRound(PictureBox pic)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pic.Width - 3, pic.Height - 3);
            Region rg = new Region(gp);
            pic.Region = rg;
            pic.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
