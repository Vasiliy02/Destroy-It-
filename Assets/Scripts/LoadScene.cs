using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene(0);
        FlyBullet.whatAboutBullet = 0;
    }
}
