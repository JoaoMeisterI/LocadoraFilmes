using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Drawing;
using System.IO;

namespace ApiFilmes.Model;

internal class Filme
{

    [JsonPropertyName("Title")]
    public string? Nome { get; set; }
    [JsonPropertyName("Year")]
    public string? Ano { get; set; }
    [JsonPropertyName("Actors")]
    public string? Elenco { get; set; }
    [JsonPropertyName("Poster")]
    public string? Poster { get; set; }
    public  byte[]? Foto { get; set; } 

    public void MostraInfoFilme()
    {
        Console.WriteLine($"Nome Filme: {Nome}");
        Console.WriteLine($"Nome Filme: {Ano}");
        Console.WriteLine($"Nome Filme: {Elenco}");
        Console.WriteLine($"Nome Filme: {Poster}");
    }

    public Image ExibirImagem()
    {


        using (MemoryStream ms = new MemoryStream(Foto))
        {
            Image imagem = Image.FromStream(ms);

            return imagem;
            
            // Faça o que você quiser com a imagem, como exibi-la em um controle PictureBox
        }
    }
}      