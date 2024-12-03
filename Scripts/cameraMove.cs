using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform target; //player
    private Transform tr; //camera

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void LateUpdate()
    {
        tr.position = new Vector3(target.position.x - 0.52f, target.position.y + 2.0f, target.position.z - 6.56f);

        tr.LookAt(target);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
