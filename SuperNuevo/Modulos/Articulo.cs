using SuperNuevo.Enum;

namespace SuperNuevo.Modulos
{
    public class Articulo
    {
        public string NombreArt {  get; set; }
        public int Cod_Articulo {  get; set; }
        public int Precio {  get; set; }
        public Categoria Categoria { get; set; }
        public Articulo(string nombreArt,int cod_Articulo,int precio,Categoria categoria) 
        {
            NombreArt = nombreArt;
            Cod_Articulo = cod_Articulo;
            Precio = precio;
            Categoria = categoria;
        }

        
        public void MostrarDetalle()
        {
            Console.WriteLine($"Articulo: {Cod_Articulo}, Nombre: {NombreArt}");
            Console.WriteLine($"precio: {Precio}, Categoria: {Categoria}");
            Console.WriteLine("------------------------");

        }
    }
}
