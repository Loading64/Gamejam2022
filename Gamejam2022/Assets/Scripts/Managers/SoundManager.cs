using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    private Vector3 cameraPosition;

    // Weapon Clips
    public AudioClip lasergunClip;
    public AudioClip lasercannonClip;
    public AudioClip chargerifleClip;
    // Utility Clips
    public AudioClip thrusterClip;
    public AudioClip shieldClip;
    public AudioClip shieldbrokenClip;
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
            case "lasergun":
                PlaySound(lasergunClip);
                break;
            case "laser cannon":
                PlaySound(lasercannonClip);
                break;
            case "chargerifle":
                PlaySound(chargerifleClip);
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
            case "thrust":
                PlaySound(thrusterClip);
                break;
            case "Shield":
                PlaySound(shieldClip);
                break;
            case "Shield Broken":
                PlaySound(shieldbrokenClip);
                break;

            default:
                Debug.Log("Utility Sound Broke");
                break;
        }
    }
}
