namespace Lab2_Weather_API
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
            Data_box = new ListBox();
            get_location = new Button();
            wroclaw_location = new Button();
            warsaw_location = new Button();
            home_location = new Button();
            give_coord = new Button();
            latitude_textBox = new TextBox();
            label1 = new Label();
            longitude_textBox = new TextBox();
            label2 = new Label();
            show_data_base = new Button();
            delete_database = new Button();
            city_name_textBox = new TextBox();
            label3 = new Label();
            name_sort = new Button();
            min_max = new Button();
            parametr_comboBox = new ComboBox();
            min_max_listBox = new ListBox();
            wykres_button = new Button();
            delete_by_city_button = new Button();
            map_button = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Data_box
            // 
            Data_box.FormattingEnabled = true;
            Data_box.ItemHeight = 15;
            Data_box.Location = new Point(255, 12);
            Data_box.Name = "Data_box";
            Data_box.Size = new Size(260, 439);
            Data_box.TabIndex = 1;
            // 
            // get_location
            // 
            get_location.Location = new Point(613, 12);
            get_location.Name = "get_location";
            get_location.Size = new Size(75, 23);
            get_location.TabIndex = 2;
            get_location.Text = "Location";
            get_location.UseVisualStyleBackColor = true;
            get_location.Click += get_location_Click;
            // 
            // wroclaw_location
            // 
            wroclaw_location.Location = new Point(532, 41);
            wroclaw_location.Name = "wroclaw_location";
            wroclaw_location.Size = new Size(75, 23);
            wroclaw_location.TabIndex = 3;
            wroclaw_location.Text = "Wroclaw";
            wroclaw_location.UseVisualStyleBackColor = true;
            wroclaw_location.Click += wroclaw_location_Click;
            // 
            // warsaw_location
            // 
            warsaw_location.Location = new Point(613, 41);
            warsaw_location.Name = "warsaw_location";
            warsaw_location.Size = new Size(75, 23);
            warsaw_location.TabIndex = 4;
            warsaw_location.Text = "Warsaw";
            warsaw_location.UseVisualStyleBackColor = true;
            warsaw_location.Click += warsaw_location_Click;
            // 
            // home_location
            // 
            home_location.Location = new Point(694, 41);
            home_location.Name = "home_location";
            home_location.Size = new Size(75, 23);
            home_location.TabIndex = 5;
            home_location.Text = "Home";
            home_location.UseVisualStyleBackColor = true;
            home_location.Click += home_location_Click;
            // 
            // give_coord
            // 
            give_coord.Location = new Point(613, 70);
            give_coord.Name = "give_coord";
            give_coord.Size = new Size(75, 23);
            give_coord.TabIndex = 6;
            give_coord.Text = "Enter";
            give_coord.UseVisualStyleBackColor = true;
            give_coord.Click += give_coord_Click;
            // 
            // latitude_textBox
            // 
            latitude_textBox.Location = new Point(532, 99);
            latitude_textBox.Name = "latitude_textBox";
            latitude_textBox.Size = new Size(100, 23);
            latitude_textBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(532, 81);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 8;
            label1.Text = "latitude";
            // 
            // longitude_textBox
            // 
            longitude_textBox.Location = new Point(669, 99);
            longitude_textBox.Name = "longitude_textBox";
            longitude_textBox.Size = new Size(100, 23);
            longitude_textBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(711, 81);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 10;
            label2.Text = "longitude";
            // 
            // show_data_base
            // 
            show_data_base.Location = new Point(23, 12);
            show_data_base.Name = "show_data_base";
            show_data_base.Size = new Size(75, 23);
            show_data_base.TabIndex = 11;
            show_data_base.Text = "show data";
            show_data_base.UseVisualStyleBackColor = true;
            show_data_base.Click += show_data_base_Click;
            // 
            // delete_database
            // 
            delete_database.Location = new Point(127, 12);
            delete_database.Name = "delete_database";
            delete_database.Size = new Size(75, 23);
            delete_database.TabIndex = 12;
            delete_database.Text = "delete all";
            delete_database.UseVisualStyleBackColor = true;
            delete_database.Click += delete_database_Click;
            // 
            // city_name_textBox
            // 
            city_name_textBox.Location = new Point(102, 78);
            city_name_textBox.Name = "city_name_textBox";
            city_name_textBox.Size = new Size(100, 23);
            city_name_textBox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 62);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 14;
            label3.Text = "City Name";
            // 
            // name_sort
            // 
            name_sort.Location = new Point(21, 58);
            name_sort.Name = "name_sort";
            name_sort.Size = new Size(75, 23);
            name_sort.TabIndex = 15;
            name_sort.Text = "sort";
            name_sort.UseVisualStyleBackColor = true;
            name_sort.Click += name_sort_Click;
            // 
            // min_max
            // 
            min_max.Location = new Point(10, 167);
            min_max.Name = "min_max";
            min_max.Size = new Size(75, 23);
            min_max.TabIndex = 16;
            min_max.Text = "min_max";
            min_max.UseVisualStyleBackColor = true;
            min_max.Click += min_max_Click;
            // 
            // parametr_comboBox
            // 
            parametr_comboBox.FormattingEnabled = true;
            parametr_comboBox.Location = new Point(91, 167);
            parametr_comboBox.Name = "parametr_comboBox";
            parametr_comboBox.Size = new Size(121, 23);
            parametr_comboBox.TabIndex = 17;
            // 
            // min_max_listBox
            // 
            min_max_listBox.FormattingEnabled = true;
            min_max_listBox.ItemHeight = 15;
            min_max_listBox.Location = new Point(12, 196);
            min_max_listBox.Name = "min_max_listBox";
            min_max_listBox.Size = new Size(237, 64);
            min_max_listBox.TabIndex = 18;
            // 
            // wykres_button
            // 
            wykres_button.Location = new Point(20, 274);
            wykres_button.Name = "wykres_button";
            wykres_button.Size = new Size(75, 23);
            wykres_button.TabIndex = 19;
            wykres_button.Text = "rysuj";
            wykres_button.UseVisualStyleBackColor = true;
            wykres_button.Click += wykres_button_Click;
            // 
            // delete_by_city_button
            // 
            delete_by_city_button.Location = new Point(21, 87);
            delete_by_city_button.Name = "delete_by_city_button";
            delete_by_city_button.Size = new Size(75, 39);
            delete_by_city_button.TabIndex = 20;
            delete_by_city_button.Text = "delete selected";
            delete_by_city_button.UseVisualStyleBackColor = true;
            delete_by_city_button.Click += delete_by_city_button_Click;
            // 
            // map_button
            // 
            map_button.Location = new Point(20, 303);
            map_button.Name = "map_button";
            map_button.Size = new Size(75, 23);
            map_button.TabIndex = 21;
            map_button.Text = "map";
            map_button.UseVisualStyleBackColor = true;
            map_button.Click += map_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(590, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 255);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(map_button);
            Controls.Add(delete_by_city_button);
            Controls.Add(wykres_button);
            Controls.Add(min_max_listBox);
            Controls.Add(parametr_comboBox);
            Controls.Add(min_max);
            Controls.Add(name_sort);
            Controls.Add(label3);
            Controls.Add(city_name_textBox);
            Controls.Add(delete_database);
            Controls.Add(show_data_base);
            Controls.Add(label2);
            Controls.Add(longitude_textBox);
            Controls.Add(label1);
            Controls.Add(latitude_textBox);
            Controls.Add(give_coord);
            Controls.Add(home_location);
            Controls.Add(warsaw_location);
            Controls.Add(wroclaw_location);
            Controls.Add(get_location);
            Controls.Add(Data_box);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox Data_box;
        private Button get_location;
        private Button wroclaw_location;
        private Button warsaw_location;
        private Button home_location;
        private Button give_coord;
        private TextBox latitude_textBox;
        private Label label1;
        private TextBox longitude_textBox;
        private Label label2;
        private Button show_data_base;
        private Button delete_database;
        private TextBox city_name_textBox;
        private Label label3;
        private Button name_sort;
        private Button min_max;
        private ComboBox parametr_comboBox;
        private ListBox min_max_listBox;
        private Button wykres_button;
        private Button delete_by_city_button;
        private Button map_button;
        private PictureBox pictureBox1;
    }
}
