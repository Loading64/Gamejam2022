using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands : MonoBehaviour
{
    public Transform[] hands;
    private Transform[] child = new Transform[2];
    public TriggerPlayer triggerPlayer;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(hands[0]);
        Debug.Log(hands[1]);
        child[0] = hands[0].Find("Bone").transform.Find("Bone.009");
        child[1] = hands[1].Find("Bone").transform.Find("Bone.009");
        child[0].gameObject.SetActive(false);
        child[1].gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(triggerPlayer.isCollecting) {
            child[0].gameObject.SetActive(true);
            child[1].gameObject.SetActive(true);
        }
    }
}
