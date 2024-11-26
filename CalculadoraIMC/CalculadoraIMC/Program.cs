using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double peso;
            double imc;

            Console.Write("Escreva sua ALTURA: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Escreva seu PESO: ");
            peso = double.Parse(Console.ReadLine());

            imc = (peso / (altura * altura));

            if (imc < 17)
            {
                Console.WriteLine("Seu IMC é: " + imc + "\n" + "Você está MUITO abaixo do peso");
            }
            else if (imc >= 17 && imc <= 18.49)
            {
                Console.WriteLine("Seu IMC é: " + imc + "\n" + "Você está abaixo do peso");
            }
            else if (imc >= 18.5 && imc <= 24.99)
            {
                Console.WriteLine("Seu IMC é: " + imc + "\n" + "Você está com o peso normal");
            }
            else if (imc >= 25 && imc <= 29.99)
            {
                Console.WriteLine("Seu IMC é: " + imc + "\n" + "Você está acima do peso");
            }
            else if (imc >= 30 && imc <= 34.99)
            {
                Console.WriteLine("Seu IMC é: " + imc + "\n" + "Obesidade I");
            }
            else if (imc >= 35 && imc <= 39.99)
            {
                Console.WriteLine("Seu IMC é: " + imc + "\n" + "Obesidade II");
            }
            else if (imc >= 40)
            {
                Console.WriteLine("Seu IMC é: " + imc + "\n" + "Obesidade III");
            }
            Console.ReadLine();
        }
    }
}
