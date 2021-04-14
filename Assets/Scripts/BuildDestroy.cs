using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildDestroy : MonoBehaviour
{
    [SerializeField]
    GameObject rbBuild, standartBuild;

    private void FixedUpdate()
    {
        if(FlyBullet.whatAboutBullet == 2)
        {
            rbBuild.SetActive(true);
            standartBuild.SetActive(false);
        }
    }
}
