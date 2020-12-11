using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace GALF
{
    public class DadosPedidos
    {
        Queue<string> listaPedidos = new Queue<string>();

        public void SalvarDados()
        {
            listaPedidos.Enqueue("Guilherme");
            listaPedidos.Enqueue("Alisson");

            ExibirPedidos();
        }

        public string ExibirPedidos()
        {
            try
            {
                if(listaPedidos.Count > 0)
                {
                    return listaPedidos.ToString();
                }
                else
                {
                    return "Nenhum pedido!";
                }
            }
            catch
            {
                return "O sistema não está acessando os pedidos.";
            }
        }
    }
}
