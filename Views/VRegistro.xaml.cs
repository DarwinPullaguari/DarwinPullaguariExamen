namespace DarwinPullaguariExamen.Views;

public partial class VRegistro : ContentPage
{
    string datoU;
	public VRegistro(string dato)
	{
		InitializeComponent();
        datoU = dato;
        LblDato.Text = "usuario conectado " + dato;
    }
    private void OnCalcularPagoMensualClicked(object sender, EventArgs e)
    {
        // Implementar lógica de cálculo de pago mensual aquí
        double montoInicial = 45; // 15% de 300
        double resto = 300 - montoInicial;
        double cuotaMensual = resto / 3 * 1.05;
        montoInicialEntry.Text = cuotaMensual.ToString("F2");
    }


    private void OnVerResumenClicked(object sender, EventArgs e)
    {
        // Aquí puedes implementar la navegación al resumen.
        //Navigation.PushAsync(new VResumen(datoU));
        Navigation.PushAsync(new VResumen(datoU, nombreEntry.Text, apellidoEntry.Text, vaPicker.SelectedItem.ToString()??"No seleccionado", fechaPicker.Date.ToString()??"No seleccionada", ciudadPicker.SelectedItem.ToString() ?? "No seleccionado","45", montoInicialEntry.Text,"300"));
    }
}