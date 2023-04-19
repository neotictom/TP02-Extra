class Boxeador{
    public string Nombre{get;set;}
    public string Pais{get;set;}
    public int Peso{get;set;}
    public int PotenciaGolpes{get;set;}
    public int VelocidadPiernas{get;set;}
    public Boxeador(string nom, string pais, int peso, int pg, int vp){
        Nombre = nom;
        Pais = pais;
        Peso = peso;
        PotenciaGolpes = pg;
        VelocidadPiernas = vp;
    }
    public int ObtenerSkill(){
        int vp = Convert.ToInt32(VelocidadPiernas*0.6);
        int pg = Convert.ToInt32(PotenciaGolpes*0.8);
        Random r = new Random();
        int numeroazar = r.Next(1,10);
        int skill = numeroazar+pg+vp;
        return skill;

    }





}