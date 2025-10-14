
using System;
using System.Collections.Generic;

public static class Arenas {
    public static readonly Arena FIRE_ARENA = new FireArena();
    public static readonly Arena ICE_ARENA = new IceArena();
    public static readonly Arena FOREST_ARENA = new ForestArena();
    
    public static readonly List<Arena> ALL_ARENAS = [
        FIRE_ARENA,
        ICE_ARENA,
        FOREST_ARENA
    ];
    
    public static Arena GetArenaByID(string id) {
        foreach (Arena arena in ALL_ARENAS)
            if (arena.GetID() == id)
                return arena;
        return null;
    }
    
    public static Arena GetRandomArena() {
        Random rand = new();
        int index = rand.Next(ALL_ARENAS.Count);
        return ALL_ARENAS[index];
    }
}