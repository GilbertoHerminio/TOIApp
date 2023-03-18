namespace TOIApp;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnfncCalcular(object sender, EventArgs e)
    {
         lstrResultado.Text = (Convert.ToInt32(lintNumero1.Text)
                            + Convert.ToInt32(lintNumero2.Text))
                            .ToString();
    }


    private async void OnfncFrmSobre(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new frmSobre());
    }

    private async void OnfncFrmAjuda(object sender, EventArgs e)
    {
        await DisplayAlert("TOI Digital", "Página em construção!", "OK");       
    }










}

