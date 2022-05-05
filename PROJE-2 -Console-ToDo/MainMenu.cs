using System;

namespace PROJE_2__Console_ToDo
{
    public class MainMenu
    {        
        public static void MakeSelection()
        {
            // seçim mesajı
            Console.WriteLine(MessagesMainMenu.title, Console.ForegroundColor = ConsoleColor.White);

            // Seçenekler - (1) Board Listelemek (2) Board'a Kart Eklemek (3) Board'dan Kart Silmek (4) Kart Taşımak (5) Çıkış
            foreach (var process in Lists.processes)
            {
                Console.WriteLine(process);
            }

            int selection;

            int.TryParse(Console.ReadLine(), out selection);

            // Seçim
            switch (selection)
            {
                case 1:
                    Console.Clear();
                    ListCards.ListCard();
                    break;
                case 2:
                    Console.Clear();
                    AddCard.NewCard();
                    break;
                case 3:
                    Console.Clear();
                    DeleteCard.Delete();
                    break;
                case 4:
                    Console.Clear();
                    MoveCard.SelectCard();
                    break;
                case 5:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    // hatalı seçim mesajı
                    Console.WriteLine(MessagesMainMenu.enterAgain, Console.ForegroundColor = ConsoleColor.Red);
                    MakeSelection();
                    break;
            }
        }
    }
}