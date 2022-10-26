using Microsoft.VisualBasic.Logging;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numHappy.Text = Properties.Settings.Default.number.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number;

            try
            {
                number = int.Parse(this.numHappy.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Гуляй", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Properties.Settings.Default.number = number;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.Compare(number), "Вывод:");
        }
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);
            }
            if (e.KeyValue == (char)Keys.Escape)
            {
                Close();
            }
        }
    }
    public class Logic
    {
        public static string Compare(int number)
        {
            int firstDigit;
            int secondDigit;
            int thirdDigit;
            int fourDigit;
            int fiveDigit;
            int sixDigit;

            if (number > 999999)
            {
                return "ошибка";
            }
            else if (number < 100000)
            {
                return "ошибка";
            }
            else
            {
                firstDigit = number / 100000;
                secondDigit = (number / 10000) % 10;
                thirdDigit = (number / 1000) % 10;
                fourDigit = (number / 100) % 10;
                fiveDigit = (number / 10) % 10;
                sixDigit = number % 10;

                if ((firstDigit + secondDigit + thirdDigit) == (fourDigit + fiveDigit + sixDigit))
                {
                    return "число счастливое";
                }
                else
                {
                    return "число не счастливое";
                }
            }
        }
    }
}