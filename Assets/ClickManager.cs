using UnityEngine;
using System.Collections.Generic;

public class ClickManager : MonoBehaviour{
    List<Clickable> listeners = new List<Clickable>();
    Clickable selected;
    
    public GameObject MembreMenu;
    
    public void Start(){
        MembreMenu = GameObject.Find("MembreMenu");
    }

    public void AddListener(Clickable elt){
        listeners.Add(elt);
    }
    
    public void RemoveListener(Clickable elt){
        listeners.Remove(elt);
    }

    public void Set_Selected(Clickable elt){
        selected = elt;
    }

    public void collect_membre(Membre elt){

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
            selected = null;
            Debug.Log("NOT TOUCHED");
        }else{
                
                if (hit.collider.GetComponent<MembreHoldClick>()!= null){
                    selected = hit.collider.GetComponent<Clickable>();;
                    
                }else{
                if(hit.collider.GetComponent<MembreClick>() != null){
                        selected.GetComponent<MembreHoldClick>().set_membre(hit.collider.GetComponent<Membre>());
                }else{

                
                foreach (var elt in listeners){
                    if(elt != selected ){
                        elt.GetComponent<Clickable>().clickoff();
                    }
                }
                
                hit.collider.GetComponent<Clickable>().clickon();
                
                Debug.Log("TOUCHED");
                }
                }
            }
        }
    }
}