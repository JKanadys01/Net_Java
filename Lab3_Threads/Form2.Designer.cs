namespace Lab3_Threads
{
    partial class Form2
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
            open_button = new Button();
            original_pictureBox = new PictureBox();
            threshold_pictureBox = new PictureBox();
            negative_pictureBox = new PictureBox();
            gray_scale_pictureBox = new PictureBox();
            mirror_pictureBox = new PictureBox();
            filter_button = new Button();
            threshold_trackBar = new TrackBar();
            label1 = new Label();
            threshold_label = new Label();
            ((System.ComponentModel.ISupportInitialize)original_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)threshold_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)negative_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gray_scale_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mirror_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)threshold_trackBar).BeginInit();
            SuspendLayout();
            // 
            // open_button
            // 
            open_button.Location = new Point(137, 479);
            open_button.Name = "open_button";
            open_button.Size = new Size(179, 77);
            open_button.TabIndex = 0;
            open_button.Text = "Open";
            open_button.UseVisualStyleBackColor = true;
            open_button.Click += open_button_Click;
            // 
            // original_pictureBox
            // 
            original_pictureBox.Location = new Point(12, 37);
            original_pictureBox.Name = "original_pictureBox";
            original_pictureBox.Size = new Size(485, 436);
            original_pictureBox.TabIndex = 1;
            original_pictureBox.TabStop = false;
            // 
            // threshold_pictureBox
            // 
            threshold_pictureBox.Location = new Point(503, 37);
            threshold_pictureBox.Name = "threshold_pictureBox";
            threshold_pictureBox.Size = new Size(283, 215);
            threshold_pictureBox.TabIndex = 2;
            threshold_pictureBox.TabStop = false;
            // 
            // negative_pictureBox
            // 
            negative_pictureBox.Location = new Point(503, 258);
            negative_pictureBox.Name = "negative_pictureBox";
            negative_pictureBox.Size = new Size(283, 215);
            negative_pictureBox.TabIndex = 3;
            negative_pictureBox.TabStop = false;
            // 
            // gray_scale_pictureBox
            // 
            gray_scale_pictureBox.Location = new Point(792, 37);
            gray_scale_pictureBox.Name = "gray_scale_pictureBox";
            gray_scale_pictureBox.Size = new Size(283, 215);
            gray_scale_pictureBox.TabIndex = 4;
            gray_scale_pictureBox.TabStop = false;
            // 
            // mirror_pictureBox
            // 
            mirror_pictureBox.Location = new Point(792, 258);
            mirror_pictureBox.Name = "mirror_pictureBox";
            mirror_pictureBox.Size = new Size(283, 215);
            mirror_pictureBox.TabIndex = 5;
            mirror_pictureBox.TabStop = false;
            // 
            // filter_button
            // 
            filter_button.Location = new Point(701, 479);
            filter_button.Name = "filter_button";
            filter_button.Size = new Size(179, 84);
            filter_button.TabIndex = 6;
            filter_button.Text = "Filter";
            filter_button.UseVisualStyleBackColor = true;
            filter_button.Click += filter_button_Click;
            // 
            // threshold_trackBar
            // 
            threshold_trackBar.Location = new Point(701, 607);
            threshold_trackBar.Name = "threshold_trackBar";
            threshold_trackBar.Size = new Size(225, 45);
            threshold_trackBar.TabIndex = 7;
            threshold_trackBar.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(701, 589);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 8;
            label1.Text = "Threshold ";
            // 
            // threshold_label
            // 
            threshold_label.AutoSize = true;
            threshold_label.Location = new Point(769, 589);
            threshold_label.Name = "threshold_label";
            threshold_label.Size = new Size(10, 15);
            threshold_label.TabIndex = 9;
            threshold_label.Text = ":";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1189, 664);
            Controls.Add(threshold_label);
            Controls.Add(label1);
            Controls.Add(threshold_trackBar);
            Controls.Add(filter_button);
            Controls.Add(mirror_pictureBox);
            Controls.Add(gray_scale_pictureBox);
            Controls.Add(negative_pictureBox);
            Controls.Add(threshold_pictureBox);
            Controls.Add(original_pictureBox);
            Controls.Add(open_button);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)original_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)threshold_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)negative_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)gray_scale_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mirror_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)threshold_trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button open_button;
        private PictureBox original_pictureBox;
        private PictureBox threshold_pictureBox;
        private PictureBox negative_pictureBox;
        private PictureBox gray_scale_pictureBox;
        private PictureBox mirror_pictureBox;
        private Button filter_button;
        private TrackBar threshold_trackBar;
        private Label label1;
        private Label threshold_label;
    }
}