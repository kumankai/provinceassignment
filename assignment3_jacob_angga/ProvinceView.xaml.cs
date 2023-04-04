using assignment3_jacob_angga.Model;
namespace assignment3_jacob_angga;

public partial class ProvinceView : ContentPage
{
    public ProvinceView(Province province)
	{
		InitializeComponent();

        pname.Text = province.Name;
        pcapital.Text = province.Capital;
        pflag.Source = province.Flag;

    }
}
