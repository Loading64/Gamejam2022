using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlayer : MonoBehaviour
{
    public Animator[] anim; //accessing animator
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        InteractableObject target = other.GetComponent<InteractableObject>();
        if (target != null)
        {
            target.OnPlayerInteracted();
            Debug.Log("Interacted");
            anim[0].Play("Armature|HandSlot");
            anim[1].Play("Armature|HandSlot");
        }
    }
}
