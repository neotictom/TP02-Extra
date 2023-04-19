internal class Program
{
    private static void Main(string[] args)
    {
        string e = Environment.NewLine;
        int menu = 0;
        Boxeador box1 = new Boxeador("","", 0, 0 ,0), box2 = new Boxeador("","",0,0,0);
        while(menu != 4){
            menu = IngresarInt($"Elija una opcion {e}1. Cargar Datos Boxeador 1 {e}2. Cargar Datos Boxeador 2 {e}3. Pelear!{e}4. Salir");
            switch(menu){
                case 1:
                DatosBoxeador(ref box1, menu);
                break;
                case 2:
                DatosBoxeador(ref box2, menu);
                break;
                case 3:
                Pelear(box1,box2);
                break;
            }
        }
    }
    static void DatosBoxeador(ref Boxeador box, int num){
        string nom, pais;
        int peso,vp,pg;
        nom = IngresarString("Ingresa el nombre del boxeador "+ num);
        pais = IngresarString("Ingrese el pais del boxeador "+ num);
        peso = IngresarInt("Ingrese el peso del boxeador "+ num);
        vp = IngresarInt("Ingrese la velocidad del boxeador "+ num);
        pg = IngresarInt("Ingrese la potencia del boxeador "+ num);
        box = new Boxeador(nom,pais,peso,pg,vp);
    } 
    static void Pelear(Boxeador box1, Boxeador box2){
        int skillbox1 = box1.ObtenerSkill();
        int skillbox2 = box2.ObtenerSkill();

    }
    static int IngresarInt(string m){
        int d;
        Console.WriteLine(m);
        return d = int.Parse(Console.ReadLine());
    }
    static string IngresarString(string m){
        string d;
        Console.WriteLine(m);
        return d = Console.ReadLine();
    }
}