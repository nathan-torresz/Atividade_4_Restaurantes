using System;
using System.Collections.Generic;
using System.Threading;

namespace Atv_4_Restaurantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurantes restaurante1 = new Restaurantes();
            restaurante1.Nome = "Nc Donald's BR";
            restaurante1.lanches = new List<Lanches>();

            Lanches NcFeijoada = new Lanches();
            {
                NcFeijoada.nome = "Nc Feijoada";
                NcFeijoada.descricao = "Lanche com uma das receitas mais conhecidas da nação.+\n" +
                    "corra provar!";
                NcFeijoada.preco = 14.98f;
                restaurante1.lanches.Add(NcFeijoada);
            }
            Lanches NcBacon = new Lanches();
            {
                NcBacon.nome = "Nc Bacon";
                NcBacon.descricao = "hamburger, queijo, tomate, bacon, molho especial";
                NcBacon.preco = 16.90f;
                restaurante1.lanches.Add(NcBacon);
            }
            Lanches NcAcaraje = new Lanches();
            {
                NcAcaraje.nome = "Nc Acarajé";
                NcAcaraje.descricao = "Camarão seco, mandioquinha, cebola e salsa\n" +
                    "um gostinho da Bahia";
                NcAcaraje.preco = 12.49f;
                restaurante1.lanches.Add(NcAcaraje);
            }
            Lanches NcPicanha = new Lanches();
            {
                NcPicanha.nome = "Nc Picanha";
                NcPicanha.descricao = "picanha grelhada, tomate, alface queijo cheddar, picles e onion";
                NcPicanha.preco = 19.90f;
                restaurante1.lanches.Add(NcPicanha);
            }

            Restaurantes restaurante2 = new Restaurantes();
            restaurante2.Nome = "Mc Donald´s AR";
            restaurante2.lanches = new List<Lanches>();

            Lanches ncpicanha = new Lanches();
            {
                ncpicanha.nome = "Nc Picanha";
                ncpicanha.descricao = "picanha grelhada, tomate, alface queijo cheddar, picles e onion";
                ncpicanha.preco = 12.88f;
                restaurante2.lanches.Add(ncpicanha);
            }
            Lanches ncChimiChurri = new Lanches();
            {
                ncChimiChurri.nome = "Nc Chimi Chúrri";
                ncChimiChurri.descricao = "Um prato carregado pela cultura argentina";
                ncChimiChurri.preco = 16.90f;
                restaurante2.lanches.Add(ncChimiChurri);
            }

            Restaurantes restaurante3 = new Restaurantes();
            restaurante3.Nome = "Mc Donald's EUA";
            restaurante3.lanches = new List<Lanches>();

            Lanches Ncbacon = new Lanches();
            {
                Ncbacon.nome = "Nc Bacon";
                Ncbacon.descricao = "hamburger, queijo, tomate, bacon, molho especial";
                Ncbacon.preco = 8.99f;
                restaurante3.lanches.Add(Ncbacon);
            }
            Lanches ncCheddar = new Lanches();
            {
                ncCheddar.nome = "Nc Cheddar";
                ncCheddar.descricao = "hamburger grelhado, alface, vinagrete, queijo chedar, molho esoecial";
                ncCheddar.preco = 10.98f;
                restaurante3.lanches.Add(ncCheddar);
            }

            Restaurantes restaurante4 = new Restaurantes();
            restaurante4.Nome = "Mc Donald's Japan";
            restaurante4.lanches = new List<Lanches>();

            Lanches ncSushi = new Lanches();
            {
                ncSushi.nome = "Nc Sushi";
                ncSushi.descricao = "Um dos gostinhos mais característicos\n" +
                    "da terra do sol nascente...";
                ncSushi.preco = 16.99f;
                restaurante4.lanches.Add(ncSushi);
            }
            Lanches nccheddar = new Lanches();
            {
                nccheddar.nome = "Nc Cheddar";
                nccheddar.descricao = "hamburger grelhado, alface, vinagrete, queijo chedar, molho esoecial";
                nccheddar.preco = 8.98f;
                restaurante4.lanches.Add(nccheddar);
            }

            string[] vetA = new string[2];
            Console.WriteLine("Bem vindos à rede de restaurantes Mequi");
            vetA[0] = "";
            vetA[1] = "Digite 1 para cardápio específico\n" +
                "digite 2 para acessar toda a rede";
            for (int i = 0; i < vetA.Length; i++)
            {
                Console.WriteLine(vetA[i]);
                Thread.Sleep(1500);
            }



            Console.WriteLine("");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Digite o nome do país:");
                    string pais = Console.ReadLine();
                    if (pais == "Brasil")
                    {
                        MostrarLanche(restaurante1);
                    }
                    else if (pais == "Argentina")
                    {
                        MostrarLanche(restaurante2);
                    }
                    else if (pais == "EUA")
                    {
                        MostrarLanche(restaurante3);
                    }
                    else if (pais == "Japão")
                    {
                        MostrarLanche(restaurante4);
                    }
                    else
                    {
                        Console.WriteLine("Unidade não encontrada!");
                    }
                    break;

                case 2:
                    MostrarLanche(restaurante1);
                    Console.WriteLine("");
                    MostrarLanche(restaurante2);
                    Console.WriteLine("");
                    MostrarLanche(restaurante3);
                    Console.WriteLine("");
                    MostrarLanche(restaurante4);
                    break;
            }

            static void MostrarLanche(Restaurantes restaurante)
            {
                Console.WriteLine("Os lanches da unidade " + restaurante.Nome + " são: ");
                Console.WriteLine("");
                foreach (Lanches lanche in restaurante.lanches)
                {
                    Console.WriteLine($"Nome: {lanche.nome}\n" +
                        $"Descrição: {lanche.descricao}\n" +
                        $"Preço: {lanche.preco}");
                    Console.WriteLine("");
                }
            }
        }
    }
}
