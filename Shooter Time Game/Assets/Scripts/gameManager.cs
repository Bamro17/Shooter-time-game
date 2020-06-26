using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject nextLevel;
    public int levelCounter = 0;
    
    private void Awake()
    {
        int numInstances = FindObjectsOfType<gameManager>().Length;
        if (numInstances != 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        nextLevel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadNextLevel()
    {
        if (levelCounter == 0)
        {
            Application.LoadLevel("Cavemen");
        }
        else if (levelCounter == 1)
        {
            Application.LoadLevel("Desperado");
        }
        else if (levelCounter == 2)
        {
            Application.LoadLevel("Modern");
        }
        else if (levelCounter == 3)
        {
            Application.LoadLevel("Noir");
        }
        else if (levelCounter == 4)
        {
            Application.LoadLevel("bossRoom");
        }
        else Debug.LogError("error, restart game");
    }
    
}
