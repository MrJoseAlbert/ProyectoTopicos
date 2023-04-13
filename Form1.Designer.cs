namespace ProyectoU1P2
{
    partial class frmcvja
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcvja));
            pbcvja = new PictureBox();
            tbcvjaUser = new TextBox();
            tbcvjaPassword = new TextBox();
            lblcvja2 = new Label();
            lblcvja = new Label();
            btncvjaIniciarSesion = new Button();
            btncvjaRegistrarse = new Button();
            label1 = new Label();
            label2 = new Label();
            tbcvjaContrRegis = new TextBox();
            tbcvjaName = new TextBox();
            label3 = new Label();
            tbcvjaAp = new TextBox();
            errorName1cvja = new ErrorProvider(components);
            errorApcvja = new ErrorProvider(components);
            errorContracvja = new ErrorProvider(components);
            errorName2cvja = new ErrorProvider(components);
            errorPasscvja = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbcvja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorName1cvja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorApcvja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorContracvja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorName2cvja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorPasscvja).BeginInit();
            SuspendLayout();
            // 
            // pbcvja
            // 
            pbcvja.Image = Properties.Resources._3d_user_folder_20516;
            pbcvja.Location = new Point(266, 12);
            pbcvja.Name = "pbcvja";
            pbcvja.Size = new Size(163, 150);
            pbcvja.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcvja.TabIndex = 0;
            pbcvja.TabStop = false;
            // 
            // tbcvjaUser
            // 
            tbcvjaUser.Location = new Point(116, 241);
            tbcvjaUser.Name = "tbcvjaUser";
            tbcvjaUser.Size = new Size(163, 23);
            tbcvjaUser.TabIndex = 1;
            tbcvjaUser.KeyDown += tbcvjaUser_KeyDown;
            // 
            // tbcvjaPassword
            // 
            tbcvjaPassword.Location = new Point(116, 285);
            tbcvjaPassword.Name = "tbcvjaPassword";
            tbcvjaPassword.Size = new Size(163, 23);
            tbcvjaPassword.TabIndex = 2;
            tbcvjaPassword.UseSystemPasswordChar = true;
            tbcvjaPassword.KeyDown += tbcvjaPassword_KeyDown;
            // 
            // lblcvja2
            // 
            lblcvja2.AutoSize = true;
            lblcvja2.BackColor = Color.Transparent;
            lblcvja2.Font = new Font("Tw Cen MT Condensed Extra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblcvja2.ForeColor = SystemColors.MenuHighlight;
            lblcvja2.Location = new Point(44, 240);
            lblcvja2.Name = "lblcvja2";
            lblcvja2.Size = new Size(73, 24);
            lblcvja2.TabIndex = 3;
            lblcvja2.Text = "Nombre";
            // 
            // lblcvja
            // 
            lblcvja.AutoSize = true;
            lblcvja.BackColor = Color.Transparent;
            lblcvja.Font = new Font("Tw Cen MT Condensed Extra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblcvja.ForeColor = SystemColors.MenuHighlight;
            lblcvja.Location = new Point(19, 284);
            lblcvja.Name = "lblcvja";
            lblcvja.Size = new Size(97, 24);
            lblcvja.TabIndex = 4;
            lblcvja.Text = "Contraseña";
            // 
            // btncvjaIniciarSesion
            // 
            btncvjaIniciarSesion.Font = new Font("Myanmar Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btncvjaIniciarSesion.Location = new Point(124, 321);
            btncvjaIniciarSesion.Name = "btncvjaIniciarSesion";
            btncvjaIniciarSesion.Size = new Size(148, 51);
            btncvjaIniciarSesion.TabIndex = 6;
            btncvjaIniciarSesion.Text = "Iniciar Sesion";
            btncvjaIniciarSesion.UseVisualStyleBackColor = true;
            btncvjaIniciarSesion.Click += btncvjaIniciarSesion_Click;
            // 
            // btncvjaRegistrarse
            // 
            btncvjaRegistrarse.Font = new Font("Myanmar Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btncvjaRegistrarse.Location = new Point(412, 321);
            btncvjaRegistrarse.Name = "btncvjaRegistrarse";
            btncvjaRegistrarse.Size = new Size(148, 51);
            btncvjaRegistrarse.TabIndex = 7;
            btncvjaRegistrarse.Text = "Registrarse";
            btncvjaRegistrarse.UseVisualStyleBackColor = true;
            btncvjaRegistrarse.Click += btncvjaRegistrarse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(315, 283);
            label1.Name = "label1";
            label1.Size = new Size(97, 24);
            label1.TabIndex = 11;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tw Cen MT Condensed Extra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(340, 198);
            label2.Name = "label2";
            label2.Size = new Size(73, 24);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // tbcvjaContrRegis
            // 
            tbcvjaContrRegis.Location = new Point(412, 284);
            tbcvjaContrRegis.Name = "tbcvjaContrRegis";
            tbcvjaContrRegis.Size = new Size(163, 23);
            tbcvjaContrRegis.TabIndex = 10;
            tbcvjaContrRegis.UseSystemPasswordChar = true;
            // 
            // tbcvjaName
            // 
            tbcvjaName.Location = new Point(412, 199);
            tbcvjaName.Name = "tbcvjaName";
            tbcvjaName.Size = new Size(163, 23);
            tbcvjaName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tw Cen MT Condensed Extra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(338, 239);
            label3.Name = "label3";
            label3.Size = new Size(74, 24);
            label3.TabIndex = 13;
            label3.Text = "Apellido";
            // 
            // tbcvjaAp
            // 
            tbcvjaAp.Location = new Point(412, 240);
            tbcvjaAp.Name = "tbcvjaAp";
            tbcvjaAp.Size = new Size(163, 23);
            tbcvjaAp.TabIndex = 9;
            // 
            // errorName1cvja
            // 
            errorName1cvja.ContainerControl = this;
            // 
            // errorApcvja
            // 
            errorApcvja.ContainerControl = this;
            // 
            // errorContracvja
            // 
            errorContracvja.ContainerControl = this;
            // 
            // errorName2cvja
            // 
            errorName2cvja.ContainerControl = this;
            // 
            // errorPasscvja
            // 
            errorPasscvja.ContainerControl = this;
            // 
            // frmcvja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(703, 480);
            Controls.Add(label3);
            Controls.Add(tbcvjaAp);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(tbcvjaContrRegis);
            Controls.Add(tbcvjaName);
            Controls.Add(btncvjaRegistrarse);
            Controls.Add(btncvjaIniciarSesion);
            Controls.Add(lblcvja);
            Controls.Add(lblcvja2);
            Controls.Add(tbcvjaPassword);
            Controls.Add(tbcvjaUser);
            Controls.Add(pbcvja);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmcvja";
            Text = "Inicio de sesion";
            KeyDown += frmcvja_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbcvja).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorName1cvja).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorApcvja).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorContracvja).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorName2cvja).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorPasscvja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbcvja;
        private TextBox tbcvjaUser;
        private TextBox tbcvjaPassword;
        private Label lblcvja2;
        private Label lblcvja;
        private Button btncvjaIniciarSesion;
        private Button btncvjaRegistrarse;
        private Label label1;
        private Label label2;
        private TextBox tbcvjaContrRegis;
        private TextBox tbcvjaName;
        private Label label3;
        private TextBox tbcvjaAp;
        private ErrorProvider errorName1cvja;
        private ErrorProvider errorApcvja;
        private ErrorProvider errorContracvja;
        private ErrorProvider errorName2cvja;
        private ErrorProvider errorPasscvja;
    }
}