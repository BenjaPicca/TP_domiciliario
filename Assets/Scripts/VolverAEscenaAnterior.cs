using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverAEscenaAnterior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void cambiarEscena()
    {
        SceneManager.LoadScene("EscenaInicial");
    }
    public void recargarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
