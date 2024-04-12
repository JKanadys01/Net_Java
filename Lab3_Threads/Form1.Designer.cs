namespace Lab3_Threads
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
            button1 = new Button();
            generated_textBox = new TextBox();
            size_textBox = new TextBox();
            label1 = new Label();
            num_thread_textBox = new TextBox();
            label2 = new Label();
            parallel_textBox = new TextBox();
            seq_textBox = new TextBox();
            thread_textBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            check_button = new Button();
            imagine_button = new Button();
            seed_textBox = new TextBox();
            label7 = new Label();
            sequential_button = new Button();
            threads_button = new Button();
            paralell_button = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(99, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "run all";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // generated_textBox
            // 
            generated_textBox.Location = new Point(344, 12);
            generated_textBox.Multiline = true;
            generated_textBox.Name = "generated_textBox";
            generated_textBox.ReadOnly = true;
            generated_textBox.ScrollBars = ScrollBars.Both;
            generated_textBox.Size = new Size(444, 336);
            generated_textBox.TabIndex = 1;
            // 
            // size_textBox
            // 
            size_textBox.Location = new Point(24, 84);
            size_textBox.Name = "size_textBox";
            size_textBox.Size = new Size(100, 23);
            size_textBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 66);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 3;
            label1.Text = "Size";
            // 
            // num_thread_textBox
            // 
            num_thread_textBox.Location = new Point(188, 84);
            num_thread_textBox.Name = "num_thread_textBox";
            num_thread_textBox.Size = new Size(100, 23);
            num_thread_textBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 66);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 5;
            label2.Text = "Number of threads";
            // 
            // parallel_textBox
            // 
            parallel_textBox.Location = new Point(224, 302);
            parallel_textBox.Name = "parallel_textBox";
            parallel_textBox.ReadOnly = true;
            parallel_textBox.Size = new Size(100, 23);
            parallel_textBox.TabIndex = 6;
            // 
            // seq_textBox
            // 
            seq_textBox.Location = new Point(12, 302);
            seq_textBox.Name = "seq_textBox";
            seq_textBox.ReadOnly = true;
            seq_textBox.Size = new Size(100, 23);
            seq_textBox.TabIndex = 7;
            // 
            // thread_textBox
            // 
            thread_textBox.Location = new Point(118, 302);
            thread_textBox.Name = "thread_textBox";
            thread_textBox.ReadOnly = true;
            thread_textBox.Size = new Size(100, 23);
            thread_textBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 284);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 9;
            label3.Text = "Sequential Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 284);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 10;
            label4.Text = "Threads Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 284);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 11;
            label5.Text = "Parallel Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 113);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(77, 15);
            label6.TabIndex = 12;
            label6.Text = "Check matrix";
            // 
            // check_button
            // 
            check_button.Location = new Point(24, 131);
            check_button.Name = "check_button";
            check_button.Size = new Size(75, 23);
            check_button.TabIndex = 13;
            check_button.Text = "check";
            check_button.UseVisualStyleBackColor = true;
            check_button.Click += check_button_Click;
            // 
            // imagine_button
            // 
            imagine_button.Location = new Point(24, 349);
            imagine_button.Name = "imagine_button";
            imagine_button.Size = new Size(169, 89);
            imagine_button.TabIndex = 14;
            imagine_button.Text = "Imagine";
            imagine_button.UseVisualStyleBackColor = true;
            imagine_button.Click += button2_Click;
            // 
            // seed_textBox
            // 
            seed_textBox.Location = new Point(188, 131);
            seed_textBox.Name = "seed_textBox";
            seed_textBox.Size = new Size(100, 23);
            seed_textBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 113);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 16;
            label7.Text = "Seed";
            // 
            // sequential_button
            // 
            sequential_button.Location = new Point(12, 232);
            sequential_button.Name = "sequential_button";
            sequential_button.Size = new Size(75, 49);
            sequential_button.TabIndex = 17;
            sequential_button.Text = "run Sequential";
            sequential_button.UseVisualStyleBackColor = true;
            sequential_button.Click += sequential_button_Click;
            // 
            // threads_button
            // 
            threads_button.Location = new Point(118, 232);
            threads_button.Name = "threads_button";
            threads_button.Size = new Size(75, 49);
            threads_button.TabIndex = 18;
            threads_button.Text = "run Threads";
            threads_button.UseVisualStyleBackColor = true;
            threads_button.Click += threads_button_Click;
            // 
            // paralell_button
            // 
            paralell_button.Location = new Point(224, 232);
            paralell_button.Name = "paralell_button";
            paralell_button.Size = new Size(75, 49);
            paralell_button.TabIndex = 19;
            paralell_button.Text = "run Parallel";
            paralell_button.UseVisualStyleBackColor = true;
            paralell_button.Click += paralell_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(paralell_button);
            Controls.Add(threads_button);
            Controls.Add(sequential_button);
            Controls.Add(label7);
            Controls.Add(seed_textBox);
            Controls.Add(imagine_button);
            Controls.Add(check_button);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(thread_textBox);
            Controls.Add(seq_textBox);
            Controls.Add(parallel_textBox);
            Controls.Add(label2);
            Controls.Add(num_thread_textBox);
            Controls.Add(label1);
            Controls.Add(size_textBox);
            Controls.Add(generated_textBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Check";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox generated_textBox;
        private TextBox size_textBox;
        private Label label1;
        private TextBox num_thread_textBox;
        private Label label2;
        private TextBox parallel_textBox;
        private TextBox seq_textBox;
        private TextBox thread_textBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button check_button;
        private Button imagine_button;
        private TextBox seed_textBox;
        private Label label7;
        private Button sequential_button;
        private Button threads_button;
        private Button paralell_button;
    }
}
