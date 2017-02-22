using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartMenuView : MenuView {

    public static readonly string START = "Start";
    public static readonly string EXIT = "Exit";

    public Button _StartButton;
    public Button _ExitButton;

    public override void Start()
    {
        //_BackButton.onClick.AddListener(delegate { ((MenuController)Controller).Operation(BACK); });
        base.Start();
        _StartButton.onClick.AddListener(delegate { ((StartMenuController)Controller).Operation(START); });
        _ExitButton.onClick.AddListener(delegate { ((StartMenuController)Controller).Operation(EXIT); });
    }

    public override void Destroy()
    {
        base.Destroy();
        _StartButton.onClick.RemoveAllListeners();
        _ExitButton.onClick.RemoveAllListeners();
    }
}
