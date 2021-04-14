using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBullet : MonoBehaviour
{
    public static int whatAboutBullet;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            whatAboutBullet = 1;
            Destroy(gameObject, 1f);
        }

        else if(collision.gameObject.tag == "Build")
        {
            whatAboutBullet = 2;
        }
    }
}
