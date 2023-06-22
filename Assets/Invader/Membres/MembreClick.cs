using UnityEngine;

public class MembreClick : Clickable {

    new protected void Start(){
        base.Start(); 
    }
    public override void clickon(){
        transform.GetChild(0).GetComponent<Renderer> ().enabled = true;
        base.clickmanager.Set_Selected(this);
    }

    public override void clickoff()
    {
        transform.GetChild(0).GetComponent<Renderer> ().enabled = false;
    }

}