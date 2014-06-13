using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms; //Strictly for debugging 

namespace Pixel_Sorter
{
    class PixelSorter
    {
        List<Color> pixelColours;
        public Bitmap sorterImg(Bitmap currentImage)
        {
            Bitmap sortThis = currentImage;

            BitmapData pixelData = new BitmapData();
            #region LockBits
            IntPtr Pointer;

            pixelData = sortThis.LockBits(new Rectangle(0, 0, sortThis.Width, sortThis.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            Pointer = pixelData.Scan0;

            int ArraySize = Math.Abs(pixelData.Stride) * sortThis.Height;

            byte[] PixelArray = new byte[ArraySize];

            Marshal.Copy(Pointer, PixelArray, 0, ArraySize);

            int PixelAmount = 4; //Argb

            pixelColours = new List<Color>();

            unsafe
            {
                for (int y = 0; y < pixelData.Height; y++)
                {
                    byte* row = (byte*)pixelData.Scan0 + (y * pixelData.Stride);

                    for (int x = 0; x < pixelData.Width; x++)
                    {
                        int offSet = x * PixelAmount;

                        //List of all the colours, going from left to right, then down.
                        pixelColours.Add(Color.FromArgb(row[offSet + 3], row[offSet + 2], row[offSet + 1], row[offSet]));

                    }
                }
            }
            #endregion
            sortThis.UnlockBits(pixelData);
            return sortThis;
        }

        private void sorter(int imgWidth, int imgHeight)
        {
            for (int y = 0; y < imgHeight; y++)
            {
                for (int x = 0; x < imgWidth; x++)
                {
                    //Sort.
                }
            }
        }
    }
}
