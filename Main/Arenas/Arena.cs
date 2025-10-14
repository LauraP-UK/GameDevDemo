
using Godot;

public abstract class Arena {
    public abstract string GetID();
    public abstract string GetName();
    public abstract string GetPrefabPath();
    public abstract void OnMapLoaded();
    
    public Node3D GetArenaInstance() {
        PackedScene arenaScene = GD.Load<PackedScene>(GetPrefabPath());
        return arenaScene.Instantiate<Node3D>();
    }
}