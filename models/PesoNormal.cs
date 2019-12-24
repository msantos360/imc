using System;

class PesoNormal : Imc
{
    private Imc imc;
    public void setProximo(Imc imc)
    {
        this.imc = imc;
    }

    public TipoImc tipoImc(double calculo)
    {
        if(calculo >= 18.5 && calculo < 24.99){
            return TipoImc.PESO_NORMAL;
        }

        return imc.tipoImc(calculo);
    }
}