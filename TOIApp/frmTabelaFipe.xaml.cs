using System.Globalization;
using TOIApp.Modelo;
using TOIApp.Repositorio;

namespace TOIApp;

public partial class frmTabelaFipe : ContentPage
{
    private static string _TipoVeiculo;


    public frmTabelaFipe()
    {
        InitializeComponent();
        fncCarregarTipos(); 
    }




    public void fncCarregarTipos()
    {
        cmbTipoVeiculo.ItemsSource = repVeiculo.ListarVeiculos();
        cmbTipoVeiculo.ItemDisplayBinding = new Binding("Tipo");  
    }



    void fncSelecionarTipo(Object sender, EventArgs e)
    {
        var oRetorno = (Picker)sender;
        int selectedIndex=cmbTipoVeiculo.SelectedIndex; 
        
        if (selectedIndex != -1)
        {
            clsVeiculo veiculos = (clsVeiculo)cmbTipoVeiculo.ItemsSource[selectedIndex];
            _TipoVeiculo = veiculos.Tipo;
            fncCarregarFabricantes(veiculos.Tipo);
        }
    }

    void fncCarregarFabricantes(string _TipoVeiculo)
    {
        cmbFabricante.ItemsSource = repFabricante.LstFabricantes(_TipoVeiculo);
        cmbFabricante.ItemDisplayBinding = new Binding("nome");
    }




    private void OnFncCalcularTabelaFipe(object sender, EventArgs e)
    {
        return;
    }






}