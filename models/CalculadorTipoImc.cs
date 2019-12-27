using System;

class CalculadorTipoImc
{
    public TipoImc tipo(double valor){
        
        Imc t1 = new AbaixoDoPeso();
        Imc t2 = new PesoNormal();
        Imc t3 = new SobrePeso();
        Imc t4 = new ObesidadeGrauI();
        Imc t5 = new ObesidadeGrauII();
        Imc t6 = new ObesidadeGrauIII();
        Imc semImc = new SemImc();

        t1.setProximo(t2);
        t2.setProximo(t3);
        t3.setProximo(t4);
        t4.setProximo(t5);
        t5.setProximo(t6);
        t6.setProximo(semImc);

        return t1.tipoImc(valor);
    }
}