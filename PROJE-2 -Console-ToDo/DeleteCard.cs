using System;
using System.Linq;

namespace PROJE_2__Console_ToDo
{
    public static class DeleteCard
    {
        public static void Delete()
        {
            Console.Clear();

            // mesaj - kart seçimi - 'kart başlığıni girin'
            Console.WriteLine(MessagesDeleting.cardSelection, Console.ForegroundColor = ConsoleColor.White);

            string title = Console.ReadLine().ToLower();

            // girilen kart başlığı ile eşleşen kartlar
            
            var card = Cards.cards.Where(x => x.Title.ToLower() == title).ToList();

            //girilen kart başlığı ile eşleşen en az bir kart varsa
            if (card.Count > 0)
            {
                Console.Clear();

                // Başlık bilgisine göre kart sil
                Cards.cards.RemoveAll((x) => x.Title.ToLower() == title.ToLower());
                
                Console.WriteLine(MessagesDeleting.deleteDone); // silme başarılı mesajı
                
                MainMenu.MakeSelection(); // Ana menüye dön
            }
            else
            {
                Selection(); // Kart bulunmadıysa devam edilip edilmeyeceğini sor
            }
        }

        static void Selection()
        {
            // Mesajlar - silme: iptal (ana menüye dön) - devam
            Console.WriteLine(MessagesDeleting.cardNotFound, Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine(MessagesDeleting.selection, Console.ForegroundColor = ConsoleColor.White);
            Console.WriteLine(MessagesDeleting.selectionEnd);
            Console.WriteLine(MessagesDeleting.selectionContinue);

            int selection;

            int.TryParse(Console.ReadLine(), out selection);

            switch (selection)
            {
                case 1: // Ana menüye dön
                    Console.Clear();
                    MainMenu.MakeSelection();
                    break;
                case 2: // Tekrar dene
                    Console.Clear();
                    Delete();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(MessagesDeleting.deleteContinue, Console.ForegroundColor = ConsoleColor.Red);
                    Selection(); // giriş '1' ya da '2' değilse yeniden giriş yap
                    break;
            }
        }
    }
}
