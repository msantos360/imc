using System;

class ObesidadeGrauIII : Imc
{
    private Imc imc;
    public void setProximo(Imc imc)
    {
        this.imc = imc;
    }

    public TipoImc tipoImc(double calculo)
    {
        if(calculo >= 40){
            return TipoImc.OBESIDADE_GRAL_III;
        }

        return imc.tipoImc(calculo);
    }
}