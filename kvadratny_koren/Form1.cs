
namespace kvadratny_koren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number;

            
            if (double.TryParse(textBox1.Text, out number))
            {
                if (number < 0)
                {
                    label1.Text = "������: ������ ��������� ���������� ������ �� �������������� �����.";
                }
                else
                {
                    double Sqrt = sqrt(number);
                    label1.Text = $"���������� ������ �� {number} ����� {Sqrt}";
                }
            }
            else
            {
                label1.Text = "����������� ����";
            }
        }
        private double sqrt(double number)
        {
            double guess = number / 2.0;
            double tolerance = 0.00001;
            int maxIterations = 1000;
            int iteration = 0;

            while (true)
            {
                double nextGuess = (guess + number / guess) / 2;

                if (Math.Abs(nextGuess - guess) < tolerance || iteration > maxIterations)
                {
                    return nextGuess;
                }

                guess = nextGuess;
                iteration++;
            }
        }
    }
}


