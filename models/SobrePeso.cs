using System;
class SobrePeso : Imc
{
    private Imc imc;

    public void setProximo(Imc imc)
    {
        this.imc = imc;
    }

    public TipoImc tipoImc(double calculo)
    {
        if(calculo >= 25 && calculo < 29.99){
            return TipoImc.SOBREPESO;
        }

        return imc.tipoImc(calculo);
    }
}