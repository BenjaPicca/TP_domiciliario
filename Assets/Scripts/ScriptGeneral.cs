using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;


public class ScriptGeneral : MonoBehaviour
{
    public GameObject[] Objetos;
    Dictionary<GameObject, int> precios = new Dictionary<GameObject, int>();
    GameObject objetoRandom;
    public Text txt_precioASumar;
    public Text txt_precio1;
    public Text txt_precio2;
    public Text txt_precio3;
    public Text txt_suma;
    public Text txt_btnVolverAJugar;
    public Text txt_notificacion;
    public GameObject panelCorrectooIncorrecto;
    public GameObject panelSeleccionarAlgo;
    int randomaSumar;
    int SumaPrecios;
    int ObjetoSeleccionado;
    int precioASumar;
    int precio1;
    int precio2;
    int precio3;


    // Start is called before the first frame update
    void Start()
    {
        panelSeleccionarAlgo.SetActive(false);
        panelCorrectooIncorrecto.SetActive(false);
        //DeactivateAll();
        CrearPrecios();
        ActivarObjetoRandom(-6.4f, 3.31f, 0);
        precioASumar = precios[objetoRandom];
        txt_precioASumar.text = "$"+precioASumar.ToString();
        ActivarObjetoRandom(-6.5f, -2.1f, 0);
        precio1 = precios[objetoRandom];
        txt_precio1.text = "$" + precio1.ToString();
        ActivarObjetoRandom(-1.05f, -2.31f, 0);
        precio2 = precios[objetoRandom];
        txt_precio2.text = "$" + precio2.ToString();
        ActivarObjetoRandom(4.41f, -2f, 0);
        precio3 = precios[objetoRandom];
        txt_precio3.text = "$" + precio3.ToString();
        randomaSumar = Random.Range(1, 4);
        if (randomaSumar == 1)
        {
            SumaPrecios = precioASumar+precio1;
        }
        else if (randomaSumar == 2)
        {
            SumaPrecios = SumaPrecios = precioASumar + precio2;
        }
        else if(randomaSumar == 3)
        {
            SumaPrecios = SumaPrecios = precioASumar + precio3;
        }
        txt_suma.text= "$"+SumaPrecios.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DeactivateAll()
    {
        for (int i = 0; i < Objetos.Length; i++)
        {
            Objetos[i].SetActive(false);
        }

    }
    void CrearPrecios()
    {
        for (int i = 0; i < Objetos.Length; i++)
        {
            precios.Add(Objetos[i], Random.Range(1, 21));
        }
    }
    void ActivarObjetoRandom(float x, float y, float z)
    {
        int randomIndex = Random.Range(0, Objetos.Length);
        objetoRandom = Objetos[randomIndex];
        Vector3 posicion = new Vector3(x, y, z);
        Instantiate(objetoRandom, posicion, Quaternion.identity);
    }

    public void opcion1()
    {
        ObjetoSeleccionado = 1;
        txt_precio1.fontStyle = FontStyle.Bold;
        txt_precio2.fontStyle = FontStyle.Normal;
        txt_precio3.fontStyle = FontStyle.Normal;
    }
    public void opcion2()
    {
        ObjetoSeleccionado = 2;
        txt_precio2.fontStyle = FontStyle.Bold;
        txt_precio1.fontStyle = FontStyle.Normal;
        txt_precio3.fontStyle = FontStyle.Normal;
    }
    public void opcion3()
    {
        ObjetoSeleccionado = 3;
        txt_precio3.fontStyle = FontStyle.Bold;
        txt_precio2.fontStyle = FontStyle.Normal;
        txt_precio1.fontStyle = FontStyle.Normal;
    }
    public void respuesta()
    {
        if (ObjetoSeleccionado == 1)
        {
            if (precio1 + precioASumar == SumaPrecios)
            {
                panelCorrectooIncorrecto.SetActive(true);
                txt_notificacion.text = "Correcto";
                txt_btnVolverAJugar.text = "Reiniciar Desafío";

            }
            else
            {
                panelCorrectooIncorrecto.SetActive(true);
                txt_notificacion.text = "Incorrecto";
                txt_btnVolverAJugar.text = "Volver a intentar";
            }
        }
        else if (ObjetoSeleccionado == 2)
        {
            if (precio2 + precioASumar == SumaPrecios)
            {
                panelCorrectooIncorrecto.SetActive(true);
                txt_notificacion.text = "Correcto";
                txt_btnVolverAJugar.text = "Reiniciar Desafío";
            }
            else
            {
                panelCorrectooIncorrecto.SetActive(true);
                txt_notificacion.text = "Incorrecto";
                txt_btnVolverAJugar.text = "Volver a intentar";
            }
        }
        else if (ObjetoSeleccionado == 3)
        {
            if (precio3 + precioASumar == SumaPrecios)
            {
                panelCorrectooIncorrecto.SetActive(true);
                txt_notificacion.text = "Correcto";
                txt_btnVolverAJugar.text = "Reiniciar Desafío";
            }
            else
            {
                panelCorrectooIncorrecto.SetActive(true);
                txt_notificacion.text = "Incorrecto";
                txt_btnVolverAJugar.text = "Volver a intentar";

            }
        }
        else
        {
            activarPanelSeleccionar();
        }
    }
    async void activarPanelSeleccionar()
    {
        panelSeleccionarAlgo.SetActive(true);
        await Task.Delay(3000);
        panelSeleccionarAlgo.SetActive(false);
    }
}
