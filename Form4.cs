using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_hw_2
{
    public partial class Form4 : Form
    {
        Timer timer1 = new Timer();
        public Form4()
        {
            
            InitializeComponent();
            
            button_stop.Enabled = false;
            timer1.Tick += new EventHandler(ShowTimer);
            timer2.Tick += new EventHandler(countDown);

            
        }



        private void ShowTimer(object sender, EventArgs e)
        {
            timer1.Stop();
            button_stop.Enabled = false;
            MessageBox.Show("Timer stopped", "Timer");
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            countdown.Text = "Оставшееся время: ";
            if (timer_1.Value < 0)
            {
                MessageBox.Show("Error");
            }
            button_stop.Enabled = true;
            timer1.Interval = Decimal.ToInt32(timer_1.Value) * 1000;
            timer1.Start();
            timer2.Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            MessageBox.Show("Timer stopped before end of time", "Timer");
            countdown.Text += timer_1.Value.ToString();
            button_stop.Enabled = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            button_stop.Enabled = false;
            MessageBox.Show("Timer stopped", "Timer");
        }

        private void countDown(object sender, EventArgs e)
        {
            if (timer_1.Value > 0)
            {
               timer_1.Value--.ToString();
            }
        
        }
    }
}
