namespace SuperNuevo.Modulos
{
    public class Tienda
    {
        public string Nombre { get; private set; }
        public List<Articulo> Articulos { get; set; } = new List<Articulo>();
        public Tienda(string nombre)
        {
            Nombre = nombre;
        }
        public Tienda(string nombre, List<Articulo> articulos)
        {
            Nombre = nombre;
            Articulos = articulos;
        }
        public void AgregarArticulo(Articulo Art)
        {
            Articulos.Add(Art);
        }
        public void QuitarArticulo(Articulo Art)
        {
            Articulos.Remove(Art);
        }
        public void ModificarProducto(Articulo art, int precio)
        {
            art.Precio = precio;
            Console.WriteLine($"El articulo{art.NombreArt}, ahora vale $ {art.Precio}");
        }
        public void ModificarProducto(Articulo art, int precio,int cod_Articulo)
        {
            art.Precio= precio;
            art.Cod_Articulo= cod_Articulo;
            Console.WriteLine($"El articulo{art.NombreArt}, ahora vale $ {art.Precio}, y su codigo es {art.Cod_Articulo}");
        }
}
}
