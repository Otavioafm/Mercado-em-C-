/*using System.Dynamic;

namespace Cadastro;

public class Modulo08
{

    public static class Calculo{
        public static int somaNumeros(int a, int b){
            return a+b;
        }
    }

    public string Descricao{get;set;}

    public int Estoque{get;}

     private int Id;

    public void imprimeDescricao(){
        Console.WriteLine("id= "+getId()+" | Produto= "+Descricao);
    }


      public void setId(int id){
      Id=id;
    }

    public int getId(){
        return Id;
    }

     public class pessoa{
        int rg{get;set;}
        string nome{get; set;}
        long cpf{get; set;}

        public void imprimePessoaDados(){
            Console.WriteLine("Nome: "+nome+"\n"+"Cpf: "+cpf+"\n"+"Rg: "+rg+"\n");
        }
    }

    public class cidadePessoa:pessoa{
        long cep{get; set;}
    }



    private static void AulaRecord(){
        
    }



}



using System.Collections;
using System.Data.Common;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace programa
{
  
  public class Programa{
    static void Main(string[]args){
      
      var resultado=Cadastro.Modulo08.Calculo.somaNumeros(10,5);
      //Console.WriteLine("\n"+resultado+"\n");

      var produto=new Cadastro.Modulo08();
      produto.Descricao= "batata";
      produto.setId(1);

      produto.imprimeDescricao();
    }
   

  }
}

*/