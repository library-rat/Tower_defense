using UnityEngine;
using UnityEngine.UI;
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

    public void open_membre_menu(){

    }





public void react_to_Membre( Membre mem){
    Debug.Log("Membre");
    if((!mem.get_used()) && (selected.GetComponent<MembreHoldClick>() != null)){
        selected.GetComponent<MembreHoldClick>().set_membre(mem);
    }
}

public void react_to_MembreHold( MembreHoldClick mem){
    Debug.Log("MembreHold");
    selected = mem.GetComponent<Clickable>();
    mem.GetComponent<Clickable>().clickon();

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