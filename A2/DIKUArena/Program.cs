using System;
using System.Collections.Generic;

namespace DIKUArena;
public class Program {
    static void Main(string[] args) {
        Gladiator samnite = new Samnite("Boris");
        Gladiator traex = new Traex("Oleks");
        Gladiator retiarii = new Retiarii("The Professor Boss");
        Arena colosseum = new Arena();

        Console.WriteLine("First Battle: Boris vs Oleks");
        Gladiator winner1 = colosseum.Battle(samnite, traex);

        Console.WriteLine("Second battle: The winner vs The Professor Boss");
        colosseum.Battle(winner1, retiarii);
    }
}
