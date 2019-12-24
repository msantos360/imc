using System;

class Calculadora{
    private Paciente paciente;

    public Calculadora(Paciente paciente){
        this.paciente = paciente;
    }

    public double imcCalculado(){
        return Math.Round(paciente.peso / (paciente.altura * paciente.altura), 2);
    }
    
}