abstract class Musico
{
    public string nombre {get; set;}

    public Musico(string n)
    {
        nombre = n;
    }

    public void saluda()
    {
        System.Console.WriteLine("Hola, yo soy " + nombre);
    }

    public abstract void Toca();
    /*{
        System.Console.WriteLine(nombre + " está tocando su instrumento");
    }*/


}

class Violinista : Musico
{
    public string violin {get; set;}

    public Violinista(string n, string vio) : base (n)
    {
        this.violin = vio;
    }

        public override void Toca()
    {
        System.Console.WriteLine($"{nombre}  tocando su  {violin}");
    }

}

class Baterista : Musico
{
    public string bateria {get; set;}

    public Baterista(string n, string bat) : base (n)
    {
        this.bateria = bat;
    }

        public override void Toca()
    {
        System.Console.WriteLine(nombre + " tocando su " + bateria);
    }

}

class Bajista : Musico
{
    public string bajo {get; set;}

    public Bajista(string n, string baj) : base (n)
    {
        this.bajo = baj;

    }

    public override void Toca()
    {
        System.Console.WriteLine(nombre + " tocando su " + bajo);
    }
}


class Program
{
    private static void Main()
    {
        List<Musico> Grupo = new List<Musico>();
        //Grupo.Add(new Musico("Eric"));
        Grupo.Add(new Bajista("Omar ", "está tocando su bajo"));
        Grupo.Add(new Violinista("Iker ", "está tocanco su violín"));
        Grupo.Add(new Baterista("Carlos ", "está tocanco su bateria"));

        foreach(var m in Grupo)
        m.saluda();

        foreach(var m in Grupo)
        m.Toca();

    }
}