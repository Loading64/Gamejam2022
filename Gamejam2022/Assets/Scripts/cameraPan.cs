using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraPan : MonoBehaviour
{
    int length = 400;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(pan());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator pan() {
        for (int i=0; i<length; i++) {
            transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, transform.position.z);
            yield return new WaitForSeconds(0.01f);
        }
        SceneManager.LoadScene("Level 1");
    }
}
