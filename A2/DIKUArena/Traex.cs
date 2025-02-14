using System;

namespace DIKUArena;
public class Traex : Gladiator {
    public Traex(string name) : base(name) {
        this.Level = 1;
        this.MaxHealth = 30;
        this.Health = 30;
        this.Strength = 4;
        this.Dodge = 10;
        this.DoubleStrike = 15;
    }
    public override void GetExperience() {
        Level = Level + 1;
        Strength = Strength + 2;
        MaxHealth = MaxHealth + 10;
        Dodge = Dodge + 5;
        DoubleStrike = DoubleStrike + 8;
        Health = MaxHealth;
    }
}
