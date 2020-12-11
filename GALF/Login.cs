using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace GALF
{
    public partial class Login : Form
    {
        private int linhas = 0;
        public Login()
        {
            InitializeComponent();
        }

        public void Sair()
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;User Id=root;database=galf; password=");
                conn.Open();
                //COMANDOS DE CONEXAO COM O BANCO DE DADOS
                MySqlCommand comando = new MySqlCommand("select * from Login where login='"+textBoxLogin+"' and senha='"+textBoxSenha+"'");
                comando.CommandType = CommandType.Text;
                MySqlDataReader dr;
                dr = comando.ExecuteReader();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(dt);
                linhas = Convert.ToInt32(dt.Rows.Count.ToString());

                conn.Close();
                if(linhas != 0)
                {
                    this.Hide();
                    Form1 fm = new Form1();
                    fm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Dados incorretos", "Erro",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                    textBoxLogin.Text = "";
                    textBoxSenha.Text = "";
                    textBoxLogin.Focus();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Informação:\n"+erro, "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
