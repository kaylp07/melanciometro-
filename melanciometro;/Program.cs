using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace melanciometro_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario, senha;
            int tentativas = 3;

            Console.WriteLine("Bem-vindo ao sistema de cadastro de usuários!");

            while (true)
            {
                Console.WriteLine("\nDigite 1 para cadastrar um usuário");
                Console.WriteLine("Digite 2 para fazer login");
                Console.WriteLine("Digite 0 para sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        return;

                    case 1:
                        Console.Write("\nDigite o nome de usuário desejado: ");
                        usuario = Console.ReadLine();
                        Console.WriteLine("Usuário cadastrado com sucesso!");
                        break;

                    case 2:
                        Console.Write("\nDigite o nome de usuário: ");
                        usuario = Console.ReadLine();

                        while (tentativas > 0)
                        {
                            Console.Write("Digite a senha: ");
                            senha = Console.ReadLine();

                            if (senha == "123")
                            {
                                Console.WriteLine("Login efetuado com sucesso!");
                                break;
                            }
                            else
                            {
                                tentativas--;
                                Console.WriteLine("Senha incorreta! Você tem mais " + tentativas + " tentativas.");
                            }
                        }

                        if (tentativas == 0)
                        {
                            Console.WriteLine("Número máximo de tentativas excedido. Tente novamente mais tarde.");
                            return;
                        }

                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }


                Console.WriteLine("Bem vindo (a) ao Verdurão do João!");
            Console.WriteLine("Por Favor, digite a placa do caminhão:");
            string placa = Console.ReadLine(); // lê a entrada do usuário e armazena na variável "placa"

            if (placa.Length < 6)
            {
                Console.WriteLine("Placa cadastrada com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa não cadastrada");
            }

            {
                double precoMelanciababy = 5.50; // preço da melancia baby
                double precoMelanciacomum = 8.70; // preço da melancia comum

                Console.WriteLine("Para ver os preços, escolha uma opção: ");
                Console.WriteLine("1- Ver o preço da Melancia Baby");
                Console.WriteLine("2- Ver o preço da Melancia Comum");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("O preço da Melancia Baby é: R$ " + precoMelanciababy);

                    Console.ReadLine();
                }

                
               else if (opcao == 2)
                { Console.WriteLine("O preço da Melancia Comum é: R$ " + precoMelanciacomum); 
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Opção inválida!");

                }
            }
        }
    }
  }

