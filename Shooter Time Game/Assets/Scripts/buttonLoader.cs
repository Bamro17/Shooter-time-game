using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonLoader : MonoBehaviour
{
    public GameObject sceneManager;
    Button thisButton;
    // Start is called before the first frame update
    void Start()
    {
        sceneManager = GameObject.Find("gameManager");
        thisButton = GetComponent<Button>();
        thisButton.onClick.AddListener(sceneManager.GetComponent<gameManager>().loadNextLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
