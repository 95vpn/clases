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

public record struct recImpuestos
{
    public decimal PorcentajeIva { get; set; }
    public decimal PorcentajeIeps { get; set; }

    public recImpuestos(decimal porIva, decimal porIeps)
    {
        PorcentajeIva = porIva;
        PorcentajeIeps = porIeps;
    }
}

public record recMontosImpuestos
{
    public decimal MontoIva { get; set; }
    public decimal MontoIeps { get; set; }

    public recMontosImpuestos(decimal monto)
}