using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros? Ex. 1,63");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em Kg? Ex: 59,3");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso/(altura * altura);

            Console.WriteLine("{0} sua altura é {1} e seu peso é {2}", nome, peso, altura);

            Console.WriteLine("Seu IMC é {0}", imc);

            if(imc < 17){
                Console.WriteLine("Sua situação é muito abaixo do peso");
            }else if(imc < 18.5){
                Console.WriteLine("Sua situação é Abaixo do peso");
            }else if(imc < 25){
                Console.WriteLine("Sua situação é Peso normal");
            }else if(imc < 30){
                Console.WriteLine("Sua situação é Acima do peso");
            }else if(imc < 35){
                Console.WriteLine("Sua situação é Obesidade I");
            }else if(imc < 40){
                Console.WriteLine("Sua situação é Obesidade II (severa)");
            }else
                Console.WriteLine("Sua situação é Obesidade III (mórbida");
        }
    }
}
