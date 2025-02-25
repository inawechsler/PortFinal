namespace PortDev.Models
{
    public class OtroTrabajo
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionEn { get; set; }
        public string[] ImagenesUrl { get; set; }
        public string[] Tecnologías { get; set; }
        public string[] TecnologíasEn { get; set; }
        public TypeProject Tipo { get; set; }  // "Asset 3D", "Sprite", "Tool", etc.
        public int IndiceImagenActual { get; set; } = 0;
    }
}
