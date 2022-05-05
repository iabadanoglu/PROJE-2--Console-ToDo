using System;
using System.Linq;

namespace PROJE_2__Console_ToDo
{
    public static class MoveCard
    {
        static int indexCard = 0;
        static int indexPerson = 0;
        static int id = 0;
        static int line = 0;
        static string name = "";
        static string title = "";
        
        public static void SelectCard()
        {
            Console.Clear();

            Console.WriteLine(MessagesMoving.titleInput, Console.ForegroundColor = ConsoleColor.White); // kart başlığını girin

            string input = Console.ReadLine();

            var selectedCard = Cards.cards.Where(x => x.Title.ToLower() == input.ToLower()).ToList(); // girilen başlıkla eşleşen kaydı bul

            // girilen başlıkla eşleşen bir kayıt varsa
            if (selectedCard.Count > 0)
            {
                //Console.Clear();

                indexCard = selectedCard[0].ID;
                line = selectedCard[0].Line;
                indexPerson = selectedCard[0].AssignedPerson;
                title = selectedCard[0].Title.ToLower();

                var person = Persons.persons.Where(x => x.ID == indexPerson).ToList(); // kartın atandığı kişiyi bul

                name = person[0].Name + " " + person[0].Surname; // kartın atandığı kişinin adı-soyadı

                Console.WriteLine(MessagesMoving.titleCardInfos); // bulunan kart bilgileri
                Console.WriteLine(cardInfos.titleCard + selectedCard[0].Title); // başlık
                Console.WriteLine(cardInfos.contentCard + selectedCard[0].Content); // içerik
                Console.WriteLine(cardInfos.assignedPersonCard + name); // atanan kişi
                Console.WriteLine(cardInfos.sizeCard + selectedCard[0].Size); // büyüklük
                Console.WriteLine(cardInfos.lineCard + Lists.lines[line - 1] + "\n"); // line

                SelectLineAndMoveSelectedCard(); // kartın taşınacağı line'ı seç

                Console.Clear();

                Console.WriteLine(MessagesMoving.movingDone, Console.ForegroundColor = ConsoleColor.White); // taşıma gerçekleşti

                MainMenu.MakeSelection(); // ana menüye git
            }
            else
            {
                Console.WriteLine(MessagesMoving.cardNotFound, Console.ForegroundColor = ConsoleColor.Red); // kart bulunamadı
                LineSelection();
            }
        }

        // 'SelectCard' içinde girilen başlıkla eşleşen bir kayıt yoksa
        static void LineSelection()
        {
            Console.WriteLine(MessagesMoving.selectWhatToDo, Console.ForegroundColor = ConsoleColor.White); //seçenekler
            Console.WriteLine(MessagesMoving.selectCancel); // taşıma işleminden vaz geç
            Console.WriteLine(MessagesMoving.selectContinue); // yeniden dene

            int selection;

            int.TryParse(Console.ReadLine(), out selection);

            switch (selection)
            {
                case 1:
                    Console.Clear();
                    MainMenu.MakeSelection(); // taşıma iptal - ana menüye git
                    break;
                case 2:
                    Console.Clear();
                    SelectCard(); // tekrar bir kar seç
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(MessagesMoving.selectAgain, Console.ForegroundColor = ConsoleColor.Red);
                    LineSelection(); // geçersiz seçim
                    break;
            }
        }

        // 'SelectCard' içinde girilen başlıkla eşleşen bir kayıt varsa - line seçimi
        static void SelectLineAndMoveSelectedCard()
        {
            Console.WriteLine(MessagesMoving.selectLine, Console.ForegroundColor = ConsoleColor.White); // taşınacak line'ı seçin

            // line'ları göster
            foreach(var line in Lists.lines) Console.WriteLine(line); // (1) TODO Line, (2) IN PROGRESS Line, (3) DONE Line, (4) Vazgeç

            int selection;

            int.TryParse(Console.ReadLine(), out selection);

            Console.WriteLine();

            switch (selection)
            {
                case 1:
                    line = 1; // (1) TODO Line
                    break;
                case 2:
                    line = 2; // (2) IN PROGRESS Line
                    break;
                case 3:
                    line = 3; // DONE Line
                    break;
                case 4:
                    Console.Clear ();
                    MainMenu.MakeSelection(); // seçim iptal - ana menüye git
                    break;
                default:
                    Console.WriteLine(MessagesMoving.selectLineAgain, Console.ForegroundColor = ConsoleColor.Red);
                    line = 0;
                    SelectLineAndMoveSelectedCard(); // geçersiz seçim - yeniden seçim işlemi
                    break;
            }

            // girilen başlıkla eşleşen kaydı bul
            var selectedCard = Cards.cards.Where(x => x.Title.ToLower() == title).ToList();
            
            if (selectedCard.Count > 0)
            {
                int i = 0;

                foreach (var card in Cards.cards)
                {
                    if (card == selectedCard[0])
                    {
                        // kartı taşı - seçilen kartın line değerini seçilen line'a eşitle 
                        if (Cards.cards[i].Line != line) Cards.cards[i].Line = line; 
                        else InvalidSelection(line); // hata - aynı line'a atama 
                        break;
                    }
                    i++;
                }
            }
        }

        static void InvalidSelection(int _line)
        {
            string Line = Lists.lines[_line - 1];
            Console.WriteLine("Seçilen kart zaten " + Line + " içinde! \nLütfen başka bir seçim yapınız!\n");
            SelectLineAndMoveSelectedCard();
        }
    }
}