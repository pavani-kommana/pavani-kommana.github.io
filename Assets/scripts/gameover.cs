using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public GameObject gameoverpanel;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length==0)
        {
          gameoverpanel.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
