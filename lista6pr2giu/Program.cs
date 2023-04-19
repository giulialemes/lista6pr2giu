using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace lista6pr2giu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine(" ========== MENU ============ ");
            Console.WriteLine(" 1 - EXERCÍCIO 1 ");
            Console.WriteLine(" 2 - EXERCÍCIO 2 ");
            Console.WriteLine(" 3 - EXERCÍCIO 3 ");
            Console.WriteLine(" 4 - EXERCÍCIO 4 ");
            Console.WriteLine(" 5 - EXERCÍCIO 5 ");
            Console.WriteLine(" 6 - EXERCÍCIO 6 ");
            Console.WriteLine(" 7 - EXERCÍCIO 7 ");
            Console.WriteLine(" ========================= ");

            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    float quantproduto, valorprod, valorfinal = 0, quant = 0;
                    int i;

                    for (i = 1; ; i++)
                    {
                        Console.WriteLine("Digite a quantidade de produtos: ");
                        quantproduto = float.Parse(Console.ReadLine());
                        if (quantproduto == 0)
                        {
                            break;
                        }

                        Console.WriteLine("Digite o preço de cada produto: ");
                        valorprod = float.Parse(Console.ReadLine());

                        valorfinal += quantproduto * valorprod;
                        quant += quantproduto;

                        Console.WriteLine("A quantidade de produtos  é: " + quant);
                        Console.WriteLine("O total é: " + valorfinal);

                    }

                    break;

                case 2:
                    String nome, nomemenor = " ", nomemaior = "";
                    int numitens, parada = 2;
                    float preco, menorvalor, maiorvalor;

                    menorvalor = float.MaxValue;
                    maiorvalor = float.MinValue;

                    for (; parada != 1;)//laço infinito
                    {
                        Console.WriteLine("Informe o nome do produto: ");
                        nome = Console.ReadLine();

                        Console.WriteLine("Infome a quantidade: ");
                        numitens = int.Parse(Console.ReadLine());

                        Console.WriteLine("Entre com preço unitario: ");
                        preco = float.Parse(Console.ReadLine());

                        float total = numitens * preco;

                        if (total > maiorvalor)
                        {
                            maiorvalor = total;
                            nomemaior = nome;
                        }

                        if (total < menorvalor)
                        {
                            menorvalor = total;
                            nomemenor = nome;
                        }

                        Console.WriteLine("Digite 1 para SAIR ou 2 para CONTINUAR");
                        parada = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("maior quantia investida { 0} no produto { 1} ", +maiorvalor, nomemaior);
                    Console.WriteLine("menor quantia investida { 0} no produto { 1} ", +menorvalor, nomemenor);

                    break;

                case 3:
                    float peso, pesototal = 0;

                    Console.WriteLine("Digite o total de avaliações: ");
                    int avaliação = int.Parse(Console.ReadLine());

                    for (i = 1; i <= avaliação; i++)
                    {
                        Console.WriteLine("Digite os pesos das notas: ");
                        peso = float.Parse(Console.ReadLine());

                        pesototal = peso;
                    }

                    if (pesototal < 100)
                        Console.WriteLine("Nota insuficiente");

                    else if (pesototal > 100)
                        Console.WriteLine("Nota superior");

                    else
                        Console.WriteLine("Nota alcançada ");

                    break;

                case 4:
                    String estado;

                    Console.WriteLine(" ========== MENU ============ ");
                    Console.WriteLine("AC");
                    Console.WriteLine("AL");
                    Console.WriteLine("AP");
                    Console.WriteLine("AM");
                    Console.WriteLine("BA");
                    Console.WriteLine("CE");
                    Console.WriteLine("DF");
                    Console.WriteLine("ES");
                    Console.WriteLine("GO");
                    Console.WriteLine("MA");
                    Console.WriteLine("MT");
                    Console.WriteLine("MS");
                    Console.WriteLine("MG");
                    Console.WriteLine("PA");
                    Console.WriteLine("PB");
                    Console.WriteLine("PR");
                    Console.WriteLine("PE");
                    Console.WriteLine("PI");
                    Console.WriteLine("RJ");
                    Console.WriteLine("RN");
                    Console.WriteLine("RS");
                    Console.WriteLine("RO");
                    Console.WriteLine("RR");
                    Console.WriteLine("SC");
                    Console.WriteLine("SP");
                    Console.WriteLine("SE");
                    Console.WriteLine("TO");
                    Console.WriteLine(" ========================= ");

                    Console.WriteLine("escolha a sigla de um estado ");
                    estado = Console.ReadLine();

                    switch (estado)
                    {
                    
                        case "AC":
                            Console.WriteLine("Acre");
                            break;

                        case “AL”:
                            Console.WriteLine(“Alagoas”);
                            break;

                        case “AP”:
                            Console.WriteLine(“Amapá”);
                            break;

                        case “AM”:
                            Console.WriteLine(“Amazonas”);
                            break;

                        case “BA”:
                            Console.WriteLine(“Bahia”);
                            break;

                        case “CE”:
                            Console.WriteLine(“Ceará”);
                            break;

                        case “DF”:
                            Console.WriteLine(“Distrito Federal”);
                            break;

                        case “ES”:
                            Console.WriteLine(“ Espírito Santo”);
                            break;

                        case “GO”:
                            Console.WriteLine(“ Goiás”);
                            break;

                        case “MA”:
                            Console.WriteLine(“ Maranhão “);
                            break;

                        case “MT”:
                            Console.WriteLine(“ Mato Grosso”);
                            break;

                        case “MS”:
                            Console.WriteLine(“Mato Grosso do Sul  “);
                            break;

                        case “MG”:
                            Console.WriteLine(“ Minas Gerais”);
                            break;

                        case “PA”:
                            Console.WriteLine(“ Pará”);
                            break;

                        case “PB”:
                            Console.WriteLine(“ Paraíba”);
                            break;

                        case “PR”:
                            Console.WriteLine(“ Paraná”);
                            break;

                        case “PE”:
                            Console.WriteLine(“ Pernambuco”);
                            break;

                        case “PI”:
                            Console.WriteLine(“Piauí”);
                            break;

                        case “RJ”:
                            Console.WriteLine(“ Rio de Janeiro”);
                            break;

                        case “RN”:
                            Console.WriteLine(“ Rio Grande do Norte”);
                            break;

                        case “RS”:
                            Console.WriteLine(“ Rio Grande do Sul”);
                            break;

                        case “RO”:
                            Console.WriteLine(“ Rondônia “);
                            break;

                        case “RR”:
                            Console.WriteLine(“ Roraima”);
                            break;


                        case “SC”:
                            Console.WriteLine(“ Santa Catarina “);
                            break;

                        case “SP”:
                            Console.WriteLine(“ São Paulo “);
                            break;

                        case “SE”:
                            Console.WriteLine(“ Sergipe”);
                            break;

                        case “TO”:
                            Console.WriteLine(“ Tocantins “);
                            break;

                        Default: Console.WriteLine(“ Opção Inválida! “);
                            Break;
                    }
                    break;

                case 5:
                    int mes, dia;

                    Console.WriteLine(“Digite um número entre 1 e 12: “);
                    mes = int.Parse(Console.ReadLine());
                    switch (mes)
                    {
                        case 1:
                            Console.WriteLine(“A estação é verão”);
                            break;
                       
                        case 2:
                            Console.WriteLine(“A estação é verão”);
                            break;
                      
                        case 3:
                            Console.WriteLine(“me diga que dia:”);
                            dia = int.Parse(Console.ReadLine());
                            if (dia >= 20)
                                Console.WriteLine(“a estaçao é outono”);
                            else
                                Console.WriteLine(“A estação é verão”);
                            break;
                        
                        case 4:
                            Console.WriteLine(“A estação é outono”);
                            break;
                       
                        case 5:
                            Console.WriteLine(“A estação é outono”);
                            break;
                        
                        case 6:
                            Console.WriteLine(“me diga o dia:”);
                            dia = int.Parse(Console.ReadLine());
                            if (dia >= 20)
                                Console.WriteLine(“a estaçao é inverno”);
                            else
                                Console.WriteLine(“A estação é outono”);
                            break;
                       
                        case 7:
                            Console.WriteLine(“a estaçao é inverno”);
                            break;
                       
                        Case 8:
                            Console.WriteLine(“a estaçao é inverno”);
                            break;
                       
                        case 9:
                            Console.WriteLine(“me diga o dia:”);
                            dia = int.Parse(Console.ReadLine());
                            if (dia >= 22)
                                Console.WriteLine(“a estaçao é primavera”);
                            else
                                Console.WriteLine(“A estação é inverno”);
                            break;
                       
                        case 10:
                            Console.WriteLine(“a estaçao é primavera”);
                            break;
                      
                        case 11:
                            Console.WriteLine(“a estaçao é primavera”);
                            break;
                     
                        case 12:
                            Console.WriteLine(“me informe o dia:”);
                            Dia = int.Parse(Console.ReadLine());
                            if (dia >= 21)
                                Console.WriteLine(“a estaçao é verão”);
                            else
                                Console.WriteLine(“A estação é primavera”);
                            break;
                    }

                    break;

                case 6:
                    
                     float pesoA, altura, imc;
                   
                    Console.WriteLine(“informe sua altura:”);
                    altura = float.Parse(Console.ReadLine());
                   
                    Console.WriteLine(“informe o seu peso:”);
                    pesoA = float.Parse(Console.ReadLine());
                   
                    imc = pesoh / (altura * altura);

                    if (imc < 18.5)
                        Console.WriteLine(“esta abaixo do peso”);
                 
                    else if (imc == 18.5 && imc == 34.90)
                        Console.WriteLine(“Peso normal”);
                   
                    else if (imc == 25.0 && imc == 29.9)
                        Console.WriteLine(“Sobrepeso”);
                   
                    else if (imc == 30.0 && imc == 34.9)
                        Console.WriteLine(“obesidade grau 1”);
                
                    else if (imc == 35.0 && imc == 39.9)
                        Console.WriteLine(“obesidade de grau 2”);
                    
                    else
                        Console.WriteLine(“Obesidade de grau 3(morbita)”);
                    break;


                case 7:
                    float numero;
                  
                    Console.WriteLine(“digite um numero que seja maior que zero:”);
                    Numero = int.Parse(Console.ReadLine());
                 
                    Console.WriteLine(“Divisores de “ + numero + “:”);

                    for ( I = 1; I <= numero; i++)
                    {
                        If (numero % I == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;

            }

            Console.ReadKey();
        }
    }
}
