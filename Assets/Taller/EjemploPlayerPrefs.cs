using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploPlayerPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("Ejemplo entrada", 10);

        float ejemplo = PlayerPrefs.GetFloat("Ejemplo entrada");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
