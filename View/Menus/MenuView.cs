using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuView : View {

    public static readonly string BACK = "Back";

    public Button _BackButton;

    // Use this for initialization
    public virtual void Start () {
        if (_BackButton != null)
            _BackButton.onClick.AddListener(delegate { ((MenuController)Controller).Operation(BACK); });
	}
	

    public virtual void Destroy()
    {
        if(_BackButton != null)
        {
            _BackButton.onClick.RemoveAllListeners();
        }
    }
}
