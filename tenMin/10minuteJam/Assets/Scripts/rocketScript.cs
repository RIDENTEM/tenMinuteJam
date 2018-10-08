using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rocketScript : MonoBehaviour
{
    Rigidbody currentRigidbody;
    float rocketSpeed = 2.0f;
    GameObject playerEyes;
    [SerializeField] ParticleSystem explosion;

    void Start()
    {
        playerEyes = GameObject.FindGameObjectWithTag("MainCamera");
        currentRigidbody = GetComponent<Rigidbody>();
        transform.LookAt(playerEyes.transform.position);
    }

    private void OnDestroy()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        rocketSpawner.trueSpawner.spawnRocket();
    }

    void Update()
    {
        currentRigidbody.AddForce(transform.forward);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
