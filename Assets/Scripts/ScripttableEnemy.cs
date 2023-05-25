using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ScriptableEnemy", menuName = "Enemy" )]

public class ScriptableEnemy : ScriptableObject
{

    [SerializeField] private string nombre;
    [SerializeField] private int vida;
    [SerializeField] private string saludo;

    public string Nombre { get { return nombre; } }
    public int Vida { get { return vida; } }
    public string Saludo { get { return saludo; } }



    public void PrintData()
    {
        Debug.Log(nombre);
        Debug.Log(vida);
        Debug.Log(saludo);
    }

}
