Console.WriteLine("Digite seu altura: ");
Double Altura = Convert.ToDouble(Console.ReadLine());   
Console.WriteLine("Digite seu peso: ");
Double Peso = Convert.ToDouble(Console.ReadLine()); 

Pessoa p1 = new Pessoa(Altura,Peso);

Console.WriteLine("Seu Imc: {0}", p1.Imc);

Console.WriteLine("Sua situação é {0}", p1.SituacaoPeso());
if(p1.CalculoPesoIdeal() > 0.0)
{
    Console.WriteLine("Você precisa ganhar {0} Kg para atingir um peso ideal",p1.CalculoPesoIdeal());
}else
{
    Console.WriteLine("Você precisa Perder {0} Kg para atingir um peso ideal",p1.CalculoPesoIdeal()*(-1));
}


