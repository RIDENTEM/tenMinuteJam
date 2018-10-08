using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketSpawner : MonoBehaviour
{

    [SerializeField] GameObject rocket;

    static public rocketSpawner trueSpawner;

    private void Start()
    {
        if (this != null)
            trueSpawner = this;
        spawnRocket();
    }

    public void spawnRocket()
    {
        if (rocket != null)
            Instantiate(rocket, transform.position, Quaternion.identity);

    }

}
