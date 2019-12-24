using System;

class CalculadorTipoImc
{
    public TipoImc tipo(double valor){
        
        Imc t1 = new AbaixoDoPeso();
        Imc t2 = new PesoNormal();
        Imc t0 = new SemImc();

        t1.setProximo(t2);
        t2.setProximo(t0);

        return t1.tipoImc(valor);

    }
}