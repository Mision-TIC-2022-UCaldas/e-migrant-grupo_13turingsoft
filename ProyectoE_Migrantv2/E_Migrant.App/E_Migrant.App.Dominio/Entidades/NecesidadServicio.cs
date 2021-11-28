namespace E_Migrant.App.Dominio.Entidades
{
    public class NecesidadServicio
    {
        public int Id {get; set;}
        public Categorias Categorias {get; set;}
        public string Descripcion {get; set;}
        public Calificacion Calificacion {get; set;}
    }

    public enum Categorias
    {
        Salud,
        Alimentacion,
        Empleo,
        AlojamientoTemporal,
        AlojamientoPermanente,
        Educacion,
        AyudaLegal
    }

    public enum Calificacion
    {
        Baja = 0,
        Media = 1,
        Alta = 2
    }
}