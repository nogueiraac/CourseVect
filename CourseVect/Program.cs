using System;

namespace CourseVect {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe o número de quartos que serão ocupados: ");
            int n = int.Parse(Console.ReadLine());

            Student[] rooms = new Student[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Quartos disponíveis: ");
                for (int j = 0; j < n; j++) {
                    if(rooms[j] == null) {
                        Console.WriteLine($"Quarto {j} vazio");
                    }
                }
                Console.Write("Informe o nome do estudante: ");
                string name = Console.ReadLine();
                Console.Write("Informe o e-mail do estudante: ");
                string email = Console.ReadLine();
                Console.Write("Informe o quarto do estudante: ");
                int room = int.Parse(Console.ReadLine());
        
                rooms[room] = new Student {
                    Name = name,
                    Email = email,
                    Room = room
                };
                Console.WriteLine("\nAlocação realizada com sucesso! \n");
            }

            Console.WriteLine("Alocação dos quartos: ");
            for (int i = 0; i < rooms.Length; i++) {
                Console.WriteLine(rooms[i]);
            }
        }
    }
}
