using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    public SoundManager soundManager;
    public AttackManager attackmanager;

    public string weapon;
    public string utility;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Left Click
            WeaponFire();
        }

        if (Input.GetMouseButtonDown(1))
        {
            // Right Click
            UseUtility();
        }
    }

    private void WeaponFire()
    {
        soundManager.PlayAttackSound(weapon);
        attackmanager.FireAttack(weapon);
        Debug.Log(weapon + "gameplaymanager");
    }

    private void UseUtility()
    {
        soundManager.PlayUtilitySound(utility);
    }


}
