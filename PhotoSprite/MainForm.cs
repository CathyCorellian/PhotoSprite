using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoSprite
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void foregroundBrushColorToolStripButton_Click(object sender, EventArgs e)
        {
            var colorPickerForm = new ColorPickerForm(foregroundBrushColorToolStripButton.BackColor);
            if(colorPickerForm.ShowDialog() == DialogResult.OK)
            {
                foregroundBrushColorToolStripButton.BackColor = colorPickerForm.CurrentColor;
            }

        }

        private void backgroundBrushColorToolStripButton_Click(object sender, EventArgs e)
        {
            var colorPickerForm = new ColorPickerForm(backgroundBrushColorToolStripButton.BackColor);
            if (colorPickerForm.ShowDialog() == DialogResult.OK)
            {
                backgroundBrushColorToolStripButton.BackColor = colorPickerForm.CurrentColor;
            }
        }
    }
}
