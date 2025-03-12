using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mischke_PIAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog sciezka = new OpenFileDialog();

            if (sciezka.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(sciezka.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private Bitmap doszarego(Bitmap original)
        {
            Bitmap szaryBit = new Bitmap(original.Width, original.Height);
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    double wynik = 0.299 * pixel.R + 0.587 * pixel.G + 0.144 * pixel.B;
                    szaryBit.SetPixel(x, y, Color.FromArgb((int)wynik, (int)wynik, (int)wynik));
                }
            }
            return szaryBit;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap aktualneZdjecie = new Bitmap(pictureBox1.Image);
                Bitmap szarePhoto = doszarego(aktualneZdjecie);
                pictureBox1.Image = szarePhoto;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Wczytaj plik
            pictureBox1.Image = new Bitmap(pictureBox1.Image);
            pictureBox1.Height = pictureBox1.Image.Height;
            pictureBox1.Width = pictureBox1.Image.Width;

            //Oblicz histogram
            int[] red = new int[256];
            int[] green = new int[256];
            int[] blue = new int[256];

            int minR = red[100];
            int maxR = red[100];
            double sredniaR = 0;

            int minG = red[100];
            int maxG = red[100];
            double sredniaG = 0;

            int minB = red[100];
            int maxB = red[100];
            double sredniaB = 0;
            int ilosc = 0;
            for (int x = 0; x < pictureBox1.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    Color pixel = ((Bitmap)pictureBox1.Image).GetPixel(x, y);
                    red[pixel.R]++;
                    green[pixel.G]++;
                    blue[pixel.B]++;
                    
                    sredniaR = sredniaR + red[pixel.R];

                    if (minG > green[pixel.G])
                    {
                        minG = green[pixel.G];
                    }
                    if (maxG < green[pixel.G])
                    {
                        maxG = green[pixel.G];
                    }
                    sredniaG = sredniaG + green[pixel.G];

                    if (minB > blue[pixel.B])
                    {
                        minB = blue[pixel.B];
                    }
                    if (maxB < blue[pixel.B])
                    {
                        maxB = blue[pixel.B];
                    }
                    sredniaB = sredniaB + blue[pixel.B];
                    ilosc++;
                }
            }
            for (int i = 0; i < 256; i++)
            {
                if (red[i] != 0)
                {
                    minR = i;
                    break;
                }
            }
            for (int i = 255; i >= 0; i--)
            {
                if (red[i] != 0)
                {
                    maxR = i;
                    break;
                }
            }
            for (int i = 0; i < 256; i++)
            {
                if (blue[i] != 0)
                {
                    minB = i;
                    break;
                }
            }
            for (int i = 255; i >= 0; i--)
            {
                if (blue[i] != 0)
                {
                    maxB = i;
                    break;
                }
            }
            for (int i = 0; i < 256; i++)
            {
                if (green[i] != 0)
                {
                    minG = i;
                    break;
                }
            }
            for (int i = 255; i >= 0; i--)
            {
                if (green[i] != 0)
                {
                    maxG = i;
                    break;
                }
            }


            //Wyswietl histogram na wykresie
            chart.Series["red"].Points.Clear();
            chart.Series["green"].Points.Clear();
            chart.Series["blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
               
                chart.Series["red"].Points.AddXY(i, red[i]);
                chart.Series["green"].Points.AddXY(i, green[i]);
                chart.Series["blue"].Points.AddXY(i, blue[i]);
            }
            chart.Invalidate();
            sredniaB = sredniaB / ilosc;
            sredniaR = sredniaR / ilosc;
            sredniaG = sredniaG / ilosc;
            label1.Text = "Najmniejsza wartość red" + minR.ToString() + " Najwieksza " + maxR.ToString() + " Średnia " + sredniaR.ToString()+ "\n Najmniejsza wartość green" + minG.ToString() + " Najwieksza " + maxG.ToString() + " Średnia " + sredniaG.ToString() + "\n Najmniejsza wartość blue" + minB.ToString() + " Najwieksza " + maxB.ToString() + " Średnia " + sredniaB.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Image);
            pictureBox1.Height = pictureBox1.Image.Height;
            pictureBox1.Width = pictureBox1.Image.Width;

            //Oblicz histogram
            int[] szaro = new int[256];

            int min = 0;
            int max = 0;
            double srednia = 0;
            int ilosc = 0;
            for (int x = 0; x < pictureBox1.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    Color pixel = ((Bitmap)pictureBox1.Image).GetPixel(x, y);
                    szaro[pixel.G]++;
                    srednia = srednia + szaro[pixel.G];
                    ilosc++;
                }
            }

            //Wyswietl histogram na wykresie
            chart1.Series["szaro"].Points.Clear();
            
            for (int i = 0; i < 256; i++)
            {
                   
                chart1.Series["szaro"].Points.AddXY(i, szaro[i]);
                
            }
            srednia = srednia / ilosc;
            for (int i = 0; i < 256; i++)
            {
                if(szaro[i] != 0)
                {
                    min = i;
                    break;
                }
            }
            for (int i = 255; i >= 0; i--)
            {
                if (szaro[i] != 0)
                {
                    max = i;
                    break;
                }
            }

            label2.Text = "Najmniejsza wartość " + min.ToString() + " Największa " + max.ToString() + "\n Średnia " + srednia.ToString();
            chart1.Invalidate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Bitmap szaryBit = new Bitmap(pictureBox1.Image);

            for (int x = 0; x < szaryBit.Width; x++)
            {
                for (int y = 0; y < szaryBit.Height; y++)
                {
                    //Color pixel = ((Bitmap)pictureBox1.Image).GetPixel(x, y);
                    //int[] szaro = new int[256];
                    ////szaro[pixel.G]++;
                    //int l = 0;  
                    //((Bitmap)pictureBox1.Image).SetPixel(x, y, Color.Black);
                    Color pixel = szaryBit.GetPixel(x, y);

                    //double testTego = (int)pixel.G;
                    double wynik = 0.299 * pixel.R + 0.587 * pixel.G + 0.144 * pixel.B;
                    //double przemiana = ((pixel.G * pixel.G) /(255*255))*255;
                    double przemiana = ((wynik * wynik) /(255*255))*255-10;
                    //double przemiana1 = ((pixel.R * pixel.R) / (255 * 255)) * 255;
                    //double przemiana2 = ((pixel.G * pixel.G) / (255 * 255)) * 255;
                    //double przemiana3 = ((pixel.B * pixel.B) / (255 * 255)) * 255;
                    if(przemiana > 255)
                    {
                        przemiana = 255;
                    }else if(przemiana < 0)
                    {
                        przemiana = 0;
                    }
                    
                    szaryBit.SetPixel(x, y, Color.FromArgb((int)przemiana, (int)przemiana, (int)przemiana));

                }
            }
            pictureBox1.Image = szaryBit;
            /*
              Bitmap szaryBit = new Bitmap(original.Width, original.Height);
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    double wynik = 0.299 * pixel.R + 0.587 * pixel.G + 0.144 * pixel.B;
                    szaryBit.SetPixel(x, y, Color.FromArgb((int)wynik, (int)wynik, (int)wynik));
                }
            }
            return szaryBit;
              */
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap szaryBit = new Bitmap(pictureBox1.Image);

            for (int x = 0; x < szaryBit.Width; x++)
            {
                for (int y = 0; y < szaryBit.Height; y++)
                {
                    Color pixel = szaryBit.GetPixel(x, y);

                    double wynik = 0.299 * pixel.R + 0.587 * pixel.G + 0.144 * pixel.B;

                    double przemiana = (Math.Sqrt(wynik)/15.96)*255+1;

                    if (przemiana > 255)
                    {
                        przemiana = 255;
                    }
                    else if (przemiana < 0)
                    {
                        przemiana = 0;
                    }

                    szaryBit.SetPixel(x, y, Color.FromArgb((int)przemiana, (int)przemiana, (int)przemiana));
                }
            }
            pictureBox1.Image = szaryBit;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap szaryBit = new Bitmap(pictureBox1.Image);

            for (int x = 0; x < szaryBit.Width; x++)
            {
                for (int y = 0; y < szaryBit.Height; y++)
                {
                    Color pixel = szaryBit.GetPixel(x, y);

                    double wynik = 0.299 * pixel.R + 0.587 * pixel.G + 0.144 * pixel.B;

                    //double przemiana = (Math.Log(wynik+1));
                    double przemiana = 127 + (wynik - 127) * 255/(255 - 2 * Math.Log(wynik + 1));

                    if (przemiana > 255)
                    {
                        przemiana = 255;
                    }
                    else if (przemiana < 0)
                    {
                        przemiana = 0;
                    }

                    szaryBit.SetPixel(x, y, Color.FromArgb((int)przemiana, (int)przemiana, (int)przemiana));
                }
            }
            pictureBox1.Image = szaryBit;
        }
    }
}
