namespace ProyectoU1P2
{
    partial class Ticket
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
            lbcvjaComprasFinal = new ListBox();
            lbcvjaPreciosFinal = new ListBox();
            label1 = new Label();
            panel1 = new Panel();
            rbcvjaSi = new RadioButton();
            rbcvjaNo = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbcvjaComprasFinal
            // 
            lbcvjaComprasFinal.FormattingEnabled = true;
            lbcvjaComprasFinal.ItemHeight = 15;
            lbcvjaComprasFinal.Location = new Point(17, 68);
            lbcvjaComprasFinal.Name = "lbcvjaComprasFinal";
            lbcvjaComprasFinal.Size = new Size(681, 169);
            lbcvjaComprasFinal.TabIndex = 0;
            // 
            // lbcvjaPreciosFinal
            // 
            lbcvjaPreciosFinal.FormattingEnabled = true;
            lbcvjaPreciosFinal.ItemHeight = 15;
            lbcvjaPreciosFinal.Location = new Point(704, 68);
            lbcvjaPreciosFinal.Name = "lbcvjaPreciosFinal";
            lbcvjaPreciosFinal.Size = new Size(80, 169);
            lbcvjaPreciosFinal.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 240);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 2;
            label1.Text = "Desea Firmar?";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(rbcvjaNo);
            panel1.Controls.Add(rbcvjaSi);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbcvjaPreciosFinal);
            panel1.Controls.Add(lbcvjaComprasFinal);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 285);
            panel1.TabIndex = 3;
            // 
            // rbcvjaSi
            // 
            rbcvjaSi.AutoSize = true;
            rbcvjaSi.Location = new Point(431, 263);
            rbcvjaSi.Name = "rbcvjaSi";
            rbcvjaSi.Size = new Size(34, 19);
            rbcvjaSi.TabIndex = 3;
            rbcvjaSi.TabStop = true;
            rbcvjaSi.Text = "Si";
            rbcvjaSi.UseVisualStyleBackColor = true;
            // 
            // rbcvjaNo
            // 
            rbcvjaNo.AutoSize = true;
            rbcvjaNo.Location = new Point(299, 263);
            rbcvjaNo.Name = "rbcvjaNo";
            rbcvjaNo.Size = new Size(41, 19);
            rbcvjaNo.TabIndex = 4;
            rbcvjaNo.TabStop = true;
            rbcvjaNo.Text = "No";
            rbcvjaNo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(660, 240);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 5;
            label2.Text = "Total";
            // 
            // label3
            // 
            label3.Location = new Point(704, 240);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 6;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Ticket";
            Text = "Ticket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbcvjaComprasFinal;
        private ListBox lbcvjaPreciosFinal;
        private Label label1;
        private Panel panel1;
        private RadioButton rbcvjaNo;
        private RadioButton rbcvjaSi;
        private Label label3;
        private Label label2;
    }
}