public record class recProductos
{
    public int idProducto { get; set; }
    public string Description { get; set; }
    public string CodigoBarras { get; set; }
    public recProductos(int idProducto, string description, string codigoBarras)
    {
        this.idProducto = idProducto;
        this.Description = description;
        this.CodigoBarras = codigoBarras;
    }
}