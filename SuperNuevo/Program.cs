using SuperNuevo.Modulos;
using SuperNuevo.Enum;
namespace SuperNuevo
{
   class Program
    {
        static void Main()
        {
            Articulo banana = new Articulo("banana", 1, 50, Categoria.Alimentos);
            banana.MostrarDetalle();

            Articulo jean= new Articulo("jean",2,30, Categoria.Ropa);
            jean.MostrarDetalle();

            Articulo computadora = new Articulo("computadora", 1, 90, Categoria.DispositivosElectronicos);
            computadora.MostrarDetalle();

            Tienda super = new Tienda("SuperMart");
            super.AgregarArticulo(banana);
            super.AgregarArticulo(jean);
            super.AgregarArticulo(computadora);
            super.QuitarArticulo(jean);
            super.ModificarProducto(banana, 10);

           

        }
    }
}
