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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string CoordMouseToString(MouseEventArgs mea)
        {
            return $"Mouse coordinates:  x = {mea.X} y = {mea.Y}";
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            string message = null;
            Point p = Cursor.Position;
            if (e.Button == MouseButtons.Left)
            {
                if (ModifierKeys.HasFlag(Keys.Control))
                {
                    message = "Exit";
                    this.Close();
                }

                else
                {
                    if (p.Y == 0 || p.Y == 202 || p.X == 392 || p.X == 0)
                    {
                        message = "You are on border of rectangle";
                    }
                    else
                        message = "You are inside rectangle";
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                Text = $"Width: {panel1.Width} Height: {panel1.Height}";
                message = $"Width: {panel1.Width} Height: {panel1.Height}";               
            }

            string caption = "mouse click";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            string message = null;
            if (e.Button == MouseButtons.Left)
            {
                message = "You are outside rectangle";
                string caption = "mouse click";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = CoordMouseToString(e);
        }
    }
}
