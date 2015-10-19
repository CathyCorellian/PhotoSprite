using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PhotoSprite
{
    public partial class ColorPickerForm : Form
    {
        private bool isLocked = false;
        private Color currentColor;

        public Color CurrentColor
        {
            get
            {
                return currentColor;
            }
            set
            {
                currentColorPictureBox.BackColor = currentColor = value;

                alphaNumericUpDown.Value = alphaTrackBar.Value = currentColor.A;
                redNumericUpDown.Value = redTrackBar.Value = currentColor.R;
                greenNumericUpDown.Value = greenTrackBar.Value = currentColor.G;
                blueNumericUpDown.Value = blueTrackBar.Value = currentColor.B;

                
                rgbTextBox.Text = ((uint)currentColor.ToArgb()).ToString("X8");
            }
        }

        public ColorPickerForm(Color color)
        {
            InitializeComponent();

            CurrentColor = backupColorPictureBox.BackColor = color;

            var colorPictureBoxes = new PictureBox[] {alphaPictureBox, redPictureBox, greenPictureBox, bluePictureBox };
            var colors = new Color[] {Color.Transparent, Color.Red, Color.Green, Color.Blue };
            var bmps = new Bitmap[4];

            for (var i = 0; i < 4; i++)
            {
                bmps[i] = new Bitmap(colorPictureBoxes[i].Width, colorPictureBoxes[i].Height);
                using (var g = Graphics.FromImage(bmps[i]))
                {
                    using (var brush = new LinearGradientBrush(Point.Empty, new Point(0, colorPictureBoxes[i].Height), colors[i], Color.Black))
                    {
                        g.FillRectangle(brush, new Rectangle(Point.Empty, colorPictureBoxes[i].Size));
                    }
                }
                colorPictureBoxes[i].Image = bmps[i];
            }


            var bmp = new Bitmap(redTrackBar.Width, redTrackBar.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(Brushes.Red, 0, 0, bmp.Width, bmp.Height);
            }

         
            
        }



        private void alphaTrackBar_Scroll(object sender, EventArgs e)
        {
            if (!isLocked)
            {
                isLocked = true;

                CurrentColor = Color.FromArgb(alphaTrackBar.Value, CurrentColor.R, CurrentColor.G, CurrentColor.B);

                isLocked = false;
            }
        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            if (!isLocked)
            {
                isLocked = true;

                CurrentColor = Color.FromArgb(CurrentColor.A, redTrackBar.Value, CurrentColor.G, CurrentColor.B);

                isLocked = false;
            }
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            if (!isLocked)
            {
                isLocked = true;

                CurrentColor = Color.FromArgb(CurrentColor.A, CurrentColor.R, greenTrackBar.Value, CurrentColor.B);

                isLocked = false;
            }
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            if (!isLocked)
            {
                isLocked = true;

                CurrentColor = Color.FromArgb(CurrentColor.A, CurrentColor.R, CurrentColor.G, blueTrackBar.Value);

                isLocked = false;
            }
        }

        private void alphaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!isLocked)
            {
                isLocked = true;

                CurrentColor = Color.FromArgb((int)alphaNumericUpDown.Value, CurrentColor.R, CurrentColor.G, CurrentColor.B);

                isLocked = false;
            }
        }

        private void redNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!isLocked)
            {
                isLocked = true;

                CurrentColor = Color.FromArgb(CurrentColor.A, (int)redNumericUpDown.Value, CurrentColor.G, CurrentColor.B);

                isLocked = false;
            }
        }

        private void greenNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!isLocked)
            {
                isLocked = true;

                CurrentColor = Color.FromArgb(CurrentColor.A, CurrentColor.R, (int)greenNumericUpDown.Value, CurrentColor.B);

                isLocked = false;
            }
        }

        private void blueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!isLocked)
            {
                isLocked = true;

                CurrentColor = Color.FromArgb(CurrentColor.A, CurrentColor.R, CurrentColor.G, (int)blueNumericUpDown.Value);

                isLocked = false;
            }
        }

        private void backupColorPictureBox_Click(object sender, EventArgs e)
        {
            if (!isLocked)
            {
                isLocked = true;

                CurrentColor = backupColorPictureBox.BackColor;

                isLocked = false;
            }
        }

        private void hexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
                e.Handled = !System.Uri.IsHexDigit(e.KeyChar);
        }

        private void rgbTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rgbTextBox.TextLength == 8)
            {
                if (!isLocked)
                {
                    isLocked = true;

                    CurrentColor = Color.FromArgb(Convert.ToInt32(rgbTextBox.Text, 16));

                    isLocked = false;
                }

                if(rgbTextBox.Font.Style != FontStyle.Regular)
                    rgbTextBox.Font = new Font(rgbTextBox.Font, FontStyle.Regular);
            }
            else
            {
                if (rgbTextBox.Font.Style != FontStyle.Strikeout)
                    rgbTextBox.Font = new Font(rgbTextBox.Font, FontStyle.Strikeout);
            }
        }




    }
}
