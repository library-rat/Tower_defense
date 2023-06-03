using UnityEngine;

public class Detect : MonoBehaviour{

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("ouch");
    }
}
