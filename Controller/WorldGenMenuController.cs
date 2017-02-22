using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(WorldGenMenuView))]
public class WorldGenMenuController : MenuController {

    // Use this for initialization
    public override void Start()
    {
        View = GetComponent<WorldGenMenuView>();
        View.Controller = this;
        Model = new WorldGenMenuModel();
        ((WorldGenMenuModel)Model).MapWidth(Mathf.RoundToInt(Mathf.Pow(2f, 6f)));
        ((WorldGenMenuModel)Model).SeedInput(0);
    }

    public override void Operation(string option)
    {
        base.Operation(option);
        if (option == WorldGenMenuView.SEEDGEN)
        {
            ((WorldGenMenuView)View).UpdateSeedText(((WorldGenMenuModel)Model).SeedGenerate());
        }
        else if (option == WorldGenMenuView.WORLDGEN)
            ((WorldGenMenuModel)Model).WorldGenerate();
    }

    public void Operation(string option, Object obj)
    {
        if (option == WorldGenMenuView.SEEDINPUT)
        {
            int input = 0;
            if (int.TryParse(((InputField)obj).text, out input))
            {
                input = Mathf.Clamp(input, int.MinValue, int.MaxValue);
            }
            else
            {
                input = 0;
            }
            ((WorldGenMenuView)View).UpdateSeedText(((WorldGenMenuModel)Model).SeedInput(input));
        }
        else if (option == WorldGenMenuView.MAPSIZE)
        {
            int input = Mathf.RoundToInt(Mathf.Pow(2f, (((Dropdown)obj).value + 6f)));
            ((WorldGenMenuModel)Model).MapWidth(input);
        }
    }
}
