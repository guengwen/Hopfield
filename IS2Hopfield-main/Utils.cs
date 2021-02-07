using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HopfieldNeuralNetwork;

namespace IS2HopfieldNetwork
{
    class Utils
    {
        static private string[] string_letters = { "A", "B", "C", "D", "E", "F" };
        static public int getNextLetter(int[] selected_letters, int current_panel)
        {
            int curr_letter = (selected_letters[current_panel] + 1) % 6;
            int next_panel1 = (current_panel + 1) % 3;
            int next_panel2 = (current_panel + 2) % 3;

            while (curr_letter == selected_letters[next_panel1] || curr_letter == selected_letters[next_panel2])
            {
                curr_letter = (curr_letter + 1) % 6;
            }

            return curr_letter;
        }

        static private string toLetterSelected(int index)
        {
            return string_letters[index];
        }

        static public string updateLabel(int[] selected_letters)
        {
            return toLetterSelected(selected_letters[0]) 
                + ", " + toLetterSelected(selected_letters[1])
                + ", " + toLetterSelected(selected_letters[2]);
        }
        static public List<Neuron> bitmapToPattern(Bitmap b)
        {
            int bitmapSize = b.Width * b.Height;
            List<Neuron> p = new List<Neuron>(bitmapSize);
            Color c;

            for (int j = 0; j < b.Height; j++)
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

        static public Bitmap patternToBitmap(List<Neuron> p)
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

        static public List<Neuron> canvasToPattern(int[,] cnvs)
        {
            int canvasSize = cnvs.GetLength(0) * cnvs.GetLength(1);
            List<Neuron> p = new List<Neuron>(canvasSize);

            for (int j = 0; j < cnvs.GetLength(1); j++)
            {
                for (int i = 0; i < cnvs.GetLength(0); i++)
                {
                    Neuron n = new Neuron();

                    n.State = cnvs[i, j] == 0 ? -1 : 1;

                    p.Add(n);
                    //Console.WriteLine(p[p.Count-1].State);
                }
            }

            return p;
        }
        static public List<Neuron> generateRandomPattern(int size)
        {
            List<Neuron> pattern = new List<Neuron>();
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                Neuron n = new Neuron();
                n.State = rand.Next(2) > 0 ? 1 : -1;
                pattern.Add(n);
            }

            return pattern;
        }

        static public void paintCanvas(Graphics g, int[,] canvas, int size, int lengthX, int lengthY, SolidBrush brush)
        {
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int multiplierX = lengthX / size;
                    int multiplierY = lengthY / size;
                    int x = i * multiplierX;
                    int y = j * multiplierY;
                    Rectangle rect = new Rectangle(x, y, multiplierX, multiplierY);
                    if (canvas[i, j] == 1)
                        g.FillRectangle(brush, rect);
                    else
                        g.FillRectangle(whiteBrush, rect);
                }
            }
        }

        static public int[] checkWord(Bitmap[] patterns, Bitmap[] letters, int size)
        {
            int[] errors = new int[3];

            for (int z = 0; z < patterns.Length; z++)
            {

                errors[z] = checkLetter(patterns[z], letters, size);
            }

            return errors;
        }

        static private int checkLetter(Bitmap pattern, Bitmap[] letters, int size)
        {
            int error = 1;

            for (int z = 0; z < letters.Length && error != 0; z++)
            {
                error = 0;

                for (int i = 0; i < size && error != 1; i++)
                {
                    for (int j = 0; j < size && error != 1; j++)
                    {
                        error = pattern.GetPixel(i, j).R == letters[z].GetPixel(i, j).R ? 0 : 1;
                    }
                }
            }

            return error;
        }

        static public string getWord(Bitmap[] patterns, Bitmap[] letters, int[] selected_letters, int size)
        {
            string[] word = new string[3];

            for (int z = 0; z < patterns.Length; z++)
            {

                word[z] = getLetter(patterns[z], letters, size);
            }

            return word[0] + word[1] + word[2];
        }

        static private string getLetter(Bitmap pattern, Bitmap[] letters, int size)
        {
            int error = 1;

            for (int z = 0; z < letters.Length; z++)
            {
                error = 0;

                for (int i = 0; i < size && error != 1; i++)
                {
                    for (int j = 0; j < size && error != 1; j++)
                    {
                        error = pattern.GetPixel(i, j).R == letters[z].GetPixel(i, j).R ? 0 : 1;
                    }
                }

                if (error == 0)
                {
                    error = z;
                    break;
                }
            }

            return string_letters[error];
        }
    }
}
