using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class MenuPausa : MonoBehaviour
{
    public GameObject botonPausa;
    public GameObject menuPausado;
    private bool juegoPausado = false;
    public GameObject ganaste;
    private bool panelganaste = false;
    public int numeroEscena;

    public FirstPersonController fps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                Reanudar();
            }
            else
            {
                Pausa();
            }
        }
       /* if (Input.GetKeyDown(KeyCode.M))
        {
            if (panelganaste)
            {
                Siguiente();
            }
            
        }*/
    }
    public void Pausa()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausado.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        // fps.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
    }
    public void Reanudar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausado.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
       // fps.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
    }
    public void Reiniciar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       // fps.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
    }
    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
      //  fps.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
    }
    public void Siguiente()
    {
        
        ganaste.SetActive(false);
       
    }
}
