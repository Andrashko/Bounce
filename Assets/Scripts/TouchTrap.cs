using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTrap : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            PlayerLogic playerLogic = collider.gameObject.GetComponent<PlayerLogic>();
            playerLogic.Kill();

        }
    }
}
