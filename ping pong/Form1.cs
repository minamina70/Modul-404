using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping_pong
{
    public partial class Form1 : Form
    {
        private int _directionX = 5;
        private int _directionY = 2;
        private int _punkte = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picball.Location = new Point(picball.Location.X + _directionX, picball.Location.Y + _directionY);
            if (picball.Location.X >= pictureBox1.Width - picball.Width - pictureBox2.Width
                && picball.Location.Y + picball.Height >= pictureBox2.Location.Y
                && picball.Location.Y <= pictureBox2.Location.Y + pictureBox2.Height) ;
        
        
            _directionX = -_directionX;
            _punkte += 10;
            
            if (picball.Location.X <= 0)
            {
                _directionX = -_directionX;
            }
            
            
            if (picball.Location.Y >= pictureBox1.Height - picball.Height)
            {
                _directionY = -_directionY;
            }
            
            
            if (picball.Location.Y < 0)
            {
                _directionY = -_directionY;
            }

        }
            

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
    }
    

       
    }
