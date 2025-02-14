using System;

namespace DIKUArena;
public class Samnite : Gladiator {
    public Samnite(string name) : base(name) {
        this.Level = 1;
        this.MaxHealth = 20;
        this.Health = 20;
        this.Strength = 6;
        this.Dodge = 5;
        this.DoubleStrike = 10;
    }
    public override void GetExperience() {
        Level = Level + 1;
        Strength = Strength + 3;
        MaxHealth = MaxHealth + 15;
        Dodge = Dodge + 2;
        DoubleStrike = DoubleStrike + 5;
        Health = MaxHealth;
    }
}
