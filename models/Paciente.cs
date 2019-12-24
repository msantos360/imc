using System;

class Paciente
{
    public string nome { get; }

    public int idade { get; }

    public string sexo { get; }

    public double peso { get; }

    public double altura { get; }

    public Paciente(string nome,
        int idade,
        string sexo,
        double peso,
        double altura)
    {
        this.nome = nome;
        this.idade = idade;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
    }

}