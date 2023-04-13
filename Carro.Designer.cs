namespace ProyectoU1P2
{
    partial class Carrocvja
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
            label1 = new Label();
            label2 = new Label();
            lbcvjaProductos = new ListBox();
            lbcvjaPrecios = new ListBox();
            btncvjaQuitar = new Button();
            btncvjaRegresar = new Button();
            btncvjaComprar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(343, 43);
            label1.TabIndex = 0;
            label1.Text = "Carro de compras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 74);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // lbcvjaProductos
            // 
            lbcvjaProductos.FormattingEnabled = true;
            lbcvjaProductos.ItemHeight = 15;
            lbcvjaProductos.Location = new Point(26, 103);
            lbcvjaProductos.Name = "lbcvjaProductos";
            lbcvjaProductos.Size = new Size(673, 259);
            lbcvjaProductos.TabIndex = 2;
            // 
            // lbcvjaPrecios
            // 
            lbcvjaPrecios.FormattingEnabled = true;
            lbcvjaPrecios.ItemHeight = 15;
            lbcvjaPrecios.Location = new Point(715, 103);
            lbcvjaPrecios.Name = "lbcvjaPrecios";
            lbcvjaPrecios.Size = new Size(84, 259);
            lbcvjaPrecios.TabIndex = 3;
            // 
            // btncvjaQuitar
            // 
            btncvjaQuitar.Location = new Point(702, 419);
            btncvjaQuitar.Name = "btncvjaQuitar";
            btncvjaQuitar.Size = new Size(97, 31);
            btncvjaQuitar.TabIndex = 4;
            btncvjaQuitar.Text = "Quitar";
            btncvjaQuitar.UseVisualStyleBackColor = true;
            // 
            // btncvjaRegresar
            // 
            btncvjaRegresar.Location = new Point(12, 419);
            btncvjaRegresar.Name = "btncvjaRegresar";
            btncvjaRegresar.Size = new Size(94, 31);
            btncvjaRegresar.TabIndex = 5;
            btncvjaRegresar.Text = "Regresar";
            btncvjaRegresar.UseVisualStyleBackColor = true;
            btncvjaRegresar.Click += btncvjaRegresar_Click;
            // 
            // btncvjaComprar
            // 
            btncvjaComprar.Location = new Point(348, 406);
            btncvjaComprar.Name = "btncvjaComprar";
            btncvjaComprar.Size = new Size(97, 44);
            btncvjaComprar.TabIndex = 6;
            btncvjaComprar.Text = "Realizar compra";
            btncvjaComprar.UseVisualStyleBackColor = true;
            // 
            // Carrocvja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 462);
            Controls.Add(btncvjaComprar);
            Controls.Add(btncvjaRegresar);
            Controls.Add(btncvjaQuitar);
            Controls.Add(lbcvjaPrecios);
            Controls.Add(lbcvjaProductos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Carrocvja";
            Text = "Carro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lbcvjaProductos;
        private ListBox lbcvjaPrecios;
        private Button btncvjaQuitar;
        private Button btncvjaRegresar;
        private Button btncvjaComprar;
    }
}