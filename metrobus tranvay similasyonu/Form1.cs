namespace metrobus_tranvay_similasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Value += 1;
            if (progressBar1.Value  != 12 )
            {
                button1.BackColor = Color.Green;

                if (progressBar1.Value   == 7)
                {
                    button1.BackColor = Color.Red;
                }
               else if (progressBar1.Value   ==8)
                {
                    button1.BackColor = Color.Black;
                }
                
                
            }
          
            if (progressBar1.Value != 28)
            {
                button2.BackColor = Color.Green;

                if (progressBar1.Value == 20)
                {
                    button2.BackColor = Color.Red;
                }
                else if (progressBar1.Value == 22)
                {
                    button2.BackColor = Color.Black;
                }
            }

            if(progressBar1.Value != 40 )
            {
                button3.BackColor= Color.Green;

                if (progressBar1.Value == 35)
                {
                    button3.BackColor = Color.Red;
                }
                else if (progressBar1.Value == 37)
                {
                    button3.BackColor = Color.Black;
                }
               
            }
            if (progressBar1.Value != 60)
            {
                button4.BackColor = Color.Green;

                if (progressBar1.Value == 51)
                {
                    button4.BackColor = Color.Red;
                }
                else if (progressBar1.Value == 52)
                {
                    button4.BackColor = Color.Black;
                }
            }
            if (progressBar1.Value !=  70)
            {
                button5.BackColor = Color.Green;

                if (progressBar1.Value == 66)
                {
                    button5.BackColor = Color.Red;
                }
                else if (progressBar1.Value == 68)
                {
                    button5.BackColor = Color.Black;
                }
            }
            if (progressBar1.Value != 88 )
            {
                button6.BackColor = Color.Green;

                if (progressBar1.Value == 82)
                {
                    button6.BackColor = Color.Red;
                }
                else if (progressBar1.Value == 84)
                {
                    button6.BackColor = Color.Black;
                }
            }
            if (progressBar1.Value !=100 )
            {
                button7.BackColor = Color.Green;

                if (progressBar1.Value == 98)
                {
                    button7.BackColor = Color.Red;
                }
               
            }

            else if (progressBar1.Value == 100)
            {
                button7.BackColor = Color.Black;
                timer1.Stop();
            }

            
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 1;
            if (progressBar2.Value != 12)
            {
                button8.BackColor = Color.Green;

                if (progressBar2.Value == 5)
                {
                    button8.BackColor = Color.Red;
                }
                else if (progressBar2.Value == 7)
                {
                    button8.BackColor = Color.Black;
                }

            }

            if (progressBar2.Value != 30)
            {
                button9.BackColor = Color.Green;

                if (progressBar2.Value ==22 )
                {
                    button9.BackColor = Color.Red;
                }
                else if (progressBar2.Value == 24)
                {
                    button9.BackColor = Color.Black;
                }
            }

            if (progressBar2.Value != 45)
            {
                button10.BackColor = Color.Green;

                if (progressBar2.Value ==38 )
                {
                    button10.BackColor = Color.Red;
                }
                else if (progressBar2.Value == 40)
                {
                    button10.BackColor = Color.Black;
                }

            }
            if (progressBar2.Value != 65)
            {
                button11.BackColor = Color.Green;

                if (progressBar2.Value == 54)
                {
                    button11.BackColor = Color.Red;
                }
                else if (progressBar2.Value == 56)
                {
                    button11.BackColor = Color.Black;
                }
            }
            if (progressBar2.Value != 75)
            {
                button12.BackColor = Color.Green;

                if (progressBar2.Value == 70)
                {
                    button12.BackColor = Color.Red;
                }
                else if (progressBar2.Value == 72)
                {
                    button12.BackColor = Color.Black;
                }
            }
            if (progressBar2.Value != 95)
            {
                button13.BackColor = Color.Green;

                if (progressBar2.Value == 85)
                {
                    button13.BackColor = Color.Red;
                }
                else if (progressBar2.Value == 87)
                {
                    button13.BackColor = Color.Black;
                }
            }
            if (progressBar2.Value != 100)
            {
                button14.BackColor = Color.Green;

                if (progressBar1.Value == 98)
                {
                    button14.BackColor = Color.Red;
                }

            }

            else if (progressBar2.Value == 100)
            {
                button14.BackColor = Color.Black;
                timer1.Stop();
            }

        }
    }
}