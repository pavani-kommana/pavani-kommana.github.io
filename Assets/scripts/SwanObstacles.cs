using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwanObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float minX, minY, maxX, maxY;
    private float spawntime;
    public float betweentime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawntime)
        {
            spawn();
            spawntime = Time.time + betweentime;
        }
    }
    void spawn()
    {
        float randomx = Random.Range(minX, maxX);
       float randomy = Random.Range(minY, maxY);
        Instantiate(obstacle,transform.position + new Vector3(randomx,randomy,0),transform.rotation);

    }
}
