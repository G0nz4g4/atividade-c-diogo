using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int questoes = 0;

            do {
            Console.WriteLine("Informe em números qual questão quer fazer, sendo 1 para primeira questão \ne assim sucessivamente até a questão 9. Para Sair do programa, informar o numero 0.");
            questoes = int.Parse(Console.ReadLine());

                switch (questoes) {
                    case 1:

                        Console.WriteLine("Informe em numeros os graus Celsius que você quer transformas em Fahrenheit.");
                        double c = double.Parse(Console.ReadLine());
                        double f = (9 * c + 160) / 5;
                        Console.WriteLine("{0}º Celsius transformado em Fahrenheit, ficam {1}º Fahrenheit!", c, f);
                         break;

                    case 2:

                        Console.WriteLine("Informe em números quantas horas você dá em 1 aula.");
                        double quntHora = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe em números Quantas aulas você deu no mês.");
                        double quntAula = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o Preço da Hora aula.");
                        double precoAula = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe em números a porcentagem de desconto do INSS.");
                        double porcInss = (double.Parse(Console.ReadLine()) /100);

                        double salario = ((quntHora * quntAula) * precoAula) - (((quntHora * quntAula) * precoAula) * porcInss);

                        Console.WriteLine("Seu salário ficou em {0} R$.",salario);
                        break;

                    case 3:

                        Console.WriteLine("Informe o numero.");
                        double numquestres = double.Parse(Console.ReadLine());

                        if (numquestres % 2 == 0) {
                            Console.WriteLine(Math.Sqrt(numquestres));
                        } else
                        {
                            Console.WriteLine((numquestres*numquestres));
                        }
                        break;

                    case 4:

                        const double pi = 3.1415;

                        Console.WriteLine("Informe o valor do Raio.");
                        double raio = double.Parse(Console.ReadLine());
                        double area = pi * (raio*raio);

                        Console.WriteLine("O valor da área é {0}", area);
                        break;

                    case 5:

                        Console.WriteLine("Informe o ano de nascimento.");
                        int anoNas = int.Parse(Console.ReadLine());
                        int anoAtual = DateTime.Now.Year;

                        int idadeAtual = anoAtual - anoNas;
                        int idade2022 = 2022 - anoNas;

                        Console.WriteLine("Sua idade atual é: {0}", idadeAtual);
                        Console.WriteLine("Sua idade em 2022 é: {0}", idade2022);
                        break;

                    case 6:

                        Console.WriteLine("Informe o preço de fábrica do veículo.");
                        double precoFab = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o percentual de lucro do distribuidor.");
                        double lucroDist = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o percentual de imposto aplicado.");
                        double imposto = double.Parse(Console.ReadLine());

                        double valorFinal = precoFab + (precoFab*(lucroDist/100)) + (precoFab*(imposto/100));

                        Double lucroFinal = (precoFab*(lucroDist/100));
                        double impostoFinal = (precoFab*(imposto/100));

                        Console.WriteLine("O Valor correspondente do lucro do distribuidor é de R$ {0}. \nO valor correspondente aos Impostos é de R$ {1}. \nO preço final do veículo é de R$ {2}.", lucroFinal, impostoFinal, valorFinal);
                        break;
                    

                    case 7:

                        Console.WriteLine("Informe a altura do degrau ao qual irá subir.");
                        double altDegrau = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a altura ao qual irá subir.");
                        double altDesejada = double.Parse(Console.ReadLine());

                        double qtnDegrau = altDesejada /altDegrau; 
                        int qntint = (int)qtnDegrau;
                        Console.WriteLine("Você irá subir {0} Degraus.", qntint);
                        break;

                    case 8:

                        Console.WriteLine("Informe o número de horas trabalhadas.");
                        int horasTrab = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o salário mínimo atual.");
                        double salMinimo = double.Parse(Console.ReadLine());

                        double precoHoraTrab = salMinimo / 2; 
                        double salBruto = (double)horasTrab * precoHoraTrab;
                        double impostoQuestao8 = (3/100) * salBruto;
                        Double salarioFinal8 = salBruto - impostoQuestao8;

                        Console.WriteLine("O seu salário é de R$ {0}.",salarioFinal8);
                        break;

                    case 9:

                        int valor = 1;

                        Console.WriteLine("Escolha um valor de 1 até 4");
                        valor = int.Parse(Console.ReadLine());

                        if (valor >= 1 && valor <= 4) {
                            switch (valor) {
                            case 1:
                                Console.WriteLine("Você Ganhou um PlayStation 4! Parabens!");
                            break;

                            case 2:
                                Console.WriteLine("Você Ganhou um Double Cheddar Cremoso da McDonalds! Parabens!");
                            break;

                            case 3:
                                Console.WriteLine("Você Ganhou um Abraço do prof diogo! Parabens!");
                            break;

                            case 4:
                                Console.WriteLine("Você Ganhou um grande e enorme par de chifres, tipico de recifense! Parabens!");
                            break;
                            }
                        } else { 

                            Console.WriteLine("Valor escolhido diferente do exigido!");
                        }
                        break;


                }

            } while (questoes != 0);

        }
    }
}
