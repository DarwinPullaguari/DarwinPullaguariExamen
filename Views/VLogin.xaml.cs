namespace DarwinPullaguariExamen.Views;

public partial class VLogin : ContentPage
{
    private string[] users = { "estudiante2024", "examen1", "NombreEstudiante" };
    private string[] passwords = { "uisrael2024", "parcial1", "2024" };
    public VLogin()
    {
        InitializeComponent();
    }
    private void OnLoginClicked(object sender, EventArgs e)
    {

        string enteredUser = UserEntry.Text;
        string enteredPass = PassEntry.Text;


        for (int i = 0; i < users.Length; i++)
        {
            if (users[i].Equals(enteredUser, StringComparison.OrdinalIgnoreCase) &&
                passwords[i].Equals(enteredPass))
            {

                DisplayAlert("Bienvenido", $"¡Bienvenido {users[i]}!", "Cerrar");


                Navigation.PushAsync(new VRegistro());
                return;
            }
        }


        LoginStatusLabel.Text = "Usuario o contraseña incorrectos";
    }

}