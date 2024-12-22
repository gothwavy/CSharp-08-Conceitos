using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_GetSet
{
    internal class Pessoa
    {
        // Atributo nome
        private string nome;

        // Get e Set
        public string Nome
        {
            //Get -> Usado para pegar uma informacao
            get
            {
                return nome;
            }

            //Set -> Usado para enviar uma informacao
            set
            {
                nome = value;
            }
        }
    }
}
