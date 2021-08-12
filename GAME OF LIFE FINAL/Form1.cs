using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME_OF_LIFE_FINAL
{
    public partial class Form1 : Form
    {
       
        
           





            Rectangle rect = new Rectangle(0, 0, 100, 100);

        int number = 10;
        Color numColor = Color.Red;


        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, rect);

            Brush numBrush = new SolidBrush(numColor);
            e.Graphics.DrawString(number.ToString(), panel1.Font, numBrush, new PointF(0, 0));
            numBrush.Dispose();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            rect.Location = e.Location;

            panel1.Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rect.Location = new Point(0, 0);

            panel1.Invalidate();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = numColor;

             if(DialogResult.OK == dlg.ShowDialog())
             {
                numColor = dlg.Color;

                panel1.Invalidate();
             }
        }

        private void modalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalDialog dlg = new ModalDialog();

            // dlg.SetNumber(number);
            dlg.Number = number;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                //number = dlg.GetNumber();
                number = dlg.Number;

                panel1.Invalidate();
            }

        }

        

        }

      


          
    }




