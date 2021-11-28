namespace E_Migrant.App.Dominio.Entidades
{
    public class MigrantesFA : Persona
    {
        public FamyAmi FamyAmi {get; set;}
    }

    public enum FamyAmi {
        Familiar,
        Amigo
    }
}