using System;

namespace morse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Morse.Encoder(args[0]));
    }
  }
}