using UnityEngine;
using UnityEngine.UI;

public class MembreClick : Clickable {
    private Button buttref;
    new protected void Start(){
        base.Start();
        buttref = GetComponent<Button>();
        Membre memself = GetComponent<Membre>();
        buttref.onClick.AddListener(() => {clickmanager.react_to_Membre(memself);});
    }
    public override void clickon(){
        Debug.Log("click on membre");
    }

    public override void clickoff()
    {
/*         transform.GetChild(0).GetComponent<Renderer> ().enabled = false;
 */    }

}