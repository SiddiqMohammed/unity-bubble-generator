using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public List<GameObject> newInstance;
    public Transform spawnPoint;

    public float maxX;
    public float maxZ;

    public int x = 1;

    // Start is called before the first frame update
    void Start()
    {
        // SpawnBall();
    }

    // Update is called once per frame
    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBall();
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            DestroyBalls();
        }
    }

    public void SpawnBall()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);

        Vector3 randomSpawnPos = new Vector3(randomX, 10f, randomZ);

        newInstance[x] = Instantiate(ball, randomSpawnPos, Quaternion.identity);
        // print(newInstance);
        x++;
        // print(x);
        // Instantiate(ball, spawnPoint.position, Quaternion.identity);
    }

    public void DestroyBalls()
    {
        Destroy(newInstance[x]);
        x--;
        print(x);
    }
}
