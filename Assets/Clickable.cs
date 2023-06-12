using UnityEngine;

public class Clickable : MonoBehaviour{
    public ClickManager clickmanager;

    protected void Start(){
        clickmanager = GameObject.Find("ClickManager").GetComponent<ClickManager>();
        clickmanager.AddListener(this);
    }
    public virtual void clickon(){
    }

    public virtual void clickoff(){
    }


}