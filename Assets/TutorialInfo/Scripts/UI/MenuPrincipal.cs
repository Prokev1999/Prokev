using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class MenuPrincipal : MonoBehaviour
{
    public GameObject menuOpciones;
    bool showOptions = false;
    public void Start()
    {
        menuOpciones.SetActive(showOptions);
    }
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }
    public void Opciones()
    {
        showOptions = !showOptions;
        menuOpciones.SetActive(showOptions);
    }
    public void Salir()
    {
        Application.Quit();
    }
}

