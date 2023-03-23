abstract class Musico // Cuando la clase es abstracta, los metodos de las clases que heredan de ella llevarán overrite
{
    public string nombre {get; set;}

    public Musico(string n)
    {
        nombre = n;
    }

    public virtual void saluda() // El parametro virtual es para reedefinir
    {
        System.Console.WriteLine($"Hola, yo soy {nombre}" );
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

        public override void Toca() // Cuando la clase es abstracta, los metodos de las clases que heredan de ella llevarán override
    {
        System.Console.WriteLine($"{nombre}  {violin}");
    }

    //public override string GetSaludo() => base.GetSaludo() + $"Hola, yo soy"+ nombre;


}

class Baterista : Musico
{
    public string bateria {get; set;}

    public Baterista(string n, string bat) : base (n) //El "base" es una referencia a la clase base
    {
        this.bateria = bat;
    }

        public override void Toca()
    {
        System.Console.WriteLine($"{nombre}  {bateria}");
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
        System.Console.WriteLine($"{nombre}  {bajo}");
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