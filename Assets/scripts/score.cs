using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoretext;
    private float score1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")!=null)
        {
            score1 += 1*Time.deltaTime;
            scoretext.text =((int)score1).ToString();
        }
    }
}
