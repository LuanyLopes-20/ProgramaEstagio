using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conex = new SqlConnection(@"Data Source=DESKTOP-CMHH41P; integrated security =SSPI; initial catalog=MeusAlunos");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dados;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textNome.Text == "")
            {
                label6.Text = "O nome do aluno é obrigatório";
            } 

            else if (textNota1.Text == "")
            {
                label7.Text = "A primeira nota é obrigatória";
            }
            else if (textNota2.Text == "")
            {
                label8.Text = "A segunda nota é obrigatória";
            } 
            else {
                int id = 6;
                double nota1 = double.Parse(textNota1.Text);
                double nota2 = double.Parse(textNota2.Text);
                double media = (nota1 + nota2) / 2; 
                if (media < 6.5)
                {
                    label4.Text = "Reprovado";
                    label4.ForeColor = Color.Red;
                }
                else 
                {
                    label4.Text = "Aprovado";
                    label4.ForeColor = Color.Green;
                }

                try
                {
                    conex.Open();
                    string inserSQL = "insert into  DadosAlunos (id, Nome, Nota1, Nota2, Ano) values (@id++, @textNome.text, @textNota1.text', @textNota2.text', '2023')";
                    cm.Parameters.Add("@id", SqlDbType.Int).Value = id++;
                    cm.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textNome.Text;
                    cm.Parameters.Add("@Nota1", SqlDbType.Float).Value = textNota1.Text;
                    cm.Parameters.Add("@Nota2", SqlDbType.Float).Value = textNota2.Text;
                    cm.Parameters.Add("@Ano", SqlDbType.VarChar).Value = "2023";
                   
                    cm.Connection = conex;
                    cm.CommandText = inserSQL;
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados!");

                    cm.Parameters.Clear();
                    conex.Close();
               
                } catch (Exception Erro) { }
            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textNome.Text = "";
            textNota1.Text = "";
            textNota2.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }
    }
}
