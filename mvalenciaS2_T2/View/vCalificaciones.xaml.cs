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
        double nparcial1;
        double nparcial2;
        double ntotal;

        if (pkEstudiantes.SelectedIndex < 0)
            DisplayAlert("Alerta", "Debe seleccionar un estudiante", "ok");
        else
        {
            nota1 = nota1 * 0.30;
            exa1 = exa1 * 0.20;
            nparcial1 = nota1 + exa1;
            nota2 = nota2 * 0.30;
            exa2 = exa2 * 0.20;
            nparcial2 = nota2 + exa2;
            ntotal = nparcial1 + nparcial2;

            np1.Text = nparcial1.ToString();
            np2.Text = nparcial2.ToString();
            lblTotal.Text = ntotal.ToString();
            if (ntotal >= 7)
                DisplayAlert("Mensaje", "El o la estudiante aprueba con: " + lblTotal.Text, "OK");
            else
                DisplayAlert("Mensaje", "El o la estdiante reprueba con: " + lblTotal.Text, "OK");

        }

    }
}