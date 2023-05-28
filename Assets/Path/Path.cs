using UnityEngine;

public class Path :MonoBehaviour {
    [SerializeField]
    private Transform[] waypoints;
    public Transform[] get_path(){
        return waypoints;


    }
} 