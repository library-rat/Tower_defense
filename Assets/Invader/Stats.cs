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

    
    
}