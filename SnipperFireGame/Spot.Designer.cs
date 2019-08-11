namespace SnipperFireGame
{
    partial class Spot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spot));
            this.images = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.ButtonFire = new System.Windows.Forms.Button();
            this.blood = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood)).BeginInit();
            this.SuspendLayout();
            // 
            // images
            // 
            this.images.BackColor = System.Drawing.Color.Transparent;
            this.images.Location = new System.Drawing.Point(229, 217);
            this.images.Name = "images";
            this.images.Size = new System.Drawing.Size(285, 235);
            this.images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.images.TabIndex = 0;
            this.images.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 249);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 37);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Spin";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ButtonFire
            // 
            this.ButtonFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonFire.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFire.Location = new System.Drawing.Point(10, 357);
            this.ButtonFire.Name = "ButtonFire";
            this.ButtonFire.Size = new System.Drawing.Size(126, 56);
            this.ButtonFire.TabIndex = 2;
            this.ButtonFire.Text = "Shoot Away";
            this.ButtonFire.UseVisualStyleBackColor = true;
            this.ButtonFire.Click += new System.EventHandler(this.ButtonFire_Click);
            // 
            // blood
            // 
            this.blood.BackColor = System.Drawing.Color.Transparent;
            this.blood.Image = ((System.Drawing.Image)(resources.GetObject("blood.Image")));
            this.blood.Location = new System.Drawing.Point(317, 68);
            this.blood.Name = "blood";
            this.blood.Size = new System.Drawing.Size(82, 85);
            this.blood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blood.TabIndex = 3;
            this.blood.TabStop = false;
            this.blood.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 56);
            this.button3.TabIndex = 6;
            this.button3.Text = "Shoot";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Spot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.blood);
            this.Controls.Add(this.ButtonFire);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.images);
            this.Name = "Spot";
            this.Text = "Spot";
            this.Load += new System.EventHandler(this.Spot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox images;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button ButtonFire;
        private System.Windows.Forms.PictureBox blood;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}