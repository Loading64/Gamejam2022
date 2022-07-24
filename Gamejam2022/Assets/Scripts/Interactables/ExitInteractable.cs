using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitInteractable : InteractableObject
{
    public string Levelscene;
    public override void OnPlayerInteracted()
    {
        //base.OnPlayerInteracted();

        SceneManager.LoadScene(Levelscene);
    }
}
