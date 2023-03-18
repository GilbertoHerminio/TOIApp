namespace TOIApp;

public partial class frmSobre : ContentPage
{
	public frmSobre()
	{
		InitializeComponent();
	}

    private async void OnfncFrmPrincipal(object sender, EventArgs e)
    {
        await Navigation.PopAsync();    
    }




}