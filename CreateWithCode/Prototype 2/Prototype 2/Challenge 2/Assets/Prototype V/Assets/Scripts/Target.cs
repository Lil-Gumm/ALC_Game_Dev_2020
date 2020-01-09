using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    private GameManager GameManager;
    private Rigidbody targerRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float yspawnPos = -6;
    public int pointValue;



    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        Target.Rb.AddTorque(RandomTorque(), RandomTourque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
        GameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    private void OnMouseDown()
    {
        if (GameManager.isGameActive)
        {
            Destroy(gameObject);
            Instantiate(explosionParticle, Transform.position, explosionParticle.transform.rotation);
            GameManager.UpdateScore(pointValue);

        }
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Destroy(GameObject);
        GameManager.UpdateScore(5)
        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
    }
    Vector3 RandomForce()
    {
        return Vector3.up * RandomRange(minSpeed, maxSpeed);
    }
    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }
    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), yspawnPos)
    }
    void Update()
    {
        
    }
}
