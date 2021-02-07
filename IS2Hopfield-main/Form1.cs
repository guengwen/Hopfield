using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using HopfieldNeuralNetwork;

namespace IS2HopfieldNetwork
{
    public partial class Form1 : Form
    {
        NeuralNetwork NN = new NeuralNetwork(100);
        Bitmap[] m = new Bitmap[10];
        int[,] canvas = new int[10, 10];

        public Form1()
        {
            InitializeComponent();
            label1.Text = (NN.M).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m[0] = new Bitmap(openFileDialog1.FileName);

                List<Neuron> pattern = bitmapToPattern(m[0]);

                imageMagnifier1.ImageToMagnify = m[0];
                imageMagnifier1.MagnificationCoefficient = 6;

                NN.AddPattern(pattern);

                Bitmap bitmap = patternToBitmap(NN.Neurons);
                imageMagnifier3.ImageToMagnify = bitmap;
                imageMagnifier3.MagnificationCoefficient = 10;

                //List<Neuron> randomPattern = generateRandomPattern(100);
                //imageMagnifier2.ImageToMagnify = patternToBitmap(randomPattern);
                //imageMagnifier2.MagnificationCoefficient = 10;

                label1.Text = (NN.M).ToString();
            }
        }

        private List<Neuron> bitmapToPattern(Bitmap b)
        {
            int bitmapSize = b.Width * b.Height;
            List<Neuron> p = new List<Neuron>(bitmapSize);
            Color c;

            for (int j = 0; j < b.Height; j ++)
            {
                for (int i = 0; i < b.Width; i++)
                {
                    Neuron n = new Neuron();

                    c = b.GetPixel(i, j);

                    n.State = c.R > 127 ? 1 : -1;

                    p.Add(n);
                }
            }/*
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    string pat = p[(b.Width * i) + j].State == 1 ? "[ ]" : "[0]";
                    Console.Write(pat + '\t');
                }
                Console.WriteLine();
            }*/

            return p;
        }

        private Bitmap patternToBitmap(List<Neuron> p)
        {
            int size = 10;
            Bitmap bitmap = new Bitmap(size, size);
            Color c;

            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    c = p[(size * j) + i].State > 0 ? Color.Black : Color.White;
                    //string pat = p[(size * i) + j].State == 1 ? "[ ]" : "[0]";
                    //Console.Write(pat + '\t');

                    bitmap.SetPixel(i, j, c);
                }
                //Console.WriteLine();
            }

            return bitmap;
        }

        private List<Neuron> canvasToPattern(int[,] cnvs)
        {
            int canvasSize = cnvs.GetLength(0) * cnvs.GetLength(1);
            List<Neuron> p = new List<Neuron>(canvasSize);

            for (int j = 0; j < cnvs.GetLength(1); j++)
            {
                for (int i = 0; i < cnvs.GetLength(0); i++)
                {
                    Neuron n = new Neuron();

                    n.State = cnvs[i,j] == 0 ? -1 : 1;

                    p.Add(n);
                    //Console.WriteLine(p[p.Count-1].State);
                }
            }

            return p;
        }
        private List<Neuron> generateRandomPattern(int size)
        {
            List<Neuron> pattern = new List<Neuron>();
            Random rand  = new Random();

            for (int i = 0; i < size; i++)
            {
                Neuron n = new Neuron();
                n.State = rand.Next(2) > 0 ? 1 : -1;
                pattern.Add(n);
            }

            return pattern;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Neuron> pattern = canvasToPattern(canvas);
            NN.Run(pattern);
            imageMagnifier3.ImageToMagnify = patternToBitmap(NN.Neurons);
            imageMagnifier3.MagnificationCoefficient = 10;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X / (panel1.Width / 10);
            int y = e.Y / (panel1.Height / 10);
            canvas[x, y] = 1;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int x = i * (panel1.Width / 10);
                    int y = j * (panel1.Height / 10);
                    Rectangle rect = new Rectangle(x, y, panel1.Width/10, panel1.Height/10);
                    if (canvas[i,j] == 1)
                        g.FillRectangle(blackBrush, rect);
                    else
                        g.FillRectangle(whiteBrush, rect);
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                try
                {
                    int x = e.X / (panel1.Width / 10);
                    int y = e.Y / (panel1.Height / 10);
                    canvas[x, y] = 1;
                    panel1.Invalidate();
                } catch(Exception err) {}
            }
        }

        private void imageMagnifier3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imageMagnifier4_Click(object sender, EventArgs e)
        {

        }

        private void imageMagnifier2_Click(object sender, EventArgs e)
        {

        }

        private void imageMagnifier1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
