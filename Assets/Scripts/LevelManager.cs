 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    GameObject camAngle1, camAngle2;

    [SerializeField]
    GameObject bar,loseTable, winTable;

    private void Start()
    {
        loseTable.SetActive(false);
        winTable.SetActive(false);
    }

    private void FixedUpdate()
    {
        if(FlyBullet.whatAboutBullet == 1)
        {
            bar.SetActive(false);
            camAngle1.SetActive(true);
            camAngle2.SetActive(false);

            if(Bullet.amountAmmo == 0)
            {
                loseTable.SetActive(true);
            }
        }
        else if(FlyBullet.whatAboutBullet == 2)
        {
            winTable.SetActive(true);
        }
    }
}
