using DIO.Curso.Lote.Core.Interfaces;
using Newtonsoft.Json;
using System;
using System.IO;

namespace DIO.Curso.Lote.Core
{
    public class GeradorLinhasLote : IGeradorLinhasLote
    {
        public string[] Gerar(int idTurma, string[] alunos)
        {
            var arquivoJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app.json");
            var json = File.ReadAllText(arquivoJson);
            var info = JsonConvert.DeserializeObject<Config>(json);

            var linhas = new string[alunos.Length + 1];
            
            linhas[0] = $"CURSO;INSTRUTOR;TURMA;ALUNO;MATRICULA;";
            for (int i = 0; i < alunos.Length; i++)
                linhas[i+1] = $"{info.NomeCurso};{info.Instrutor};{idTurma};{alunos[i]};{DateTime.Now:d}";

            return linhas;
        }
    }
}