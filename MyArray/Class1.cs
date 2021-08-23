using System;

namespace MyArrayLibrary
{
  public static class MyArray
  {
    public static double sumOfEvenElements(ref double[] array)
    {
      double SumOfEvenElements = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] % 2 == 0)
        {
          SumOfEvenElements += array[i];
        }
      }
      return SumOfEvenElements;
    }

    public static int findTheFirstIndexByValue(ref double[] array, double value)
    {
      int index = -1;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == value)
        {
          index = i;
          break;
        }
      }

      return index;
    }

    public static void Resize(ref int[] array, char sign, int count)
    {
      int[] currArray = new int[array.Length];
      for (int i = 0; i < array.Length; i++)
      {
        currArray[i] = array[i];
      }
      if (sign == '+')
      {
        array = new int[array.Length + count];
        for (int i = 0; i < currArray.Length; i++)
        {
          array[i] = currArray[i];
        }
      }
      else if (sign == '-')
      {
        array = new int[array.Length - count];
        for (int i = 0; i < array.Length; i++)
        {
          array[i] = currArray[i];
        }

      }
    }

    public static void addToEnd(ref int[] array)
    {
      int[] currArray = new int[array.Length];
      for (int i = 0; i < array.Length; i++)
      {
        currArray[i] = array[i];
      }
      array = new int[array.Length + 1];
      for (int i = 0; i < currArray.Length; i++)
      {
        array[i] = currArray[i];
      }
      Console.Write("Введите значение для элемента: ");
      array[array.Length - 1] = int.Parse(Console.ReadLine());

    }

    public static void addToStart(ref int[] array)
    {
      int[] currArray = new int[array.Length];
      for (int i = 0; i < array.Length; i++)
      {
        currArray[i] = array[i];
      }
      array = new int[array.Length + 1];
      for (int i = 0; i < currArray.Length; i++)
      {
        array[i + 1] = currArray[i];
      }
      Console.Write("Введите значение для элемента: ");
      array[0] = int.Parse(Console.ReadLine());
    }

    static void addByIndex(ref int[] array, int index)
    {
      if (index == 0)
      {
        addToStart(ref array);
      }
      else if (index == array.Length - 1)
      {
        addToEnd(ref array);
      }
      else
      {
        int[] currArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
          currArray[i] = array[i];
        }
        array = new int[array.Length + 1];
        for (int i = 0; i < index; i++)
        {
          array[i] = currArray[i];
        }
        Console.Write("Введите значение для элемента: ");
        array[index] = int.Parse(Console.ReadLine());
        for (int i = index + 1, j = index; i < array.Length && j < currArray.Length; i++, j++)
        {
          array[i] = currArray[j];
        }
      }
    }
  }
}
