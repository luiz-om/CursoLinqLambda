using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayInteiro
            //int[] numeros = { 701, 2, 3, 4, 5, 6, 74, 18, 9, 4 };


            ////"select campo from tabela;"--sql
            ////
            //var resultado = from num in numeros where num >4 orderby num select num;
            //var resultado2 = numeros.Where(n => n  > 4).OrderBy(x =>x);

            //foreach (var numero in resultado)
            //{

            //        Console.WriteLine("aqui é o numero " + numero);




            //}
            #endregion

            #region ArrayString
            string[] cores = { "Preto", "Branco","Verde","Vermelho", "Azul","Escuro"};


            var resultado = cores.Where(x => x.Contains("e") || x.Contains("z"));
            var resultado2 = from coresss in cores where cores.Contains("e") select cores ;

            foreach (var cor in resultado)
            {
                Console.WriteLine(cor);
            }
            #endregion

            Console.ReadKey();

        }
    }
}
