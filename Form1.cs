using System;

namespace ProyectoU1P2
{
    public partial class frmcvja : Form
    {
        public frmcvja()
        {
            InitializeComponent();
            Program.f1 = this;
        }
        int cont = 0;
        Usuarios[] users = new Usuarios[10];
        private int indice = 0;

        public void comprueba()
        {
            bool usuarioEncontrado = false;
            string nombreUsuario = tbcvjaUser.Text;
            string contrasena = tbcvjaPassword.Text;
            if (tbcvjaUser.Text == "")
            {
                errorName2cvja.SetError(tbcvjaUser, "Introduzca al empleado porfavor");
                if (tbcvjaPassword.Text == "")
                {

                    errorPasscvja.SetError(tbcvjaPassword, "Introduzca el sueldo por hora porfavor");
                }
            }
            else if (tbcvjaPassword.Text == "")
            {
                errorPasscvja.SetError(tbcvjaPassword, "Introduzca el sueldo por hora porfavor");
            }
            else
            {
                errorName2cvja.Clear();
                errorPasscvja.Clear();
                for (int i = 0; i < indice; i++)
                {
                    if (users[i].nombre == nombreUsuario && users[i].contra == contrasena)
                    {
                        usuarioEncontrado = true;
                        MessageBox.Show("Entraste", "Felicidades");
                        tbcvjaUser.Focus();
                        if (Program.f2 == null)
                        {
                            Program.f2 = new frmcvjaCompras(tbcvjaUser.Text);
                        }
                        tbcvjaPassword.Clear();
                        tbcvjaUser.Clear();
                        Program.f2.Show();
                        Program.f1.Hide();
                        break;
                    }
                    else if (!usuarioEncontrado)
                    {
                        cont++;
                        tbcvjaPassword.Clear();
                        tbcvjaUser.Clear();
                        tbcvjaUser.Focus();
                        MessageBox.Show("El usuario y/o contraseña son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (cont == 3)
                        {
                            MessageBox.Show("Excediste el numero de intentos, la aplicacion se cerrara", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }
                }
            }



        }
        private void btncvjaIniciarSesion_Click(object sender, EventArgs e)
        {

            comprueba();
        }

        private void tbcvjaPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comprueba();
            }
        }

        private void tbcvjaUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comprueba();
            }
        }

        private void frmcvja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                String resp = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (resp == "Yes")
                {
                    Application.Exit();
                }
            }
        }

        private void btncvjaRegistrarse_Click(object sender, EventArgs e)
        {
            if (tbcvjaName.Text == "" || tbcvjaAp.Text == "" || tbcvjaContrRegis.Text == "")
            {
                if (tbcvjaName.Text != "")
                {
                    errorName1cvja.Clear();
                }
                if (tbcvjaAp.Text != "")
                {
                    errorApcvja.Clear();
                }
                if (tbcvjaContrRegis.Text != "")
                {
                    errorContracvja.Clear();
                }
                if (tbcvjaName.Text == "" && tbcvjaAp.Text == "" && tbcvjaContrRegis.Text == "")
                {
                    errorName1cvja.SetError(tbcvjaName, "Introduzca los datos porfavor");
                    errorApcvja.SetError(tbcvjaAp, "Introduzca los datos porfavor");
                    errorContracvja.SetError(tbcvjaContrRegis, "Introduzca los datos porfavor");
                }
                else if (tbcvjaAp.Text == "" && tbcvjaContrRegis.Text == "")
                {
                    errorApcvja.SetError(tbcvjaAp, "Introduzca los datos porfavor");
                    errorContracvja.SetError(tbcvjaContrRegis, "Introduzca los datos porfavor");
                }
                else if (tbcvjaContrRegis.Text == "" && tbcvjaName.Text == "")
                {
                    errorName1cvja.SetError(tbcvjaContrRegis, "Introduzca los datos porfavor");
                    errorName1cvja.SetError(tbcvjaName, "Introduzca los datos porfavor");
                }
                else if (tbcvjaAp.Text == "" && tbcvjaName.Text == "")
                {
                    errorApcvja.SetError(tbcvjaName, "Introduzca los datos porfavor");
                    errorName1cvja.SetError(tbcvjaAp, "Introduzca los datos porfavor");
                }
                else if (tbcvjaName.Text == "")
                {
                    errorName1cvja.SetError(tbcvjaName, "Introduzca los datos porfavor");
                }
                else if (tbcvjaAp.Text == "")
                {
                    errorApcvja.SetError(tbcvjaAp, "Introduzca los datos porfavor");
                }
                else if (tbcvjaContrRegis.Text == "")
                {
                    errorContracvja.SetError(tbcvjaContrRegis, "Introduzca los datos porfavor");
                }
            }
            else
            {
                string Name = tbcvjaName.Text;
                string Ap = tbcvjaAp.Text;
                string Contra = tbcvjaContrRegis.Text;
                Usuarios newUser = new Usuarios(Name, Ap, Contra);
                users[indice] = newUser;
                indice++;
                MessageBox.Show("Usuario Agregado");
                tbcvjaName.Clear();
                tbcvjaAp.Clear();
                tbcvjaContrRegis.Clear();
            }

        }
    }
}