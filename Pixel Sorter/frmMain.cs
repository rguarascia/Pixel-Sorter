using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Sorter
{
    public partial class frmMain : Form
    {
        Bitmap userImg;
        PixelSorter sort = new PixelSorter();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImg = new OpenFileDialog();
            if (getImg.ShowDialog() == DialogResult.OK)
                userImg = new Bitmap(getImg.FileName);

            picDisplay.Image = sort.sorterImg(userImg);
        }
    }
}
