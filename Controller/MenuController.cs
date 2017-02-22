using UnityEngine;
using System.Collections;

public abstract class MenuController : Controller {

	// Use this for initialization
	public virtual void Start ()
    {
        View = GetComponent<MenuView>();
        View.Controller = this;
        Model = new MenuModel();
	}
	
    public virtual void Operation(string option)
    {
        if (option == MenuView.BACK)
            ((MenuModel)Model).Back();
    }
}
