namespace DarwinPullaguariExamen.Views;

public partial class VResumen : ContentPage
{
	public VResumen(string dato, string nombre, string apellido, string va, string fecha, string ciudad, string montoInicial, string cuotaMensual, string pagoTotal)
	{
		InitializeComponent();
        LblDato.Text = "Usuario conectado " + dato;
        NombreEntry.Text = nombre;
        ApellidoEntry.Text = apellido;
        VAEntry.Text = va;
        FechaEntry.Text= fecha;
        CiudadEntry.Text = ciudad;
        MontoEntry.Text = montoInicial;
        CuotaEntry.Text = cuotaMensual;
        TotalEntry.Text = pagoTotal;
    }

    private async void btnCerrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.VLogin());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.VLogin());
    }
}