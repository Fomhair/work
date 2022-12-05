using System;

namespace Filtration
{
  public static class Filter
  {
    // Метод фильтрующий элементы
    public static string[] ByLength(string[] values, int limit = 3)
    {
      int count = 0;

      for(int i = 0; i < values.Length; i++)
      {
        if(values[i].Length <= limit) count++;
      }

      string[] result = new string[count];

      if(count > 0)
      {
        count = 0;
        for(int k = 0; k < values.Length; k++)
        {
          if(values[k].Length <= limit)
          {
            result[count] = values[k];
            count++;
          }
        }
      }
      return result;
    }
  }

  // Класс обработки вводимых пользователем значений
  public static class IOFunc
  {
    public static string RequestString(string msg = "Input your value: ")
    {
      Console.Write(msg);
      string value = Console.ReadLine();
      return value ?? string.Empty;
    }

    public static string OptimizeString(string value)
    {
      string newStr = value.Replace("  "," ");
      newStr = newStr.Replace(",,",",");
      newStr = newStr.Replace("..",".");
      newStr = newStr.Replace(", ",",");
      newStr = newStr.Replace(". ",".");
      
      if(newStr.Contains("  ") || newStr.Contains(",,")) return OptimizeString(newStr);
      return newStr;
    }

    public static void ShowArray(string[] values)
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      for(int i = 0; i < values.Length; i++)
      {
        if(i == values.Length-1) 
        {
          Console.WriteLine($"{values[i]}");
        }
        else 
        {
          Console.Write($"{values[i]}, ");
        }
      }
      Console.ForegroundColor = ConsoleColor.White;
    }

    public static bool Exit() 
    {
      ConsoleKeyInfo exitKey = Console.ReadKey(true);
      if(exitKey.Key == ConsoleKey.Escape || exitKey.Key == ConsoleKey.Q)
      { return true; }
      else
      { return false; }
    }
  }

  class Program
  {
    static void Start()
    {
      while (true)
      {
        string demoText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ";
        Console.WriteLine("Сейчас программа отфильтрует этот текст: {0}", demoText);
        string[] test = IOFunc.OptimizeString(demoText).Split(' ', ',', '.');

        test = Filter.ByLength(test);
        Console.Write(" -> ");
        IOFunc.ShowArray(test); 
        
        try
        {
          string source = IOFunc.OptimizeString(IOFunc.RequestString(msg: "Введите свой текст для фильтрации: \n"));
          string[] values = source.Split(' ', ',', '.');

          values = Filter.ByLength(values);

          Console.Write(" -> ");
          IOFunc.ShowArray(values); 

          Console.WriteLine("Нажмите ESC или Q для завершения или любую другу клавишу, чтобы попробовать ещё.");
          if(IOFunc.Exit()) break;
        }
        catch(IndexOutOfRangeException e)
        {
          Console.WriteLine("Incorrect values: " + e);
        }
      }
    }
    static void Main(string[] args)
    {
      Start();
    }
  }
}