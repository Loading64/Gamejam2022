using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlayer : HandInteractable
{
    public Animator[] anim; //accessing animator
    public bool isCollecting = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        InteractableObject target = other.GetComponent<InteractableObject>();
        if (target != null)
        {
            isCollecting = true;
            StartCoroutine(wait());
            target.OnPlayerInteracted();
            Debug.Log("Interacted");
            StartCoroutine(collectanimation());
           // anim[0].Play("Armature|HandSlot");
            
           // anim[1].Play("Armature|HandSlot");
        }
    }

    IEnumerator wait() {
        yield return new WaitForSeconds(3);
        isCollecting = false;
    }
    IEnumerator collectanimation()
    {
        anim[0].Play("Armature|HandSlot");
        yield return new WaitForSeconds(3);
        anim[1].Play("Armature|HandSlot");
    }

}
