namespace PhotoSprite
{
    partial class ColorPickerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.rgbTabPage = new System.Windows.Forms.TabPage();
            this.alphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.alphaTrackBar = new System.Windows.Forms.TrackBar();
            this.alphaPictureBox = new System.Windows.Forms.PictureBox();
            this.rgbTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.redNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bluePictureBox = new System.Windows.Forms.PictureBox();
            this.greenPictureBox = new System.Windows.Forms.PictureBox();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.redPictureBox = new System.Windows.Forms.PictureBox();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.hslTabPage = new System.Windows.Forms.TabPage();
            this.backupColorPictureBox = new System.Windows.Forms.PictureBox();
            this.currentColorPictureBox = new System.Windows.Forms.PictureBox();
            this.nonButton = new System.Windows.Forms.Button();
            this.yaButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.rgbTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentColorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.rgbTabPage);
            this.tabControl1.Controls.Add(this.hslTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(401, 277);
            this.tabControl1.TabIndex = 1;
            // 
            // rgbTabPage
            // 
            this.rgbTabPage.Controls.Add(this.alphaNumericUpDown);
            this.rgbTabPage.Controls.Add(this.alphaTrackBar);
            this.rgbTabPage.Controls.Add(this.alphaPictureBox);
            this.rgbTabPage.Controls.Add(this.rgbTextBox);
            this.rgbTabPage.Controls.Add(this.label1);
            this.rgbTabPage.Controls.Add(this.blueNumericUpDown);
            this.rgbTabPage.Controls.Add(this.greenNumericUpDown);
            this.rgbTabPage.Controls.Add(this.redNumericUpDown);
            this.rgbTabPage.Controls.Add(this.bluePictureBox);
            this.rgbTabPage.Controls.Add(this.greenPictureBox);
            this.rgbTabPage.Controls.Add(this.redTrackBar);
            this.rgbTabPage.Controls.Add(this.redPictureBox);
            this.rgbTabPage.Controls.Add(this.blueTrackBar);
            this.rgbTabPage.Controls.Add(this.greenTrackBar);
            this.rgbTabPage.Location = new System.Drawing.Point(4, 22);
            this.rgbTabPage.Name = "rgbTabPage";
            this.rgbTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rgbTabPage.Size = new System.Drawing.Size(393, 251);
            this.rgbTabPage.TabIndex = 0;
            this.rgbTabPage.Text = "RGB";
            this.rgbTabPage.UseVisualStyleBackColor = true;
            // 
            // alphaNumericUpDown
            // 
            this.alphaNumericUpDown.Location = new System.Drawing.Point(8, 216);
            this.alphaNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.alphaNumericUpDown.Name = "alphaNumericUpDown";
            this.alphaNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.alphaNumericUpDown.TabIndex = 33;
            this.alphaNumericUpDown.ValueChanged += new System.EventHandler(this.alphaNumericUpDown_ValueChanged);
            // 
            // alphaTrackBar
            // 
            this.alphaTrackBar.AutoSize = false;
            this.alphaTrackBar.Location = new System.Drawing.Point(8, 6);
            this.alphaTrackBar.Maximum = 255;
            this.alphaTrackBar.Name = "alphaTrackBar";
            this.alphaTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.alphaTrackBar.Size = new System.Drawing.Size(30, 204);
            this.alphaTrackBar.TabIndex = 32;
            this.alphaTrackBar.TickFrequency = 0;
            this.alphaTrackBar.Scroll += new System.EventHandler(this.alphaTrackBar_Scroll);
            // 
            // alphaPictureBox
            // 
            this.alphaPictureBox.BackColor = System.Drawing.Color.White;
            this.alphaPictureBox.Location = new System.Drawing.Point(44, 18);
            this.alphaPictureBox.Name = "alphaPictureBox";
            this.alphaPictureBox.Size = new System.Drawing.Size(20, 180);
            this.alphaPictureBox.TabIndex = 31;
            this.alphaPictureBox.TabStop = false;
            // 
            // rgbTextBox
            // 
            this.rgbTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.rgbTextBox.Location = new System.Drawing.Point(324, 216);
            this.rgbTextBox.MaxLength = 8;
            this.rgbTextBox.Name = "rgbTextBox";
            this.rgbTextBox.Size = new System.Drawing.Size(63, 20);
            this.rgbTextBox.TabIndex = 30;
            this.rgbTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rgbTextBox.TextChanged += new System.EventHandler(this.rgbTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "#";
            // 
            // blueNumericUpDown
            // 
            this.blueNumericUpDown.Location = new System.Drawing.Point(246, 216);
            this.blueNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueNumericUpDown.Name = "blueNumericUpDown";
            this.blueNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.blueNumericUpDown.TabIndex = 25;
            this.blueNumericUpDown.ValueChanged += new System.EventHandler(this.blueNumericUpDown_ValueChanged);
            // 
            // greenNumericUpDown
            // 
            this.greenNumericUpDown.Location = new System.Drawing.Point(170, 216);
            this.greenNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenNumericUpDown.Name = "greenNumericUpDown";
            this.greenNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.greenNumericUpDown.TabIndex = 24;
            this.greenNumericUpDown.ValueChanged += new System.EventHandler(this.greenNumericUpDown_ValueChanged);
            // 
            // redNumericUpDown
            // 
            this.redNumericUpDown.Location = new System.Drawing.Point(85, 216);
            this.redNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redNumericUpDown.Name = "redNumericUpDown";
            this.redNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.redNumericUpDown.TabIndex = 23;
            this.redNumericUpDown.ValueChanged += new System.EventHandler(this.redNumericUpDown_ValueChanged);
            // 
            // bluePictureBox
            // 
            this.bluePictureBox.Location = new System.Drawing.Point(279, 18);
            this.bluePictureBox.Name = "bluePictureBox";
            this.bluePictureBox.Size = new System.Drawing.Size(20, 180);
            this.bluePictureBox.TabIndex = 21;
            this.bluePictureBox.TabStop = false;
            // 
            // greenPictureBox
            // 
            this.greenPictureBox.Location = new System.Drawing.Point(203, 18);
            this.greenPictureBox.Name = "greenPictureBox";
            this.greenPictureBox.Size = new System.Drawing.Size(20, 180);
            this.greenPictureBox.TabIndex = 20;
            this.greenPictureBox.TabStop = false;
            // 
            // redTrackBar
            // 
            this.redTrackBar.AutoSize = false;
            this.redTrackBar.Location = new System.Drawing.Point(85, 6);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.redTrackBar.Size = new System.Drawing.Size(30, 204);
            this.redTrackBar.TabIndex = 19;
            this.redTrackBar.TickFrequency = 0;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // redPictureBox
            // 
            this.redPictureBox.BackColor = System.Drawing.Color.White;
            this.redPictureBox.Location = new System.Drawing.Point(121, 18);
            this.redPictureBox.Name = "redPictureBox";
            this.redPictureBox.Size = new System.Drawing.Size(20, 180);
            this.redPictureBox.TabIndex = 18;
            this.redPictureBox.TabStop = false;
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.AutoSize = false;
            this.blueTrackBar.Location = new System.Drawing.Point(243, 6);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.blueTrackBar.Size = new System.Drawing.Size(30, 204);
            this.blueTrackBar.TabIndex = 17;
            this.blueTrackBar.TickFrequency = 0;
            this.blueTrackBar.Scroll += new System.EventHandler(this.blueTrackBar_Scroll);
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.AutoSize = false;
            this.greenTrackBar.Location = new System.Drawing.Point(167, 6);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.greenTrackBar.Size = new System.Drawing.Size(30, 204);
            this.greenTrackBar.TabIndex = 16;
            this.greenTrackBar.TickFrequency = 0;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // hslTabPage
            // 
            this.hslTabPage.Location = new System.Drawing.Point(4, 22);
            this.hslTabPage.Name = "hslTabPage";
            this.hslTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.hslTabPage.Size = new System.Drawing.Size(393, 251);
            this.hslTabPage.TabIndex = 1;
            this.hslTabPage.Text = "HSL";
            this.hslTabPage.UseVisualStyleBackColor = true;
            // 
            // backupColorPictureBox
            // 
            this.backupColorPictureBox.Location = new System.Drawing.Point(418, 102);
            this.backupColorPictureBox.Name = "backupColorPictureBox";
            this.backupColorPictureBox.Size = new System.Drawing.Size(80, 80);
            this.backupColorPictureBox.TabIndex = 30;
            this.backupColorPictureBox.TabStop = false;
            // 
            // currentColorPictureBox
            // 
            this.currentColorPictureBox.Location = new System.Drawing.Point(418, 22);
            this.currentColorPictureBox.Name = "currentColorPictureBox";
            this.currentColorPictureBox.Size = new System.Drawing.Size(80, 80);
            this.currentColorPictureBox.TabIndex = 29;
            this.currentColorPictureBox.TabStop = false;
            // 
            // nonButton
            // 
            this.nonButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.nonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonButton.Location = new System.Drawing.Point(188, 314);
            this.nonButton.Name = "nonButton";
            this.nonButton.Size = new System.Drawing.Size(75, 23);
            this.nonButton.TabIndex = 32;
            this.nonButton.Text = "non";
            this.nonButton.UseVisualStyleBackColor = true;
            // 
            // yaButton
            // 
            this.yaButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.yaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yaButton.Location = new System.Drawing.Point(89, 314);
            this.yaButton.Name = "yaButton";
            this.yaButton.Size = new System.Drawing.Size(75, 23);
            this.yaButton.TabIndex = 31;
            this.yaButton.Text = "ya";
            this.yaButton.UseVisualStyleBackColor = true;
            // 
            // ColorPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 357);
            this.Controls.Add(this.nonButton);
            this.Controls.Add(this.yaButton);
            this.Controls.Add(this.backupColorPictureBox);
            this.Controls.Add(this.currentColorPictureBox);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorPickerForm";
            this.Text = "ColorPickerForm";
            this.tabControl1.ResumeLayout(false);
            this.rgbTabPage.ResumeLayout(false);
            this.rgbTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentColorPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage rgbTabPage;
        private System.Windows.Forms.TrackBar alphaTrackBar;
        private System.Windows.Forms.PictureBox alphaPictureBox;
        private System.Windows.Forms.TextBox rgbTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown blueNumericUpDown;
        private System.Windows.Forms.NumericUpDown greenNumericUpDown;
        private System.Windows.Forms.NumericUpDown redNumericUpDown;
        private System.Windows.Forms.PictureBox bluePictureBox;
        private System.Windows.Forms.PictureBox greenPictureBox;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.PictureBox redPictureBox;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TabPage hslTabPage;
        private System.Windows.Forms.PictureBox backupColorPictureBox;
        private System.Windows.Forms.PictureBox currentColorPictureBox;
        private System.Windows.Forms.Button nonButton;
        private System.Windows.Forms.Button yaButton;
        private System.Windows.Forms.NumericUpDown alphaNumericUpDown;

    }
}