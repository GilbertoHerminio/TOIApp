using TOIApp.Modelo;

namespace TOIApp.Repositorio
{
    public class repVeiculo
    {
        public static List<clsVeiculo> ListarVeiculos()
        {
            List<clsVeiculo> lstVeiculos = new List<clsVeiculo>()
            {
              new clsVeiculo() {Id=1,Tipo="carros"},
              new clsVeiculo() {Id=2,Tipo="motos" },
              new clsVeiculo() {Id=3,Tipo="caminhoes"},
            };
            return lstVeiculos;
        }
    }
}
