


using GaguirreClaseS2.VIEWS;

namespace GaguirreClaseS2.View;

public partial class login : ContentPage
{
    string[] USUARIO = { "Carlos", "Ana", "Jose" };
    string[] CONTRASEÑA = { "carlos123", "ana123", "jose123" };
    public login()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contraseña = txtPassword.Text;
        bool credencialesValidas = false;
        for (int i = 0; i < USUARIO.Length; i++)
        {
            if (USUARIO[i] == usuario && CONTRASEÑA[i] == contraseña)
            {
                credencialesValidas = true;
                DisplayAlert("Bienvenido", $"Bienvenido, {usuario}!", "OK");
                Navigation.PushAsync(new vCalificaciones());
                break;
            }
        }

        if (!credencialesValidas)
        {
            DisplayAlert("Alerta", "Usuario o contraseña incorrectas", "OK");
        }
    }
}