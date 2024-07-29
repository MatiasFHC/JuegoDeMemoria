using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form3Inicio : Form
    {
        private int cont = 0;
        private int cont2 = 0;
        private int cont3 = 0;

        private Image imag1;
        private int contImag = 0;

        public Form3Inicio()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources._7;
            pictureBox2.Image = Properties.Resources._7;
            pictureBox3.Image = Properties.Resources._7;
            pictureBox4.Image = Properties.Resources._7;
            pictureBox5.Image = Properties.Resources._7;
            pictureBox6.Image = Properties.Resources._7;
            pictureBox7.Image = Properties.Resources._7;
            pictureBox8.Image = Properties.Resources._7;
            pictureBox9.Image = Properties.Resources._7;
            pictureBox10.Image = Properties.Resources._7;
            pictureBox11.Image = Properties.Resources._7;
            pictureBox12.Image = Properties.Resources._7;
        }

        private async void pictureBox10_Click_1(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources._3_1;
            if (cont == 12)
            {
                cont2++;

                if (cont2 == 2)
                {
                    cont2 = 0;
                    if (ComparacionImagenes(imag1, pictureBox10.Image))
                    {
                        cont3++;
                    }
                    else
                    {
                        await Task.Delay(2000);

                        PictureBox pb = ObtenerPictureBoxPorNombre(contImag);
                        pb.Image = Properties.Resources._7;
                        pictureBox10.Image = Properties.Resources._7;
                    }
                }
                else
                {
                    imag1 = pictureBox10.Image;
                    contImag = 10;
                }
            }
            else
            {
                cont++;
            }
            FinNivel();
        }

        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources._3_2;
            if (cont == 12)
            {
                cont2++;

                if (cont2 == 2)
                {
                    cont2 = 0;
                    if (ComparacionImagenes(imag1, pictureBox2.Image))
                    {
                        cont3++;
                    }
                    else
                    {
                        await Task.Delay(2000);

                        PictureBox pb = ObtenerPictureBoxPorNombre(contImag);
                        pb.Image = Properties.Resources._7;
                        pictureBox2.Image = Properties.Resources._7;
                    }
                }
                else
                {
                    imag1 = pictureBox2.Image;
                    contImag = 2;
                }
            }
            else
            {
                cont++;
            }
            FinNivel();
        }

        private async void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._3_3;
            if (cont == 12)
            {
                cont2++;

                if (cont2 == 2)
                {
                    cont2 = 0;
                    if (ComparacionImagenes(imag1, pictureBox6.Image))
                    {
                        cont3++;
                    }
                    else
                    {
                        await Task.Delay(2000);

                        PictureBox pb = ObtenerPictureBoxPorNombre(contImag);
                        pb.Image = Properties.Resources._7;
                        pictureBox6.Image = Properties.Resources._7;
                    }
                }
                else
                {
                    imag1 = pictureBox6.Image;
                    contImag = 6;
                }
            }
            else
            {
                cont++;
            }
            FinNivel();
        }

        private async void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources._3_4;
            if (cont == 12)
            {
                cont2++;

                if (cont2 == 2)
                {
                    cont2 = 0;
                    if (ComparacionImagenes(imag1, pictureBox4.Image))
                    {
                        cont3++;
                    }
                    else
                    {
                        await Task.Delay(2000);

                        PictureBox pb = ObtenerPictureBoxPorNombre(contImag);
                        pb.Image = Properties.Resources._7;
                        pictureBox4.Image = Properties.Resources._7;
                    }
                }
                else
                {
                    imag1 = pictureBox4.Image;
                    contImag = 4;
                }
            }
            else
            {
                cont++;
            }
            FinNivel();
        }

        private async void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources._3_6;
            if (cont == 12)
            {
                cont2++;

                if (cont2 == 2)
                {
                    cont2 = 0;
                    if (ComparacionImagenes(imag1, pictureBox12.Image))
                    {
                        cont3++;
                    }
                    else
                    {
                        await Task.Delay(2000);

                        PictureBox pb = ObtenerPictureBoxPorNombre(contImag);
                        pb.Image = Properties.Resources._7;
                        pictureBox12.Image = Properties.Resources._7;
                    }
                }
                else
                {
                    imag1 = pictureBox12.Image;
                    contImag = 12;
                }
            }
            else
            {
                cont++;
            }
            FinNivel();
        }

        private async void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources._3_5;
            if (cont == 12)
            {
                cont2++;

                if (cont2 == 2)
                {
                    cont2 = 0;
                    if (ComparacionImagenes(imag1, pictureBox5.Image))
                    {
                        cont3++;
                    }
                    else
                    {
                        await Task.Delay(2000);

                        PictureBox pb = ObtenerPictureBoxPorNombre(contImag);
                        pb.Image = Properties.Resources._7;
                        pictureBox5.Image = Properties.Resources._7;
                    }
                }
                else
                {
                    imag1 = pictureBox5.Image;
                    contImag = 5;
                }
            }
            else
            {
                cont++;
            }
            FinNivel();
        }

        private async void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources._3_2;
            if (cont == 12)
            {
                cont2++;

                if (cont2 == 2)
                {
                    cont2 = 0;
                    if (ComparacionImagenes(imag1, pictureBox11.Image))
                    {
                        cont3++;
                    }
                    else
                    {
                        await Task.Delay(2000);

                        PictureBox pb = ObtenerPictureBoxPorNombre(contImag);
                        pb.Image = Properties.Resources._7;
                        pictureBox11.Image = Properties.Resources._7;
                    }
                }
                else
                {
                    imag1 = pictureBox11.Image;
                    contImag = 11;
                }
            }
            else
            {
                cont++;
            }
            FinNivel();
        }

        private async void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources._3_3;
            if (cont == 12)
            {
                cont2++;

                if (cont2 == 2)
                {
                    cont2 = 0;
                    if (ComparacionImagenes(imag1, pictureBox7.Image))
                    {
                        cont3++;
                    }
                    else
                    {
                        await Task.Delay(2000);

                        PictureBox pb = ObtenerPictureBoxPorNombre(contImag);
                        pb.Image = Properties.Resources._7;
                        pictureBox7.Image = Properties.Resources._7;
                    }
                }
                else
                {
                    imag1 = pictureBox7.Image;
                    contImag = 7;
                }
            }
            else
            {
                cont++;
            }
            FinNivel();
        }

        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources._3_6;
            if (cont == 12)
            {
                cont2++;

                if (cont2 == 2)
                {
                    cont2 = 0;
                    if (ComparacionImagenes(imag1, pictureBox3.Image))
                    {
                        cont3++;
                    }
                    else
                    {
                        await Task.Delay(2000);

                        PictureBox pb = ObtenerPictureBoxPorNombre(contImag);
                        pb.Image = Properties.Resources._7;
                        pictureBox3.Image = Properties.Resources._7;
                    }
                }
                else
                {
                    imag1 = pictureBox3.Image;
                    contImag = 3;
                }
            }
            else
            {
                cont++;
            }
            FinNivel();
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._3_1;
            if (cont == 12)
            {
                cont2++;

                if (cont2 == 2)
                {
                    cont2 = 0;
                    if (ComparacionImagenes(imag1, pictureBox1.Image))
                    {
                        cont3++;
                    }
                    else
                    {
                        await Task.Delay(2000);

                        PictureBox pb = ObtenerPictureBoxPorNombre(contImag);
                        pb.Image = Properties.Resources._7;
                        pictureBox1.Image = Properties.Resources._7;
                    }
                }
                else
                {
                    imag1 = pictureBox1.Image;
                    contImag = 1;
                }
            }
            else
            {
                cont++;
            }
            FinNivel();
        }

        private async void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources._3_5;
            if (cont == 12)
            {
                cont2++;

                if (cont2 == 2)
                {
                    cont2 = 0;
                    if (ComparacionImagenes(imag1, pictureBox8.Image))
                    {
                        cont3++;
                    }
                    else
                    {
                        await Task.Delay(2000);

                        PictureBox pb = ObtenerPictureBoxPorNombre(contImag);
                        pb.Image = Properties.Resources._7;
                        pictureBox8.Image = Properties.Resources._7;
                    }
                }
                else
                {
                    imag1 = pictureBox8.Image;
                    contImag = 8;
                }
            }
            else
            {
                cont++;
            }
            FinNivel();
        }

        private async void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources._3_4;
            if (cont == 12)
            {
                cont2++;

                if (cont2 == 2)
                {
                    cont2 = 0;
                    if (ComparacionImagenes(imag1, pictureBox9.Image))
                    {
                        cont3++;
                    }
                    else
                    {
                        await Task.Delay(2000);

                        PictureBox pb = ObtenerPictureBoxPorNombre(contImag);
                        pb.Image = Properties.Resources._7;
                        pictureBox9.Image = Properties.Resources._7;
                    }
                }
                else
                {
                    imag1 = pictureBox9.Image;
                    contImag = 9;
                }
            }
            else
            {
                cont++;
            }
            FinNivel();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Delay(10000);

            if (cont == 12)
            {
                pictureBox1.Image = Properties.Resources._7;
                pictureBox2.Image = Properties.Resources._7;
                pictureBox3.Image = Properties.Resources._7;
                pictureBox4.Image = Properties.Resources._7;
                pictureBox5.Image = Properties.Resources._7;
                pictureBox6.Image = Properties.Resources._7;
                pictureBox7.Image = Properties.Resources._7;
                pictureBox8.Image = Properties.Resources._7;
                pictureBox9.Image = Properties.Resources._7;
                pictureBox10.Image = Properties.Resources._7;
                pictureBox11.Image = Properties.Resources._7;
                pictureBox12.Image = Properties.Resources._7;
            }
        }

        private PictureBox ObtenerPictureBoxPorNombre(int nombre)
        {
            switch (nombre)
            {
                case 1:
                    return pictureBox1;
                case 2:
                    return pictureBox2;
                case 3:
                    return pictureBox3;
                case 4:
                    return pictureBox4;
                case 5:
                    return pictureBox5;
                case 6:
                    return pictureBox6;
                case 7:
                    return pictureBox7;
                case 8:
                    return pictureBox8;
                case 9:
                    return pictureBox9;
                case 10:
                    return pictureBox10;
                case 11:
                    return pictureBox11;
                case 12:
                    return pictureBox12;
                default:
                    return null;
            }
        }

        private bool ComparacionImagenes(Image img1, Image img2)
        {
            if (img1 == null || img2 == null)
                return img1 == img2; // Both are null or one is null

            if (img1.Width != img2.Width || img1.Height != img2.Height)
                return false; // Different dimensions

            // Compare pixel by pixel
            using (Bitmap bmp1 = new Bitmap(img1))
            using (Bitmap bmp2 = new Bitmap(img2))
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    for (int y = 0; y < bmp1.Height; y++)
                    {
                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                            return false;
                    }
                }
            }
            return true;
        }

        private async void FinNivel()
        {
            if (cont3 == 6)
            {
                await Task.Delay(3000);
                FormFin3 form = new FormFin3();
                this.Close();
                form.Show();
            }
        }   
    }
}
