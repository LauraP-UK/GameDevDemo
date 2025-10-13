
using System;
using Godot;

public static class GameManager {

    private static bool _init;

    static GameManager() {
        GD.Print("[GameManager] Created!");
    }

    public static void Init() {
        if (_init) throw new InvalidOperationException("ERROR: GameManager.Init() : GameManager instance already exists.");
        _init = true;
        GD.Print("[GameManager] Initialized!");
        ArenaManager.Init();
    }
    
    public static void Process(double delta) {
    }
}