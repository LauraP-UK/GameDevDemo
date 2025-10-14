
using Godot;

public class ForestArena : Arena {
    public override string GetID() => "forest_map";
    public override string GetName() => "Forest Map";
    public override string GetPrefabPath() => "res://Main/Prefabs/Scenes/Arenas/ForestArena.tscn";
    public override void OnMapLoaded() {
        GD.Print("ForestMap loaded! Get lost in the wilderness!");
    }
}