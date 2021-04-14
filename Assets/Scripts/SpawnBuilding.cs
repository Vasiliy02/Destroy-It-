using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBuilding : MonoBehaviour
{
    public List<GameObject> listPrefabs = new List<GameObject>();

    private void Start()
    {
        Instantiate(listPrefabs[Random.Range(0, 3)], transform.position, Quaternion.identity);
    }

}
