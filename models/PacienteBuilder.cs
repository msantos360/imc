using System;
class PacienteBuilder
{
    private string nome;

    private int idade;

    private string sexo;

    private double peso;

    private double altura;

    public PacienteBuilder comNome(string nome){
        this.nome = nome;
        return this;
    }

    public PacienteBuilder comIdade(int idade){
        this.idade = idade;
        return this;
    }

    public PacienteBuilder comSexo(string sexo){
        this.sexo = sexo;
        return this;
    }

    public PacienteBuilder comPeso(double peso){
        this.peso = peso;
        return this;
    }

    public PacienteBuilder comAltura(double altura){
        this.altura = altura;
        return this;
    }

    public Paciente builder(){
        return new Paciente(nome, idade, sexo, peso, altura);
    }

}