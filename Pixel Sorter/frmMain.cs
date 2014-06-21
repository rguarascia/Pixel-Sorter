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

        string imagePath;
        PixelSorter sort = new PixelSorter();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImg = new OpenFileDialog();
            if (getImg.ShowDialog() == DialogResult.OK)
                imagePath = getImg.FileName;

            lblRes.Text = "Res: " + sort.Res().ToString();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            PixelSorter sortMe = new PixelSorter();
            if (radSort.Checked)
                picDisplay.Image = sortMe.sorterImg(imagePath, 0);
            else if (radRandom.Checked)
               picDisplay.Image = sortMe.sorterImg(imagePath, 1);
            else
                 picDisplay.Image = sortMe.sorterImg(imagePath, 2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            picDisplay.Image.Save("Edited-Space.png");
        }
    }
}
