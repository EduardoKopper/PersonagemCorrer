//Na sobrecarga de métodos, criamos esse exemplo onde o Personagem ao correr perde 10 de energia, porém ao criar o Elfo dizemos que ele perde somente 5 de energia pois é mais resistente

using System;

class Personagem{
    public int energia = 100;

    public virtual void Correr(){
        energia = energia - 10;
    }
}

class Elfo : Personagem{
    public override void Correr(){
        energia = energia - 5;
    }
}

class Mago : Personagem{
    public override void Correr(){
        energia = energia - 10; // O Mago corre igual ao Personagem padrão
    }
}

class Program{
    public static void Main(string[] args){
        Elfo e = new Elfo();
        Mago m = new Mago();
        e.Correr();
        m.Correr();
        Console.WriteLine("Energia do Elfo: " + e.energia); // 95
        Console.WriteLine("Energia do Mago: " + m.energia); // 90
    }
}
