
using Godot;

public class IceArena : Arena {
    public override string GetID() => "ice_map";
    public override string GetName() => "Ice Map";
    public override string GetPrefabPath() => "res://Main/Prefabs/Scenes/Arenas/IceArena.tscn";
    public override void OnArenaLoaded(Node3D arenaNode) {
        GD.Print("IceMap loaded! Freeze the enemies!");
    }
}