using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeInstrumentos.Entities
{
    internal class Loja_Instrumentos 
    {
        private List<Instrumentos> instrumentos = new List<Instrumentos>();
        private List<Clientes> clientes = new List<Clientes>();



        public void AddCliente(Clientes cli)
        {
            clientes.Add(cli);
        }


        public void AddInstrumento(Instrumentos inst)
        { 
            instrumentos.Add(inst);
        }

        public void listarClientes()
        {

            foreach (Clientes cli in clientes)
            {

                cli.ExibirDetalhes();

            }

        }


        public void listarInstrumentos() 
        {
          
            foreach (Instrumentos ins in instrumentos)
            {   
              
                ins.ExiberDetalhes();
                                    
            }
        
        }
    }
}
