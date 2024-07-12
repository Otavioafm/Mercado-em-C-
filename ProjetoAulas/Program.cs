using System.Collections;
using System.Data.Common;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Curso_c;

namespace programa
{

  
  public class Programa{
    static void Main(string[]args){

      Console.Write("\nDigite o seu nome: ");
      string nome=Console.ReadLine().Trim(); 


      Console.Write("Digite a sua idade: ");
      string inputIdade=Console.ReadLine();
      int idade =int.Parse(inputIdade);
      
      var data=DateTime.Now;

      if(idade>=18){
        Console.WriteLine("\nSeja bem-vindo "+nome+"\nAo super mercado C# | "+"Hora atual= "+data+"\n");
      }

      else{
        Console.WriteLine("\nEntrada negada,detectamos que você é menor de idade\nEncerrando código ...");
         return;
      }
      
      Mercado arroz = new Mercado(1, "Arroz", 1);
      Mercado feijao = new Mercado(2, "Feijão", 8);
      Mercado batata = new Mercado(3, "Batata", 38);

      arroz.ImprimeDescricao();
      feijao.ImprimeDescricao();
      batata.ImprimeDescricao();
     
     
      



    }
  }
}

















