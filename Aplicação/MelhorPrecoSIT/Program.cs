using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace MelhorPrecoSIT
{
    class Program
    {
        static void Main(string[] args)
        {
            var pratos = new Pratos();

            Console.WriteLine("Informe o minimo que você deseja pagar:");
            pratos.ValorPratoDe = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o máximo que você deseja pagar:");
            pratos.ValorPratoPara = Convert.ToDecimal(Console.ReadLine());

            var resultado = ObterPratos(pratos);

            if (resultado.Count > 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("=============================");
                Console.WriteLine("Resultados para a busca: ");

                foreach (var item in resultado)
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine("Restaurante: " + item.NomeRestaurante);
                    Console.WriteLine("Nome do Prato: " + item.NomePrato);
                    Console.WriteLine("Valor: R$" + item.ValorPratoDe.ToString("0.##"));
                    Console.WriteLine("Descrição: " + item.DescricaoPrato);
                    Console.WriteLine("=============================");
                }

            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("====================================================================================");
                Console.WriteLine("Não foram encontrados resultados para sua busca! Tente novamente com outros valores.");
                Console.WriteLine("====================================================================================");
            }

                Console.ReadLine();            
        }

        static List<Pratos> ObterPratos(Pratos pratos)
        {
            try
            {
                var token = ObterToken();
                var json = JsonConvert.SerializeObject(pratos);
                var retorno = new List<Pratos>();

                var request = (HttpWebRequest)WebRequest.Create("http://localhost:60504/Api/BuscaPratos");
                request.ContentType = "application/json";
                request.Method = "POST";
                request.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token);

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var resultado = streamReader.ReadToEnd();
                    retorno = JsonConvert.DeserializeObject<List<Pratos>>(resultado);
                }

                return retorno;
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("Ocorreu um problema ao processar sua solicitação: " + ex.Message);
            }
        }

        public static string ObterToken()
        {
            try
            {
                const string usuario = "felipe";
                const string senha = "1234567890";
                var request = WebRequest.Create("http://localhost:60504/Api/token") as HttpWebRequest;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                var authCredentials = "grant_type=password&userName=" + usuario + "&password=" + senha;
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(authCredentials);
                request.ContentLength = bytes.Length;

                using (var requestStream = request.GetRequestStream())
                    requestStream.Write(bytes, 0, bytes.Length);

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    var getResponse = (HttpWebResponse)request.GetResponse();
                    var stream = getResponse.GetResponseStream();
                    var sr = new StreamReader(stream);
                    var token = sr.ReadToEnd();
                    var retorno = JsonConvert.DeserializeObject<AccessToken>(token);
                    return retorno.access_token;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("Ocorreu um problema ao processar sua solicitação: " + ex.Message);
            }
        }
    }
}
