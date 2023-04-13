namespace ProyectoU1P2
{
    partial class frmcvjaCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcvjaCompras));
            cvjaMenu = new MenuStrip();
            carroToolStripMenuItem = new ToolStripMenuItem();
            verCarroToolStripMenuItem = new ToolStripMenuItem();
            vaciarCarroToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            clbcvjaProductosDisp = new CheckedListBox();
            gbcvja = new GroupBox();
            combcvjaProductos = new ComboBox();
            label1 = new Label();
            pbcvja = new PictureBox();
            label2 = new Label();
            lblcvjaPrecio = new Label();
            btncvjaAgregar = new Button();
            cvjaMenu.SuspendLayout();
            gbcvja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbcvja).BeginInit();
            SuspendLayout();
            // 
            // cvjaMenu
            // 
            cvjaMenu.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cvjaMenu.Items.AddRange(new ToolStripItem[] { carroToolStripMenuItem, acercaDeToolStripMenuItem });
            cvjaMenu.Location = new Point(0, 0);
            cvjaMenu.Name = "cvjaMenu";
            cvjaMenu.Size = new Size(942, 25);
            cvjaMenu.TabIndex = 0;
            cvjaMenu.Text = "menuStrip1";
            // 
            // carroToolStripMenuItem
            // 
            carroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verCarroToolStripMenuItem, vaciarCarroToolStripMenuItem });
            carroToolStripMenuItem.Name = "carroToolStripMenuItem";
            carroToolStripMenuItem.Size = new Size(55, 21);
            carroToolStripMenuItem.Text = "Carro";
            // 
            // verCarroToolStripMenuItem
            // 
            verCarroToolStripMenuItem.Name = "verCarroToolStripMenuItem";
            verCarroToolStripMenuItem.Size = new Size(154, 22);
            verCarroToolStripMenuItem.Text = "Ver Carro";
            verCarroToolStripMenuItem.Click += verCarroToolStripMenuItem_Click;
            // 
            // vaciarCarroToolStripMenuItem
            // 
            vaciarCarroToolStripMenuItem.Name = "vaciarCarroToolStripMenuItem";
            vaciarCarroToolStripMenuItem.Size = new Size(154, 22);
            vaciarCarroToolStripMenuItem.Text = "Vaciar Carro";
            vaciarCarroToolStripMenuItem.Click += vaciarCarroToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(82, 21);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // clbcvjaProductosDisp
            // 
            clbcvjaProductosDisp.CheckOnClick = true;
            clbcvjaProductosDisp.FormattingEnabled = true;
            clbcvjaProductosDisp.Location = new Point(6, 22);
            clbcvjaProductosDisp.Name = "clbcvjaProductosDisp";
            clbcvjaProductosDisp.Size = new Size(599, 156);
            clbcvjaProductosDisp.TabIndex = 1;
            clbcvjaProductosDisp.ItemCheck += clbcvjaProductosDisp_ItemCheck;
            clbcvjaProductosDisp.SelectedIndexChanged += clbcvjaProductosDisp_SelectedIndexChanged;
            // 
            // gbcvja
            // 
            gbcvja.BackColor = Color.Transparent;
            gbcvja.Controls.Add(clbcvjaProductosDisp);
            gbcvja.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            gbcvja.ForeColor = Color.White;
            gbcvja.Location = new Point(42, 93);
            gbcvja.Name = "gbcvja";
            gbcvja.Size = new Size(611, 196);
            gbcvja.TabIndex = 2;
            gbcvja.TabStop = false;
            gbcvja.Text = "Productos Disponibles";
            // 
            // combcvjaProductos
            // 
            combcvjaProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            combcvjaProductos.Font = new Font("Tw Cen MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combcvjaProductos.FormattingEnabled = true;
            combcvjaProductos.Items.AddRange(new object[] { "Audifonos", "Laptops", "Mouses", "PC's Escritorio", "Teclados" });
            combcvjaProductos.Location = new Point(713, 52);
            combcvjaProductos.Name = "combcvjaProductos";
            combcvjaProductos.Size = new Size(172, 27);
            combcvjaProductos.Sorted = true;
            combcvjaProductos.TabIndex = 4;
            combcvjaProductos.SelectedIndexChanged += combcvjaProductos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(713, 30);
            label1.Name = "label1";
            label1.Size = new Size(116, 19);
            label1.TabIndex = 5;
            label1.Text = "Tipo de Producto";
            // 
            // pbcvja
            // 
            pbcvja.Location = new Point(671, 93);
            pbcvja.Name = "pbcvja";
            pbcvja.Size = new Size(251, 270);
            pbcvja.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcvja.TabIndex = 6;
            pbcvja.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(42, 304);
            label2.Name = "label2";
            label2.Size = new Size(85, 31);
            label2.TabIndex = 7;
            label2.Text = "Precio:";
            // 
            // lblcvjaPrecio
            // 
            lblcvjaPrecio.Font = new Font("Tw Cen MT", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblcvjaPrecio.Location = new Point(133, 304);
            lblcvjaPrecio.Name = "lblcvjaPrecio";
            lblcvjaPrecio.Size = new Size(174, 31);
            lblcvjaPrecio.TabIndex = 8;
            lblcvjaPrecio.Text = "0";
            // 
            // btncvjaAgregar
            // 
            btncvjaAgregar.Location = new Point(519, 300);
            btncvjaAgregar.Name = "btncvjaAgregar";
            btncvjaAgregar.Size = new Size(134, 31);
            btncvjaAgregar.TabIndex = 9;
            btncvjaAgregar.Text = "Agregar al carro";
            btncvjaAgregar.UseVisualStyleBackColor = true;
            btncvjaAgregar.Click += btncvjaAgregar_Click;
            // 
            // frmcvjaCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 406);
            Controls.Add(btncvjaAgregar);
            Controls.Add(lblcvjaPrecio);
            Controls.Add(label2);
            Controls.Add(pbcvja);
            Controls.Add(label1);
            Controls.Add(combcvjaProductos);
            Controls.Add(gbcvja);
            Controls.Add(cvjaMenu);
            MainMenuStrip = cvjaMenu;
            Name = "frmcvjaCompras";
            ShowIcon = false;
            Text = "Bienvenido:";
            cvjaMenu.ResumeLayout(false);
            cvjaMenu.PerformLayout();
            gbcvja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbcvja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip cvjaMenu;
        private ToolStripMenuItem carroToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private CheckedListBox clbcvjaProductosDisp;
        private GroupBox gbcvja;
        private ComboBox combcvjaProductos;
        private Label label1;
        private PictureBox pbcvja;
        private ToolStripMenuItem verCarroToolStripMenuItem;
        private ToolStripMenuItem vaciarCarroToolStripMenuItem;
        private Label label2;
        private Label lblcvjaPrecio;
        private Button btncvjaAgregar;
    }
}