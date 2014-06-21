using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms; //Strictly for debugging 


//Ryan Guarasica
//June, 20, 2014
//A pixel sorter and placement arranger
namespace Pixel_Sorter
{
    class PixelSorter
    {
        int sendMeOver;
        public Bitmap sorterImg(string currentPath, int sortMethod)
        {
            List<byte> bluePix = new List<byte>();
            List<byte> redPix = new List<byte>();
            List<byte> greenPix = new List<byte>();
            sendMeOver = 0;
            Bitmap sortThis = new Bitmap(currentPath);
            BitmapData pixelData = new BitmapData();
            IntPtr Pointer;
            pixelData = sortThis.LockBits(new Rectangle(0, 0, sortThis.Width, sortThis.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            Pointer = pixelData.Scan0;
            int ArraySize = Math.Abs(pixelData.Stride) * sortThis.Height;
            byte[] PixelArray = new byte[ArraySize];
            Marshal.Copy(Pointer, PixelArray, 0, ArraySize);
            int PixelAmount = 4; //Argb

            int res = 0;
            redPix.Clear();
            greenPix.Clear();
            bluePix.Clear();
            unsafe
            {
                for (int y = 0; y < pixelData.Height; y++)
                {
                    byte* row = (byte*)pixelData.Scan0 + (y * pixelData.Stride);
                    for (int x = 0; x < pixelData.Width; x++)
                    {
                        int offSet = x * PixelAmount;

                        switch (sortMethod)
                        {
                            case 0:

                                bluePix.Add(row[offSet]);
                                greenPix.Add(row[offSet + 1]);
                                redPix.Add(row[offSet + 2]);

                                row[offSet] = bluePix[res];
                                row[offSet + 1] = greenPix[res];
                                row[offSet + 2] = redPix[res];
                                break;

                            case 1:
                                bluePix.Add(row[offSet]);
                                greenPix.Add(row[offSet + 1]);
                                redPix.Add(row[offSet + 2]);

                                row[offSet] = bluePix[x * y];
                                row[offSet + 1] = greenPix[x * y];
                                row[offSet + 2] = redPix[x * y];
                                break;

                            case 2:
                                bluePix.Add(row[offSet]);
                                greenPix.Add(row[offSet + 1]);
                                redPix.Add(row[offSet + 2]);

                                row[offSet] = bluePix[res / 2];
                                row[offSet + 1] = greenPix[res / 2];
                                row[offSet + 2] = redPix[res / 2];
                                break;

                        }
                        res++;
                    }
                }
                sendMeOver = res;
            }
            sortThis.UnlockBits(pixelData);
            return sortThis;
        }

        private bool checkPixels(int pix1, int pix2)
        {
            return Math.Abs(pix1 - pix2) / 256 < 42;
        }

        public int Res()
        {
            return sendMeOver;
        }
    }
}
