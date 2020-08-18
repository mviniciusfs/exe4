using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite as 4 notas bimestrais: ");
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int n3 = int.Parse(Console.ReadLine());
    int n4 = int.Parse(Console.ReadLine());

    Console.WriteLine("Média das notas: " + ((n1 + n2 + n3 + n4) / 4));
  }
}