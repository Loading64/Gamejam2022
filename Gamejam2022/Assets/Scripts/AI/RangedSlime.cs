using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class RangedSlime : Slime
{
    // This Script Handle's The Tower's Targeting

    //public GameObject PlayerInRange;
    //public GameObject SlimeBall;
    //private float lastShotTime;
    //public float fireRate;
    //void Start()
    //{
    //    PlayerInRange = null;
    //    lastShotTime = Time.time;
    //    // Cache agent component and destination
    //    agent = GetComponent<NavMeshAgent>();
    //    destination = agent.destination;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (PlayerInRange != null)
    //    {
    //        // Found Target So Fire
    //        if (Time.time - lastShotTime > fireRate)
    //        {
    //            Shoot(PlayerInRange.GetComponent<CapsuleCollider>());
    //            lastShotTime = Time.time;
    //        }
    //        Vector3 direction = gameObject.transform.position - PlayerInRange.transform.position;
    //        gameObject.transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(direction.y, direction.x) * 180 / Mathf.PI, new Vector3(0, 0, 1));
    //    }
    //}
    //void OnTriggerEnter2D(CapsuleCollider other)
    //{
    //    // Target In Range
    //    if(other.gameObject.tag.Equals("Player"))
    //    {
    //        PlayerInRange = other.gameObject;
    //    }
    //}
    //void OnTriggerExit2D(CapsuleCollider other)
    //{
    //    // Target Left Range
    //    if (other.gameObject.tag.Equals("Player"))
    //    {
    //        PlayerInRange = null;
    //    }
    //}
    //void Shoot(CapsuleCollider PlayerTarget)
    //{
    //    Vector3 startPosition = gameObject.transform.position;
    //    Vector3 targetPosition = PlayerTarget.transform.position;
    //    startPosition.z = SlimeBall.transform.position.z;
    //    targetPosition.z = SlimeBall.transform.position.z;

    //    GameObject NewSlimeBall = (GameObject)Instantiate(SlimeBall);
    //    NewSlimeBall.transform.position = startPosition;
    //    BulletBehaviour bulletComp = NewSlimeBall.GetComponent<BulletBehaviour>();
    //    bulletComp.target = PlayerTarget.gameObject;
    //    bulletComp.startPosition = startPosition;
    //    bulletComp.targetPosition = targetPosition;

    //    Animator animator = monsterData.CurrentLevel.visualization.GetComponent<Animator>();
    //    animator.SetTrigger("fireShot");
    //    AudioSource audioSource = gameObject.GetComponent<AudioSource>();
    //    audioSource.PlayOneShot(audioSource.clip);
    //}
}
