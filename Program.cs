using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Teste__lógica_de_programação_ {
    internal class Program {
        static void Main(string[] args) {
            //Chamando os métodos do exércicio para imprimir o resultado de cada exércicio. 
            Exer01();
            Exer02();
            Exer05();
        }

        //Exércio 01. 
        static public void Exer01() {
            int indice = 13, soma = 0, k = 0;
            while (k < indice) { // Enquanto k for menor que 13, será executado o código abaixo.
                k += 1;
                soma += k;
            }
            Console.WriteLine(soma); //será impresso o número 91. 
        }

        //Exércio 02.
        static public void Exer02() {
            //Declarando as variaveis que serão usadas. 
            int numAtual;
            List<int> listFibo = new List<int>();

            //Recebendo o tamanho da sequência fibo e o número que será consultado. 
            Console.Write("Informe o tamanho da sequência: ");
            int tam = int.Parse(Console.ReadLine());
            Console.Write("Informe o número para consultar na sequência: ");
            int numTeste = int.Parse(Console.ReadLine());

            //Realizando o for para criar a sequência. 
            for (int c = 0; c < tam; c++) {
                numAtual = Calc(c);
                Console.Write($"{numAtual}, ");
                listFibo.Add(numAtual);
            }
            //Consultando se o elemento passado existe na lista. 
            if (listFibo.Any(x => x == numTeste)) {
                Console.WriteLine($"\n\nO número {numTeste} existe na sequência!");
            }
            else {
                Console.WriteLine($"\n\nO número {numTeste} não existe na sequência!");
            }

            //Criando a função que será chamada recursivamente para calcular a sequência fibo. 
            int Calc(int n) {
                if (n < 2) {
                    return n;
                }
                else {
                    return Calc(n - 1) + Calc(n - 2);
                }
            }
        }

        //Exércicio 05
        static public void Exer05() {
            string nome = "Antonio Marques";
            Console.Write($"\nNome {nome} invertido é: ");
            for (int c = nome.Length -1; c >= 0; c--) { // Estou pegando o tamanho da string - 1 porquê todo vetor inicia de zero, e ele irá mostrar cada caracter do último para o primeiro. 
                Console.Write(nome[c]); // 
            }
            Console.WriteLine();
        }

    }
}
