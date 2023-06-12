using UnityEngine;
using System.Collections.Generic;

public class ClickManager : MonoBehaviour{
    List<Clickable> listeners = new List<Clickable>();
    
    public void AddListener(Clickable elt){
        listeners.Add(elt);
    }
    
    public void RemoveListener(Clickable elt){
        listeners.Remove(elt);
    }

    private void Update (){
        if(Input.GetMouseButtonDown(0)){
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos,Vector3.zero);
        if (hit.collider == null){
            foreach (var elt in listeners)
            {
                elt.GetComponent<Clickable>().clickoff();
            }
            Debug.Log("NOT TOUCHED");
            }else{
                hit.collider.GetComponent<Clickable>().clickon();
                Debug.Log("TOUCHED");
            }
        }
    }
}