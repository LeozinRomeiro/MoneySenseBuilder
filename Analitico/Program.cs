﻿using Analitico.Usuarios;
using Analitico.Pagamento_virtual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analitico.Sistema;

namespace Analitico
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cadastrar();

            Console.ReadLine();

        }
        public static void Cadastrar()
        {
            Usuario Leonardo = new Usuario();

            Leonardo.CPF = "143.526.119-48";
            Leonardo.Nome = "Leonardo Henrique";

            DateTime variavel = new DateTime(2011, 7, 10);
            Console.WriteLine("Today is " + variavel.ToString("MM/yy") + ".");

            Credito roxo = new Credito(9395, variavel, 213, 2568, "NuBank");
        }
    }
}
