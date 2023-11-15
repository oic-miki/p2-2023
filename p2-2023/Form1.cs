using System.Diagnostics;

namespace p2_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<int> list = new List<int>();

            list.Add(100);
            list.Add(200);
            list.Add(300);

            foreach (int i in list)
            {

                label1.Text = i.ToString();

                Debug.Print("i -> {0}", i);

            }

        }
    }
}