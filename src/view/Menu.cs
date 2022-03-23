namespace Lunaris.Src.View
{
    class Menu
    {

        protected static void Intro()
        {
            Console.Title = "Lunaris";
            Console.Clear();
            Console.WriteLine(@"
                        .......
                   ..........
                ...........    |||
              ...........      |||
             ........          |||
              .........        |||_____
               ...........     |||_____|
                   ..........
                      ..........
            ");
            Thread.Sleep(500);
        }

        protected static void MenuPrincipal()
        {
            Console.Title = "Lunaris";
            Console.Clear();
            Console.WriteLine("---------------| Lunaris |---------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\n Escolha a ação desejada:\n   (0) Sair\n   (1) Novo arquivo");
            var keyIndex = Console.ReadKey().Key;
            switch(keyIndex)
            {
                case ConsoleKey.NumPad0:
                    Console.Clear();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Bye ;)");
                    Console.ResetColor();
                    Thread.Sleep(200);
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                case ConsoleKey.NumPad1:
                    //
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida, por favor pressione um número válido!");
                    Console.ResetColor();
                    Thread.Sleep(500);
                    Console.Clear();
                    MenuPrincipal();
                    break;
            }
        }
    }
}