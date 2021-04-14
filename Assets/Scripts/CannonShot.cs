using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonShot : MonoBehaviour
{
    [SerializeField]
    GameObject camAngle1, camAngle2;

    [SerializeField]
    GameObject bulletPrefab;
    GameObject bullet;

    [SerializeField]
    ParticleSystem effect;

    [SerializeField]
    GameObject bar;

    [SerializeField]
    Image forceBar;

    Animator animCannon;

    public float forceShot = 50f;

    private float moveBar = 0.01f;
    private int ammountBullet = 4;

    Rigidbody rb;

    private void Start()
    {
        forceBar.fillAmount = 0;
        animCannon = GetComponent<Animator>();
        bar.SetActive(false);
    }

    private void FixedUpdate()
    {
        Bar();
    }

    private void Update()
    {
        SpawnBullet();
        Shoot();
    }

    private void SpawnBullet()
    {
        if (Bullet.plusBullet == true)
        {
            if (gameObject.transform.childCount < ammountBullet)
            {
                bullet = (GameObject)Instantiate(bulletPrefab, transform);

                bar.SetActive(true);

                camAngle1.SetActive(false);
                camAngle2.SetActive(true);
            }
        }
    }

    private void Bar()
    {
        if (Bullet.plusBullet == true)
        {
            if (forceBar.fillAmount < 1)
            {
                forceBar.fillAmount += moveBar;
            }

            else if (forceBar.fillAmount == 1)
            {
                forceBar.fillAmount = 0;
            }
        }
        else
        {
            forceBar.fillAmount = forceBar.fillAmount;
        }
        if(FlyBullet.whatAboutBullet == 1)
        {
            forceBar.fillAmount = 0;
        }
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Bullet.plusBullet == true)
            {
                rb = bullet.GetComponent<Rigidbody>();
                rb.useGravity = true;
                rb.isKinematic = false;
                rb.AddForce(new Vector3(forceShot * forceBar.fillAmount, 0f, 0f), ForceMode.Impulse);

                effect.Play();

                animCannon.SetTrigger("Shooting");

                Bullet.plusBullet = false;
            }
        }
    }
}
