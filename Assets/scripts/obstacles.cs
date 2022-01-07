using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{

    public GameObject player;
    public GameObject blast;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.transform.tag == "Player")
        {
            Destroy(player.gameObject);
        }
        else if (collision.transform.tag == "bullet")
        {
            Instantiate(blast,this.transform.position,Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}

