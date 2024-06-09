namespace GaguirreClaseS2.VIEWS
{
    public partial class vCalificaciones : ContentPage
    {
        public vCalificaciones()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double nota1 = 0;
            double factorNota = 0.3;
            double notaExamen = 0;

            double nota2 = 0;
            double notaExamen2 = 0;
            double factorExamen = 0.2;
            double resultado = 0.00;

            //Parcial 1
            if (string.IsNullOrEmpty(txtSeguimiento.Text))
            {
                DisplayAlert("Alerta", "Ingrese un valor entre 0.1 y 10", "Cancel");
                return;
            }
            else
            {
                nota1 = Convert.ToDouble(txtSeguimiento.Text);
                nota1 = validarNumeros("Ingrese Nota 1", nota1, factorNota);
            }

            if (string.IsNullOrEmpty(txtExamen.Text))
            {
                DisplayAlert("Alerta", "Ingrese un valor entre 0.1 y 10", "Cancel");
                return;
            }
            else
            {
                notaExamen = Convert.ToDouble(txtExamen.Text);
                notaExamen = validarNumeros("Ingrese Nota Examen", notaExamen, factorExamen);
            }

            // Parcial2
            if (string.IsNullOrEmpty(txtSeguimientoP2.Text))
            {
                DisplayAlert("Alerta", "Ingrese un valor entre 0.1 y 10", "Cancel");
                return;
            }
            else
            {
                nota2 = Convert.ToDouble(txtSeguimientoP2.Text);
                nota2 = validarNumeros("Ingrese Nota 1", nota2, factorNota);
            }

            if (string.IsNullOrEmpty(txtExamen2.Text))
            {
                DisplayAlert("Alerta", "Ingrese un valor entre 0.1 y 10", "Cancel");
                return;
            }
            else
            {
                notaExamen2 = Convert.ToDouble(txtExamen2.Text);
                notaExamen2 = validarNumeros("Ingrese Nota Examen", notaExamen2, factorExamen);
            }

            nota1 += notaExamen;
            nota2 += notaExamen2;
            resultado = nota1 + nota2;
            resultado = Math.Round(resultado, 2);

            DisplayAlert("Calificaciones del estudiante: " + pkEstudiantes.SelectedItem,
                         "Nota Parcial1: " + nota1 + "\n"
                         + "Nota Parcial2: " + nota2 + "\n"
                         + "Nota Final: " + resultado + "\n"
                         + "Resultado Final: " + resultadofinal(resultado),
                         "Close");
        }

        private string resultadofinal(double nota)
        {
            if (nota >= 0.1 && nota <= 4.9)
            {
                return "Reprobado";
            }
            if (nota >= 5 && nota <= 6.9)
            {
                return "Complementario";
            }
            return "Aprobado";
        }

        private double validarNumeros(string mensaje, double numero, double factor)
        {
            if (numero >= 0.1 && numero <= 10)
            {
                numero *= factor;
            }
            else
            {
                DisplayAlert("Alerta", "Ingrese un valor entre 0.1 y 10 en: " + mensaje, "Cancel");
            }
            return numero;
        }
    }
}
