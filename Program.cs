using System;
using System.Threading;

namespace cadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;



            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"+===================================================+");
            Console.WriteLine($"|       Bem vindo ao Sistema de cadastro de         |");
            Console.WriteLine($"|           pessoas Fisica e Juridica               |");
            Console.WriteLine($"+===================================================+");

            Console.ResetColor();
            Thread.Sleep(1000);

            BarraCarregamento("Iniciando");

            Console.Clear();
            Console.ResetColor();


            do
            {

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@$"
+===================================================+
|                  Escolha uma opção                |
|---------------------------------------------------|
|       1 - Pessoa Fisica                           |
|       2 - Pessoa Juridica                         |
|                                                   |
|       0 - Sair                                    |
+===================================================+
");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        Console.ResetColor();
                        PessoaFisica pf = new PessoaFisica();
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco endPf = new Endereco();

                        endPf.logradouro = "Av.Brasil";
                        endPf.numero = 1384;
                        endPf.complemento = "Proximo ao Senai";
                        endPf.enderecoComercial = false;

                        novaPf.endereco = endPf;
                        novaPf.cpf = "123456789";
                        novaPf.nome = "Pessoa fisica";
                        novaPf.dataNascimento = new DateTime(2000, 06, 15);

                        Console.WriteLine($"Rua: {novaPf.endereco.logradouro}, Numero: {novaPf.endereco.numero}");
                        bool idadeValida = pf.validarDataNascimento(novaPf.dataNascimento);

                        if (idadeValida == true)
                        {
                            Console.WriteLine($"Cadastro Aprovado!");
                        }
                        else
                        {
                            Console.WriteLine($"Cadastro Reprovado!");
                        }
                        

                        break;

                    case "2":
                    
                        Console.ResetColor();
                        PessoaJuridica pj = new PessoaJuridica();
                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco endPj = new Endereco();

                        endPj.logradouro = "Av.Lisboa";
                        endPj.numero = 1028;
                        endPj.complemento = "Proximo ao Clube X";
                        endPj.enderecoComercial = true;

                        novaPj.endereco = endPj;
                        novaPj.cnpj = "12345678000101";
                        novaPj.razaoSocial = "Pessoa Juridica";

                        if (pj.validarCNPJ(novaPj.cnpj))
                        {
                            Console.WriteLine($"CNPJ Valido!");
                        }
                        else
                        {
                            Console.WriteLine($"CNPJ Invalido!");
                        }

                        break;

                    case "0":
                        Console.ResetColor();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Obrigado por utilizar o sistema");

                        BarraCarregamento("Finalizando");

                        Console.ResetColor();
                        break;

                    default:
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"Opção invalida, digite uma opção válida");
                        break;
                }
            } while (opcao != "0");



        }

        static void BarraCarregamento(string textoCarregamento)
        {

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(textoCarregamento);
            Thread.Sleep(300);

            for (var contador = 0; contador < 5; contador++)
            {
                Console.Write($".");
                Thread.Sleep(180);
            }
        }
    }
}