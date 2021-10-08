using System;

namespace API.Models
{
    public class Produto
    {
        //Construtor
        //Em C# se o metodo tiver apenas 1 linha, não precisa das {}, pode ser feito dessa forma ->
        public Produto( ) => CriadoEm = DateTime.Now;
        //prop + TAB =  public int MyProperty { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco{ get; set; }
        public string Descricao { get; set; }
         public int Quantidade { get; set; }
         public DateTime CriadoEm { get; set; } //Fazer using systen
         public Categoria Categoria { get; set; }

        //é uma subscrita do q já exixte
         public override string ToString( ) =>
         $"Nome: {Nome}  |  Preço: {Preco.ToString("C2")}  |  Criado em: {CriadoEm}" ;


    }
}