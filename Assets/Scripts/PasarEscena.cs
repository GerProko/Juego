using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;


public class PasarEscena : MonoBehaviour
{
    public int numeroEscena;
    public GameObject jugador;
    public FirstPersonController fps;
    // public GameObject botonPausa;
    //  public GameObject ganaste;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
          /*  botonPausa.SetActive(false);
            ganaste.SetActive(true);
            Time.timeScale = 0f;*/
            SceneManager.LoadScene(numeroEscena);
            fps.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        }
    }

}
