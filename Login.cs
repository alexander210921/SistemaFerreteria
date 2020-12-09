using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas
{
    public partial class Login : Form
    {
        Users us = new Users();
        Inicio start = new Inicio();
        IDuser user = new IDuser();
        public static  bool Acce;
        
        public Login()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            us.verificarusuario(textBox1.Text,textBox2.Text);
            if (us.rpt==true)
            {                
                user.IDus(textBox1.Text, textBox2.Text);
                us.verificarROL(textBox1.Text, textBox2.Text);
                if (Users.acceso.Equals("Vendedor")) {
                    Login.Acce = false;  
                } 
                if (Users.acceso.Equals("Administrador")) {
                    Login.Acce = true;
                }
                start.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
