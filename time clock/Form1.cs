namespace time_clock
{
    public partial class Form1 : Form
    {
        private DateTime[] horariosRegistrados = new DateTime[10];

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;

            

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime atual = DateTime.Now;

            for (int i =0; i < horariosRegistrados.Length; i++)
            {
                if (horariosRegistrados[i] == DateTime.MinValue)
                {
                    horariosRegistrados [i] = atual; break;

                }
            }

            AttListBox();
        }


        private void AttListBox()
        {
            listBox.Items.Clear();

            foreach ( DateTime horario in horariosRegistrados)
            {
                if (horario != DateTime.MinValue)
                {
                    listBox.Items.Add(horario.ToString("dd/MM/yyyy HH:mm:ss"));
                }
            }
        }

    }
}
