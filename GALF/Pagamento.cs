using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GALF
{
    public partial class Pagamento : Form
    {
        public Pagamento()
        {
            InitializeComponent();

            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {
            string[] pedidoitens = new string[3];

            pedidoitens[0] = "01";
            pedidoitens[1] = "Guilherme";
            dataGridView1.Rows.Add(pedidoitens);

            pedidoitens[0] = "02";
            pedidoitens[1] = "Alisson";
            dataGridView1.Rows.Add(pedidoitens);

            pedidoitens[0] = "03";
            pedidoitens[1] = "Luiz Fernando";
            dataGridView1.Rows.Add(pedidoitens);
        }

        private void BasedeDados(string x)
        {
            string[,] pedidoitens = new string[3,4];

            pedidoitens[0,0] = "01";
            pedidoitens[0,1] = "Guilherme";
            pedidoitens[0,2] = "Av. José Messias de Paula França - 522";
            pedidoitens[0,3] = "12992147422";
            dataGridView1.Rows.Add(pedidoitens);

            pedidoitens[0,0] = "02";
            pedidoitens[0,1] = "Alisson";
            pedidoitens[0,2] = "Rua Corifeu de Azevedo Marques - 522";
            pedidoitens[0,3] = "12991964781";
            dataGridView1.Rows.Add(pedidoitens);

            pedidoitens[0,0] = "03";
            pedidoitens[0,1] = "Luiz Fernando";
            pedidoitens[0,2] = "Rua Porteira";
            pedidoitens[0,3] = "12992478599";
            dataGridView1.Rows.Add(pedidoitens);

            for(int i = 0; i < pedidoitens.Length; i++)
            {
                if(pedidoitens[i,1].Equals(x))
                {
                    listBox1.Items.Add(pedidoitens[i,2]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1 || e.ColumnIndex == 0)
            {
                textBox1.Text = (string)dataGridView1.CurrentRow.Cells[1].Value;
                listBox1.Items.Add((string)dataGridView1.CurrentRow.Cells[1].Value);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}
