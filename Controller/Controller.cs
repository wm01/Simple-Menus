using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    private Model _Model;
    private View _View;

    public View View
    {
        get { return _View; }
        set { _View = value; }
    }

    public Model Model
    {
        get { return _Model; }
        set { _Model = value; }
    }

    public View GetView() { return _View; }
    public void SetView(View view) { _View = view; }
    public Model GetModel() { return _Model; }
    public void SetModel(Model model) { _Model = model; }
}
