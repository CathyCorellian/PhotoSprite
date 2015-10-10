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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hexTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backupColorPictureBox = new System.Windows.Forms.PictureBox();
            this.nonButton = new System.Windows.Forms.Button();
            this.yaButton = new System.Windows.Forms.Button();
            this.blueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.redNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.currentColorPictureBox = new System.Windows.Forms.PictureBox();
            this.bluePictureBox = new System.Windows.Forms.PictureBox();
            this.greenPictureBox = new System.Windows.Forms.PictureBox();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.redPictureBox = new System.Windows.Forms.PictureBox();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hexTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.backupColorPictureBox);
            this.groupBox1.Controls.Add(this.nonButton);
            this.groupBox1.Controls.Add(this.yaButton);
            this.groupBox1.Controls.Add(this.blueNumericUpDown);
            this.groupBox1.Controls.Add(this.greenNumericUpDown);
            this.groupBox1.Controls.Add(this.redNumericUpDown);
            this.groupBox1.Controls.Add(this.currentColorPictureBox);
            this.groupBox1.Controls.Add(this.bluePictureBox);
            this.groupBox1.Controls.Add(this.greenPictureBox);
            this.groupBox1.Controls.Add(this.redTrackBar);
            this.groupBox1.Controls.Add(this.redPictureBox);
            this.groupBox1.Controls.Add(this.blueTrackBar);
            this.groupBox1.Controls.Add(this.greenTrackBar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RGB";
            // 
            // hexTextBox
            // 
            this.hexTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hexTextBox.Location = new System.Drawing.Point(257, 228);
            this.hexTextBox.MaxLength = 8;
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.Size = new System.Drawing.Size(63, 20);
            this.hexTextBox.TabIndex = 15;
            this.hexTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hexTextBox.TextChanged += new System.EventHandler(this.hexTextBox_TextChanged);
            this.hexTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hexTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "#";
            // 
            // backupColorPictureBox
            // 
            this.backupColorPictureBox.Location = new System.Drawing.Point(246, 108);
            this.backupColorPictureBox.Name = "backupColorPictureBox";
            this.backupColorPictureBox.Size = new System.Drawing.Size(80, 80);
            this.backupColorPictureBox.TabIndex = 13;
            this.backupColorPictureBox.TabStop = false;
            this.backupColorPictureBox.Click += new System.EventHandler(this.backupColorPictureBox_Click);
            // 
            // nonButton
            // 
            this.nonButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.nonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonButton.Location = new System.Drawing.Point(147, 267);
            this.nonButton.Name = "nonButton";
            this.nonButton.Size = new System.Drawing.Size(75, 23);
            this.nonButton.TabIndex = 12;
            this.nonButton.Text = "non";
            this.nonButton.UseVisualStyleBackColor = true;
            // 
            // yaButton
            // 
            this.yaButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.yaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yaButton.Location = new System.Drawing.Point(48, 267);
            this.yaButton.Name = "yaButton";
            this.yaButton.Size = new System.Drawing.Size(75, 23);
            this.yaButton.TabIndex = 11;
            this.yaButton.Text = "ya";
            this.yaButton.UseVisualStyleBackColor = true;
            // 
            // blueNumericUpDown
            // 
            this.blueNumericUpDown.Location = new System.Drawing.Point(167, 226);
            this.blueNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueNumericUpDown.Name = "blueNumericUpDown";
            this.blueNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.blueNumericUpDown.TabIndex = 10;
            this.blueNumericUpDown.ValueChanged += new System.EventHandler(this.blueNumericUpDown_ValueChanged);
            // 
            // greenNumericUpDown
            // 
            this.greenNumericUpDown.Location = new System.Drawing.Point(91, 226);
            this.greenNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenNumericUpDown.Name = "greenNumericUpDown";
            this.greenNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.greenNumericUpDown.TabIndex = 9;
            this.greenNumericUpDown.ValueChanged += new System.EventHandler(this.greenNumericUpDown_ValueChanged);
            // 
            // redNumericUpDown
            // 
            this.redNumericUpDown.Location = new System.Drawing.Point(6, 226);
            this.redNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redNumericUpDown.Name = "redNumericUpDown";
            this.redNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.redNumericUpDown.TabIndex = 8;
            this.redNumericUpDown.ValueChanged += new System.EventHandler(this.redNumericUpDown_ValueChanged);
            // 
            // currentColorPictureBox
            // 
            this.currentColorPictureBox.Location = new System.Drawing.Point(246, 28);
            this.currentColorPictureBox.Name = "currentColorPictureBox";
            this.currentColorPictureBox.Size = new System.Drawing.Size(80, 80);
            this.currentColorPictureBox.TabIndex = 7;
            this.currentColorPictureBox.TabStop = false;
            // 
            // bluePictureBox
            // 
            this.bluePictureBox.Location = new System.Drawing.Point(203, 28);
            this.bluePictureBox.Name = "bluePictureBox";
            this.bluePictureBox.Size = new System.Drawing.Size(20, 180);
            this.bluePictureBox.TabIndex = 6;
            this.bluePictureBox.TabStop = false;
            // 
            // greenPictureBox
            // 
            this.greenPictureBox.Location = new System.Drawing.Point(127, 28);
            this.greenPictureBox.Name = "greenPictureBox";
            this.greenPictureBox.Size = new System.Drawing.Size(20, 180);
            this.greenPictureBox.TabIndex = 5;
            this.greenPictureBox.TabStop = false;
            // 
            // redTrackBar
            // 
            this.redTrackBar.AutoSize = false;
            this.redTrackBar.Location = new System.Drawing.Point(9, 16);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.redTrackBar.Size = new System.Drawing.Size(30, 204);
            this.redTrackBar.TabIndex = 4;
            this.redTrackBar.TickFrequency = 0;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // redPictureBox
            // 
            this.redPictureBox.BackColor = System.Drawing.Color.White;
            this.redPictureBox.Location = new System.Drawing.Point(45, 28);
            this.redPictureBox.Name = "redPictureBox";
            this.redPictureBox.Size = new System.Drawing.Size(20, 180);
            this.redPictureBox.TabIndex = 3;
            this.redPictureBox.TabStop = false;
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.AutoSize = false;
            this.blueTrackBar.Location = new System.Drawing.Point(167, 16);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.blueTrackBar.Size = new System.Drawing.Size(30, 204);
            this.blueTrackBar.TabIndex = 2;
            this.blueTrackBar.TickFrequency = 0;
            this.blueTrackBar.Scroll += new System.EventHandler(this.blueTrackBar_Scroll);
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.AutoSize = false;
            this.greenTrackBar.Location = new System.Drawing.Point(91, 16);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.greenTrackBar.Size = new System.Drawing.Size(30, 204);
            this.greenTrackBar.TabIndex = 1;
            this.greenTrackBar.TickFrequency = 0;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // ColorPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 305);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorPickerForm";
            this.Text = "ColorPickerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.PictureBox redPictureBox;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.PictureBox greenPictureBox;
        private System.Windows.Forms.PictureBox bluePictureBox;
        private System.Windows.Forms.PictureBox currentColorPictureBox;
        private System.Windows.Forms.NumericUpDown blueNumericUpDown;
        private System.Windows.Forms.NumericUpDown greenNumericUpDown;
        private System.Windows.Forms.NumericUpDown redNumericUpDown;
        private System.Windows.Forms.Button nonButton;
        private System.Windows.Forms.Button yaButton;
        private System.Windows.Forms.PictureBox backupColorPictureBox;
        private System.Windows.Forms.TextBox hexTextBox;
        private System.Windows.Forms.Label label1;
    }
}