using System;

class Calculadora{
    private Paciente paciente;

    public Calculadora(Paciente paciente){
        this.paciente = paciente;
    }

    public double imcCalculado(){
        return Math.Round(paciente.peso / Math.Pow(paciente.altura, 2), 2);
    }
    
}