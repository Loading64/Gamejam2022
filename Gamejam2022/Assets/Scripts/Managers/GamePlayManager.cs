using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    private string weapon;
    private string utility;
    public SoundManager soundManager;

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
    }

    private void UseUtility()
    {
        soundManager.PlayUtilitySound(utility);
    }


}
