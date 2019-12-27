using System;

class ObesidadeGrauI : Imc
{
    private Imc imc;
    public void setProximo(Imc imc)
    {
        this.imc = imc;
    }

    public TipoImc tipoImc(double calculo)
    {
        if(calculo >= 30 && calculo < 34.99){
            return TipoImc.OBESIDADE_GRAL_I;
        }

        return imc.tipoImc(calculo);
    }
}