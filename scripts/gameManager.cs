using Godot;
using System;

public partial class gameManager : Node
{
    [Export]
    public int playerHealth = 10;
    [Export]
    public bool alive = true;
    [Export]
    public int score = 0;
    [Export]
    public int damage = 2;
    
    
}
