using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float radius = 18.0f;
    public GameObject enemy;
    private float timeStamp;

    // Start is called before the first frame update
    void Start()
    {
        timeStamp = Time.time; //time since start of the game
        Debug.Log("EnemeySpawner.Start() at time: " + timeStamp);

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeStamp > 1.0f) //once per second
        {
            SpawnEnemy();
            timeStamp = Time.time;
        } 
    }

    private void SpawnEnemy()
    {
        float X = Random.Range(-radius, radius);
        float Y = Mathf.Sqrt((radius * radius) - (X * X));

        //Randomly flip the Y value to allow enemies to spawn below the gem
        if (Random.Range(-1, 1) < 0)
        {
            Y = -Y;
        }

        Instantiate(enemy, new Vector3(X, Y, 0), Quaternion.identity);
    }
}
