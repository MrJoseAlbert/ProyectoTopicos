namespace ProyectoU1P2
{
    partial class Acercade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acercade));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            llinklcvjaProovedores = new LinkLabel();
            linklcvjaYoutube = new LinkLabel();
            linklcvjaFace = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(220, 9);
            label1.Name = "label1";
            label1.Size = new Size(424, 76);
            label1.TabIndex = 0;
            label1.Text = "Tech Tower";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(319, 85);
            label2.Name = "label2";
            label2.Size = new Size(208, 23);
            label2.TabIndex = 1;
            label2.Text = "Tienda de PCs y mas...";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // llinklcvjaProovedores
            // 
            llinklcvjaProovedores.AutoSize = true;
            llinklcvjaProovedores.Location = new Point(235, 125);
            llinklcvjaProovedores.Name = "llinklcvjaProovedores";
            llinklcvjaProovedores.Size = new Size(193, 15);
            llinklcvjaProovedores.TabIndex = 3;
            llinklcvjaProovedores.TabStop = true;
            llinklcvjaProovedores.Text = "Visita la tienda de nuestro provedor";
            llinklcvjaProovedores.LinkClicked += llinklcvjaProovedores_LinkClicked;
            // 
            // linklcvjaYoutube
            // 
            linklcvjaYoutube.AutoSize = true;
            linklcvjaYoutube.Location = new Point(235, 151);
            linklcvjaYoutube.Name = "linklcvjaYoutube";
            linklcvjaYoutube.Size = new Size(51, 15);
            linklcvjaYoutube.TabIndex = 4;
            linklcvjaYoutube.TabStop = true;
            linklcvjaYoutube.Text = "Youtube";
            linklcvjaYoutube.LinkClicked += linklcvjaYoutube_LinkClicked;
            // 
            // linklcvjaFace
            // 
            linklcvjaFace.AutoSize = true;
            linklcvjaFace.Location = new Point(235, 180);
            linklcvjaFace.Name = "linklcvjaFace";
            linklcvjaFace.Size = new Size(58, 15);
            linklcvjaFace.TabIndex = 5;
            linklcvjaFace.TabStop = true;
            linklcvjaFace.Text = "Facebook";
            linklcvjaFace.LinkClicked += linklcvjaFace_LinkClicked;
            // 
            // Acercade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 241);
            Controls.Add(linklcvjaFace);
            Controls.Add(linklcvjaYoutube);
            Controls.Add(llinklcvjaProovedores);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Acercade";
            Text = "Acercade";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private LinkLabel llinklcvjaProovedores;
        private LinkLabel linklcvjaYoutube;
        private LinkLabel linklcvjaFace;
    }
}