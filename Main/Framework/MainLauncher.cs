using System;
using Godot;

public partial class MainLauncher : Node {

    private static MainLauncher _instance;
    private static double _elapsedTime;
    
    // Runs as soon as the scene is created
    public MainLauncher() {
        if (_instance != null) throw new InvalidOperationException("ERROR: MainLauncher.<init> : MainLauncher instance already exists!");
        _instance = this;
        GameManager.Init();
    }
    
    // Runs as soon as the node is added to the scene
    public override void _Ready() {
        ArenaManager.SetSpawnPoint(GetNode<Node3D>("ArenaSpawn"));
        ArenaManager.LoadRandomArena();
    }
    
    // Runs every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta) {
        GameManager.Process(delta);
        
        _elapsedTime += delta;
        if (_elapsedTime >= 0.5) {
            _elapsedTime = 0;
            ArenaManager.LoadArena(Arenas.GetNextArena(ArenaManager.GetCurrentArena()));
        }
    }

    // Runs every physics frame. 'delta' is the elapsed time since the previous frame.
    public override void _PhysicsProcess(double delta) {
        
    }
}