using System;
using System.Collections.Generic;

namespace PROJE_2__Console_ToDo
{
    public static class AddCard
    {
        static int id = 0;
        static string title = "";
        static string content = "";
        static string size = "";
        static int line = 1;

        // yeni kart ekle
        public static void NewCard()
        {
            SetTitle(); // kart başlığını al
            SetContent(); // kart içeriğini al
            SetSize(); // kart büyüklüğünü al
            SetPerson(); // kartın atanacaği kişinin id'sini al

            Card card = new Card(Lists.id, line,  title, content, id, size); // kartı oluştur
            
            Cards.cards.Add(card); // kartı kart listesine ekle

            Lists.id++; // daha sonra eklenecek kartın id'sini belirle

            Console.Clear();

            Console.WriteLine(MessagesAdding.addingDone); // kayıt başarılı mesajı

            MainMenu.MakeSelection(); // ana menüye dön
        }
        static void SetTitle()
        {
            Console.Write(MessagesAdding.addingTitle, Console.ForegroundColor = ConsoleColor.White);
            title = Console.ReadLine();
        }

        static void SetContent()
        {
            Console.Write(MessagesAdding.addingContent, Console.ForegroundColor = ConsoleColor.White);
            content = Console.ReadLine();
        }

        static void SetSize()
        {
            Console.Write(MessagesAdding.selectingSize, Console.ForegroundColor = ConsoleColor.White);

            int selection;

            int.TryParse(Console.ReadLine(), out selection);

            if (selection == 1) size = Sizes.XS.ToString();
            else if (selection == 2) size = Sizes.S.ToString();
            else if (selection == 3) size = Sizes.M.ToString();
            else if (selection == 4) size = Sizes.L.ToString();
            else if (selection == 5) size = Sizes.XL.ToString();
            else
            {
                Console.WriteLine(MessagesAdding.enterIDSelectingSizeAgain, Console.ForegroundColor = ConsoleColor.Red);
                SetSize();
            }
        }
        static void SetPerson()
        {
            Console.Write(MessagesAdding.selectingPerson, Console.ForegroundColor = ConsoleColor.White);

            int selection;

            int.TryParse(Console.ReadLine(), out selection);

            bool b = checkPerson(selection);
            bool _b = false;
            if (b)
            {
                for (int i = 0; i < Persons.persons.Count; i++)
                {
                    if (selection == Persons.persons[i].ID)
                    {
                        id = selection;
                        _b = true;
                        break;
                    }
                }

                if (!_b) IDMessage();
            }
            else
            {
                IDMessage();
            }
        }

        static void IDMessage()
        {
            Console.WriteLine(MessagesAdding.enterID, Console.ForegroundColor = ConsoleColor.Red);
            SetPerson();
        }

        static bool checkPerson(int id)
        {
            bool b = false;

            for(int i=0; i<Lists.personNumber; i++)
            {
                if (id == (i + 1))
                {
                    b = true;
                    break;
                }
            }
            return b;
        }
    }
}