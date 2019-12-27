using System;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paulo = new PacienteBuilder()
                .comNome("Paulo Lopes")
                .comPeso(62)
                .comAltura(1.70)
                .comIdade(25)
                .comSexo(TipoSexo.MASCULINO)
                .builder();

            Console.WriteLine(new Calculadora(paulo).getResultado());
        }
    }
}
