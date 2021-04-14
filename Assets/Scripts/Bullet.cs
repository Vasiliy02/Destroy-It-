using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static bool plusBullet;

    public static int amountAmmo;

    private void Start()
    {
        plusBullet = false;
        amountAmmo = 3;
    }

    private void FixedUpdate()
    {
        if(FlyBullet.whatAboutBullet == 1)
        {
            GetComponentInParent<MoveAmmo>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Cannon")
        {
            plusBullet = true;
            Destroy(gameObject);
            GetComponentInParent<MoveAmmo>().enabled = false;
            FlyBullet.whatAboutBullet = 0;
            amountAmmo -= 1; 
        }
    }
}
