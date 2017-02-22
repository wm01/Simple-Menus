using UnityEngine;
using System.Collections;

public class MenuModel : Model {

    public void Back()
    {
        GameStateManager.Instance.PreviousState();
    }


}
