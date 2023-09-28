//-------------------------------------Task 1--------------------------------
//int number = int.Parse(Console.ReadLine());



//while (number != 0 && number % 2 == 0)
//{
//    number = number / 2;

//}
//if(number == 1)
//{
//    Console.WriteLine("Eded 2 nin quvvetidir");
//}
//else
//{
//    Console.WriteLine("eded 2 in quvveti deyil");
//}


//-----------------------------------------Task 2 ---------------------------
//Console.WriteLine("Ededi daxil edin :");
//int number = int.Parse(Console.ReadLine());
//Console.WriteLine("Reqemi daxil edin :");
//int digit = int.Parse(Console.ReadLine());

//int countDigit = 0;

//if(digit>=0 && digit < 10)
//{

//    for (int i = 1; i <= number; i++)
//    {
//        int j = i;

//        while (j > 0)
//        {
//            if (j % 10 == digit)
//            {
//                countDigit++;

//            }
//            j = j / 10;

//        }

//    }

//    Console.WriteLine("Reqemlerin sayi:" + countDigit);
//}
//else
//{
//    Console.WriteLine("Reqemi duzgun daxil edin");
//}









//----------------------------------Task3----------------------------------

//Console.WriteLine("Ededi daxil edin :");
//int number = int.Parse(Console.ReadLine());


//int remainder;
//int sum = 0;

//for (int i = 1; i < number; i++)
//{
//    remainder = number % i;

//    if (remainder == 0)
//    {
//        sum = sum + i;

//    }

//}
//if (sum == number)
//{
//    Console.WriteLine("Eded mukemmel ededdir");
//}
//else
//{
//    Console.WriteLine("Eded mukemmel eded deyil.");
//}

//----------------------------------Task4------------

//int number = int.Parse(Console.ReadLine());
//int remainder;
//int remainder2;
//int reverse=0;
//while (number > 0)
//{
//    remainder = number%2;

//    while(remainder != 0 && remainder==0)
//    {
//        remainder2= remainder%10;
//        reverse=reverse*10;
//        reverse = reverse + remainder2;
//        remainder = remainder / 10;

//        remainder=reverse ;
//    }


//    Console.WriteLine(remainder);

//    number = number / 2;

//}

//------------------------------------------Task5-------------------------------


//int number = int.Parse(Console.ReadLine());
//int digit;
//int largeDigit = 0;
//int smallDigit=9; // werte gore 9 yazilir.

//while (number > 0)
//{
//    digit = number % 10;
//	if (digit>largeDigit)
//	{
//		largeDigit = digit;
//	}
//	if(digit<smallDigit)
//	{ 
//		smallDigit = digit;
//	}
//	number = number / 10;
//}

//Console.WriteLine("En boyuk reqem :" + largeDigit);
//Console.WriteLine("En kicik reqem :" + smallDigit);
//Console.WriteLine("Hemin reqemlerin hasili:" + (largeDigit * smallDigit));


//------------------------------------------Task6---------------------------------


//int n = int.Parse(Console.ReadLine());
//int i = 0;

//while (n > i)
//{

//    Console.WriteLine("*");
//    i++;
//}

