using System;

class ObesidadeGrauII : Imc
{
    private Imc imc;
    public void setProximo(Imc imc)
    {
        this.imc = imc;
    }

    public TipoImc tipoImc(double calculo)
    {
        if(calculo >= 35 && calculo < 39.99){
            return TipoImc.OBESIDADE_GRAL_II;
        }

        return imc.tipoImc(calculo);
    }
}