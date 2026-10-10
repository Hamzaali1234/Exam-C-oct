// tack 2
// int EvenCount(int n)
// {
//     if (n == 0)
//     {
//         return 0;
//     }

//     int b = n % 10;

//     if (b % 2 == 0)
//     {
//         return 1 + EvenCount(n / 10);
//     }

//     return EvenCount(n / 10);
// }

// System.Console.WriteLine(EvenCount(12345));



//  int OddCount(int n)
// {
//     if (n == 0)
//     {
//         return 0;
//     }

//     int b = n % 10;

//     if (b % 2 != 0)
//     {
//         return 1 + OddCount(n / 10);
//     }

//     return OddCount(n / 10);
// }

// System.Console.WriteLine(OddCount(12345));



// int DigitCount(int n)
// {
//     if(n>0 && n < 10)
//     {
//         return 1;
//     }
//     return 1+DigitCount(n/10);
// }
// System.Console.WriteLine(DigitCount(12345));



// int SumDigit(int n)
// {
//     int sum = 0;
//     for (int i = n; i > 0; i /= 10)
//     {
//         sum += i % 10;
//     }
//     return sum;
// }
// System.Console.WriteLine(SumDigit(12345));



// tack 3
// string IsPalindrome(int a)
// {
//     int b = 0;
//     for (int i = a; i > 0; i /= 10)
//     {
//         b = b*10+i%10;
//     }
//     if(b==a) return "Yes";
//     else
//     {
//         return "No";
//     }
// }
// System.Console.WriteLine(IsPalindrome(121));


// tack 4
// int SumDigit(int n)
// {
//     int sum = 0;
//     for (int i = n; i > 0; i /= 10)
//     {
//         sum += i % 10;
//     }
//     return sum;
// }
// System.Console.WriteLine(SumDigit(1234));



// tack 5
// void IncrementArrayElements(ref int[] arr, ref int n)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr[i] + n;
//     }
// }

// int[] arr = { 1, 2, 3, 4, 5 };
// int n = 5;

// IncrementArrayElements(ref arr, ref n);

// for (int i = 0; i < arr.Length; i++)
// {
//     System.Console.Write(arr[i] + " ");
// }


// tack 6
// void Swap(ref int a, ref int b)
// {
//     int c = a;
//     a = b;
//     b = c;
// }
// int x = 5;
// int y = 10;
// Swap(ref x, ref y);
// System.Console.WriteLine(x);
// System.Console.WriteLine(y);

// tack 7
// int SumDigits(int n)
// {
//     if (n < 10)
//     {
//         return n;
//     }
//     else
//     {
//         return n % 10 + SumDigits(n / 10);
//     }
// }
// System.Console.WriteLine(SumDigits(1234));

// tack 8
// string RepeatText(string txt, int n)
// {
//     if (n == 0)
//     {
//         return "";
//     }
//     return txt + "n" + RepeatText(txt, n - 1);
// }
// System.Console.WriteLine(RepeatText("Salom", 3));