using UnityEngine;
using System.Collections;

public class WorldGenMenuModel : MenuModel {

    public int SeedGenerate()
    {
        int seed = Random.Range(int.MinValue, int.MaxValue);
        WorldController.Instance.World.WorldSeed = seed;
        return WorldController.Instance.World.WorldSeed;
    }

    public int SeedInput(int input)
    {
        WorldController.Instance.World.WorldSeed = input;
        return WorldController.Instance.World.WorldSeed;
    }

    public void MapWidth(int input)
    {
        WorldController.Instance.World.WorldWidth = input;
    }

    public void WorldGenerate()
    {
        GameStateManager.Instance.ChangeState(new GameStateGenerate());
    }

}
