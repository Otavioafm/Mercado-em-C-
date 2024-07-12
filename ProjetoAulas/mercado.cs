using System;

namespace Curso_c
{
    public class Mercado
    {

        public string Descricao { get; set; }
        public int Estoque { get; set; } 
        private int Id; 

        
        public Mercado(int id, string descricao, int estoqueinicial){
            Id = id;
            Descricao = descricao;
            Estoque = estoqueinicial;
        }

        
        public void ImprimeDescricao()
        {
            Console.WriteLine($"ID= {Id} | Produto= {Descricao} | Quantidade= {Estoque}");
        }


        private int GetId()
        {
            return Id;
        }
        public void estoqueQuantidade(int quantidade){
            Estoque=quantidade;
        }




    }
}
