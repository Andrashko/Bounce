using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMove : MonoBehaviour
{
    public Vector3 Offset;
    public GameObject Target;

    void Start()
    {
        Offset =  transform.position - Target.transform.position ;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            transform.RotateAround(Target.transform.position, Vector3.up, 180);
            Offset = new Vector3(-Offset.x, Offset.y, Offset.z);
        }
    }
    void LateUpdate()
    {
        transform.position = Target.transform.position + Offset;
        Vector3 targetSpeed = Target.GetComponent<Rigidbody>().velocity;
        
    }
}
