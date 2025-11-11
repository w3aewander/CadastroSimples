using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSimples
{
    internal class Cadastro
    {

        public static List<Pessoa> pessoas = new List<Pessoa>();

        public static void SaveToFile(Pessoa pessoa)
        {
            // Implementar a lógica para salvar os dados em um arquivo, se necessário
            Console.WriteLine("Salvando dados em arquivo...");

            //Limpar a lista antes de salvar
            pessoas.Clear();

            //Salvar os dados em um arquivo de texto
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("cadastro.txt", true))
            {

                file.WriteLine($"{pessoa.Id};{pessoa.Nome};" +
                    $"{pessoa.DataNascimento.ToString("yyyy-MM-dd")};{pessoa.Email}");
            }

            LoadFromFile();
        }

        public static void LoadFromFile()
        {

            //Limpar a lista antes de carregar
            pessoas.Clear();

            // Implementar a lógica para carregar os dados de um arquivo, se necessário
            Console.WriteLine("Carregando dados de arquivo...");
            if (System.IO.File.Exists("cadastro.txt"))
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader("cadastro.txt"))
                {
                    string line;
                    while ((line = file.ReadLine()) != null) //Lê linha por linha: campos da linha separados por ;
                    {
                        var parts = line.Split(';');
                        if (parts.Length == 4)
                        {
                            Pessoa p = new Pessoa(
                                int.Parse(parts[0]), //id
                                parts[1], //nome
                                DateOnly.Parse(parts[2]), //data nascimento
                                parts[3] //email
                            );
                            pessoas.Add(p);
                        }
                    }
                }
            }
        }

        public static void SaveToFile(Pessoa pessoa, bool delete)
        {
            // Implementar a lógica para salvar os dados em um arquivo, se necessário
            Console.WriteLine("Salvando dados em arquivo...");

            //Limpar a lista antes de salvar
            pessoas.Clear();

            if (delete)
            {
                //pegar todos os registros exceto o que será deletado
                var toDelete = pessoas.Where(p => p.Id != pessoa.Id).ToList();

                //Salvar os dados em um arquivo de texto
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("cadastro.txt", false))
                {
                    foreach (var p in toDelete)
                    {
                        file.WriteLine($"{p.Id};{p.Nome};" +
                        $"{p.DataNascimento.ToString("yyyy-MM-dd")};{p.Email}");
                    }
                }
            }
            //Recarregar a lista
            LoadFromFile();
        }

        public static void DeleteRecord(Pessoa pessoa)
        {
            var idToDelete = pessoas.FirstOrDefault(p => p.Id == pessoa.Id);

            if (idToDelete != null)
            {
                pessoas.Remove(idToDelete);
                
                var updatedList = pessoas.ToList();

                Console.WriteLine($"Registro com ID {pessoa.Id} excluído com sucesso.");

                //salvar os dados da lista para o arquivo
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("cadastro.txt"))
                { 
                    foreach (var p in updatedList )
                    {
                        file.WriteLine($"{p.Id};{p.Nome};" +
                         $"{p.DataNascimento.ToString("yyyy-MM-dd")};{p.Email}");
                    }                
                }

            }
        }
    }
}
