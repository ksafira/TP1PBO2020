namespace TP1
{
    partial class Barang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btBuy = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbJudul = new System.Windows.Forms.Label();
            this.lbHarga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btBuy
            // 
            this.btBuy.BackColor = System.Drawing.Color.ForestGreen;
            this.btBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBuy.Location = new System.Drawing.Point(84, 217);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(58, 28);
            this.btBuy.TabIndex = 1;
            this.btBuy.Text = "Beli";
            this.btBuy.UseVisualStyleBackColor = false;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 140);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lbJudul
            // 
            this.lbJudul.AutoSize = true;
            this.lbJudul.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJudul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbJudul.Location = new System.Drawing.Point(6, 159);
            this.lbJudul.Name = "lbJudul";
            this.lbJudul.Size = new System.Drawing.Size(45, 16);
            this.lbJudul.TabIndex = 3;
            this.lbJudul.Text = "Judul";
            // 
            // lbHarga
            // 
            this.lbHarga.AutoSize = true;
            this.lbHarga.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbHarga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHarga.Location = new System.Drawing.Point(8, 184);
            this.lbHarga.Name = "lbHarga";
            this.lbHarga.Size = new System.Drawing.Size(36, 13);
            this.lbHarga.TabIndex = 4;
            this.lbHarga.Text = "Harga";
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbHarga);
            this.Controls.Add(this.lbJudul);
            this.Controls.Add(this.btBuy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Barang";
            this.Size = new System.Drawing.Size(150, 253);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbJudul;
        private System.Windows.Forms.Label lbHarga;
    }
}
