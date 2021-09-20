using System;
using System.Collections.Generic;

public class Tamagotchi
{
    public string name;
    private int hunger;
    private int boredom;
    private bool isAlive = true;
    private List<string> words = new List<string>() { "OvO", "Onichan" };
    private Random rnd = new Random();
    public Tamagotchi()
    {
        Console.WriteLine("Choose a name for me Dommy Mommy");
        this.name = Console.ReadLine();
    }
    public bool GetAlive()
    {
        return isAlive;
    }
    public void Teach(string word)
    {
        words.Add(word);
        Console.WriteLine($"Succesfully added {word} to dictionary OvO");
        ReduceBoredom();
    }
    public void Hi()
    {
        int index = rnd.Next(words.Count);
        Console.WriteLine(words[index]);
        ReduceBoredom();
    }
    public void Feed()
    {
        hunger -= 3;
        hunger = Math.Max(0, hunger);
    }
    public void Tick()
    {
        boredom++;
        hunger++;
        if (hunger > 10 || boredom > 10)
            isAlive = false;
    }
    public void PrintStats()
    {
        Console.WriteLine("My name is" + name);
        Console.WriteLine($"I am {hunger} hungry OvO");
        Console.WriteLine($"I am {boredom} bored -n-");
    }
    private void ReduceBoredom()
    {
        boredom -= 2;
        boredom = Math.Max(0, boredom);
    }
}