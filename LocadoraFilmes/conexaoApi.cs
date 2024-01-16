using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;



namespace ApiFilmes.Model;


internal class Conexao
{
    private HttpClient client = new HttpClient();

    public async Task<Filme?> ObterInformacoesFilme()
    {
        try
        {
            string resposta = await client.GetStringAsync("https://www.omdbapi.com/?apikey=f1bb6200&t=X-men");

            Filme filme = JsonSerializer.Deserialize<Filme>(resposta);

            filme.Foto = await ObterPosterFilme(filme.Poster);


            return filme;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Temos um problema: {e.Message} ");

            return null;
        }

        
    }

    //Quando terminar o projeto estudar mais a fundo sobre essa conexão e sobre o httpResponseMessage
    private async Task<byte[]> ObterPosterFilme(string urlImagem)
    {


        {
            try
            {
               
                using (HttpResponseMessage response = await client.GetAsync(urlImagem))
                {
                    response.EnsureSuccessStatusCode(); // Lança uma exceção em caso de erro HTTP
                    //Stream é uma sequência de bytes     
                    using (MemoryStream ms = new MemoryStream())
                    {
                        //FromStream é um método do objeto Image que pega a sequência de bytes que é
                        // o stream e converte ele para uma Imagem 
                        await response.Content.CopyToAsync(ms);
                        return ms.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter a imagem: {ex.Message}");
                return null;
            }
        }



    }
}
