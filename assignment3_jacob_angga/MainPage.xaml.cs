using System.Collections.ObjectModel;
using assignment3_jacob_angga.Model;
using assignment3_jacob_angga.Data;
namespace assignment3_jacob_angga;

public partial class MainPage : ContentPage
{
    ObservableCollection<Province> provinces;
	public MainPage()
	{
		InitializeComponent();
		provinces = new ObservableCollection<Province>(Provinces.GetProvinces());
	}

    void Btn_Clicked(System.Object sender, System.EventArgs e)
    {
        provincelist.ItemsSource = provinces;
    }

    void provincelist_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        Province selected = provincelist.SelectedItem as Province;
        Navigation.PushAsync(new ProvinceView(selected));
    }
}


