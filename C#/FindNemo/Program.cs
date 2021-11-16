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
      var watch = new System.Diagnostics.Stopwatch();

      watch.Start();
      for (int i = 0; i < (int)array.Length; i++)
      {
        if (array[i] == "nemo") Console.WriteLine("FoundNemo!");
      }
      watch.Stop();
      Console.WriteLine($"{ watch.ElapsedMilliseconds} ms");
    }
  }
}
