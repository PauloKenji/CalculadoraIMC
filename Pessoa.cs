public class Pessoa{
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double Imc { get => Peso/(Altura * Altura);}

    public Pessoa(double altura, double peso)
    {
        Altura = altura;
        Peso = peso;
    }

    public String SituacaoPeso()
    {
        if(Imc < 17)
            {
               return "muito abaixo do Peso";
            }else if(Imc < 18.5)
            {
                return "Abaixo do Peso";
            }else if(Imc < 25)
            {
                return "Peso normal";
            }else if(Imc < 30)
            {
                return "Acima do Peso";
            }else if(Imc < 35)
            {
                return "Obesidade I";
            }else if(Imc < 40)
            {
               return "Obesidade II (severa)";
            }else
            {
                return "Obesidade III (mórbida)";
            }

    }
    public double CalculoPesoIdeal()
    {        
        double PesoIdeal = 0;

        if(Imc < 18.5)
        {
            PesoIdeal = (18.5*(Altura*Altura)) - Peso;
            return PesoIdeal;
        }else if(Imc >= 25)
        { 
            PesoIdeal = (24.99*(Altura*Altura) - Peso);
            return PesoIdeal;
        }
            return 0;
    }
}