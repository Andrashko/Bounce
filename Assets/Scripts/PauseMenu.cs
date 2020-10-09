using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu; 
    private bool isActive = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            isActive = !isActive;
            menu.SetActive (isActive);
            if (isActive) 
                Time.timeScale = 0f;
            else 
                Time.timeScale = 1f;
        }
    }

    public void Restart(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }
}
