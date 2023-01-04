public class Library43
{
// Создание массива
  public static int[] CreateArray(int count)
  {
    return new int[count];
  }

// Заполнение числами от ... до ...
  public static void Fill(int[] array)
  {
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = Random.Shared.Next(1, 100);
    }
  }

// печать массива
  public static string Print(int[] array)
    {
    return String.Join(" ", array);
    }

// Метод Pow возведение в степень
// a^b =  a*a*a*...*a
//           b раз
  public static int Pow(int a, int b)
  {
    int result = 1;
    for (int i = 0; i < b; i++)
    {
      result = result * a;
    }
    return result;
  }

  // написать конвертор из 15-ой в 10-ую
  //  0  1  2   3 - i
  // [6, 4, 3, 10]
  //  3  2  1   0 - степени
  // 10 * 15^0 + 3 * 15^1 + 4 * 15^2 + 6 * 15^3
  public static int ToDec(int[] value)
  {
    int  result = 0;
    int count = value.Length;

    for (int i = 0; i < count; i++)
    {
      result += value[i] * Pow(15, count - 1 - i);
    }
    return result;
  }
  //Нахождение чётных чисел в массиве
  
//public static int Even(int[] value)
  // {
   //int value = 0;
  // int count = value.Length;

 // for (int i = 0; i < count; i++)
  //{
   // if (value % 2 == 0)
   // return value;
   //}
    //WriteLine($"{Print(ar)} => {even}");
  // }
}

 