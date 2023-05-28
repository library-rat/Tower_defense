using UnityEngine;

public class FollowThePath : MonoBehaviour
{

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
        Debug.Log("array len" + len);
    	transform.position = waypoints[waypointIndex].transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move(){
        Debug.Log(transform.position + " " + waypoints[waypointIndex].transform.position);
        if(waypointIndex <= waypoints.Length -1){
            transform.position = Vector2.MoveTowards(transform.position,waypoints[waypointIndex].transform.position,moveSpeed*Time.deltaTime);
            Debug.Log(Vector2.MoveTowards(transform.position,waypoints[waypointIndex].transform.position,moveSpeed*Time.deltaTime) + "+ hi");
        }
        if(transform.position == waypoints[waypointIndex].transform.position){
            waypointIndex +=1;
        }
    }
}
