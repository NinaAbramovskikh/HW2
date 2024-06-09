// Задача 1.
// void krat (int num )
//  {
//     if(num % 7 == 0 && num % 23 == 0)
//     {
//         System.Console.WriteLine("кратно");
//     }
//     else 
//     {
//          System.Console.WriteLine("не кратно");
//     }
//  }

// System.Console.WriteLine("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// krat(num);



// Задача 2.
// void Koord (int x, int y) 
// {
//     if( x == 0 || y == 0)
//     {
//         System.Console.WriteLine("координаты не могут == 0");
//         return;
//     }

//     if (x > 0 && y > 0)
//     {
//         System.Console.WriteLine("I четверть");
//     }
//     else if (x < 0 && y > 0)
//     {
//         System.Console.WriteLine("II четверть");
//     }
//     else if (x < 0 && y < 0)
//     {
//         System.Console.WriteLine("III четверть");
//     }
//     else
//     {
//         System.Console.WriteLine("IV четверть");
//     }
// }

// System.Console.WriteLine("Введите координату X: ");
// int coordX = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y: ");
// int coordY = Convert.ToInt32(Console.ReadLine());

// Koord(coordX, coordY);

// Задача 3.
// void MaxDigit (int num)
// {
//      int des = num/10;
//      int ed =  num%10;
//      if (des>= ed) 
//      {
//         System.Console.WriteLine(des);
//      }
//      else
//      {
//         System.Console.WriteLine((ed));
//      }
// }
//       System.Console.WriteLine("Введите число: ");
//       int num = Convert.ToInt32(Console.ReadLine());
//       MaxDigit(num);

// Задача 4.
void NatNumToPosledovat (int a)
{
    foreach (char item in $"{a}")
    {
        System.Console.Write($"{item},");
    }
}
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

NatNumToPosledovat(num);



