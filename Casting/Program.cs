while (true)
{
    Console.WriteLine("Choose operation:");
    Console.WriteLine("1.Show number in HexaDecimal and Binary");
    Console.WriteLine("2.Convert String to Any Integer");
    Console.WriteLine("3.Checking Overflow");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            while (true)
            {
                Console.Write("Enter Number: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                if (number == 0)
                    break;
                string hex = Convert.ToString(number, 16);
                string binary = Convert.ToString(number, 2);
                string numberFromHex = Convert.ToString(number, 10);
                Console.WriteLine("HexaDecimal:" + hex);
                Console.WriteLine("Binary:" + binary);
                Console.WriteLine("HexaDecimal to Number:" + numberFromHex);
                break;
            }
            break;
        case 2:
            Console.Write("Enter Number: ");
            string inputString = Console.ReadLine();
            if (decimal.TryParse(inputString, out decimal numb))
            {
                Console.WriteLine("Number:" + numb);
            }
            else
            {
                Console.WriteLine("String is invalid");
            }
            break;

        case 3:
            Console.Write("Enter Loop'max value:");
            int max = Convert.ToInt32(Console.ReadLine());
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
                if (i == byte.MaxValue)
                {
                    Console.WriteLine("----End----");
                    break;

                }
            }

            break;
        default:
            Console.WriteLine("Choose from given operations!");
            break;
    }
}

#region Tasks Casting

//Istifadeci 2 kəsr ədəd daxil edir.Onların tam və kəsr hissələrinin cəmini tapın.
Console.Write("Enter first Float number: ");
float num1 = float.Parse(Console.ReadLine());
Console.Write("Enter second Float number: ");
float num2 = float.Parse(Console.ReadLine());
Console.WriteLine("Sum of two float numbers: "+(num1+num2));
Console.WriteLine("----------------------");

//Istifadəçi ədəd daxil edir.Həmin ədədin ASCİİ cədvəlindəki xarakterini ekrana çıxarın

Console.Write("Enter a number:");
 int num=Convert.ToInt32(Console.ReadLine());
Console.Write("Ascii Value of number:"+Convert.ToChar(num));
Console.WriteLine("----------------------");

//İstifadəçi sahib olduğu pulu daxil edir. İstifadəçinin neçə manat və neçə qəpiyi oludğunu ekrana çıxarın
Console.Write("Enter money:");
decimal decimalNumber = decimal.Parse(Console.ReadLine());
Console.WriteLine("Manat:"+(int)decimalNumber);
Console.WriteLine("Coin:"+(decimalNumber-(int)decimalNumber));//Deqiq bilmedim
Console.WriteLine("----------------------");

//İstifadəçi kütləni tonla daxil edir.Ekrana ton,kilogram,qram halinda çıxarın.
Console.Write("Enter tone:");
decimal decimalTone = Convert.ToDecimal(Console.ReadLine());
decimal fractionPart=(decimalTone - (int)decimalTone);
Console.WriteLine("fraction:"+fractionPart);
Console.WriteLine(String.Format("{0:#,0.000}",decimalTone));
Console.WriteLine("Ton:" + (int)decimalTone);
Console.WriteLine("KG:" + (fractionPart / 1000));
Console.WriteLine("Gram:" + (fractionPart-(fractionPart/1000)));


//İstifadəçi areoporta məsafəni və ora çatmaq üçün sahib olduğu vaxtı daxil edir. Aeroporta çatmaq üçün hansı sürətlə 
//getməli olduğunu tapan proqram yaz
Console.Write("Enter distance:");
decimal distance = Convert.ToDecimal(Console.ReadLine());
Console.Write("Enter time: ");
decimal time = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Speed: "+String.Format("{0:#,0.0}",(distance/time)));

//İstifadəçi bir filmin gigabayt ilə ölçüsünü və internetin bit\saniyə ilə sürətini daxil edir. Filmin hansı zaman ərzində
//yüklənəcəyini hesablayan proqram yazın.???
Console.Write("Enter measure GBayt:");
decimal measureGB = Convert.ToDecimal(Console.ReadLine());
decimal measureinBit =measureGB * Convert.ToDecimal(Math.Pow(2, 33));
Console.Write("Enter downloaded bit in 1 second:");
decimal measureBit = Convert.ToDecimal(Console.ReadLine());
int timeinSeconds = Convert.ToDateTime(measureinBit / measureBit).Minute;
Console.WriteLine("Time in seconds: "+timeinSeconds);

//
#endregion

