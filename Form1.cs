using System;
using System.Linq;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] array = { 0.0, 2.5, -3.4, 0.0, 5.1, -6.7, 1.2 };

            int zeroCount = array.Count(x => x == 0);
            MessageBox.Show($"Кількість елементів, рівних 0: {zeroCount}");

            int minIndex = Array.IndexOf(array, array.Min());
            double sumAfterMin = array.Skip(minIndex + 1).Sum();
            MessageBox.Show($"Сума елементів після мінімального: {sumAfterMin}");

            double[] sortedArray = array.OrderBy(x => Math.Abs(x)).ToArray();
            MessageBox.Show("Масив, відсортований за зростанням модулів: " + string.Join(", ", sortedArray));
        }

        private void button2_Click(object sender, EventArgs e)
        {
 
            int[,] array2D = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            array2D[1, 1] = 13;
            DisplayArray(array2D);

            int b = 42; 
            array2D[0, 0] = b; 
            DisplayArray(array2D);
        }

        private void DisplayArray(int[,] array)
        {
            string result = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result += array[i, j] + " ";
                }
                result += Environment.NewLine;
            }
            MessageBox.Show(result);
        }
    }
}
