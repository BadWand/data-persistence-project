using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    public static string playerName;
    public Text nameText;

    
    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(this.gameObject);    
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void StartGame()
    {
        playerName = nameText.text;
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
