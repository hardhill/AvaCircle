using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avacircle
{
    public partial class frmMain : Form
    {
        Imagerist imagerist;
        private int x = 0;
        private int y = 0;
        public frmMain()
        {
            InitializeComponent();
            imagerist = new Imagerist();
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            //load picture
            if (dlgOpenPisture.ShowDialog() == DialogResult.OK)
            {
                string file = dlgOpenPisture.FileName;
                try {
                    imagerist.SetBitmap(new Bitmap(file));
                    toolImageInfo.Text = String.Format("img size width:{0}, height:{1}", imagerist.GetWidth(), imagerist.GetHeight());
                    pictureBox1.Image = imagerist.GetBitmap();

                } catch {
                    MessageBox.Show("Не получилось загрузить картинку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imagerist.GetBitmap();
            toolImageInfo.Text = String.Format("img size width:{0}, height:{1}", imagerist.GetWidth(), imagerist.GetHeight());
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (imagerist.GetBitmap() != null)
            {
                if (dlgSavePicture.ShowDialog() == DialogResult.OK)
                {
                    switch (dlgSavePicture.FilterIndex)
                    {
                        case 1:
                            try
                            {
                                imagerist.SavePNG(dlgSavePicture.FileName);
                            }
                            catch { MessageBox.Show("Невозможно сохранить файл PNG", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            break;
                        case 2:
                            try
                            {
                                imagerist.SaveJPG(dlgSavePicture.FileName);
                            }
                            catch
                            { MessageBox.Show("Невозможно сохранить файл JPG", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            break;

                    }
                }
            }
        }

        private void trbQuality_Scroll(object sender, EventArgs e)
        {
            imagerist.Quality = trbQuality.Value;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //
            {
                Point pos = new Point(Cursor.Position.X - x, Cursor.Position.Y - y);
               pictureBox1.Location = PointToClient(pos);
            }
        }

        private void trbPicsize_Scroll(object sender, EventArgs e)
        {
            imagerist.SetZoom((double)trbPicsize.Value / (double)trbPicsize.Maximum);
            pictureBox1.Image = imagerist.GetBitmap();
        }
    }
}
