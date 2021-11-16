using System;

namespace FindNemo
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] nemo = new string[] { "nemo" };
      Program.FindNemo(nemo);
    }

    static void FindNemo(string[] array)
    {
      for (int i = 0; i < (int)array.Length; i++)
      {
        if (array[i] == "nemo") Console.WriteLine("FoundNemo!");
      }
    }
  }
}
