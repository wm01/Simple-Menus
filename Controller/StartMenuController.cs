using UnityEngine;
using System.Collections;

[RequireComponent(typeof(StartMenuView))]
public class StartMenuController : MenuController {

	// Use this for initialization
	public override void Start () {
        View = GetComponent<StartMenuView>();
        View.Controller = this;
        Model = new StartMenuModel();
	}

    public override void Operation(string option)
    {
        base.Operation(option);
        if (option == StartMenuView.START)
            ((StartMenuModel)Model).Start();
        else if (option == StartMenuView.EXIT)
            ((StartMenuModel)Model).Exit();        
    }
    // Update is called once per frame
    void Update () {
	
	}
}
