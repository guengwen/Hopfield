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
        Bitmap[] letters = new Bitmap[6] { Letters.A, Letters.B, Letters.C, Letters.D, Letters.E, Letters.F };
        int[,] canvas1 = new int[10, 10];
        int[,] canvas2 = new int[10, 10];
        int[,] canvas3 = new int[10, 10];
        int[] selected_letters = new int[3] { 0, 1, 2 };
        int[] errors = new int[3];
        int magnifier = 6;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "A, B, C";

            imageMagnifier1.ImageToMagnify = letters[selected_letters[0]];
            imageMagnifier1.MagnificationCoefficient = magnifier;
            imageMagnifier2.ImageToMagnify = letters[selected_letters[1]];
            imageMagnifier2.MagnificationCoefficient = magnifier;
            imageMagnifier4.ImageToMagnify = letters[selected_letters[2]];
            imageMagnifier4.MagnificationCoefficient = magnifier;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap[] patternResults = new Bitmap[3];
            Bitmap[] selectedLetters = new Bitmap[3];
            selectedLetters[0] = letters[selected_letters[0]];
            selectedLetters[1] = letters[selected_letters[1]];
            selectedLetters[2] = letters[selected_letters[2]];
            List<Neuron> letterPattern1 = Utils.bitmapToPattern(letters[selected_letters[0]]);
            List<Neuron> letterPattern2 = Utils.bitmapToPattern(letters[selected_letters[1]]);
            List<Neuron> letterPattern3 = Utils.bitmapToPattern(letters[selected_letters[2]]);
            List<Neuron> drawnPattern1 = Utils.canvasToPattern(canvas1);
            List<Neuron> drawnPattern2 = Utils.canvasToPattern(canvas2);
            List<Neuron> drawnPattern3 = Utils.canvasToPattern(canvas3);
            NN.AddPattern(letterPattern1);
            NN.AddPattern(letterPattern2);
            NN.AddPattern(letterPattern3);

            NN.Run(drawnPattern1);
            patternResults[0] = Utils.patternToBitmap(NN.Neurons);
            imageMagnifier3.ImageToMagnify = patternResults[0];
            imageMagnifier3.MagnificationCoefficient = 10;

            NN.Run(drawnPattern2);
            patternResults[1] = Utils.patternToBitmap(NN.Neurons);
            imageMagnifier5.ImageToMagnify = patternResults[1];
            imageMagnifier5.MagnificationCoefficient = 10;

            NN.Run(drawnPattern3);
            patternResults[2] = Utils.patternToBitmap(NN.Neurons);
            imageMagnifier6.ImageToMagnify = patternResults[2];
            imageMagnifier6.MagnificationCoefficient = 10;

            NN = new NeuralNetwork(100);

            errors = Utils.checkWord(patternResults, selectedLetters, 10);

            int count = errors[0] + errors[1] + errors[2];
            string result;

            if (count == 0)
            {
                result = "Your word is " + Utils.getWord(patternResults, letters, selected_letters, 10);
            }
            else
            {
                result = "Sorry, " + count + " of your letters can't be read. Try rewriting them.";
            }

            panel1.Invalidate();
            panel2.Invalidate();
            panel3.Invalidate();

            MessageBox.Show(result);
        }

        private void imageMagnifier4_Click(object sender, EventArgs e)
        {
            int next_letter = Utils.getNextLetter(selected_letters, 2);

            selected_letters[2] = next_letter;
            imageMagnifier4.ImageToMagnify = letters[next_letter];
            imageMagnifier4.MagnificationCoefficient = magnifier;
            label1.Text = Utils.updateLabel(selected_letters);
        }

        private void imageMagnifier2_Click(object sender, EventArgs e)
        {
            int next_letter = Utils.getNextLetter(selected_letters, 1);

            selected_letters[1] = next_letter;
            imageMagnifier2.ImageToMagnify = letters[next_letter];
            imageMagnifier2.MagnificationCoefficient = magnifier;
            label1.Text = Utils.updateLabel(selected_letters);
        }

        private void imageMagnifier1_Click(object sender, EventArgs e)
        {
            int next_letter = Utils.getNextLetter(selected_letters, 0);

            selected_letters[0] = next_letter;
            imageMagnifier1.ImageToMagnify = letters[next_letter];
            imageMagnifier1.MagnificationCoefficient = magnifier;
            label1.Text = Utils.updateLabel(selected_letters);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X / (panel1.Width / 10);
            int y = e.Y / (panel1.Height / 10);
            canvas1[x, y] = 1;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(errors[0] == 0 ? Color.Black : Color.Red);

            Utils.paintCanvas(g, canvas1, 10, panel1.Width, panel1.Height, brush);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                try
                {
                    int x = e.X / (panel1.Width / 10);
                    int y = e.Y / (panel1.Height / 10);
                    canvas1[x, y] = 1;
                    panel1.Invalidate();
                }
                catch (Exception err) { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errors[0] = 0;
            canvas1 = new int[10, 10];
            panel1.Invalidate();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X / (panel2.Width / 10);
            int y = e.Y / (panel2.Height / 10);
            canvas2[x, y] = 1;
            panel2.Invalidate();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                try
                {
                    int x = e.X / (panel2.Width / 10);
                    int y = e.Y / (panel2.Height / 10);
                    canvas2[x, y] = 1;
                    panel2.Invalidate();
                }
                catch (Exception err) { }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            errors[1] = 0;
            canvas2 = new int[10, 10];
            panel2.Invalidate();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(errors[1] == 0 ? Color.Black : Color.Red);

            Utils.paintCanvas(g, canvas2, 10, panel2.Width, panel2.Height, brush);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(errors[2] == 0 ? Color.Black : Color.Red);

            Utils.paintCanvas(g, canvas3, 10, panel3.Width, panel3.Height, brush);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            errors[2] = 0;
            canvas3 = new int[10, 10];
            panel3.Invalidate();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X / (panel3.Width / 10);
            int y = e.Y / (panel3.Height / 10);
            canvas3[x, y] = 1;
            panel3.Invalidate();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                try
                {
                    int x = e.X / (panel3.Width / 10);
                    int y = e.Y / (panel3.Height / 10);
                    canvas3[x, y] = 1;
                    panel3.Invalidate();
                }
                catch (Exception err) { }
            }
        }
    }
}
