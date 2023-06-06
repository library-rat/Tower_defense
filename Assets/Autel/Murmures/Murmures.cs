using UnityEngine;
public class Murmures : MonoBehaviour{
    [SerializeField]
    private float cooldowntime = 0.5f;

    [SerializeField]
    private float feardmg = 3f;


    private float counttime;

    private void OnTriggerStay2D(Collider2D col){
        counttime += Time.deltaTime;
        if(counttime >= cooldowntime){
            col.gameObject.GetComponent<Stats>().scare(feardmg);
            counttime = 0f;
        }
        
    }
}