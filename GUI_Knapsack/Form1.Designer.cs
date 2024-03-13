namespace GUI_Knapsack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nr_of_items = new TextBox();
            seed = new TextBox();
            capacity = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            problem_list = new ListBox();
            knapsac_list = new ListBox();
            sorted_list = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 181);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "nr of items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "capacity";
            // 
            // nr_of_items
            // 
            nr_of_items.Location = new Point(12, 27);
            nr_of_items.Name = "nr_of_items";
            nr_of_items.Size = new Size(100, 23);
            nr_of_items.TabIndex = 7;
            nr_of_items.TextChanged += nr_of_items_TextChanged;
            // 
            // seed
            // 
            seed.Location = new Point(12, 83);
            seed.Name = "seed";
            seed.Size = new Size(100, 23);
            seed.TabIndex = 8;
            seed.TextChanged += seed_TextChanged;
            // 
            // capacity
            // 
            capacity.Location = new Point(12, 142);
            capacity.Name = "capacity";
            capacity.Size = new Size(100, 23);
            capacity.TabIndex = 9;
            capacity.TextChanged += capacity_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 6);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 11;
            label4.Text = "Generated Problem";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 236);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 14;
            label6.Text = "Results";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(463, 6);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 19;
            label5.Text = "Sorted Items";
            // 
            // problem_list
            // 
            problem_list.FormattingEnabled = true;
            problem_list.ItemHeight = 15;
            problem_list.Location = new Point(200, 27);
            problem_list.Name = "problem_list";
            problem_list.Size = new Size(200, 139);
            problem_list.TabIndex = 20;
            // 
            // knapsac_list
            // 
            knapsac_list.FormattingEnabled = true;
            knapsac_list.ItemHeight = 15;
            knapsac_list.Location = new Point(12, 254);
            knapsac_list.Name = "knapsac_list";
            knapsac_list.Size = new Size(200, 139);
            knapsac_list.TabIndex = 21;
            // 
            // sorted_list
            // 
            sorted_list.FormattingEnabled = true;
            sorted_list.ItemHeight = 15;
            sorted_list.Location = new Point(463, 27);
            sorted_list.Name = "sorted_list";
            sorted_list.Size = new Size(200, 139);
            sorted_list.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(463, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 284);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(sorted_list);
            Controls.Add(knapsac_list);
            Controls.Add(problem_list);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(capacity);
            Controls.Add(seed);
            Controls.Add(nr_of_items);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nr_of_items;
        private TextBox seed;
        private TextBox capacity;
        private Label label4;
        private Label label6;
        private Label label5;
        private ListBox problem_list;
        private ListBox knapsac_list;
        private ListBox sorted_list;
        private PictureBox pictureBox1;
    }
}
