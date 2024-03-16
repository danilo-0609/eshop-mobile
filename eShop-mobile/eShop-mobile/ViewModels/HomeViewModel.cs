using CommunityToolkit.Mvvm.ComponentModel;
using eShop_mobile.Models;
using System.Collections.ObjectModel;

namespace eShop_mobile.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<Presentation> _presentations;

    public HomeViewModel()
    {
        Presentations = new ObservableCollection<Presentation>()
        {
            new Presentation(
                Gender: "Hombre",
                Description: "Catalogo completo de productos para hombre",
                ImageUri: new Uri("https://images.unsplash.com/photo-1489352472630-7ad0b011c3b2?q=80&w=1374&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D")),

            new Presentation(
                Gender: "Mujer",
                Description: "Catalogo completo de productos para mujer",
                ImageUri: new Uri("https://images.unsplash.com/photo-1501441858156-e505fb04bfbc?q=80&w=1448&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"))
        };
    }
}
