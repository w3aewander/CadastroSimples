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

            //Salvar os dados em um arquivo de texto
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("cadastro.txt",true))
            {
                //foreach (Pessoa p in pessoas)
                //{
                //    file.WriteLine($"{p.Id};{p.Nome};{p.DataNascimento.ToString("yyyy-MM-dd")};{p.Email}");
                //}
                file.WriteLine($"{pessoa.Id};{pessoa.Nome};{pessoa.DataNascimento.ToString("yyyy-MM-dd")};{pessoa.Email}");
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
                    while ((line = file.ReadLine()) != null)
                    {
                        var parts = line.Split(';');
                        if (parts.Length == 4)
                        {
                            Pessoa p = new Pessoa(
                                int.Parse(parts[0]),
                                parts[1],
                                DateOnly.Parse(parts[2]),
                                parts[3]
                            );
                            pessoas.Add(p);
                        }
                    }
                }
            }
        }
    }
}
