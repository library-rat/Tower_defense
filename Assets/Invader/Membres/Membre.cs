using UnityEngine;
using UnityEngine.UI;
public class Membre : MonoBehaviour
{
    private bool used = true;
    private Renderer mem_renderer;
    private SpriteRenderer spriteRenderer;

    private Image buttonImage;
    private float range;
    private float health;
    private float fear;
    private float damage;
    private float atkspeed;
    public Sprite spriteBras;
    public Sprite spriteTorse;
    public Sprite spriteCrane;
    private string typemembre;

    private void Start(){
        mem_renderer = GetComponent<Renderer>();
        buttonImage = GetComponent<Image>();
    }

    public void set_free(){
        used = true;
        mem_renderer.material.color = Color.grey;
    }

    public void set_used(){
        used = false;
        mem_renderer.material.color = Color.white;

    }

    public void set_typemembre(string input){
        switch(input){
            case "bras" :
                typemembre = "bras";
                buttonImage.sprite = spriteBras;
                break;
            case "torse" :
                typemembre = "torse";
                buttonImage.sprite = spriteTorse;
                break;
            case "crane":
                typemembre = "crane";
                buttonImage.sprite = spriteCrane;
                break;
            default :
                typemembre = "torse";
                buttonImage.sprite = spriteTorse;
                break;
        }
    }

    public string get_typemembre(){
        return typemembre;
    }

    public void set_modif(float[] input){
        range = input[0];
        health = input[1];
        fear = input[2];
        damage = input[3];
        atkspeed = input[4];
    }

    public float[] get_modif(){
        float[] temp = {range, health, fear, damage, atkspeed};
        return (temp);
    }
}
