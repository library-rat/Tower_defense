using UnityEngine;

public class Membre : MonoBehaviour
{
    private bool used = true;
    private Renderer mem_renderer;

    private float range;
    private float health;
    private float fear;
    private float damage;
    private float atkspeed;

    private string typemembre;

    private void Start(){
        mem_renderer = GetComponent<Renderer>();
    }

    public void set_free(){
        used = true;
        mem_renderer.material.color = Color.Grey;
    }

    public void set_used(){
        used = false;
        mem_renderer.material.color = Color.White;

    }

    public void set_typemembre(string input){
        switch(input){
            case "bras" :
                typemembre = "bras";
                break;
            case "torse" :
                typemembre = "torse";
                break;
            case "tete":
                typemembre = "tete";
                break;
            default :
                typemembre = "torse";
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
