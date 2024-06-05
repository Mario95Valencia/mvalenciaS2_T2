namespace mvalenciaS2_T2.View;

public partial class vCalificaciones : ContentPage
{
	public vCalificaciones()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {

		double nota1 = Convert.ToDouble(txtN1.Text);
		double exa1 = Convert.ToDouble(txtN2.Text);
		double nota2 = Convert.ToDouble(txtE1.Text);
		double exa2 = Convert.ToDouble(txtE2.Text);

		if (pkEstudiantes.SelectedIndex < 0)
			DisplayAlert("Alerta", "Debe seleccionar un estudiante", "ok");
		else
		{

		}

    }
}