using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loopbackground : MonoBehaviour
{
    public float bspeed;
    public Renderer brender;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        brender.material.mainTextureOffset += new Vector2(bspeed * Time.deltaTime,0f);
    }
}
