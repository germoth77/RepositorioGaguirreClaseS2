


using GaguirreClaseS2.VIEWS;

namespace GaguirreClaseS2.View;

public partial class login : ContentPage
{
    string[] USUARIO = { "Carlos", "Ana", "Jose" };
    string[] CONTRASE�A = { "carlos123", "ana123", "jose123" };
    public login()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrase�a = txtPassword.Text;
        bool credencialesValidas = false;
        for (int i = 0; i < USUARIO.Length; i++)
        {
            if (USUARIO[i] == usuario && CONTRASE�A[i] == contrase�a)
            {
                credencialesValidas = true;
                DisplayAlert("Bienvenido", $"Bienvenido, {usuario}!", "OK");
                Navigation.PushAsync(new vCalificaciones());
                break;
            }
        }

        if (!credencialesValidas)
        {
            DisplayAlert("Alerta", "Usuario o contrase�a incorrectas", "OK");
        }
    }
}