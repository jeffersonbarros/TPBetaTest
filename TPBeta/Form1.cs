using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPBeta
{
    public partial class Form1 : Form
    {
        private int tamanhoVertical;

        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            Font font = new Font("Arial", 16);


            pictureBox1.Height = tamanhoVertical + 100;

            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            var g = Graphics.FromImage(bitmap);



            g.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;


            g.DrawString(text, font, Brushes.Black, pictureBox1.DisplayRectangle);
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = bitmap; // display bitmap on your form

            pictureBox1.Refresh();
        }

        private void richTextBox1_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            tamanhoVertical = e.NewRectangle.Height;
        }
    }
}
