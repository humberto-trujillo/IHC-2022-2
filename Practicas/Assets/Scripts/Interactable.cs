using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool isInsideZone;
    public virtual void Interact()
    {
        Debug.Log("Ineract");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entro al area");
            isInsideZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("salio del area");
            isInsideZone = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isInsideZone)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                Interact();
            }
        }
    }
}
