using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public GameObject wayPoint;
    private Vector3 wayPointPosition;
    public float speed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        wayPointPosition = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
        //Here, the zombie's will follow the waypoint.
        this.gameObject.transform.position = Vector3.MoveTowards(transform.position, wayPointPosition, speed * Time.deltaTime);

    }
}
