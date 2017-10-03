using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

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
    }
}
