using System;
using System.Collections.Generic;

namespace AprendendoSobreTestes
{
    public class Calculadora
    {
        private List<string> ListHistorico;
        private string Data;

        public Calculadora(string data)
        {
            ListHistorico = new List<string>();
            Data = data;

        }

        public int Somar(int val1, int val2)
        {
            
            int resultado = val1 + val2;
            ListHistorico.Insert(0, "Res: " + resultado + "- data: " + Data);

            return resultado;
        }

        public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            ListHistorico.Insert(0, "Res: " + resultado + "- data: " + Data);

            return resultado;
        }

        public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            ListHistorico.Insert(0, "Res: " + resultado + "- data: " + Data);

            return resultado;
        }

        public int Dividir(int val1, int val2)
        {
            int resultado = val1 / val2;
            ListHistorico.Insert(0, "Res: " + resultado + "- data: " + Data);

            return resultado;
        }

        public List<string> Historico()
        {
            ListHistorico.RemoveRange(3, ListHistorico.Count - 3);
                
            return ListHistorico;
        }

    }
}
