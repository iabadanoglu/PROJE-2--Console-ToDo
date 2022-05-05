using System;
using System.Linq;

namespace PROJE_2__Console_ToDo
{
    public static class MessagesMainMenu
    {
        public static string title = "Lütfen yapmak istediğiniz işlemi seçiniz :)\n*******************************************";
        public static string enterAgain = "Lütfen 1-5 arasında bir rakam giriniz!\n";
    }
    public static class MessagesAdding
    {
        public static string addingDone = "Kayıt işlemi başarılı\n ";
        public static string addingTitle = "Başlık Giriniz                                  : ";
        public static string addingContent = "İçerik Giriniz                                  : ";
        public static string selectingSize = "Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ";
        public static string selectingPerson = "Kişi Seçiniz                                    : ";
        public static string enterID = "\nLütfen geçerli bir id giriniz!";
        public static string enterIDSelectingSizeAgain = "\nLütfen 1-5 arası bir rakam (1 ve 5 dahil) giriniz!";
    }

    public static class MessagesDeleting
    {
        public static string cardSelection = "Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız:\n";
        public static string deleteDone = "Silme işlemi tamamlandı.\n";
        public static string deleteContinue = "Lütfen 1 ya da 2 rakamlarından birini giriniz!";
        public static string cardNotFound = "Aradığınız krtiterlere uygun kart board'da bulunamadı!";
        public static string selection = "Lütfen bir seçim yapınız.";
        public static string selectionEnd = "* Silmeyi sonlandırmak için: (1)";
        public static string selectionContinue = "* Yeniden denemek için:      (2)";
    }
    
    public static class MessagesMoving
    {
        public static string titleInput = "Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız:\n";
        public static string titleCardInfos = "Bulunan Kart Bilgileri:\n*************************************";
        public static string movingDone = "Taşıma işlemi tamamlandı.\n";
        public static string cardNotFound = "\nAradığınız krtiterlere uygun kart board'da bulunamadı!";
        public static string selectWhatToDo = "\nLütfen bir seçim yapınız.";
        public static string selectCancel = "* Taşımayı sonlandırmak için: (1)";
        public static string selectContinue = "* Yeniden denemek için:       (2)\n";
        public static string selectAgain = "Lütfen 1 ya da 2 rakamlarından birini giriniz!\n";
        public static string selectLine = "Lütfen taşımak istediğiniz Line'ı seçiniz:";
        public static string selectLineAgain = "\nLütfen 1-4 arası rakamlarından birini giriniz!\n";
    }

    public static class MessagesListing
    {
        public static string dashedLine = "------------------------";
        public static string starLine = "\n************************";
        public static string cardNotFound = "Kayıt bulunamadı!\n";
        public static string persınID = "Lütfewn kartlarını görmek istediğiniz kişin ID'sini girin.";
        public static string invalidID = "\nLütfen geçerli bir id giriniz!";
        public static string empty = "~ BOŞ ~";
    }

    public static class cardInfos
    {
        public static string titleCard = "Başlık      : ";
        public static string contentCard = "İçerik      : ";
        public static string assignedPersonCard = "Atanan Kişi : ";
        public static string sizeCard = "Büyüklük    : ";
        public static string lineCard = "Line        : ";
    }
}
