using System;
using System.Collections.Generic;

namespace ex029 {
    class Program {
        static void Main(string[] args) 
        {
            int aspas_abertas = 0, aspas_fechadas = 0;

            List<char> aspas = new List<char>();
            List<char> aspas2 = new List<char>();

            Console.WriteLine("Input a expression: ");
            string expression = Console.ReadLine();

            foreach (char letter  in expression)
            {
                if (letter == '(')
                {
                    aspas.Add('(');  
                }
                if (letter == ')')
                {
                    aspas2.Add(')');
                }
            }
            foreach (char aspa in aspas2)
            {
             if (aspas.Count > 0)
                {
                    aspas.RemoveAt(aspas.Count-1);
                }                               
            }

            if (aspas.Count > 0  ) {
                Console.WriteLine("A operação é INVÁLIDA!");
            }
            else if (aspas.Count == 0 ) {
                Console.WriteLine("A operação é VÁLIDA!");
            }
        }
    }
}
