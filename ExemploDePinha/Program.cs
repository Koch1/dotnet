using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploDePilha
{
  public class Program
  {
    static void Main()
    {
      var pilha = new Pilha();
      #Adiciona na Pilha esse elemento
      pilha.Empinha(1);
      pilha.Empinha(10);
      pilha.Empinha(100);

      #Remove os elemento da pilha e imprime no terminal o valor
      Console.WriteLine(pilha.Desempilha());
      Console.WriteLine(pilha.Desempilha());
      Console.WriteLine(pilha.Desempilha());
    }

  }

}