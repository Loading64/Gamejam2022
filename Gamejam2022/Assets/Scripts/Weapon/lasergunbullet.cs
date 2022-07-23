using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lasergunbullet : MonoBehaviour
{
    public class Bullet : MonoBehaviour
    {
        public float speed = 1000;

        private void Update()
        {
            // might have to tweak the direction e.g. Vector3.forward according to your needs
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }

}
