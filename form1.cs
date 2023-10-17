using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasticFeedback__FF_
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        //crea una funcion para verificar que un correo este escrito correctamente 
        public static bool IsValidEmail(string email)
        {
            try
            {
                //crea una variable para verificar que el mail tenga un @
                var addr = new System.Net.Mail.MailAddress(email);
                //si el mail tiene un @, retorna true
                return addr.Address == email;
            }
            catch
            {
                //si el mail no tiene un @, retorna false
                return false;
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(txtMail.Text != "" && txtContraseña.Text != "")
            {
                if (IsValidEmail(txtMail.Text) == true || txtMail.Text == "TitoSTG")
                {
                    //crea una validacion para el ingreso correcto del mail y la contraseña
                    if (txtMail.Text == "FantasticFeedback@gmail.com" && txtContraseña.Text == "admin" || txtMail.Text == "TitoSTG" && txtContraseña.Text == "admin")
                    {
                        //si el mail y la contraseña son correctos, se abre el form2
                        inicio f2 = new inicio();
                        f2.Show();
                        this.Hide();
                    }
                    else
                    {
                        //si el mail y la contraseña son incorrectos, se muestra un mensaje de error
                        txtMail.LineIdleColor = Color.Red;
                        txtContraseña.LineIdleColor = Color.Red;
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
                else
                {
                    //si el mail no esta escrito correctamente, se muestra un mensaje de error
                    txtMail.LineIdleColor = Color.Red;
                    MessageBox.Show("Ingrese un mail o usuario valido");
                }

            }
            else
            {
                txtMail.LineIdleColor = Color.Red;
                txtContraseña.LineIdleColor = Color.Red;
                MessageBox.Show("Ingrese un mail y una contraseña");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            txtMail.Text = "";
            txtContraseña.Text = "";
            txtMail.ForeColor = Color.White;
            txtContraseña.ForeColor = Color.White;
        }
    }
}
