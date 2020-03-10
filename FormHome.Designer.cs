namespace TP1
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.btLogout = new System.Windows.Forms.Button();
            this.pbKatalog = new System.Windows.Forms.PictureBox();
            this.pbBeli = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btBeli = new System.Windows.Forms.Button();
            this.btKatalog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btCari = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbKatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btLogout.Location = new System.Drawing.Point(45, 508);
            this.btLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(168, 53);
            this.btLogout.TabIndex = 0;
            this.btLogout.Text = "Logout   ";
            this.btLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // pbKatalog
            // 
            this.pbKatalog.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pbKatalog.Image = ((System.Drawing.Image)(resources.GetObject("pbKatalog.Image")));
            this.pbKatalog.Location = new System.Drawing.Point(35, 241);
            this.pbKatalog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbKatalog.Name = "pbKatalog";
            this.pbKatalog.Size = new System.Drawing.Size(67, 62);
            this.pbKatalog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKatalog.TabIndex = 1;
            this.pbKatalog.TabStop = false;
            this.pbKatalog.Click += new System.EventHandler(this.pbKatalog_Click_1);
            // 
            // pbBeli
            // 
            this.pbBeli.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pbBeli.Image = ((System.Drawing.Image)(resources.GetObject("pbBeli.Image")));
            this.pbBeli.Location = new System.Drawing.Point(35, 145);
            this.pbBeli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBeli.Name = "pbBeli";
            this.pbBeli.Size = new System.Drawing.Size(67, 62);
            this.pbBeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBeli.TabIndex = 2;
            this.pbBeli.TabStop = false;
            this.pbBeli.Click += new System.EventHandler(this.pbKatalog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1185, 103);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox2.Location = new System.Drawing.Point(1, 102);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 470);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btBeli
            // 
            this.btBeli.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBeli.Location = new System.Drawing.Point(21, 134);
            this.btBeli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBeli.Name = "btBeli";
            this.btBeli.Size = new System.Drawing.Size(225, 81);
            this.btBeli.TabIndex = 5;
            this.btBeli.Text = "Menu Beli ";
            this.btBeli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBeli.UseVisualStyleBackColor = false;
            this.btBeli.Click += new System.EventHandler(this.btBeli_Click);
            // 
            // btKatalog
            // 
            this.btKatalog.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btKatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKatalog.Location = new System.Drawing.Point(21, 231);
            this.btKatalog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btKatalog.Name = "btKatalog";
            this.btKatalog.Size = new System.Drawing.Size(225, 81);
            this.btKatalog.TabIndex = 6;
            this.btKatalog.Text = "Menu Katalog";
            this.btKatalog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btKatalog.UseVisualStyleBackColor = false;
            this.btKatalog.Click += new System.EventHandler(this.btKatalog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 70);
            this.label1.TabIndex = 7;
            this.label1.Text = "Afie\'s Store";
            this.label1.UseMnemonic = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(994, 539);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "1801411 - Koes Safira A";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Firebrick;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(60, 520);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(734, 112);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Jenis Barang";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(920, 112);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 24);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "Rentang Harga";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btCari
            // 
            this.btCari.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCari.Location = new System.Drawing.Point(1105, 112);
            this.btCari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCari.Name = "btCari";
            this.btCari.Size = new System.Drawing.Size(65, 26);
            this.btCari.TabIndex = 13;
            this.btCari.Text = "Cari";
            this.btCari.UseVisualStyleBackColor = false;
            this.btCari.Click += new System.EventHandler(this.btCari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(677, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filter:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(266, 137);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(919, 394);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCari);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbKatalog);
            this.Controls.Add(this.btKatalog);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbBeli);
            this.Controls.Add(this.btBeli);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHome";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pbKatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.PictureBox pbKatalog;
        private System.Windows.Forms.PictureBox pbBeli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btBeli;
        private System.Windows.Forms.Button btKatalog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}