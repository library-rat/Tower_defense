using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Detect : MonoBehaviour{

    private List <GameObject> targets = new List<GameObject>(); 

    public Button unhandled;

    public float range ;

    private void Start(){
        unhandled = GameObject.Find("UndetectedClickHandler").GetComponent<Button>();
        unhandled.onClick.AddListener(ClickReact);
        if (unhandled == null){
            Debug.Log("Not found");
        }else{
            Debug.Log("Found");
        }
        
    }

    private void OnMouseDown(){
        Debug.Log("Off");
    }
    private void ClickReact(){
        Debug.Log("CLick");
    }


    private void OnTriggerEnter2D(Collider2D col){
        targets.Add(col.gameObject);
    }

    private void OnTriggerExit2D(Collider2D col){
        targets.Remove(col.gameObject);
    }

}
