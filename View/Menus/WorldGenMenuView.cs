using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WorldGenMenuView : MenuView {

    public static readonly string SEEDGEN = "Seed Generate";
    public static readonly string WORLDGEN = "World Generate";
    public static readonly string MAPSIZE = "Map Size";
    public static readonly string SEEDINPUT = "Seed input";

    public Button _SeedGenButton;
    public Button _WorldGenButton;
    public Dropdown _MapSizeDropdown;
    public InputField _SeedInputField;
    public Text _SeedText;

    public override void Start()
    {
        //_BackButton.onClick.AddListener(delegate { ((MenuController)Controller).Operation(BACK); });
        base.Start();
        _SeedGenButton.onClick.AddListener(delegate { ((WorldGenMenuController)Controller).Operation(SEEDGEN); });
        _WorldGenButton.onClick.AddListener(delegate { ((WorldGenMenuController)Controller).Operation(WORLDGEN); });
        _MapSizeDropdown.onValueChanged.AddListener(delegate { ((WorldGenMenuController)Controller).Operation(MAPSIZE, _MapSizeDropdown); });
        _SeedInputField.onValueChanged.AddListener(delegate { ((WorldGenMenuController)Controller).Operation(SEEDINPUT, _SeedInputField); });
    }

    public void UpdateSeedText(int value)
    {
        _SeedText.text = "Seed Value: " + value;
    }

    public override void Destroy()
    {
        base.Destroy();
        _MapSizeDropdown.onValueChanged.RemoveAllListeners();
        _SeedInputField.onValueChanged.RemoveAllListeners();
        _WorldGenButton.onClick.RemoveAllListeners();
        _SeedGenButton.onClick.RemoveAllListeners();
    }
}
