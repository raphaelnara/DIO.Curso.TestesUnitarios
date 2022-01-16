using DIO.Curso.Lote.Core;
using System;
using System.IO;

namespace DIO.Curso.Lote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando geração do lote de turma 1...");

            var integrador = new GeradorLinhasLote();
            var linhas = integrador.Gerar(1, new[]
            {
                "Maradona",
                "Roberto Baggio",
                "Marco Van Basten",
                "Ademir da Guia",
                "Rai",
                "Ronaldo",
                "Lionel Messi",
                "Aleixo"
            });
            var diretorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OUTPUT");
            if (!Directory.Exists(diretorio)) Directory.CreateDirectory(diretorio);
            var arquivoSaida = Path.Combine(diretorio, "Turma1.csv");
            if (File.Exists(arquivoSaida)) File.Delete(arquivoSaida);
            File.WriteAllLines(arquivoSaida, linhas);

            Console.WriteLine("Lote para turma 1 gerado");
            Console.WriteLine("Pressione qualquer tecla pra finalziar");
            Console.ReadLine();
        }
    }
}
