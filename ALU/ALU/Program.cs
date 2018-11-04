using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALU
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            return;

            int opcao, a, b, saida;
            bool A, B, S, Vem1, Vai1;
            bool[] F = new bool[3]; // OPCODE: F2F1F0 			

            Menu();
			ALU1bit A0 = new ALU1bit();
            for (opcao = -1; opcao != 8;)
            {
                Menu();
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 0)
                {
                    Console.WriteLine("AND - opcode (F2F1F0 = 000) ");
                    Console.WriteLine("Digite os valores binarios/booleanos das entradas A e B:  ");
                    a = Obter_valor();
                    b = Obter_valor();
                    A = Converte_int_para_bool(a);
					B = Converte_int_para_bool(b);
                    Vem1 = false; // valor inicial para teste 					
                    F[2] = false; F[1] = false; F[0] = false; // opcode para porta AND (F2F1F0 = 000)
                    saida = A0.Ativa(A, B, F, Vem1, out Vai1);
                    S = Converte_int_para_bool(saida);
                    Imprimir_Porta2(A, B, S);
                    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu ");
                    Console.ReadKey();
                }
                else if (opcao == 1)
                {
                    Console.WriteLine("OR - opcode (F2F1F0 = 001) ");
                    Console.WriteLine("Digite os valores binarios/booleanos das entradas A e B:  ");
                    a = Obter_valor();
                    b = Obter_valor();
                    A = Converte_int_para_bool(a);
                    B = Converte_int_para_bool(b);
                    Vem1 = false; // valor inicial para teste 					
                    F[2] = false; F[1] = false; F[0] = true; // opcode para porta OR (F2F1F0 = 001)
                    saida = A0.Ativa(A, B, F, Vem1, out Vai1);
                    S = Converte_int_para_bool(saida);
                    Imprimir_Porta2(A, B, S);
                    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu ");
                    Console.ReadKey();
                }

                else if (opcao == 2)
                {
                    Console.WriteLine("XOR - opcode (F2F1F0 = 010) ");
                    Console.WriteLine("Digite os valores binarios/booleanos das entradas A e B:  ");
                    a = Obter_valor();
                    b = Obter_valor();
                    A = Converte_int_para_bool(a);
                    B = Converte_int_para_bool(b);
                    Vem1 = false; // valor inicial para teste 					
                    F[2] = false; F[1] = true; F[0] = false; // opcode para porta OR (F2F1F0 = 010)
                    saida = A0.Ativa(A, B, F, Vem1, out Vai1);
                    S = Converte_int_para_bool(saida);
                    Imprimir_Porta2(A, B, S);
                    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu ");
                    Console.ReadKey();
                }

                else if (opcao == 3)
                {
                    Console.Clear();
                    Console.WriteLine("\n3. NOT(A) - opcode (F2F1F0 = 011) ");
                    Console.WriteLine("\nOpcao nao implementada - Digite qualquer tecla para para voltar ao menu.");
                    Console.WriteLine("----------------------------------------------");
                    Console.ReadKey();
                }

                else if (opcao == 4)
                {
                    Console.Clear();
                    Console.WriteLine("\n4.NOT(B) - opcode (F2F1F0 = 100) ");
                    Console.WriteLine("Digite o valor binario/booleano da entrada B:  ");
                    b = Obter_valor();
                    B = Converte_int_para_bool(b);
                    Vem1 = false; A = false; // valores iniciais para teste 					
                    F[2] = true; F[1] = false; F[0] = false; // opcode para porta OR (F2F1F0 = 100)
                    saida = A0.Ativa(A, B, F, Vem1, out Vai1);
                    S = Converte_int_para_bool(saida);
                    Console.WriteLine("B = {0} S(saida do circuito digital) = {1} ", b, saida);
                    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu ");
                    Console.ReadKey();
                }

                else if (opcao == 5)
                {
                    Console.Clear();
                    Console.WriteLine("\n5. Somador Completo de 1 bit ");
                    Console.WriteLine("\nOpcao nao implementada - Digite qualquer tecla para para voltar ao menu.");
                    Console.WriteLine("----------------------------------------------");
                    Console.ReadKey();

                }

                else if (opcao == 6)
                {
                    Console.Clear();
                    Console.WriteLine("\n6. SUBTRAIR(A,B) de 1 bit ");
                    Console.WriteLine("\nOpcao nao implementada - Digite qualquer tecla para para voltar ao menu.");
                    Console.ReadKey();
                    Console.WriteLine("----------------------------------------------");
                }

                else if (opcao == 7)
                {
                    Console.Clear();
                    Console.WriteLine("\n7. COMPARAR A e B de 1 bit ");
                    Console.WriteLine("\nOpcao nao implementada - Digite qualquer tecla para para voltar ao menu.");
                    Console.WriteLine("----------------------------------------------");
                    Console.ReadKey();
                }


                else if (opcao == 8)
                {
                    Console.WriteLine("\nPrograma terminado!!!");
                    Console.WriteLine("\nDigite qualquer tecla para sair ");
                    Console.ReadKey();
                }


                else
                {
                    Console.WriteLine("\nOpcao {0} invalida.", opcao);
                    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu ");
                    Console.ReadKey();
                }
            }
            
        }
		static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n Programa da ALU de 1 bit\n");
            Console.WriteLine("0. AND(A,B): 1 bit");
            Console.WriteLine("1. OR(A,B): 1 bit ");
            Console.WriteLine("2. XOR(A,B): 1 bit ");
            Console.WriteLine("3. NOT(A):  1 bit ");
            Console.WriteLine("4. NOT(B): 1 bit");
            Console.WriteLine("5. SOMA (A,B): 1 bit ");
            Console.WriteLine("6. SUBTRAIR(A,B) de 1 bit ");
            Console.WriteLine("7. COMPARAR A e B:1 bit ");
            Console.WriteLine("8. Sair do programa ");
            Console.Write("\nSelecione sua Opção: ");
        }


        static int Obter_valor()
        {
            int valor;
            Console.Write("Informe um valor binario/booleano (0 ou 1): ");
            valor = int.Parse(Console.ReadLine());

            while ((valor > 1) || (valor < 0))
            {
                Console.WriteLine("O valor {0} eh invalido ", valor);
                Console.Write("Informe um valor binario/booleano valido(0 ou 1): ");
                valor = int.Parse(Console.ReadLine());
            }
            return valor;
        }

        static int Converte_bool_para_int(bool A)
        {
            if (A) return 1;
            else return 0;
        }

        static bool Converte_int_para_bool(int a)
        {
            if (a == 1) return true;
            else return false;
        }
        static void Imprimir_Porta2(bool A, bool B, bool S)
        {
            int saida, a, b;
            if (A) a = 1; else a = 0;
            if (B) b = 1; else b = 0;
            if (S) saida = 1; else saida = 0;
            Console.WriteLine("A = {0} B = {1} S(saida do circuito digital) = {2} ", a, b, saida);
        }
    }
}
