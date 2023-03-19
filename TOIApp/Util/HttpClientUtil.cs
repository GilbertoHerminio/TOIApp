using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOIApp.Util
{
    public class HttpClientUtil
    {

        // static = Pq será muito usado e será instanciado a todo o momento. E ele
        //          sempre deverá está pronto e disponível.
        // async  = Pq ele não pode ficar esperando ninguém. Sempre deve estar pronto! 
        // task   = Pq será uma tarefa
        // string = Pq o restorno será uma string(s)
        // ConfigureAwait = Para dar um tempo entre um requisição e outra. Coloquei false!
        // EnsureSuccessStatusCode = Se vira para resolver/trarar os erros que possam retonar

        public static async Task<string> ConsultarHttpClientAsync(string lstrUrl)
        {
            var lobjCliente = new HttpClient();

            try
            {
                HttpResponseMessage oResposta = await lobjCliente.GetAsync(lstrUrl).ConfigureAwait(false);
                oResposta.EnsureSuccessStatusCode();                
                return (string)await oResposta.Content.ReadAsStringAsync();

               // string lstrRetorno = await oResposta.Content.ReadAsStringAsync();
               // return lstrRetorno;


            }
            catch (Exception)
            {
                //Mesmo se der erro, a aplicação não pode parar!!!
                return "";
            }
        }



    }



}
