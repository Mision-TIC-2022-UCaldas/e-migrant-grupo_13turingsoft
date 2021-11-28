namespace E_Migrant.App.Dominio.Entidades
{
    public class Migrante:Persona
    {
        public SituacionLaboral situacionLaborlal{get;set;}
        public Salud salud{get;set;}
        public Alimentacion alimentacion {get;set;}
        public Empleo Empleo{get;set;}
        public AlojamientoTemp AlojoTemporal{get;set;}
        public AlojamientoPermanent AlojoPermanente{get;set;}
        public Educacion Educacion{get;set;}
        public AyudaLegal AyudaLegal{get;set;}

        public string Usuario{get;set;}
        public string clave{get;set;}



        

    }
}