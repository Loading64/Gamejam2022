using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherSlime : Slime
{
    //private List slimelist = new List();
    public bool canSpawn = true;
    public float timeBetweenSpawns;
    public GameObject motherSlime;
    public GameObject meleeSlime;
    public GameObject rangedSlime;
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnEnemies()
    {
        int EnemyType = Random.Range(0, 10);

        GameObject newEnemy;

        switch (EnemyType)
        {
            case 1:
                newEnemy = (GameObject)Instantiate(motherSlime);
                break;

            case 2:
            case 3:
                newEnemy = (GameObject)Instantiate(rangedSlime);
                break;

            default:
                newEnemy = (GameObject)Instantiate(meleeSlime);
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
    public void RemoveSlimeFromList(GameObject slime)
    {
        //slimelist.Remove(slime);
    }
    public void DestroyAllSheep()
    {
        // This method destroys all sheep at the end of the game
        //foreach (GameObject slime in slimelist)
       // {
        //    Destroy(slime);
       // }

        //slimelist.Clear();
    }
}
