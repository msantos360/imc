using System;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paulo = new Paciente("Paulo", 33, "M", 42, 1.70);

            Calculadora calculadora = new Calculadora(paulo);

            Console.WriteLine(paulo.nome);
            Console.WriteLine(calculadora.imcCalculado());
        }
    }
}
