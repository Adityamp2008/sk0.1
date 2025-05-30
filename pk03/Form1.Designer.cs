namespace pk03
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            judul = new Label();
            jenis = new Label();
            jm = new ComboBox();
            nm = new ComboBox();
            menu = new Label();
            jumlah = new TextBox();
            l = new Label();
            label1 = new Label();
            harga = new TextBox();
            pictureBox4 = new PictureBox();
            hitung = new Button();
            bersih = new Button();
            label2 = new Label();
            diskon = new TextBox();
            label = new Label();
            nota = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            th = new TextBox();
            label5 = new Label();
            tb = new TextBox();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(514, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(12, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(514, 261);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(557, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(221, 323);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // judul
            // 
            judul.BackColor = SystemColors.Control;
            judul.BorderStyle = BorderStyle.FixedSingle;
            judul.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            judul.Location = new Point(12, 12);
            judul.Name = "judul";
            judul.Size = new Size(514, 50);
            judul.TabIndex = 3;
            judul.Text = "Kasir Nangkring";
            judul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // jenis
            // 
            jenis.AutoSize = true;
            jenis.BackColor = SystemColors.Control;
            jenis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jenis.Location = new Point(31, 149);
            jenis.Name = "jenis";
            jenis.Size = new Size(44, 21);
            jenis.TabIndex = 4;
            jenis.Text = "Jenis";
            // 
            // jm
            // 
            jm.FormattingEnabled = true;
            jm.Location = new Point(31, 173);
            jm.Name = "jm";
            jm.Size = new Size(202, 23);
            jm.TabIndex = 5;
            jm.SelectedIndexChanged += jm_SelectedIndexChanged;
            // 
            // nm
            // 
            nm.FormattingEnabled = true;
            nm.Location = new Point(31, 237);
            nm.Name = "nm";
            nm.Size = new Size(202, 23);
            nm.TabIndex = 7;
            nm.SelectedIndexChanged += nm_SelectedIndexChanged;
            // 
            // menu
            // 
            menu.AutoSize = true;
            menu.BackColor = SystemColors.Control;
            menu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu.Location = new Point(31, 213);
            menu.Name = "menu";
            menu.Size = new Size(50, 21);
            menu.TabIndex = 6;
            menu.Text = "Menu";
            // 
            // jumlah
            // 
            jumlah.BorderStyle = BorderStyle.FixedSingle;
            jumlah.Location = new Point(299, 115);
            jumlah.Name = "jumlah";
            jumlah.Size = new Size(202, 23);
            jumlah.TabIndex = 8;
            jumlah.TextChanged += textBox1_TextChanged;
            // 
            // l
            // 
            l.AutoSize = true;
            l.BackColor = SystemColors.Control;
            l.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l.Location = new Point(299, 91);
            l.Name = "l";
            l.Size = new Size(60, 21);
            l.TabIndex = 9;
            l.Text = "Jumlah";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 150);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 11;
            label1.Text = "Harga";
            // 
            // harga
            // 
            harga.BorderStyle = BorderStyle.FixedSingle;
            harga.Location = new Point(299, 174);
            harga.Name = "harga";
            harga.Size = new Size(202, 23);
            harga.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(566, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(202, 116);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // hitung
            // 
            hitung.Location = new Point(31, 286);
            hitung.Name = "hitung";
            hitung.Size = new Size(75, 23);
            hitung.TabIndex = 13;
            hitung.Text = "Hitung";
            hitung.UseVisualStyleBackColor = true;
            hitung.Click += hitung_Click;
            // 
            // bersih
            // 
            bersih.Location = new Point(112, 286);
            bersih.Name = "bersih";
            bersih.Size = new Size(75, 23);
            bersih.TabIndex = 14;
            bersih.Text = "Bersih";
            bersih.UseVisualStyleBackColor = true;
            bersih.Click += bersih_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(299, 213);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 16;
            label2.Text = "Diskon";
            // 
            // diskon
            // 
            diskon.BorderStyle = BorderStyle.FixedSingle;
            diskon.Location = new Point(299, 238);
            diskon.Name = "diskon";
            diskon.Size = new Size(202, 23);
            diskon.TabIndex = 15;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = SystemColors.Control;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(566, 149);
            label.Name = "label";
            label.Size = new Size(69, 21);
            label.TabIndex = 18;
            label.Text = "No Nota";
            // 
            // nota
            // 
            nota.BorderStyle = BorderStyle.FixedSingle;
            nota.Location = new Point(566, 173);
            nota.Name = "nota";
            nota.Size = new Size(202, 23);
            nota.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(31, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(202, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 87);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 20;
            label3.Text = "Tanggal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(566, 203);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 22;
            label4.Text = "Total Harga";
            // 
            // th
            // 
            th.BorderStyle = BorderStyle.FixedSingle;
            th.Location = new Point(566, 227);
            th.Name = "th";
            th.Size = new Size(202, 23);
            th.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(570, 262);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 24;
            label5.Text = "Total Bayar";
            // 
            // tb
            // 
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Location = new Point(566, 288);
            tb.Name = "tb";
            tb.Size = new Size(202, 23);
            tb.TabIndex = 23;
            // 
            // exit
            // 
            exit.Location = new Point(426, 286);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 25;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(label5);
            Controls.Add(tb);
            Controls.Add(label4);
            Controls.Add(th);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label);
            Controls.Add(nota);
            Controls.Add(label2);
            Controls.Add(diskon);
            Controls.Add(bersih);
            Controls.Add(hitung);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(harga);
            Controls.Add(l);
            Controls.Add(jumlah);
            Controls.Add(nm);
            Controls.Add(menu);
            Controls.Add(jm);
            Controls.Add(jenis);
            Controls.Add(judul);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label judul;
        private Label jenis;
        private ComboBox jm;
        private ComboBox nm;
        private Label menu;
        private TextBox jumlah;
        private Label l;
        private Label label1;
        private TextBox harga;
        private PictureBox pictureBox4;
        private Button hitung;
        private Button bersih;
        private Label label2;
        private TextBox diskon;
        private Label label;
        private TextBox nota;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private TextBox th;
        private Label label5;
        private TextBox tb;
        private Button exit;
    }
}
