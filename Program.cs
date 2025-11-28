
class Program
{
    static void Main()
    {
        Console.WriteLine("--- Esperto Contra Sabido ---\n");
 
        Console.Write("Quantos alimentos serão distribuídos? ");
        int total = Convert.ToInt32(Console.ReadLine());
 
        Console.WriteLine();
 
        int picaPau = 0;
        int raposinha = 0;
        int restantes = total;
 
        int numero = 1; // Conta a vez: 1 para você, 2 para você...
 
        while (restantes > 0)
        {
            // Primeiro o Pica-Pau pega 1
            Console.Write($"{numero} para você. ");
            picaPau++;
            restantes--;
 
            // Agora a Raposinha pega 1 até 'numero'
            Console.Write("1");
            raposinha++;
            restantes--;
 
            int cont = 2;
 
            while (cont <= numero && restantes > 0)
            {
                Console.Write($", {cont}");
                raposinha++;
                restantes--;
                cont++;
            }
 
            Console.WriteLine(" para mim.");
 
            numero++;
        }
 
        Console.WriteLine();
        Console.WriteLine($"Pica-pau recebeu {picaPau} alimento(s).");
        Console.WriteLine($"Raposinha recebeu {raposinha} alimento(s).");
    }
}
