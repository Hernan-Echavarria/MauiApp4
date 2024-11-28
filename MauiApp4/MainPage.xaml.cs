using System.Collections.ObjectModel;

namespace MauiApp;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Vehiculo> Vehiculos { get; set; }

    public MainPage()
    {
        InitializeComponent();

        // Lista de vehículos (simulación de datos)
        Vehiculos = new ObservableCollection<Vehiculo>
        {
            new Vehiculo { Nombre = "Nissan Versa", Descripcion = "Mantenimiento preventivo por 10,000 km", Estado = "Pendiente", EstadoColor = "Orange", Precio = 2500, Imagen = "nissan.png" },
            new Vehiculo { Nombre = "Ford Explorer", Descripcion = "Cambio de llantas", Estado = "Finalizado", EstadoColor = "Green", Precio = 12500, Imagen = "ford.png" },
            new Vehiculo { Nombre = "Kia K3", Descripcion = "Reparación de clima", Estado = "En revisión", EstadoColor = "Yellow", Precio = 4260, Imagen = "kia.png" },
            new Vehiculo { Nombre = "Honda Civic", Descripcion = "Mantenimiento preventivo por 30,000 km", Estado = "Finalizado", EstadoColor = "Green", Precio = 6400, Imagen = "honda.png" },
            new Vehiculo { Nombre = "Volkswagen Jetta", Descripcion = "Cambio de llantas", Estado = "En proceso", EstadoColor = "Orange", Precio = 18123, Imagen = "jetta.png" }
        };

        BindingContext = this;
    }
}

// Modelo de datos
public class Vehiculo
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Estado { get; set; }
    public string EstadoColor { get; set; }
    public decimal Precio { get; set; }
    public string Imagen { get; set; }
}