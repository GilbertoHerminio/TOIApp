using System.Text.Json;
using TOIApp.Modelo;

namespace TOIApp.Repositorio
{
    public class repFabricante
    {
        public static List<clsFabricante> LstFabricantes(string TipoVeiculo)
        {
            var lstrUrl = $@"https://parallelum.com.br/fipe/api/v1/{TipoVeiculo}/marcas";
            var oResposta = Util.HttpClientUtil.ConsultarHttpClientAsync(lstrUrl);

            List<clsFabricante> lstFabricante = JsonSerializer.Deserialize<List<clsFabricante>>(oResposta.Result);

            return lstFabricante;
        }

    }
}
