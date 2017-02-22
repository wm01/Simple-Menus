using UnityEngine;
using System.Collections;

public class StartMenuModel : MenuModel {

    public void Start()
    {
        GameStateManager.Instance.ChangeState(new GameStateWorldGenMenu());
    }

    public void Exit()
    {
        Application.Quit();
    }
}
