using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    int randomaSumar;
    int SumaPrecios;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
        CrearPrecios();
        ActivarObjetoRandom(-6.4f, 3.31f, 0);
        txt_precioASumar.text = precios[objetoRandom].ToString();
        ActivarObjetoRandom(-6.5f, -2.1f, 0);
        txt_precio1.text = precios[objetoRandom].ToString();
        ActivarObjetoRandom(-1.05f, -2.31f, 0);
        txt_precio2.text = precios[objetoRandom].ToString();
        ActivarObjetoRandom(4.41f, -2f, 0);
        txt_precio3.text = precios[objetoRandom].ToString();

        randomaSumar = Random.Range(1, 4);
        if (randomaSumar == 1)
        {
            SumaPrecios = int.Parse(txt_precioASumar.text) + int.Parse(txt_precio1.text);
        }
        else if (randomaSumar == 2)
        {
            SumaPrecios = int.Parse(txt_precioASumar.text) + int.Parse(txt_precio2.text);
        }
        else if(randomaSumar == 3)
        {
            SumaPrecios = int.Parse(txt_precioASumar.text) + int.Parse(txt_precio3.text);
        }
        txt_suma.text= SumaPrecios.ToString();
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
        objetoRandom.transform.position = new Vector3(x, y, z);
        objetoRandom.SetActive(true);
    }
}
