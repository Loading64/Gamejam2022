using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public HandInteractable interactable;
    public virtual void OnPlayerInteracted()
    {
        Debug.Log("Ouch");
        GetComponent<HandInteractable>().OnPlayerInteracted1();
        //test
    }
}
