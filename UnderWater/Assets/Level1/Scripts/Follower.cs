using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 previous_pos = transform.position;
        distanceTravelled += (speed-0.2f) * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);

        // 회전 따라가게
        Vector3 relativePos = transform.position - previous_pos;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        transform.rotation = rotation;

    }
}
