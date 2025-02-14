using System;
using System.Collections.Generic;

namespace DIKUArena;
public class Arena{
    public Arena(){}
    public Gladiator Battle(Gladiator g1, Gladiator g2) {
        Console.WriteLine("Fight til death!");
        int round = 1;
        Gladiator current = g1; 
        Gladiator inactive = g2;
        while (!g1.HasLost() && !g2.HasLost()) {
            Console.WriteLine("ROUND: {0}", round);
            current.Attack(inactive);
            Gladiator temp = current;
            current = inactive;
            inactive = temp;
            round = round + 1;
        }
            Gladiator winner = g1.HasLost() ? g2 : g1;
            Console.WriteLine($"The winner is: {winner.Name}");
            winner.GetExperience();
            return winner;
    }
    public Gladiator RunTournament(List<Gladiator> Competitors) {
        if (Competitors.Count < 2) {
            Console.WriteLine("Not enough gladiators to run a tournament!");
            return Competitors[0];
        }
        while (Competitors.Count > 1) {
            List<Gladiator> winners = new List<Gladiator>();
            for (int i = 0; i < Competitors.Count; i += 2) {
                if (i + 1 < Competitors.Count) {
                    Gladiator winner = Battle(Competitors[i], Competitors[i + 1]);
                    winners.Add(winner);
                } else {
                    Console.WriteLine($"{Competitors[i].Name} advances automatically!");
                    winners.Add(Competitors[i]);
                }
            }
            Competitors = winners;
        }
        Gladiator champion = Competitors[0];
        Console.WriteLine($"{champion.Name} is the winner of the Tournament");
        return champion;
    }
}

