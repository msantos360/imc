using System;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paciente paulo = new Paciente("Paulo", 33, "M", 42, 1.70);

            Paciente paulo = new PacienteBuilder()
                .comNome("Paulo")
                .comPeso(40.2)
                .comAltura(1.70)
                .comSexo("M")
                .builder();

            Calculadora calculadora = new Calculadora(paulo);
            CalculadorTipoImc c = new CalculadorTipoImc();

            Console.WriteLine("Paciente: " + paulo.nome);
            Console.WriteLine("IMC calculado: " + calculadora.imcCalculado());
            Console.WriteLine("Tipo IMC: " + c.tipo(calculadora.imcCalculado()));
        }
    }
}
