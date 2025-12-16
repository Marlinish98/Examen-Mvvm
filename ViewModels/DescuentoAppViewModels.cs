namespace Examen_Mvvm.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Examen_Mvvm.Models;

public partial class DescuentoAppViewModels : ObservableObject
{
    [ObservableProperty]
    private double producto_1;

    [ObservableProperty]
    private double producto_2;

    [ObservableProperty]
    private double producto_3;

    [ObservableProperty]
    private double subTotal;

    [ObservableProperty]
    private double descuento;

    [ObservableProperty]
    private double totalCompra;

    [RelayCommand]

    private async Task Validacion()
    {
        try
        {
            SubTotal = Producto_1 + Producto_2 + Producto_3;
            if (Producto_1 <= 0 || Producto_2 <= 0 || Producto_3 <= 0)
            {
                await Application.Current!.MainPage!.DisplayAlert("ADVERTENCIA", "La casillas de los Productos no puede ser menor o igual a 0.", "Aceptar");
            }

            if (SubTotal>0 && SubTotal <= 999.99)
            {
                Descuento = SubTotal * 0;
            }
            else if (SubTotal>=1000 && SubTotal <= 4999.99)
            {
                Descuento = SubTotal * 0.10;
            }
             else if (SubTotal>=5000 && SubTotal <= 9999.99)
            {
                Descuento = SubTotal * 0.20;
            }
              else if (SubTotal>=10000 && SubTotal <= 19999.99)
            {
                Descuento = SubTotal * 0.30;
            }
            else
            {
                Descuento = SubTotal * 0;
            }

            TotalCompra = SubTotal - Descuento;
        }
        catch (Exception e)
        {
            await Application.Current!.MainPage!.DisplayAlert("ERROR", e.Message, "Aceptar");
        }
    }

    [RelayCommand]
    private void Limpiar()
    {
        Producto_1 = 0;
    Producto_2 = 0;
    Producto_3 = 0;
    SubTotal = 0;
    Descuento = 0;
    TotalCompra = 0;
    }

}