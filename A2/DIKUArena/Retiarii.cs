using System;

namespace DIKUArena;
public class Retiarii : Gladiator {
    public Retiarii(string name) : base(name) {
        this.Level = 1;
        this.MaxHealth = 15;
        this.Health = 15;
        this.Strength = 4;
        this.Dodge = 15;
        this.DoubleStrike = 10;
    }
    public override void GetExperience() {
        Level = Level + 1;
        Strength = Strength + 2;
        MaxHealth = MaxHealth + 5;
        Dodge = Dodge + 8;
        DoubleStrike = DoubleStrike + 5;
        Health = MaxHealth;
    }
}