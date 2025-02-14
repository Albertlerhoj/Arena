using System;

namespace DIKUArena;
public class Gladiator {
    private string name;
    private int maxHealth;
    private int level;
    private int health;
    private int strength;
    private int dodge;
    private int doubleStrike;
    public Gladiator(string name) {
        this.name = name;
        this.level = 1;
        this.maxHealth = 20;
        this.health = 20;
        this.strength = 4;
        this.dodge = 10;
        this.doubleStrike = 10;
    }
    public override string ToString() {
        return $"Gladiator: {name} | Level: {level} | Health {health}";
    }
    public bool HasLost () {
        if (health > 0)
            return false;
        else 
            return true;
    }
    private Random rand = new Random();
    public void TakeDamage(int strength) {
        health = Math.Max(0, health - strength);
    }
    public bool TryDodge() {
        return rand.Next(0, 101) < dodge;
    }
    public bool TryDoubleStrike() {
        return rand.Next(0, 101) < doubleStrike;
    }
    public bool LoseHealth (int strength) {
        if (TryDodge()) {
            Console.WriteLine($"{name} managed to dodge");
            return false;}
        else
        {
            TakeDamage(strength);
            Console.WriteLine($"{name} got hit. Health now: {health} ");    
            return true;
        }
    }
        public void Attack (Gladiator opponent) {
        if (TryDoubleStrike()) {
            Console.WriteLine($"{name} lands a double strike {opponent.name} for {2*strength} damage");
            opponent.LoseHealth(2*strength);
        }
        else {
            Console.WriteLine($"{name} hits {opponent.name} for {strength} damage");
            opponent.LoseHealth(strength);
        }
    } 
    public virtual void GetExperience() {
        level = level + 1;
        Console.WriteLine($"{name} leveled up to level {level}");
    }
    public string Name {
        get {return name;}
        set {name = value;}
    }
    public int Level {
        get {return level;}
        set {level = value;}
    }
    public int MaxHealth {
        get {return maxHealth;}
        set {maxHealth = value;}
    }
    public int Health {
        get {return health;}
        set {health = value;}
    }
    public int Strength {
        get {return strength;}
        set {strength = value;}
    }
    public int Dodge {
        get {return dodge;}
        set {dodge = Math.Min(value, 60);}
    }
    public int DoubleStrike {
        get {return doubleStrike;}
        set {doubleStrike = Math.Min(value, 60);}
    }
}