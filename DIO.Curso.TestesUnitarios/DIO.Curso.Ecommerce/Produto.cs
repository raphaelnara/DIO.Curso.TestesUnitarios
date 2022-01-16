namespace DIO.Curso.Ecommerce
{
    public class Produto
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Produto;
            return other.Codigo.Equals(Codigo);
        }
    }
}
