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
                MessageBox.Show("�����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Properties.Settings.Default.number = number;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.Compare(number), "�����:");
        }
    }
}