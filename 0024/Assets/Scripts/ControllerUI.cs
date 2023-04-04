using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerUI : MonoBehaviour
{
    public void ControleCena(string CenaNova) 
    { 
        SceneManager.LoadScene(CenaNova);
    }

    public void SairJogo() 
    { 
        Application.Quit();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
