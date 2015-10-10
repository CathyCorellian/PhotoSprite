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
        {   get
            {
                return currentColor;
            }
            set
            {
                if (!isLocked)
                {
                    isLocked = true;

                    currentColor = value;
                    redNumericUpDown.Value = redTrackBar.Value = currentColor.R;
                    greenNumericUpDown.Value = greenTrackBar.Value = currentColor.G;
                    blueNumericUpDown.Value = blueTrackBar.Value = currentColor.B;

                    hexTextBox.Text = String.Format("{0:X2}{1:X2}{2:X2}{3:X2}", currentColor.A, currentColor.R, currentColor.G, currentColor.B);

                    currentColorPictureBox.BackColor = currentColor;

                    isLocked = false;
                }
            }
        }

        public ColorPickerForm(Color color)
        {
            InitializeComponent();

            backupColorPictureBox.BackColor = CurrentColor = color;

            var colorPictureBoxes = new PictureBox[] { redPictureBox, greenPictureBox, bluePictureBox };
            var colors = new Color[] { Color.Red, Color.Green, Color.Blue };
            var bmps = new Bitmap[3];

            for(var i = 0; i < 3; i++)
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
        }


        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            Debug.WriteLine("redTrackBar_Scroll");
            CurrentColor = Color.FromArgb(CurrentColor.A, redTrackBar.Value, CurrentColor.G, CurrentColor.B);
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            Debug.WriteLine("greenTrackBar_Scroll");
            CurrentColor = Color.FromArgb(CurrentColor.A, CurrentColor.R, greenTrackBar.Value, CurrentColor.B);
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            Debug.WriteLine("blueTrackBar_Scroll");
            CurrentColor = Color.FromArgb(CurrentColor.A, CurrentColor.R, CurrentColor.G, blueTrackBar.Value);
        }

        private void redNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("redNumericUpDown_ValueChanged");
            CurrentColor = Color.FromArgb(CurrentColor.A, (int)redNumericUpDown.Value, CurrentColor.G, CurrentColor.B);
        }

        private void greenNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("greenNumericUpDown_ValueChanged");
            CurrentColor = Color.FromArgb(CurrentColor.A, CurrentColor.R, (int)greenNumericUpDown.Value, CurrentColor.B);
        }

        private void blueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("blueNumericUpDown_ValueChanged");
            CurrentColor = Color.FromArgb(CurrentColor.A, CurrentColor.R, CurrentColor.G, (int)blueNumericUpDown.Value);
        }

        private void hexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.WriteLine("hexTextBox_KeyPress " + e.KeyChar);
            if (e.KeyChar != '\b')
                e.Handled = !System.Uri.IsHexDigit(e.KeyChar);
        }

        private void hexTextBox_TextChanged(object sender, EventArgs e)
        {
           Debug.WriteLine("hexTextBox_TextChanged");
           if(hexTextBox.TextLength == 8)
           {
               CurrentColor = Color.FromArgb(
               Convert.ToInt32(hexTextBox.Text.Substring(0, 2), 16),
               Convert.ToInt32(hexTextBox.Text.Substring(2, 2), 16),
               Convert.ToInt32(hexTextBox.Text.Substring(4, 2), 16),
               Convert.ToInt32(hexTextBox.Text.Substring(6, 2), 16)
               );
               hexTextBox.Font = new Font(hexTextBox.Font, hexTextBox.Font.Style & (~FontStyle.Strikeout));
           }
           else
           {
               hexTextBox.Font = new Font(hexTextBox.Font, hexTextBox.Font.Style | FontStyle.Strikeout);
           }
        }

        private void backupColorPictureBox_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("backupColorPictureBox_Click");
            CurrentColor = backupColorPictureBox.BackColor;
        }

    }
}
