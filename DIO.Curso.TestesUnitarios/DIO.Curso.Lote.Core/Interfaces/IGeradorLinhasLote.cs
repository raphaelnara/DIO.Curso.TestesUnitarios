namespace DIO.Curso.Lote.Core.Interfaces
{
    public interface IGeradorLinhasLote
    {
        string[] Gerar(int idTurma, string[] alunos);
    }
}