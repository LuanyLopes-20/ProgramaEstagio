using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            String user = "admin";
            String password = "admin";
            if (txtUser.Text == "" || txtSenha.Text == "")
            {
                label3.Text = "O Login e Senha são obrigatórios";
            } 

               else if (txtUser.Text == user & txtSenha.Text == password)
            {
                MessageBox.Show("Acesso liberado");
                Form1 formMain = new Form1();
                formMain.Show();
                
            }
                else 
            {
                MessageBox.Show("Login ou senha incorretos");
            }
        }
    }
}
