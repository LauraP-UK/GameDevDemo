
using Godot;

public class FireArena : Arena {
    public override string GetID() => "fire_map";
    public override string GetName() => "Fire Map";
    public override string GetPrefabPath() => "res://Main/Prefabs/Scenes/Arenas/FireArena.tscn";
    public override void OnMapLoaded() {
        GD.Print("FireMap loaded! Burn your foes!");
    }
}