using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TeleportMarker;
    private void OnTriggerEnter(Collider collider)
    {
        print(TeleportMarker.transform.position);
        collider.gameObject.transform.position = TeleportMarker.transform.position;
        print(TeleportMarker.transform.position);
    }
}
