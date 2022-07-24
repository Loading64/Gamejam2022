using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MotherSlime : Slime
{
    //private List<GameObject> slimelist = new List<GameObject>();
    public bool canSpawn = true;
    public float timeBetweenSpawns;
    public GameObject motherSlime;
    public GameObject meleeSlime;
    public GameObject rangedSlime;
    void Start()
    {
        damage = 5;
        StartCoroutine(SpawnRoutine());
        // Cache agent component and destination
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
    }
    public void SpawnEnemies()
    {
        int EnemyType = Random.Range(0, 10);

        GameObject newEnemy;
        Vector3 spawnPoint = gameObject.transform.position;
        Quaternion spawnRoation = gameObject.transform.rotation;
        switch (EnemyType)
        {
            case 1:
                newEnemy = (GameObject)Instantiate(motherSlime, spawnPoint, spawnRoation);
                newEnemy.GetComponent<MotherSlime>().target = target;
                break;

            case 2:
            case 3:
            case 4:
                newEnemy = (GameObject)Instantiate(rangedSlime, spawnPoint, spawnRoation);
                newEnemy.GetComponent<RangedSlime>().target = target;
                break;

            default:
                newEnemy = (GameObject)Instantiate(meleeSlime, spawnPoint, spawnRoation);
                newEnemy.GetComponent<MeleeSlime>().target = target;
                break;
        }
        //slimelist.Add(newEnemy);
    }
    private IEnumerator SpawnRoutine()
    {
        while (canSpawn)
        {
            SpawnEnemies();
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }
    //public void RemoveSlimeFromList(GameObject slime)
    //{
    //    slimelist.Remove(slime);
    //}
    //public void DestroyAllSlime()
    //{
    //    //This method destroys all slimes at the end of the game
    //    foreach (GameObject slime in slimelist)
    //   {
    //       Destroy(slime);
    //   }

    //   slimelist.Clear();
    //}
}
