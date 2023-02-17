using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
	GameObject player;
	Vector3 offset;
	Vector3 threshold = new Vector3(9f,0f,5f);

    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
    	Vector3 offsetdist = player.transform.position + offset - transform.position;
    	float xcorrect = 0f;
    	float zcorrect = 0f;
    	if (offsetdist.x > threshold.x){
    		xcorrect = offsetdist.x - threshold.x;
    	}
    	else if (offsetdist.x < -threshold.x){
    		xcorrect = offsetdist.x + threshold.x;
    	}
    	if (offsetdist.z > threshold.z){
    		zcorrect = offsetdist.z - threshold.z;
    	}
    	else if (offsetdist.z < -threshold.z){
    		zcorrect = offsetdist.z + threshold.z;
    	}
    	// Debug.Log("Offset Dist: " + offsetdist.ToString());
    	transform.position += new Vector3(xcorrect, 0f, zcorrect);
        // transform.position = player.transform.position + offset;
        transform.LookAt(player.transform);
    }
}
