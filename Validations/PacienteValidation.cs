using System;

class PacienteValidadtion
{
    private Paciente paciente;

    public PacienteValidadtion(Paciente paciente){
        this.paciente = paciente;

        nome();
        idade();
        peso();
        altura();
    }
    private void nome(){
        if(paciente.nome == null){
            throw new ArgumentException("O nome do paciente deve ser informado.");
        }
    }
    private void idade(){
        if(paciente.idade <= 0 || paciente.idade > 120){
            throw new ArgumentException("Idade informada é inválida ou não foi informada.");
        }
    }
    private void peso(){
        if(paciente.peso <= 0 || paciente.peso > 500){
            throw new ArgumentException("Peso informado é inválido ou não foi informado.");
        }
    }
    private void altura(){
        if(paciente.altura <= 0 || paciente.altura > 3){
            throw new ArgumentException("Altura informada é inválida ou não foi informada.");
        }
    }

}