// See https://aka.ms/new-console-template for more information

using System;

//O Exercicio consiste em você fazer uma calculadora de Media para seus Alunos da Escola.
//Infelizmente o Beecrowd (antigo uri) não permite eu por parte no código que ele julgue desnecessario. (Só de brincadeira poderia ter usado um .ini para simular um Login e senha KKK, Fica a dica!)

class URI

{

    static void Main(string[] args)
    {

        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        //Foi um pouco confuso, vou ser sincero, porem eu reli a parte varias vezes + de 10, to cansado do dia de hoje, foi um dia muito cansativo, e estudar depois do Trabalho é um pouco díficil.
        //porem eu consegui e ai entendi que não era uma media simples e sim uma Media Ponderada. Tem disso na progamação KKK.
        double media = (A * 3.5 + B * 7.5) / 11;

        //Você que é dos progamas sabe, más para um suposto Entrevistador que esteja vendo, caso não entenda isso é uma pontuação maxima, não permite passar de 10.0!
        if (media >= 10.0)
        {
            media = 10.0;
        }

        Console.WriteLine("MEDIA = " + media.ToString("F5"));
    }
}