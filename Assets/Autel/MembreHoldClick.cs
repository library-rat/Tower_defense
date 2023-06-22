using UnityEngine;
using UnityEngine.UI;

public class MembreHoldClick : Clickable {

    Membre membre;

    private Image buttonImage;
    new protected void Start(){
        base.Start();
        buttonImage = GetComponent<Image>();


    }
    public override void clickon(){
        
    }

    public override void clickoff()
    {
        
    }

    public void set_membre(Membre new_m){
        membre = new_m;
        buttonImage.sprite = membre.buttonImage.sprite;
    }

}