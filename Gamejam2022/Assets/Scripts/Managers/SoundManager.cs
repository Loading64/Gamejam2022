using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager Instance;
    private Vector3 cameraPosition;
    void Awake()
    {
        Instance = this;
        cameraPosition = Camera.main.transform.position;
    }

    private void PlaySound(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, cameraPosition);
    }

    public void PlayAttackSound(string weapon)
    {
        switch(weapon)
        {
            case "laser gun":
                break;
            case "laser cannon":
                break;

            default:
                Debug.Log("Attack Sound Broke");
                break;
        }
    }

    public void PlayUtilitySound(string item)
    {
        switch(item)
        {
            case "Thruster":
                break;
            case "Shield":
                break;
            case "Shield Broken":
                break;

            default:
                Debug.Log("Utility Sound Broke");
                break;
        }
    }
}
