namespace PruebaCRUD.Models
{
    public class Producto
    {
       //He generado como ejemplo un modelo Producto que se deberia crear una tabla en sql con estas condiciones aplicando la migracion
       public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }

    }
}
