using System;

class AbaixoDoPeso : Imc
{
    private Imc imc;
    public void setProximo(Imc imc)
    {
        this.imc = imc;
    }

    public TipoImc tipoImc(double calculo)
    {
        if(calculo <= 18.49){
            return TipoImc.ABAIXO_DO_PESO;
        }

        return imc.tipoImc(calculo);
    }
}