//1.  1 ilə 25 arasında kök altısı olan ədədləri tapın.
//for (int i = 0; i <= 25; i++)
//{
//	for (int k = 1; k <= i; k++)
//	{
//		if (k * k == i) { 
//            Console.WriteLine(k);
//        }
//	}
//}

//2. Arraydaki yalnız tək ədədlərin cəmini çap edən alqoritm qurun.
//int[] numbers = { 2, 3, 4, 5, 9, 11, 12 };
//int sum = 0;
//for(int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] %2 != 0)
//    {
//        Console.WriteLine(numbers[i]);
//        sum += numbers[i];
//    }
//}
//        Console.WriteLine(sum);


// 3. Verilmiş massivin tək indeksində duran elementlərin cəmini tapan alqoritm yazın. Nəticəni konsola çıxarın. Məs. {1, 2, 1, 4, 3} => 6

int[] numbers2 = { 2, 4, 5, 6, 9 };
int sum2 = 0;
for (int i = 0; i < numbers2.Length; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(numbers2[i]);
        sum2 += numbers2[i];
    }
}
Console.WriteLine(sum2);

//4.Verilmiş sozun polindrom olub olmadigini göstərən alqoritm yazın (məs: "ata" sondan və baslanğıcdan eyni oxunur cavab true cixacaq)

//string word = "Ata";
//word = word.ToLower();
//int length = word.Length;
//int i = 0;
//int j = length - 1;

//while (i < j)
//{
//    if (word[i] != word[j])
//    {
//        Console.WriteLine($"{word} is not a palindrome.");
//        break;
//    }
//    else
//    {
//        Console.WriteLine(word +"is  a palindrome.");
//        break;
//    }
//    i++;
//    j--;
    
//}

