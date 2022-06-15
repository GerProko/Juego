using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NivelesMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void n1()
    {
        SceneManager.LoadScene("Nivel1");
    }
    public void n2()
    {
        SceneManager.LoadScene("Nivel2");
    }
    public void n3()
    {
        SceneManager.LoadScene("Nivel3");
    }
}
