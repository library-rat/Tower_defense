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
        
    }

    public override void clickoff()
    {
        
    }

    public void set_membre(Membre new_m){
        if (membre != null){
            clickmanager.collect_membre(membre);
        }
        membre = new_m;
        buttonImage.sprite = membre.buttonImage.sprite;
        if (membre == null){
            buttonImage.sprite = allSprite;
        }
    }

}