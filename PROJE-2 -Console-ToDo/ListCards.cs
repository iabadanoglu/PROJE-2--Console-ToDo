using System;
using System.Collections.Generic;
using System.Linq;

namespace PROJE_2__Console_ToDo
{
    public static class ListCards
    {
        static int cardNumber = 0;
        static int id = 0;
        static string name = "";
        static string surname = "";

        static List<Card> cardsToDo = new List<Card>();
        static List<Card> cardsInProgress = new List<Card>();
        static List<Card> cardsDone = new List<Card>();
        public static void ListCard()
        {
            cardNumber = 0;
            //Cards.cards.RemoveAt(0);
            SortList();
        }
        static void SortList()
        {
            // Kartları listelenecek kişi bilgileri - id, name, surname
            GetPerson();

            /*
            var cards = from element in Cards.cards.Where(x => x.AssignedPerson > 0)
                        orderby element.AssignedPerson, element.Line
                        select element;
            */

            var cards = from element in Cards.cards
                        orderby element.AssignedPerson, element.Line
                        select element;

            Console.Clear();

            Console.WriteLine(name + " " + surname + MessagesListing.starLine);

            cardsToDo = new List<Card>();
            cardsInProgress = new List<Card>();
            cardsDone = new List<Card>();

            //cardsToDo.RemoveAll();
            foreach (var _cards in cards)
            {
                if (id == _cards.AssignedPerson)
                {
                    if (_cards.Line == 1) cardsToDo.Add(_cards);
                    else if (_cards.Line == 2) cardsInProgress.Add(_cards);
                    else if (_cards.Line == 3) cardsDone.Add(_cards);
                }
            }

            cardNumber = cardsToDo.Count + cardsInProgress.Count + cardsDone.Count;

            if(cardNumber > 0)
            {
                // seçilen kişinin kart listesi
                SetCards(cardsToDo, 0);
                SetCards(cardsInProgress, 1);
                SetCards(cardsDone, 2);
            }
            else
            {
                Console.Clear();
                Console.WriteLine(name + " " + surname + MessagesListing.starLine);
                Console.WriteLine(MessagesListing.cardNotFound, Console.ForegroundColor = ConsoleColor.Red); // kart bulunamadı
                Console.WriteLine("", Console.ForegroundColor = ConsoleColor.White);
            }
            MainMenu.MakeSelection();
        }

        // Kartları listelenecek kişi bilgileri - id, ad, soyad
        static void GetPerson()
        {
            int selection;

            Console.Clear();

            // kartın atanacağı kişinin ID değerini gir
            Console.WriteLine(MessagesListing.persınID, Console.ForegroundColor = ConsoleColor.White);
            
            string input = Console.ReadLine();

            bool b = int.TryParse(input, out selection);

            //bool _b = false;

            if (b)
            {
                selection = int.Parse(input);

                var Selecteduser = Persons.persons.Where(x => x.ID == selection).ToList();

                if (Selecteduser.Count != 0)
                {
                    id = Selecteduser[0].ID;
                    name = Selecteduser[0].Name;
                    surname = Selecteduser[0].Surname;
                }
                else IDMessage();
            }
            else IDMessage();
        }

        static void IDMessage()
        {
            // geçersiz ID - geçerli bir ID girin
            Console.WriteLine(MessagesListing.invalidID, Console.ForegroundColor = ConsoleColor.Red);
            GetPerson(); // ID bilgisi ile kişiyi bulmak için git
        }

        // seçilen kişinin kart listesi
        static void SetCards(List<Card> list, int num)
        {
            Console.WriteLine(Lists.lines[num]);
            Console.WriteLine(MessagesListing.dashedLine);

            MessagesListing.empty = "~ BOŞ ~";
            if (list.Count > 0)
            {
                foreach (var card in list)
                {
                    Console.WriteLine(cardInfos.titleCard + card.Title); // kart başlığı
                    Console.WriteLine(cardInfos.contentCard + card.Content); // kart içeriği
                    Console.WriteLine(cardInfos.assignedPersonCard + name + " " + surname); // kartın atandığı kişinin adı-soyadı
                    Console.WriteLine(cardInfos.sizeCard + card.Size + "\n"); // kart büyüklüğü
                }
            }
            else
            {
                // kayıt yok
                Console.WriteLine(MessagesListing.empty, Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine("", Console.ForegroundColor = ConsoleColor.White);
            }
        } 
    }
}