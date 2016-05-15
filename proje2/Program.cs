using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string check = "";
            int choose = 0;
            int mode = 1;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(@"
.______       ___________    ____  _______ .______        
|   _  \     |   ____\   \  /   / |   ____||   _  \      
|  |_)  |    |  |__   \   \/   /  |  |__   |  |_)  |    
|      /     |   __|   \      /   |   __|  |      /     
|  |\  \----.|  |____   \    /    |  |____ |  |\  \----.
| _| `._____||_______|   \__/     |_______|| _| `._____|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(56, 1);
            Console.Write(@"  _______   ______");
            Console.SetCursorPosition(56, 2);
            Console.Write(@" /  _____| /  __  \");
            Console.SetCursorPosition(56, 3);
            Console.Write(@"|  |  __  |  |  |  |");
            Console.SetCursorPosition(56, 4);
            Console.Write(@"|  | |_ | |  |  |  | ");
            Console.SetCursorPosition(56, 5);
            Console.Write(@"|  |__| | |  `--'  |");
            Console.SetCursorPosition(56, 6);
            Console.WriteLine(@" \______|  \______/");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n");
            while (true)
            {
                Console.WriteLine("For the 1x16 game Please enter 1\nFor the 8x8 game Please enter 2");
                check = Console.ReadLine();
                if (check == "1" ||check == "2")//sayımı değil mi?
                {
                    choose = Convert.ToInt32(check);
                    break;
                }
                
            }
            
            
            
            //*********************************************Game 1*************************************************
            Console.Clear();
            switch (choose)
            {
                case 1:
                    {
                        int[] board = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        int userCoordinate = 0;
                        int computerCoordinate = 0;
                        int cPointCounter = 0;
                        int uPointCounter = 0;
                        int tempNumber;
                        int roundCounter = 0;
                        bool flag1 = false;
                        bool flag2 = false;
                        bool flag3 = true;
                        bool flag4 = true;
                        bool flag5 = true;
                        //interface
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@"            
  0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1                  Round    :0 
  1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6                  Human    :0
+ - - - - - - - - - - - - - - - - +                Computer :0
| . . . .                 . . . . |                     
+ - - - - - - - - - - - - - - - - +                 

");
                        Console.SetCursorPosition(10, 4);
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Write(". . . . . . . .");
                        //interface END




                        //______________________________________________________________________________________________________________________
                        for (int round = 0; round < 8; round++)
                        {
                            //get coordinate and check--------------------
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(1, 7);
                            Console.WriteLine("                                                                          ");
                            Console.WriteLine("                                                                          ");
                            Console.Write("                                                                          ");
                            Console.SetCursorPosition(1, 7);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Please enter coordinate :  ");
                            while (true)
                            {

                                check = Console.ReadLine();
                                if ((!check.All(char.IsDigit)) | (check == ""))//sayımı değil mi?
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.SetCursorPosition(1, 7);
                                    Console.WriteLine("                                                                          ");
                                    Console.Write("                                                                          ");
                                    Console.SetCursorPosition(1, 7);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nWrong coordinate. Please enter 1-16 among number. :");
                                    continue;
                                }
                                userCoordinate = Convert.ToInt32(check);

                                if (!(0 < userCoordinate & userCoordinate < 17))//1-16 mı?
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.SetCursorPosition(1, 7);
                                    Console.WriteLine("                                                                          ");
                                    Console.WriteLine("                                                                          ");
                                    Console.Write("                                                                          ");
                                    Console.SetCursorPosition(1, 7);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nWrong coordinate. Please enter 1-16 among number. :");
                                    continue;
                                }

                                if (board[userCoordinate - 1] != 0)//oynamak istediği yerde taş varmı?
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.SetCursorPosition(1, 7);
                                    Console.WriteLine("                                                                          ");
                                    Console.WriteLine("                                                                          ");
                                    Console.Write("                                                                          ");
                                    Console.SetCursorPosition(1, 7);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nWrong coordinate. Please try again : ");
                                    continue;
                                }
                                if (2 < userCoordinate & userCoordinate < 15)
                                {
                                    if ((4 < userCoordinate && userCoordinate < 13) || board[userCoordinate - 3] != 0 || (board[userCoordinate - 2] != 0 || board[userCoordinate] != 0) || board[userCoordinate + 1] != 0)
                                    {
                                        //puan atama-*-*-*-*-*-*--*
                                        board[userCoordinate - 1] = 1;
                                        if (board[userCoordinate] == -1)//kullanıcının taşının sağında bilgisayarın taşı varsa
                                        {
                                            for (int i = userCoordinate; i < 16; i++)//o taştan itibaren köşeye kadar kontrol et
                                            {
                                                if (board[i] == 0)//boşluk varsa çık
                                                {
                                                    break;
                                                }
                                                if (board[i] == 1)//kullanıcının taşı geldiğinde
                                                {
                                                    for (int j = userCoordinate; j < i; j++)//kullanıcının taşına kadar hepsini 1 yap
                                                    {
                                                        board[j] = 1;
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                        if (board[userCoordinate - 2] == -1)//kullanıcının taşının solunda bilgisayarın taşı varsa
                                        {
                                            for (int i = userCoordinate - 2; 0 <= i; i--)//o taştan itibaren köşeye kadar kontrol et
                                            {
                                                if (board[i] == 0)//boşluk varsa çık
                                                {
                                                    break;
                                                }
                                                if (board[i] == 1)//kullanıcının taşı geldiğinde
                                                {
                                                    for (int j = userCoordinate - 1; i < j; j--)//kullanıcının taşına kadar hepsini 1 yap
                                                    {
                                                        board[j] = 1;
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                        //puan atama SONU-*-*-*-*-*-*--*
                                        break;
                                    }
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.SetCursorPosition(1, 7);
                                    Console.WriteLine("                                                                          ");
                                    Console.WriteLine("                                                                          ");
                                    Console.Write("                                                                          ");
                                    Console.SetCursorPosition(1, 7);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nWrong coordinate. Please try again : ");
                                    continue;
                                }
                                else if (userCoordinate == 1)
                                {
                                    if (board[1] != 0 | board[2] != 0)
                                    {
                                        //puan atama-*-*-*-*-*-*--*
                                        board[userCoordinate - 1] = 1;
                                        if (board[1] == -1)//1. indiste bilgisayarın taşı varsa
                                        {
                                            for (int i = 1; i < 16; i++)//o taştan itibaren köşeye kadar kontrol et
                                            {
                                                if (board[i] == 0)//boşluk varsa çık
                                                {
                                                    break;
                                                }
                                                if (board[i] == 1)//kullanıcının taşı geldiğinde
                                                {
                                                    for (int j = 1; j < i; j++)//kullanıcının taşına kadar hepsini 1 yap
                                                    {
                                                        board[j] = 1;
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                        //puan atama SONU-*-*-*-*-*-*--*
                                        break;
                                    }
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.SetCursorPosition(1, 7);
                                    Console.WriteLine("                                                                          ");
                                    Console.WriteLine("                                                                          ");
                                    Console.Write("                                                                          ");
                                    Console.SetCursorPosition(1, 7);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nWrong coordinate. Please try again : ");
                                    continue;
                                }
                                else if (userCoordinate == 2)
                                {
                                    if (board[0] != 0 | board[2] != 0 | board[3] != 0)
                                    {
                                        //puan atama-*-*-*-*-*-*--*
                                        board[userCoordinate - 1] = 1;
                                        if (board[2] == -1)//2. indiste bilgisayarın taşı varsa
                                        {
                                            for (int i = 2; i < 16; i++)//o taştan itibaren köşeye kadar kontrol et
                                            {
                                                if (board[i] == 0)//boşluk varsa çık
                                                {
                                                    break;
                                                }
                                                if (board[i] == 1)//kullanıcının taşı geldiğinde
                                                {
                                                    for (int j = 1; j < i; j++)//kullanıcının taşına kadar hepsini 1 yap
                                                    {
                                                        board[j] = 1;
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                        //puan atama SONU-*-*-*-*-*-*--*
                                        break;
                                    }
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.SetCursorPosition(1, 7);
                                    Console.WriteLine("                                                                          ");
                                    Console.WriteLine("                                                                          ");
                                    Console.Write("                                                                          ");
                                    Console.SetCursorPosition(1, 7);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nWrong coordinate. Please try again : ");
                                    continue;
                                }
                                else if (userCoordinate == 15)//14.indis
                                {
                                    if (board[15] != 0 | board[13] != 0 | board[12] != 0)
                                    {
                                        //puan atama -*-*-*-*-*-*--*
                                        board[userCoordinate - 1] = 1;
                                        if (board[13] == -1)//13. indiste bilgisayarın taşı varsa
                                        {
                                            for (int i = 13; 0 <= i; i--)//o taştan itibaren köşeye kadar kontrol et
                                            {
                                                if (board[i] == 0)//boşluk varsa çık
                                                {
                                                    break;
                                                }
                                                if (board[i] == 1)//kullanıcının taşı geldiğinde
                                                {
                                                    for (int j = 13; i < j; j--)//13. indisten itibaren 1 yap
                                                    {
                                                        board[j] = 1;
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                        //puan atama SONU-*-*-*-*-*-*--*
                                        break;
                                    }
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.SetCursorPosition(1, 7);
                                    Console.WriteLine("                                                                          ");
                                    Console.WriteLine("                                                                          ");
                                    Console.Write("                                                                          ");
                                    Console.SetCursorPosition(1, 7);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nWrong coordinate. Please try again : ");
                                    continue;
                                }
                                else
                                {
                                    if (board[14] != 0 | board[13] != 0)
                                    {
                                        //puan atama -*-*-*-*-*-*--*
                                        board[userCoordinate - 1] = 1;
                                        if (board[14] == -1)//13. indiste bilgisayarın taşı varsa
                                        {
                                            for (int i = 14; 0 <= i; i--)//o taştan itibaren köşeye kadar kontrol et
                                            {
                                                if (board[i] == 0)//boşluk varsa çık
                                                {
                                                    break;
                                                }
                                                if (board[i] == 1)//kullanıcının taşı geldiğinde
                                                {
                                                    for (int j = userCoordinate - 1; j < i; j++)//kullanıcının taşına kadar hepsini 1 yap
                                                    {
                                                        board[j] = 1;
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                        //puan atama SONU-*-*-*-*-*-*--*
                                        break;
                                    }
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.SetCursorPosition(1, 7);
                                    Console.WriteLine("                                                                          ");
                                    Console.WriteLine("                                                                          ");
                                    Console.Write("                                                                          ");
                                    Console.SetCursorPosition(1, 7);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nWrong coordinate. Please try again : ");
                                    continue;
                                }
                            }
                            //get coordinate and check END**********************

                            //write change of board---
                            uPointCounter = 0;
                            cPointCounter = 0;
                            for (int i = 0; i < 16; i++)
                            {
                                Console.SetCursorPosition(2 * i + 2, 4);
                                if (board[i] == 0)
                                {
                                    continue;
                                }
                                if (board[i] == -1)
                                {
                                    cPointCounter++;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    if (3 < i & i < 12)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Gray;
                                        Console.Write("O");
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.Write("O");
                                    }
                                    continue;
                                }
                                if (board[i] == 1)
                                {
                                    uPointCounter++;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    if (3 < i & i < 12)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Gray;
                                        Console.Write("X");
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.Write("X");
                                    }

                                }
                            }//write change of board END **
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(61, 3);
                            Console.Write(cPointCounter);

                            Console.SetCursorPosition(61, 2);
                            Console.Write(uPointCounter);
                            roundCounter++;
                            Console.SetCursorPosition(61, 1);
                            Console.Write(roundCounter);
                            Console.SetCursorPosition(1, 9);
                            Console.WriteLine("Please enter for next round");
                            Console.ReadLine();

                            //turn of computer*******************************************************************************
                            int[] temp = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };///////////////////////

                            //**********GEÇİÇİ DİZİ ATAMALARI**************-----*******
                            if (board[0] == 0)//köşeyi alabilecekse değeri -3 yap
                            {
                                temp[0] = 0;
                                if (board[1] != 0 || board[2] != 0)
                                {
                                    temp[0] = -3;
                                }

                            }
                            if (board[15] == 0)//köşeyi alabilecekse değeri -3 yap
                            {
                                temp[15] = 0;
                                if (board[14] != 0 || board[13] != 0)
                                {
                                    temp[15] = -3;
                                }
                            }
                            for (int i = 1; i < 15; i++)
                            {
                                if (board[i] == 0)//boşluk var ve kullanıcının taşından en az 2 birim uzaksa -2 ata
                                {
                                    if (0 < i && i < 15)//boşluk varsa 0 ata
                                    {
                                        temp[i] = 0;
                                    }
                                    //ara değerse     & sağ ve solda  kullanıcının sayısı yoksa   &   (iki birim uzağı boş değil veya yanında bilgisayarın sayısı varsa)         
                                    if (i <= 11 && 4 <= i && board[i + 1] != 1 && board[i - 1] != 1 && (board[i + 2] != 0 || board[i - 2] != 0 || board[i + 1] == -1 || board[i - 1] == -1))
                                    {
                                        temp[i] = -2;
                                    }
                                    if (0 < i && i < 4)//1den 3e kadar
                                    {
                                        if (board[i + 1] != 1 && board[i - 1] != 1)//boşluğun yanında kullanıcının taşı yoksa
                                        {
                                            if (board[i + 2] != 0 || board[i + 1] == -1) // iki birim uzağı boş değil veya birim yanında bilgisayarın taşı varsa
                                            {
                                                temp[i] = -2;
                                            }
                                        }
                                    }
                                    if (11 < i && i < 15)//12den 14 e kadar
                                    {
                                        if (board[i + 1] != 1 && board[i - 1] != 1)//boşluğun yanında kullanıcının taşı yoksa
                                        {
                                            if (board[i - 2] != 0 || board[i - 1] == -1)// iki birim uzağı boş değil veya birim yanında bilgisayarın taşı varsa
                                            {
                                                temp[i] = -2;
                                            }
                                        }
                                    }

                                }//boşluk var ve kullanıcının taşından en az 2 birim uzaksa -2 ata SONU
                            }

                            //**********GEÇİÇİ DİZİ ATAMALARI SONU**************-----*******



                            for (int i = 1; i < 16; i++)//taş alabiliyor mu?
                            {
                                if (board[i - 1] == 0 & board[i] == 1)// sağa doğru bir boşluğun yanında kullanıcının taşı var mı?
                                {

                                    for (int j = i; j < 16; j++)
                                    {
                                        if (board[j] == 0)//kullanıcının taşından sonra boşluk varsa çık.Bir puan getiri olmayacak.
                                        {
                                            break;
                                        }
                                        if (board[j] == -1)//kullanıcının taşından sonra bilgisayarın taşı gelirse
                                        {
                                            temp[i - 1] = j - i + 1;//boşluğun bulunduğu indise geçici dizide kaç tane kullanıcı taşını alabildiğini ata.
                                            flag1 = true;
                                            break;
                                        }
                                    }
                                }
                                if (board[16 - i] == 0 & board[15 - i] == 1)// sola doğru bir boşluğun yanında kullanıcının taşı var mı?
                                {
                                    for (int j = 15 - i; 0 <= j; j--)
                                    {
                                        if (board[j] == 0)//kullanıcının taşından sonra boşluk varsa çık
                                        {
                                            break;
                                        }
                                        if (board[j] == -1)//kullanıcının taşından sonra bilgisayarın taşı gelirse
                                        {
                                            temp[16 - i] += 15 - i - j + 1;//boşluğun bulunduğu indise geçici dizide kaç tane kullanıcı taşını alabildiğini ata.
                                            flag2 = true;
                                            break;
                                        }
                                    }
                                }
                            }
                            // En yüksek değeri bul.
                            tempNumber = -1;
                            for (int i = 0; i < 16; i++)
                            {
                                if (temp[i] > tempNumber)
                                {
                                    tempNumber = temp[i];
                                }
                            }
                            //----

                            tempNumber = temp.ToList().IndexOf(tempNumber); //Enyüksek değerin bulunduğu indisi tempnumber a ata
                            if (flag1)//sağa doğru kontrole girdiyse
                            {
                                computerCoordinate = tempNumber;//bilgisayarın oynadğı yeri ekrana yazdırmak için.
                                for (int i = tempNumber; i < 16; i++)//En yüksek değerin indisinden başla
                                {
                                    if (board[i] == -1)//kendi taşına kadar arttır
                                    {
                                        break;
                                    }
                                    board[i] = -1;//ve boardda değiştir.
                                }

                            }
                            if (flag2)//sola doğru kontrole girdiyse
                            {
                                computerCoordinate = tempNumber;
                                for (int i = tempNumber; 0 <= i; i--)
                                {

                                    if (board[i] == -1)
                                    {
                                        break;
                                    }
                                    board[i] = -1;
                                }

                            }

                            if (flag1 == false && flag2 == false)//sağa ve sola puan alamıyorsa köşelere koyma durumu
                            {
                                while (true)
                                {
                                    if (temp[0] == -3) // köşeye koyabiliyor mu?
                                    {
                                        computerCoordinate = 0;
                                        board[0] = -1;
                                        flag3 = false;
                                        flag4 = false;
                                        flag5 = false;
                                        break;
                                    }
                                    if (temp[15] == -3) // köşeye koyabiliyor mu?
                                    {
                                        computerCoordinate = 15;
                                        board[15] = -1;
                                        flag3 = false;
                                        flag4 = false;
                                        flag5 = false;
                                        break;
                                    }
                                    break;
                                }



                                if (flag3)
                                {
                                    for (int i = 1; i < 5; i++)//köşeleri kaptırmamak için
                                    {
                                        if ((i == 1 || i == 2) && (temp[i] == -2 && board[i + 1] != -1)) // 1. veya 2. indiste tempteki eleman -2'yse ve sağında bilgisayarın taşı yoksa 
                                        {
                                            temp[i] = -4;//temp -2 yi -4 yap
                                        }
                                        if ((i == 3 || i == 4) && (temp[i + 10] == -2 && board[i + 9] != -1))//13. veya 14.  indiste tempteki eleman -2'yse ve sağında bilgisayarın taşı yoksa
                                        {
                                            temp[i + 10] = -4;
                                        }
                                    }
                                    for (int i = 0; i < 16; i++)
                                    {
                                        if (temp[i] == -2)//elemanlardan herhangi biri -2'yse
                                        {
                                            while (true)
                                            {
                                                tempNumber = random.Next(0, 16);//rasgele sayı üret

                                                //üretilen sayı güvenli yerdeyse ve random sayının bulunduğu indis boşsa ve yanında kullanıcının taşı yoksa
                                                if (board[tempNumber] == 0 && 3 < tempNumber && tempNumber < 12 && board[tempNumber + 1] != 1 && board[tempNumber - 1] != 1)
                                                {
                                                    computerCoordinate = tempNumber;
                                                    board[tempNumber] = -1;
                                                    flag4 = false;
                                                    flag5 = false;
                                                    break;
                                                }
                                                if (temp[tempNumber] == -2)//bu sayı herhangi bir -2'nin bulunduğu indisi verinceye kadar tekrar üret
                                                {
                                                    computerCoordinate = tempNumber;
                                                    board[tempNumber] = -1;
                                                    flag4 = false;
                                                    flag5 = false;
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                    }
                                }
                                if (flag4)//bilgisayar kendi taşının yanına koyacağı durumlar
                                {
                                    for (int i = 1; i < 15; i++)
                                    {
                                        if (temp[i] == 0 && (board[i + 1] == -1 || board[i - 1] == -1))
                                        {
                                            while (true)
                                            {
                                                tempNumber = random.Next(1, 15);
                                                if (temp[tempNumber] == 0 && (board[tempNumber + 1] == -1 || board[tempNumber - 1] == -1))
                                                {
                                                    computerCoordinate = i;
                                                    board[i] = -1;
                                                    flag5 = false;
                                                    break;
                                                }
                                            }
                                            break;

                                        }
                                    }
                                }
                                if (flag5)//en kötü durumda rasgele bir yere sayı koy
                                {
                                    while (true)
                                    {
                                        tempNumber = random.Next(0, 16);
                                        if (board[tempNumber] == 0)
                                        {
                                            board[tempNumber] = -1;
                                            break;
                                        }
                                    }
                                }



                            }//else



                            flag1 = false;
                            flag2 = false;
                            flag3 = true;
                            flag4 = true;
                            flag5 = true;
                            //write change of board---
                            cPointCounter = 0;
                            uPointCounter = 0;
                            for (int i = 0; i < 16; i++)
                            {
                                Console.SetCursorPosition(2 * i + 2, 4);
                                if (board[i] == 0)
                                {
                                    continue;
                                }
                                if (board[i] == -1)
                                {
                                    cPointCounter++;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    if (3 < i & i < 12)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Gray;
                                        Console.Write("O");
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.Write("O");
                                    }
                                    continue;
                                }
                                if (board[i] == 1)
                                {
                                    uPointCounter++;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    if (3 < i & i < 12)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Gray;
                                        Console.Write("X");
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.Write("X");
                                    }

                                }
                            }//write change of board END **
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(61, 3);
                            Console.Write("     ");
                            Console.SetCursorPosition(61, 3);
                            Console.Write(cPointCounter);

                            Console.SetCursorPosition(61, 2);
                            Console.Write("     ");
                            Console.SetCursorPosition(61, 2);
                            Console.Write(uPointCounter);
                            roundCounter++;
                            Console.SetCursorPosition(61, 1);
                            Console.Write(roundCounter);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(1, 7);
                            Console.WriteLine("                                                                          ");
                            Console.WriteLine("                                                                          ");
                            Console.Write("                                                                          ");
                            Console.SetCursorPosition(1, 8);
                            Console.Write("Computer move : {0}\nPlease enter for next round", computerCoordinate + 1);
                            Console.ReadLine();
                        }//END of other rounds


                        if (uPointCounter < cPointCounter)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(1, 7);
                            Console.WriteLine("                                                                          ");
                            Console.WriteLine("                                                                          ");
                            Console.WriteLine("                                                                          ");
                            Console.WriteLine("                                                                          ");
                            Console.SetCursorPosition(1, 7);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("                    COMPUTER WIN !!!");
                            Console.ReadLine();
                        }
                        if (uPointCounter > cPointCounter)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(1, 7);
                            Console.WriteLine("                                                                          ");
                            Console.WriteLine("                                                                          ");
                            Console.WriteLine("                                                                          ");
                            Console.WriteLine("                                                                          ");
                            Console.SetCursorPosition(1, 7);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("                    USER WIN !!!");
                            Console.ReadLine();
                        }

                        //*********************************************Game 1 END*************************************************
                    }
                    break;
                case 2:
                    {
                        
                        
                        // sınır dışı -1 boş 0 bilgisayar 1 kullanıcı 2...
                        int[,] board ={{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                                       {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                                       {-1,-1, 0, 0, 0, 0, 0, 0, 0 ,0,-1,-1},
                                       {-1,-1, 0, 0, 0, 0, 0, 0, 0 ,0,-1,-1},
                                       {-1,-1, 0, 0, 0, 0, 0, 0, 0 ,0,-1,-1},
                                       {-1,-1, 0, 0, 0, 0, 0, 0, 0 ,0,-1,-1},
                                       {-1,-1, 0, 0, 0, 0, 0, 0, 0 ,0,-1,-1},
                                       {-1,-1, 0, 0, 0, 0, 0, 0, 0 ,0,-1,-1},
                                       {-1,-1, 0, 0, 0, 0, 0, 0, 0 ,0,-1,-1},
                                       {-1,-1, 0, 0, 0, 0, 0, 0, 0 ,0,-1,-1},
                                       {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                                       {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1}};

                        
                        string check2 = "";
                        int userCoordinateX = 0;
                        int userCoordinateY = 0;
                       

                        //*********************************************Game 2*************************************************

                        //8x8 Interface
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@"            
   1 2 3 4 5 6 7 8      
 + - - - - - - - - +    Round    :0
1| . . . . . . . . |    Human    :0
2| . . . . . . . . |    Computer :0
3| . .         . . | 
4| . .         . . | 
5| . .         . . | 
6| . .         . . | 
7| . . . . . . . . | 
8| . . . . . . . . |                  
 + - - - - - - - - +                 
");
                        
                        
                    
                        Console.SetCursorPosition(7, 5);
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Write(". . . .");
                        Console.SetCursorPosition(7, 6);
                        Console.Write(". . . .");
                        Console.SetCursorPosition(7, 7);
                        Console.Write(". . . .");
                        Console.SetCursorPosition(7, 8);
                        Console.Write(". . . .");
                        //interface END

                        int uPointCounter = 0;
                        int cPointCounter = 0;
                        int roundCounter = 0;

                        for (int round = 0; round < 32; round++)//round
                        {
                            //user turn
                            userCoordinateX = 0;
                            userCoordinateY = 0;
                            while (true)
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(1, 12);
                                Console.WriteLine("                                                                          ");
                                Console.Write("                                                                          ");
                                Console.SetCursorPosition(1, 12);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Please enter vertical coordinate :  ");
                                check = Console.ReadLine();
                                Console.Write("Please enter horizontal coordinate :  ");
                                check2 = Console.ReadLine();
                                if ((!check.All(char.IsDigit) || (check == "")) || (!check2.All(char.IsDigit) || (check2 == "")))//sayımı değil mi?
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.SetCursorPosition(1, 12);

                                    Console.WriteLine("                                                                          ");
                                    Console.Write("                                                                          ");
                                    Console.SetCursorPosition(1, 12);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nWrong coordinate. Press enter");
                                    Console.ReadLine();
                                    continue;
                                }
                                userCoordinateX = Convert.ToInt32(check);
                                userCoordinateY = Convert.ToInt32(check2);

                                if (!(0 < userCoordinateX & userCoordinateX < 9) || !(0 < userCoordinateY & userCoordinateY < 9))//1-16 mı?
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.SetCursorPosition(1, 12);
                                    Console.WriteLine("                                                                          ");
                                    Console.WriteLine("                                                                          ");
                                    Console.Write("                                                                          ");
                                    Console.SetCursorPosition(1, 12);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nWrong coordinate. Please enter 1-8 among number. Press enter");
                                    Console.ReadLine();
                                    continue;
                                }
                                userCoordinateX += 1;
                                userCoordinateY += 1;
                                if (board[userCoordinateX, userCoordinateY] != 0)//1-16 mı?
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.SetCursorPosition(1, 12);
                                    Console.WriteLine("                                                                          ");
                                    Console.WriteLine("                                                                          ");
                                    Console.Write("                                                                          ");
                                    Console.SetCursorPosition(1, 12);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nWrong coordinate. Press enter.");
                                    Console.WriteLine();
                                    continue;
                                }
                                //güvenli bölgede yada herhangi bir taşa en fazla 2 uzaklıktaysa                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                                if (((3 < userCoordinateX && userCoordinateX < 8) && (3 < userCoordinateY && userCoordinateY < 8)) || (board[userCoordinateX - 1, userCoordinateY - 1] > 0 || 0 < board[userCoordinateX - 1, userCoordinateY] || 0 < board[userCoordinateX - 1, userCoordinateY + 1] || 0 < board[userCoordinateX, userCoordinateY - 1] || 0 < board[userCoordinateX, userCoordinateY + 1] || 0 < board[userCoordinateX + 1, userCoordinateY - 1] || 0 < board[userCoordinateX + 1, userCoordinateY] || 0 < board[userCoordinateX + 1, userCoordinateY + 1]) || 0 < board[userCoordinateX - 2, userCoordinateY - 2] || 0 < board[userCoordinateX - 2, userCoordinateY] || 0 < board[userCoordinateX - 2, userCoordinateY + 2] || 0 < board[userCoordinateX, userCoordinateY - 2] || 0 < board[userCoordinateX, userCoordinateY + 2] || 0 < board[userCoordinateX + 2, userCoordinateY - 2] || 0 < board[userCoordinateX + 2, userCoordinateY] || 0 < board[userCoordinateX + 2, userCoordinateY + 2] || 0 < board[userCoordinateX - 2, userCoordinateY - 1] || 0 < board[userCoordinateX - 2, userCoordinateY + 1] || 0 < board[userCoordinateX - 1, userCoordinateY - 2] || 0 < board[userCoordinateX - 1, userCoordinateY + 2] || 0 < board[userCoordinateX + 1, userCoordinateY - 2] || 0 < board[userCoordinateX + 1, userCoordinateY + 2] || 0 < board[userCoordinateX + 2, userCoordinateY - 1] || 0 < board[userCoordinateX + 2, userCoordinateY + 1])
                                {
                                    board[userCoordinateX, userCoordinateY] = 2;
                                    if (board[userCoordinateX - 1, userCoordinateY - 1] == 1)
                                    {
                                        for (int i = 1; i < 8; i++)//koşula göre en uzak noktaya kadar git
                                        {
                                            if (board[userCoordinateX - i, userCoordinateY - i] == 0 || board[userCoordinateX - i, userCoordinateY - i] == -1)
                                            {
                                                break;//sınır dışı veya boşluk gelirse çık
                                            }
                                            if (board[userCoordinateX - i, userCoordinateY - i] == 2)
                                            {
                                                for (int j = 1; j < i; j++)
                                                {
                                                    board[userCoordinateX - j, userCoordinateY - j] = 2;
                                                }
                                                break;//koşul sağlanırsa üstteki döngüdende çıkması gerekir
                                            }
                                        }
                                    }
                                    if (board[userCoordinateX - 1, userCoordinateY] == 1)
                                    {
                                        for (int i = 1; i < 8; i++)
                                        {
                                            if (board[userCoordinateX - i, userCoordinateY] == 0 || board[userCoordinateX - i, userCoordinateY] == -1)
                                            {
                                                break;
                                            }
                                            if (board[userCoordinateX - i, userCoordinateY] == 2)
                                            {
                                                for (int j = 1; j < i; j++)
                                                {
                                                    board[userCoordinateX - j, userCoordinateY] = 2;
                                                }
                                                break;
                                            }
                                        }
                                    }
                                    if (board[userCoordinateX - 1, userCoordinateY + 1] == 1) //sağ üst çapraz
                                    {
                                        for (int i = 1; i < 8; i++)//koşula göre en uzak noktaya kadar git
                                        {
                                            if (board[userCoordinateX - i, userCoordinateY + i] == 0 || board[userCoordinateX - i, userCoordinateY + i] == -1)
                                            {
                                                break;//sınır dışı veya boşluk gelirse çık
                                            }
                                            if (board[userCoordinateX - i, userCoordinateY + i] == 2)
                                            {
                                                for (int j = 1; j < i; j++)
                                                {
                                                    board[userCoordinateX - j, userCoordinateY + j] = 2;
                                                }
                                                break;//koşul sağlanırsa üstteki döngüdende çıkması gerekir
                                            }
                                        }
                                    }
                                    if (board[userCoordinateX, userCoordinateY - 1] == 1)//sol
                                    {
                                        for (int i = 1; i < 8; i++)//koşula göre en uzak noktaya kadar git
                                        {
                                            if (board[userCoordinateX, userCoordinateY - i] == 0 || board[userCoordinateX, userCoordinateY - i] == -1)
                                            {
                                                break;//sınır dışı veya boşluk gelirse çık
                                            }
                                            if (board[userCoordinateX, userCoordinateY - i] == 2)
                                            {
                                                for (int j = 1; j < i; j++)
                                                {
                                                    board[userCoordinateX, userCoordinateY - j] = 2;
                                                }
                                                break;//koşul sağlanırsa üstteki döngüdende çıkması gerekir
                                            }
                                        }
                                    }
                                    if (board[userCoordinateX, userCoordinateY + 1] == 1)//sağ
                                    {
                                        for (int i = 1; i < 8; i++)//koşula göre en uzak noktaya kadar git
                                        {
                                            if (board[userCoordinateX, userCoordinateY + i] == 0 || board[userCoordinateX, userCoordinateY + i] == -1)
                                            {
                                                break;//sınır dışı veya boşluk gelirse çık
                                            }
                                            if (board[userCoordinateX, userCoordinateY + i] == 2)
                                            {
                                                for (int j = 1; j < i; j++)
                                                {
                                                    board[userCoordinateX, userCoordinateY + j] = 2;
                                                }
                                                break;//koşul sağlanırsa üstteki döngüdende çıkması gerekir
                                            }
                                        }
                                    }
                                    if (board[userCoordinateX + 1, userCoordinateY - 1] == 1)//sol aşşa çapraz
                                    {
                                        for (int i = 1; i < 8; i++)//koşula göre en uzak noktaya kadar git
                                        {
                                            if (board[userCoordinateX + i, userCoordinateY - i] == 0 || board[userCoordinateX, userCoordinateY - i] == -1)
                                            {
                                                break;//sınır dışı veya boşluk gelirse çık
                                            }
                                            if (board[userCoordinateX + i, userCoordinateY - i] == 2)
                                            {
                                                for (int j = 1; j < i; j++)
                                                {
                                                    board[userCoordinateX + i, userCoordinateY - j] = 2;
                                                }
                                                break;//koşul sağlanırsa üstteki döngüdende çıkması gerekir
                                            }
                                        }
                                    }
                                    if (board[userCoordinateX + 1, userCoordinateY] == 1)// aşşa çapraz
                                    {
                                        for (int i = 1; i < 8; i++)//koşula göre en uzak noktaya kadar git
                                        {
                                            if (board[userCoordinateX + i, userCoordinateY] == 0 || board[userCoordinateX + i, userCoordinateY] == -1)
                                            {
                                                break;//sınır dışı veya boşluk gelirse çık
                                            }
                                            if (board[userCoordinateX + i, userCoordinateY] == 2)
                                            {
                                                for (int j = 1; j < i; j++)
                                                {
                                                    board[userCoordinateX + i, userCoordinateY] = 2;
                                                }
                                                break;//koşul sağlanırsa üstteki döngüdende çıkması gerekir
                                            }
                                        }
                                    }
                                    if (board[userCoordinateX + 1, userCoordinateY + 1] == 1)//sağ aşşa çapraz
                                    {
                                        for (int i = 1; i < 8; i++)//koşula göre en uzak noktaya kadar git
                                        {
                                            if (board[userCoordinateX + i, userCoordinateY + i] == 0 || board[userCoordinateX, userCoordinateY + i] == -1)
                                            {
                                                break;//sınır dışı veya boşluk gelirse çık
                                            }
                                            if (board[userCoordinateX + i, userCoordinateY + i] == 2)
                                            {
                                                for (int j = 1; j < i; j++)
                                                {
                                                    board[userCoordinateX + i, userCoordinateY + j] = 2;
                                                }
                                                break;//koşul sağlanırsa üstteki döngüdende çıkması gerekir
                                            }
                                        }
                                    }

                                    break;//istenilen koşul sağlanmıştır.
                                }
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(1, 12);
                                Console.WriteLine("                                                                          ");
                                Console.Write("                                                                          ");
                                Console.SetCursorPosition(1, 12);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\nWrong coordinate. Press enter");
                                Console.ReadLine();
                            }

                            //write board????????????????????????????????????????????????????????????????????

                            uPointCounter = 0;
                            cPointCounter = 0;
                            for (int x = 2; x < 10; x++)
                            {
                                for (int y = 2; y < 10; y++)
                                {
                                    if (board[x, y] == 0)
                                    {
                                        continue;
                                    }
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.SetCursorPosition(y + y - 1, x + 1);
                                    if (board[x, y] == 1)
                                    {
                                        cPointCounter++;
                                        if (3 < x && x < 8 && 3 < y && y < 8)
                                        {
                                            Console.BackgroundColor = ConsoleColor.Gray;
                                            Console.Write("O");
                                            Console.BackgroundColor = ConsoleColor.Black;
                                        }
                                        else
                                        {
                                            Console.Write("O");
                                        }

                                    }
                                    if (board[x, y] == 2)
                                    {
                                        uPointCounter++;
                                        if (3 < x && x < 8 && 3 < y && y < 8)
                                        {
                                            Console.BackgroundColor = ConsoleColor.Gray;
                                            Console.Write("X");
                                            Console.BackgroundColor = ConsoleColor.Black;
                                        }
                                        else
                                        {
                                            Console.Write("X");
                                        }
                                    }
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(34, 4);
                            Console.Write(cPointCounter);

                            Console.SetCursorPosition(34, 3);
                            Console.Write(uPointCounter);
                            roundCounter++;
                            Console.SetCursorPosition(34, 2);
                            Console.Write(roundCounter);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(1, 12);
                            Console.WriteLine("                                                                          ");
                            Console.WriteLine("                                                                          ");
                            Console.Write("                                                                          ");
                            Console.SetCursorPosition(1, 12);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(1, 12);
                            Console.WriteLine("Please enter for next round");
                            Console.ReadLine();


                            //__________________________________________________________________________________
                            //computer turn
                            //**********PUAN DİZİSİ ATAMALARI  **************-----*******
                            int[,] pointBoard ={{-1,-1,-1,-1,-1,-1,-1,-1},
                                                {-1,-1,-1,-1,-1,-1,-1,-1},
                                                {-1,-1, 0, 0, 0, 0,-1,-1},
                                                {-1,-1, 0, 0, 0, 0,-1,-1},
                                                {-1,-1, 0, 0, 0, 0,-1,-1},  //en son puana göre yer seçmede güvenli bölge kontrolü yapılıp en iyi durum seçilecek.
                                                {-1,-1, 0, 0, 0, 0,-1,-1},  //yakınında kullanıcı taşı yoksa değer 1 olacak..
                                                {-1,-1,-1,-1,-1,-1,-1,-1},
                                                {-1,-1,-1,-1,-1,-1,-1,-1},};


                            for (int X = 2; X < 10; X++)
                            {
                                for (int Y = 2; Y < 10; Y++)
                                {                            //--------------------------------------------------bir yanı-------------------------------------------------------------------------------------------------------------------------------------------   *************************************iki yanı ***********************************************************************************************************************************************************
                                    if (board[X, Y] == 0)//&& ((0 < board[X - 1, Y - 1] || 0 < board[X - 1, Y] || 0 < board[X - 1, Y + 1] || 0 < board[X, Y - 1] || 0 < board[X, Y + 1] || 0 < board[X + 1, Y - 1] || 0 < board[X + 1, Y] || 0 < board[X + 1, Y + 1]) || (0 < board[X  - 2, Y - 2] || 0 < board[X - 2, Y] || 0 < board[X - 2, Y + 2] || 0 < board[X, Y - 2] || 0 < board[X, Y + 2] || 0 < board[X + 2, Y - 2] || 0 < board[X + 2, Y] || 0 < board[X + 2, Y + 2])))
                                    {//*-*-*-*-*-*-*-*-*-TAŞ ALMA DURUM-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
                                        if (board[X - 1, Y - 1] == 2)//sol üst çaprazda kullanıcı taşı varsa.
                                        {
                                            pointBoard[X - 2, Y - 2] = 0;
                                            //puan atama____________________
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[X - i, Y - i] == 0 || board[X - i, Y - i] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    pointBoard[X - 2, Y - 2] = -2;// bununda puanı hesaplanabilir??
                                                    break;
                                                }
                                                if (board[X - i, Y - i] == 1)//kendi taşı gelirse, kaç taş aldığını yaz.
                                                {
                                                    pointBoard[X - 2, Y - 2] += i;
                                                    break;
                                                }
                                            }
                                            //____________________________
                                        }
                                        if (board[X - 1, Y] == 2)  //tam üstünde  kullanıcı taşı varsa..
                                        {
                                            pointBoard[X - 2, Y - 2] = 0;
                                            //puan atama____________________
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[X - i, Y] == 0 || board[X - i, Y] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    pointBoard[X - 2, Y - 2] = -2;
                                                    break;
                                                }
                                                if (board[X - i, Y] == 1)//kendi taşı gelirse, kaç taş aldığını yaz.
                                                {
                                                    pointBoard[X - 2, Y - 2] += i;
                                                    break;
                                                }
                                            }
                                            //____________________________
                                        }
                                        if (board[X - 1, Y + 1] == 2) //sağ üst çaprazda kullanıcı taşı varsa..
                                        {
                                            pointBoard[X - 2, Y - 2] = 0;
                                            //puan atama____________________
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[X - i, Y + i] == 0 || board[X - i, Y + i] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    pointBoard[X - 2, Y - 2] = -2;
                                                    break;
                                                }
                                                if (board[X - i, Y + i] == 1)//kendi taşı gelirse, kaç taş aldığını yaz.
                                                {
                                                    pointBoard[X - 2, Y - 2] += i;
                                                    break;
                                                }
                                            }
                                            //____________________________
                                        }
                                        if (board[X - 1, Y] == 2) //sol tarafta kullanıcı taşı varsa..
                                        {
                                            pointBoard[X - 2, Y - 2] = 0;
                                            //puan atama____________________
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[X, Y - i] == 0 || board[X, Y - i] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    pointBoard[X - 2, Y - 2] = -2;
                                                    break;
                                                }
                                                if (board[X, Y - i] == 1)//kendi taşı gelirse, kaç taş aldığını yaz.
                                                {
                                                    pointBoard[X - 2, Y - 2] += i;
                                                    break;
                                                }
                                            }
                                            //____________________________
                                        }
                                        if (board[X, Y + 1] == 2) //sağ tarafta kullanıcı taşı varsa..
                                        {
                                            pointBoard[X - 2, Y - 2] = 0;
                                            //puan atama____________________
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[X, Y + i] == 0 || board[X, Y + i] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    pointBoard[X - 2, Y - 2] = -2;
                                                    break;
                                                }
                                                if (board[X, Y + i] == 1)//kendi taşı gelirse, kaç taş aldığını yaz.
                                                {
                                                    pointBoard[X - 2, Y - 2] += i;
                                                    break;
                                                }
                                            }
                                            //____________________________
                                        }
                                        if (board[X + 1, Y - 1] == 2) //sol altta kullanıcı taşı varsa..
                                        {
                                            pointBoard[X - 2, Y - 2] = 0;
                                            //puan atama____________________
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[X + i, Y - i] == 0 || board[X + i, Y - i] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    pointBoard[X - 2, Y - 2] = -2;
                                                    break;
                                                }
                                                if (board[X + i, Y - i] == 1)//kendi taşı gelirse, kaç taş aldığını yaz.
                                                {
                                                    pointBoard[X - 2, Y - 2] += i;
                                                    break;
                                                }
                                            }
                                            //____________________________
                                        }
                                        if (board[X + 1, Y] == 2) //altta kullanıcı taşı varsa..
                                        {
                                            pointBoard[X - 2, Y - 2] = 0;
                                            //puan atama____________________
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[X + i, Y] == 0 || board[X + i, Y] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    pointBoard[X - 2, Y - 2] = -2;
                                                    break;
                                                }
                                                if (board[X + i, Y] == 1)//kendi taşı gelirse, kaç taş aldığını yaz.
                                                {
                                                    pointBoard[X - 2, Y - 2] += i;
                                                    break;
                                                }
                                            }
                                            //____________________________
                                        }
                                        if (board[X + 1, Y + 1] == 2) //sağ altta kullanıcı taşı varsa..
                                        {
                                            pointBoard[X - 2, Y - 2] = 0;
                                            //puan atama____________________
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[X + i, Y + i] == 0 || board[X + i, Y + i] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    pointBoard[X - 2, Y - 2] = -2;
                                                    break;
                                                }
                                                if (board[X + i, Y + i] == 1)//kendi taşı gelirse, kaç taş aldığını yaz.
                                                {
                                                    pointBoard[X - 2, Y - 2] += i;
                                                    break;
                                                }
                                            }
                                            //____________________________
                                        }
                                        //*-*-*-*-*-*-*-*-*-TAŞ ALMA DURUM SONU-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

                                        // bir birim yanında kullanıcının taşı yoksa ve iki birim uzağında her hangi bir taş varsa   veya güvenli bölgedeyse                                                                                              =======                                                                                                                                                                                                   ===iki yanının araları                                                                                                                                                                                                 ========                                                                                                                                                                                                                                                                                          
                                        if ((board[X - 1, Y - 1] != 2 && 2 != board[X - 1, Y] && 2 != board[X - 1, Y + 1] && 2 != board[X, Y - 1] && 2 != board[X, Y + 1] && 2 != board[X + 1, Y - 1] && 2 != board[X + 1, Y] && 2 != board[X + 1, Y + 1]) && (0 < board[X - 2, Y - 2] || 0 < board[X - 2, Y] || 0 < board[X - 2, Y + 2] || 0 < board[X, Y - 2] || 0 < board[X, Y + 2] || 0 < board[X + 2, Y - 2] || 0 < board[X + 2, Y] || 0 < board[X + 2, Y + 2] || 0 < board[X - 2, Y - 1] || 0 < board[X - 2, Y + 1] || 0 < board[X - 1, Y - 2] || 0 < board[X - 1, Y + 2] || 0 < board[X + 1, Y - 2] || 0 < board[X + 1, Y + 2] || 0 < board[X + 2, Y - 1] || 0 < board[X + 2, Y + 1] || (3 < X && X < 8 && 3 < Y && Y < 8)))
                                        {
                                            pointBoard[X - 2, Y - 2] = 1;
                                        }


                                    }
                                }
                            }
                            //zor modda kenarlar daha avantajlı olduğundan ekstra beş puan alır, en köşe ekstra 10 
                            if (mode == 1)
                            {
                                for (int x = 0; x < 8; x++)
                                {
                                    for (int y = 0; y < 8; y++)
                                    {
                                        if (((x == 0 || x == 7) || (y == 0 || y == 7)) && -1 < pointBoard[x, y])
                                        {
                                            pointBoard[x, y] += 5;
                                            if ((x == 0 && y == 0) || (x == 0 && y == 7) || (x == 7 && y == 0) || (x == 7 && y == 7))
                                            {
                                                pointBoard[x, y] += 5;
                                            }
                                        }
                                    }
                                }
                            }
                            //**********PUAN DİZİSİ ATAMALARI SONU**************-----*******

                            //find a maximum number coordinate
                            int max = 0;
                            for (int i = 0; i < 8; i++)
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    if (pointBoard[i, j] > max)
                                    {
                                        max = pointBoard[i, j];
                                    }
                                }
                            }
                            int computerX = 0;
                            int computerY = 0;
                            int rdmX = 0;
                            int rdmY = 0;
                            bool vhile = true;
                            bool cflag = true;
                            bool cflag2 = true;
                            bool cflag3 = true;
                            bool cflag4 = true;
                            if (1 < max)
                            {
                                while (vhile)
                                {

                                    rdmX = random.Next(2, 10);
                                    rdmY = random.Next(2, 10);
                                    if (pointBoard[rdmX - 2, rdmY - 2] == max)
                                    {
                                        vhile = false;
                                        if (board[rdmX - 1, rdmY - 1] == 2)//sol üst çaprazda kullanıcı taşı varsa.
                                        {
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[rdmX - i, rdmY - i] == 0 || board[rdmX - i, rdmY - i] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    break;
                                                }
                                                if (board[rdmX - i, rdmY - i] == 1)//kendi taşı gelirse, oraya kadar taşları çevir
                                                {
                                                    for (int j = 0; j < i; j++)
                                                    {
                                                        board[rdmX - j, rdmY - j] = 1;
                                                    }
                                                    break; //koşul bir kere sağlandığında  diğer taşlara bakmaması gerekir.
                                                }
                                            }
                                            //____________________________
                                        }


                                        if (board[rdmX - 1, rdmY] == 2)//üstünde kullanıcı taşı varsa.
                                        {
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[rdmX - i, rdmY] == 0 || board[rdmX - i, rdmY] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    break;
                                                }
                                                if (board[rdmX - i, rdmY] == 1)//kendi taşı gelirse, oraya kadar taşları çevir
                                                {
                                                    for (int j = 0; j < i; j++)
                                                    {
                                                        board[rdmX - j, rdmY] = 1;
                                                    }
                                                    break; //koşul bir kere sağlandığında  diğer taşlara bakmaması gerekir.
                                                }
                                            }
                                            //____________________________
                                        }

                                        if (board[rdmX - 1, rdmY + 1] == 2)//üstünde kullanıcı taşı varsa.
                                        {
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[rdmX - i, rdmY + i] == 0 || board[rdmX - i, rdmY + i] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    break;
                                                }
                                                if (board[rdmX - i, rdmY + i] == 1)//kendi taşı gelirse, oraya kadar taşları çevir
                                                {
                                                    for (int j = 0; j < i; j++)
                                                    {
                                                        board[rdmX - j, rdmY + j] = 1;
                                                    }
                                                    break; //koşul bir kere sağlandığında  diğer taşlara bakmaması gerekir.
                                                }
                                            }
                                            //____________________________
                                        }

                                        if (board[rdmX, rdmY - 1] == 2)//solunda kullanıcı taşı varsa.
                                        {
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[rdmX, rdmY - i] == 0 || board[rdmX, rdmY - i] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    break;
                                                }
                                                if (board[rdmX, rdmY - i] == 1)//kendi taşı gelirse, oraya kadar taşları çevir
                                                {
                                                    for (int j = 0; j < i; j++)
                                                    {
                                                        board[rdmX, rdmY - j] = 1;
                                                    }
                                                    break; //koşul bir kere sağlandığında  diğer taşlara bakmaması gerekir.
                                                }
                                            }
                                            //____________________________
                                        }

                                        if (board[rdmX, rdmY + 1] == 2)//sağında kullanıcı taşı varsa.
                                        {
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[rdmX, rdmY + i] == 0 || board[rdmX, rdmY + i] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    break;
                                                }
                                                if (board[rdmX, rdmY + i] == 1)//kendi taşı gelirse, oraya kadar taşları çevir
                                                {
                                                    for (int j = 0; j < i; j++)
                                                    {
                                                        board[rdmX, rdmY + j] = 1;
                                                    }
                                                    break; //koşul bir kere sağlandığında  diğer taşlara bakmaması gerekir.
                                                }
                                            }
                                            //____________________________
                                        }


                                        if (board[rdmX + 1, rdmY - 1] == 2)//sol aşşağıda kullanıcı taşı varsa.
                                        {
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[rdmX + i, rdmY - i] == 0 || board[rdmX + i, rdmY - i] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    break;
                                                }
                                                if (board[rdmX + i, rdmY - i] == 1)//kendi taşı gelirse, oraya kadar taşları çevir
                                                {
                                                    for (int j = 0; j < i; j++)
                                                    {
                                                        board[rdmX + j, rdmY - j] = 1;
                                                    }
                                                    break; //koşul bir kere sağlandığında  diğer taşlara bakmaması gerekir.
                                                }
                                            }
                                            //____________________________
                                        }


                                        if (board[rdmX + 1, rdmY] == 2)//aşşağıda kullanıcı taşı varsa.
                                        {
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[rdmX + i, rdmY] == 0 || board[rdmX + i, rdmY] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    break;
                                                }
                                                if (board[rdmX + i, rdmY] == 1)//kendi taşı gelirse, oraya kadar taşları çevir
                                                {
                                                    for (int j = 0; j < i; j++)
                                                    {
                                                        board[rdmX + j, rdmY] = 1;
                                                    }
                                                    break; //koşul bir kere sağlandığında  diğer taşlara bakmaması gerekir.
                                                }
                                            }
                                            //____________________________
                                        }

                                        if (board[rdmX + 1, rdmY + 1] == 2)//sağ aşşağıda kullanıcı taşı varsa.
                                        {
                                            for (int i = 2; 0 < 9; i++)
                                            {
                                                if (board[rdmX + i, rdmY + i] == 0 || board[rdmX + i, rdmY + i] == -1)//boşluk veya -1 gelirse direk çıkılacak.
                                                {
                                                    break;
                                                }
                                                if (board[rdmX + i, rdmY + i] == 1)//kendi taşı gelirse, oraya kadar taşları çevir
                                                {
                                                    for (int j = 0; j < i; j++)
                                                    {
                                                        board[rdmX + j, rdmY + j] = 1;
                                                    }
                                                    break; //koşul bir kere sağlandığında  diğer taşlara bakmaması gerekir.
                                                }
                                            }
                                            //____________________________
                                        }

                                        board[rdmX, rdmY] = 1;
                                        computerX = rdmX;
                                        computerY = rdmY;
                                        cflag = false;
                                        cflag2 = false;
                                        cflag3 = false;
                                        cflag4 = false;
                                        break;
                                    }
                                }
                            }

                            if (cflag)//1 olan durumlar
                            {
                                while (true)
                                {
                                    rdmX = random.Next(2, 10);
                                    rdmY = random.Next(2, 10);
                                    if (pointBoard[rdmX - 2, rdmY - 2] == 1)
                                    {
                                        board[rdmX, rdmY] = 1;
                                        computerX = rdmX;
                                        computerY = rdmY;
                                        cflag2 = false;
                                        cflag3 = false;
                                        cflag4 = false;
                                        break;
                                    }
                                }
                            }

                            if (cflag2)// 0 olan durumlar
                            {
                                while (true)
                                {
                                    rdmX = random.Next(2, 10);
                                    rdmY = random.Next(2, 10);
                                    if (pointBoard[rdmX - 2, rdmY - 2] == 0)
                                    {
                                        board[rdmX, rdmY] = 1;
                                        computerX = rdmX;
                                        computerY = rdmY;
                                        cflag3 = false;
                                        cflag4 = false;
                                        break;
                                    }
                                }
                            }

                            if (cflag3)//en kötü durum, puan kaybetmesi muhtemel bi yer.
                            {
                                while (true)
                                {
                                    rdmX = random.Next(2, 10);
                                    rdmY = random.Next(2, 10);
                                    if (pointBoard[rdmX - 2, rdmY - 2] == -2)
                                    {
                                        board[rdmX, rdmY] = 1;
                                        computerX = rdmX;
                                        computerY = rdmY;
                                        cflag4 = false;
                                        break;
                                    }
                                }
                            }
                            if (cflag4) // en en en çok kötü durum.
                            {
                                while (true)
                                {
                                    rdmX = random.Next(2, 10);
                                    rdmY = random.Next(2, 10);
                                    if (board[rdmX, rdmY] == 0)
                                    {
                                        board[rdmX, rdmY] = 1;
                                        computerX = rdmX;
                                        computerY = rdmY;
                                        cflag4 = false;
                                        break;
                                    }
                                }
                            }
                            //-*--*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-************************---------------------******************************************

                            //write change
                            uPointCounter = 0;
                            cPointCounter = 0;
                            for (int x = 2; x < 10; x++)
                            {
                                for (int y = 2; y < 10; y++)
                                {
                                    if (board[x, y] == 0)
                                    {
                                        continue;
                                    }
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.SetCursorPosition(y + y - 1, x + 1);
                                    if (board[x, y] == 1)
                                    {
                                        cPointCounter++;
                                        if (3 < x && x < 8 && 3 < y && y < 8)
                                        {
                                            Console.BackgroundColor = ConsoleColor.Gray;
                                            Console.Write("O");
                                            Console.BackgroundColor = ConsoleColor.Black;
                                        }
                                        else
                                        {
                                            Console.Write("O");
                                        }

                                    }
                                    if (board[x, y] == 2)
                                    {
                                        uPointCounter++;
                                        if (3 < x && x < 8 && 3 < y && y < 8)
                                        {
                                            Console.BackgroundColor = ConsoleColor.Gray;
                                            Console.Write("X");
                                            Console.BackgroundColor = ConsoleColor.Black;
                                        }
                                        else
                                        {
                                            Console.Write("X");
                                        }
                                    }
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(34, 4);
                            Console.Write(cPointCounter);

                            Console.SetCursorPosition(34, 3);
                            Console.Write(uPointCounter);
                            roundCounter++;
                            Console.SetCursorPosition(34, 2);
                            Console.Write(roundCounter);
                            Console.SetCursorPosition(1, 12);
                            Console.WriteLine("                                                                          ");
                            Console.WriteLine("                                                                          ");
                            Console.Write("                                                                          ");
                            Console.SetCursorPosition(1, 15);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Computer move is : " + (computerX - 1) + "," + (computerY - 1));


                            if (round ==31)
                            {
                                Console.SetCursorPosition(1, 15);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("                                                                          ");
                                if (uPointCounter > cPointCounter)
                                {
                                    Console.WriteLine(                          "Human WIN!");
                                }
                                else if (uPointCounter < cPointCounter)
                                {
                                    Console.WriteLine("                         Computer WIN!");
                                }
                                else
                                {
                                    Console.WriteLine("                             SCORLESS");
                                }
                                
                            }
                        }//round end

                        Console.Read();
                        //*********************************************Game 2 END*************************************************


                        break;
                    }
            }
            





           

            
        }
    }
} 
