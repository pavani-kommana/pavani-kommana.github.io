using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blast : MonoBehaviour
{
    public float deactivetime =3f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Dectiveobject", deactivetime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Dectiveobject()
    {
        Destroy(this.gameObject);

    }
}

