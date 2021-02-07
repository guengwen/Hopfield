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

        public Form1()
        {
            InitializeComponent();
            label1.Text = (NN.M).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m[0] = new Bitmap(openFileDialog1.FileName);

                List<Neuron> pattern = bitmapToPattern(m[0]);

                imageMagnifier1.ImageToMagnify = m[0];
                imageMagnifier1.MagnificationCoefficient = 10;

                NN.AddPattern(pattern);
                for (int i = 0; i < NN.Neurons.Count; i++)
                {
                    Console.WriteLine(NN.Neurons[i].State);
                }

                Bitmap bitmap = patternToBitmap(NN.Neurons);
                //imageMagnifier3.ImageToMagnify = bitmap;
                //imageMagnifier3.MagnificationCoefficient = 10;

                List<Neuron> randomPattern = generateRandomPattern(100);
                imageMagnifier2.ImageToMagnify = patternToBitmap(randomPattern);
                imageMagnifier2.MagnificationCoefficient = 10;

                label1.Text = (NN.M).ToString();
            }
        }

        private List<Neuron> bitmapToPattern(Bitmap b)
        {
            int bitmapSize = b.Width * b.Height;
            List<Neuron> p = new List<Neuron>(bitmapSize);
            Color c;

            for (int i = 0; i < b.Width; i ++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Neuron n = new Neuron();

                    c = b.GetPixel(i, j);

                    n.State = c.R > 127 ? 1 : -1;

                    p.Add(n);
                    //Console.WriteLine(p[p.Count-1].State);
                }
            }

            return p;
        }

        private Bitmap patternToBitmap(List<Neuron> p)
        {
            int size = 10;
            Bitmap bitmap = new Bitmap(size, size);
            Color c;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int val = p[(size * i) + j].State > 0 ? 255 : 0;
                    //Console.WriteLine(val + ": " + p[init.Width * i + j].State);

                    c = Color.FromArgb(val, val, val);

                    bitmap.SetPixel(i, j, c);
                }
            }

            return bitmap;
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
            Bitmap b = new Bitmap(imageMagnifier2.ImageToMagnify);
            List<Neuron> pattern = bitmapToPattern(b);
            NN.Run(pattern);


            imageMagnifier3.ImageToMagnify = patternToBitmap(NN.Neurons);
            imageMagnifier3.MagnificationCoefficient = 10;            
        }

        private void imageMagnifier1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
