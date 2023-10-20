using System;

public class Menu
{
    public void MenuPrincipal()
    {
        int op = 1;
        while (op != 0)
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo, Escolha uma das seguintes opções:");
            Console.WriteLine("1 - Cadastrar Novo Funcionário");
            Console.WriteLine("2 - Listar Funcionários");
            Console.WriteLine("0 - Sair\n");
            op = int.Parse(Console.ReadLine());

            if (op == 0)
            {
                break;
            }
            else if (op == 1)
            {
                Console.Clear();
                Console.WriteLine("\nCadastrando Funcionário");
                Console.ReadKey();
                // Colocar sistema de Cadastro de Funcionário que fique salvo em uma lista
            }
            else if (op == 2)
            {
                Console.Clear();
                Console.WriteLine("\nListando Funcionários");
                Console.ReadKey();
                // Acessar lista que tenha funcionários cadastrados
            }
        }
    }

    public static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.MenuPrincipal();
    }
}
