using System;

public class Corpo
{
    public string Nome { get; set; }
    public double Massa { get; set; }      // kg
    public double Densidade { get; set; }  // kg/m³
    public double PosX { get; set; }       // m
    public double PosY { get; set; }       // m
    public double VelX { get; set; }       // m/s
    public double VelY { get; set; }       // m/s

    public double Raio { get; private set; } // Com o raio calculado, não vem de fora.

    // O construtor irá recebe os 7 atributos e já calcula o Raio a partir da
    // Massa/Densidade (Essa é a fórmula do volume da esfera isolando o "r")

    public Corpo(string nome, double massa, double densidade, double posX, double posY, double velX, double velY)
    {
         // Verifica se a massa recebida é válida.
        if (massa <= 0)
        {
            throw new ArgumentException("A massa deve ser maior que zero.");
        }

        // A densidade não pode ser zero ou negativa,
        // pois é necessária para calcular o volume do corpo.
        if (densidade <= 0)
        {
            throw new ArgumentException("A densidade deve ser maior que zero.");
        }
        
        // Armazena os dados iniciais recebidos pelo corpo.
        Nome = nome;
        Massa = massa;
        Densidade = densidade;
        PosX = posX;
        PosY = posY;
        VelX = velX;
        VelY = velY;

        // Calcula o volume do corpo
        double volume = Massa / Densidade;

        // Considerando o corpo como uma esfera, calcula seu raio a partir do volume Math.PI ≈ 3,141592... e Math.Pow(valor,  / ) calcula  a raiz cúbica.     
        Raio = Math.Pow((3 * volume) / (4 * Math.PI), 1.0 / 3.0);
    }   
}

