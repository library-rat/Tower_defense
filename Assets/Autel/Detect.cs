using UnityEngine;
using System.Collections.Generic;

public class Detect : MonoBehaviour{

    private List <GameObject> targets = new List<GameObject>(); 

    public float range ;

    private void OnTriggerEnter2D(Collider2D col){
        Debug.Log("in");
        targets.Add(col.gameObject);
    }

    private void OnTriggerExit2D(Collider2D col){
        Debug.Log("out");
        targets.Remove(col.gameObject);
    }

}
