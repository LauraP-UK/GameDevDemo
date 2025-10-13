
using Godot;

public static class ArenaManager {
    
    private static Node3D _spawnPoint;
    
    public static void Init() {
        GD.Print("[ArenaManager] Initialized!");
    }
    
    public static void SetSpawnPoint(Node3D spawnPoint) => _spawnPoint = spawnPoint;

    public static void LoadRandomArena() {
        Arena randomArena = Arenas.GetRandomArena();
        LoadArena(randomArena);
    }

    public static void LoadArena(Arena arena) {
        ClearArena();
        GD.Print($"[ArenaManager] Loading arena: {arena.GetName()}");
        Node3D arenaNode = arena.GetArenaInstance();
        _spawnPoint.AddChild(arenaNode);
        arena.OnMapLoaded();
    }
    
    public static void ClearArena() {
        foreach (Node child in _spawnPoint.GetChildren()) child.QueueFree();
        GD.Print("[ArenaManager] Cleared arena.");
    }
    
}