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
    }
}