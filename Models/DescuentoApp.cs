namespace Examen_Mvvm.Models;
    public class DescuentoApp
    {
        public double Producto_1 { get; set; }
        public double Producto_2 { get; set; }
        public double Producto_3 { get; set; }

        public double SubTotal{get;set;}
    

    public DescuentoApp(double SubTotal)
    {
       
        this.SubTotal=SubTotal;

    }

}