using UnityEngine;

public class MembreClick : Clickable {

    new protected void Start(){
        base.Start(); 
    }
    public override void clickon(){
        GetComponent<Membre>().set_used();
        Debug.Log("click on membre");
    }

    public override void clickoff()
    {
/*         transform.GetChild(0).GetComponent<Renderer> ().enabled = false;
 */    }

}