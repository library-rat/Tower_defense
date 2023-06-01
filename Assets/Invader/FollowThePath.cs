using UnityEngine;

public class FollowThePath : MonoBehaviour
{
    [SerializeField]

    private bool up = true;

    [SerializeField]
    private Transform[] waypoints;
    
    [SerializeField]
    private Path path;

    [SerializeField]
    private float moveSpeed = 2f;
    
    private int waypointIndex = 0;


    // Start is called before the first frame update
    private void Start(){
        int len =path.get_path().Length;
        waypoints = new Transform[len];
        waypoints = path.get_path();
    	transform.position = waypoints[waypointIndex].transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(up){
            Move_up();
        }else{
            Move_down();
            Debug.Log("waypoint index" + waypointIndex);

        }
        Debug.Log( up);
        if(transform.position == waypoints[waypoints.Length -1].transform.position){
            Debug.Log("END !!!");
            up =false;
            waypointIndex -= 1;
        }



    }

    private void Move_up(){
        if(waypointIndex <= waypoints.Length -1){
            transform.position = Vector2.MoveTowards(transform.position,waypoints[waypointIndex].transform.position,moveSpeed*Time.deltaTime);
        
            if(transform.position == waypoints[waypointIndex].transform.position){
                waypointIndex +=1;
            }
        }
    }

    private void Move_down(){
        if (waypointIndex >= 0){
                transform.position = Vector2.MoveTowards(transform.position,waypoints[waypointIndex].transform.position,moveSpeed*Time.deltaTime);
           if(transform.position == waypoints[waypointIndex].transform.position){
            waypointIndex -= 1;
           }     
            
        }
    }
}
