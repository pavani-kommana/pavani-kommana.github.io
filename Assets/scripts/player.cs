using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float movespeed;
    private Vector2 inputdirection;
    private Rigidbody2D rd;

    [SerializeField]
    private GameObject player_bullet;
    [SerializeField]
    private GameObject attact_point;

    public float attact_timer =0.35f;
    private float current_attact;
    private bool canAttact =true;
    // Start is called before the first frame update
    void Start()
    {
        current_attact = attact_timer;
        rd= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputy = Input.GetAxisRaw("Vertical");
       inputdirection = new Vector2(0,inputy). normalized ;
        Attack();
    }
    void FixedUpdate()
    {
        rd.velocity= new Vector2(0, inputdirection.y * movespeed);  
    }
    void Attack()
    {
        attact_timer+= Time.deltaTime;
        if(current_attact > attact_timer)
        {
            canAttact = true;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (canAttact)
            {
                canAttact = false;
                attact_timer=0;
                Instantiate(player_bullet, attact_point.transform.position, Quaternion.identity);
            }
        }


    }
}

