using UnityEngine;
using UnityEngine.UI;

public class MembreHoldClick : Clickable {

    Membre membre;

    private Image buttonImage;
    public Sprite allSprite;
    new protected void Start(){
        base.Start();
        buttonImage = GetComponent<Image>();


    }
    public override void clickon(){
        clickmanager.open_membre_menu();
        if (membre != null){
            membre.set_free();
        }
    }

    public override void clickoff()
    {
        
    }

    public void set_membre(Membre new_m){
        if (membre != null){
        membre = new_m;
        buttonImage.sprite = membre.buttonImage.sprite;
        }else{
            membre = null;
            buttonImage.sprite = allSprite;
        }
    }

}