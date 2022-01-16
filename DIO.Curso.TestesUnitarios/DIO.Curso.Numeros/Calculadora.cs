using System;

namespace DIO.Curso.Numeros
{
    public class Calculadora
    {
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        public double Dividir(int numerador, int denominador)
        {
            if (denominador == 0)
                throw new ArgumentException("O denominador não deve ser igual a zero", nameof(denominador));

            return numerador / denominador;
        }
    }
}
