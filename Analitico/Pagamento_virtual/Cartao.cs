﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Pagamento_virtual
{
    internal class Cartao
    {
        public Conta Banco { get; set; }//Forma simplificada de criar um get e set
        public int Numero { get; private set; }
        public string Nome { get; set; }

        public Cartao(int numero)
        {
            Numero=numero;
        }

        public virtual bool Agregar(double valor)//Virtual possibilita a sobreescreve-lo em uma herança
        {
            return false;
        }
    }
}