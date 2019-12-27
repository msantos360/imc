using System;
using System.Globalization;

class Calculadora{
    private Paciente paciente;
    private double valor;
    private TipoImc tipoImc;

    public Calculadora(Paciente paciente){
        this.paciente = paciente;

        calculaImc();
        calculatipoImc();
    }
    public string getResultado(){
        return(
            "Paciente: " + paciente.nome +
            "\tResultado IMC: " + valor +
            "\tCategoria: " + tipoImc +
            "\tData: " + getDataFormatada()
         );
    }
    private void calculaImc(){
        this.valor = Math.Round(
            paciente.peso / Math.Pow(paciente.altura, 2),
        2);
    }
    private void calculatipoImc(){
        this.tipoImc = new CalculadorTipoImc().tipo(valor);
    }
    private string getDataFormatada(){
        return DateTime.Now.ToString(new CultureInfo("pt-BR"));
    }
    
}