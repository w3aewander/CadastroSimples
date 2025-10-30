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
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("cadastro.txt",true))
            {

                file.WriteLine($"{pessoa.Id};{pessoa.Nome};" +
                    $"{pessoa.DataNascimento.ToString("yyyy-MM-dd")};{pessoa.Email}");
            }

            LoadFromFile();
        }

        public static void LoadFromFile()
        {
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
    }
}
