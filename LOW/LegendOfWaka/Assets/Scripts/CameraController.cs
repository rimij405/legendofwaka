using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject groundPlane;
    //room width and height can take manual input
    [SerializeField] private float roomWidth;
    [SerializeField] private float roomHeight;
    private float cameraWidth;
    private float cameraHeight;

	// Use this for initialization
	void Start () {
        //find the width and height of what the camera can see
        Vector3 upperRight = gameObject.GetComponent<Camera>().ViewportToWorldPoint(new Vector3(1, 1, transform.position.y));
        cameraWidth = upperRight.x / 2;
        cameraHeight = upperRight.z / 2;

        //find the width and height of the ground plane
        if (groundPlane != null)
        {
            //(multiplying by 10 because plane is 10 units wide
            roomWidth = groundPlane.transform.localScale.x * 10 /2;
            roomHeight = groundPlane.transform.localScale.z * 10 /2;
        }
	}
	
	// Update is called once per frame
	void Update () {
        //follow the player until the camera would go over the groundPlane
        Vector3 pos = transform.position;
        //set the x position of the camera
        if (player.transform.position.x > roomWidth - cameraWidth)
        {
            pos.x = roomWidth - cameraWidth;
        }
        else if (player.transform.position.x < cameraWidth - roomWidth) {
            pos.x = cameraWidth - roomWidth;
        }
        else
        {
            pos.x = player.transform.position.x;
        }
        //set the z position of the camera
        if (player.transform.position.z > roomHeight - cameraHeight)
        {
            pos.z = roomHeight - cameraHeight;
        }
        else if (player.transform.position.z < cameraHeight - roomHeight)
        {
            pos.z = cameraHeight - roomHeight;
        }
        else
        {
            pos.z = player.transform.position.z;
        }
        transform.position = pos;
	}
}
