using UnityEngine;

public class Stats :MonoBehaviour {

    [SerializeField]
    private float health;    
    
    [SerializeField]

    private float maxhealth;
    
    [SerializeField]
    private float fear;
    
    [SerializeField]
    private float maxfear;
    
    public GameObject bars;

    private void Start(){
        bars.GetComponent<Bars>().UpdateHealthBar();
        bars.GetComponent<Bars>().UpdateFearBar();
        Debug.Log(bars.GetComponent<Bars>().InnerFear.fillAmount);

    }
    public float get_health(){
        return health;
    }

    public float get_maxhealth(){
        return maxhealth;
    }

    public float get_fear(){
        return fear;
    }

    public float get_maxfear(){
        return maxfear;
    }

    public void hit( float damage){
        health = Mathf.Max(0, health - damage); 
        bars.GetComponent<Bars>().UpdateHealthBar();
    }

    public void scare(float damage){
        fear = Mathf.Max(0, fear - damage);
        bars.GetComponent<Bars>().UpdateFearBar();

    }
    
    
}