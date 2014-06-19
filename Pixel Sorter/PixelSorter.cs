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
        List<Color> alikePixels;
        List<Color> currentPixel;
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


            alikePixels = new List<Color>();
            currentPixel = new List<Color>();

            List<Color> pixelRow = new List<Color>();
            List<Color> pixelCol = new List<Color>();

            long res = 0;
            bool flipflop = true;
            unsafe
            {
                for (int y = 0; y < pixelData.Height; y++)
                {
                    byte* row = (byte*)pixelData.Scan0 + (y * pixelData.Stride);
                    for (int x = 0; x < pixelData.Width; x++)
                    {
                        int offSet = x * PixelAmount;
                        res++;
                        if (flipflop)
                        {
                            pixelRow.Add(Color.FromArgb(row[offSet + 3], row[offSet + 2], row[offSet + 1], row[offSet]));
                            flipflop = !flipflop;
                        }
                        else
                        {
                            pixelCol.Add(Color.FromArgb(row[offSet + 3], row[offSet + 2], row[offSet + 1], row[offSet]));
                            flipflop = true;
                        }
                    }
                }
                MessageBox.Show("Total Pixels: " + res.ToString() + " Number of pixels in Row " + pixelRow.Count.ToString() + " Number of pixels in Col " + pixelCol.Count.ToString());
                //Sloppy joe
                for (int x = 0; x < pixelCol.Count; x++)
                    MessageBox.Show(pixelCol[x].ToString());
                for (int x = 0; x < pixelRow.Count; x++)
                    MessageBox.Show(pixelRow[x].ToString());
            }
            #endregion
            sortThis.UnlockBits(pixelData);
            return sortThis;
        }

        private bool checkPixels(int pix1, int pix2)
        {
            return Math.Abs(pix1 - pix2) / 256 < 42;
        }


    }
}
