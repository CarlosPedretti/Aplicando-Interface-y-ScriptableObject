using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemy : MonoBehaviour, IPresentacion
{

    [SerializeField] private ScriptableEnemy enemyData;
    [SerializeField] private string nombre;
    [SerializeField] private int vida;
    [SerializeField] private string saludo;
    

    void Start()
    {
        nombre = enemyData.Nombre;
        vida = enemyData.Vida;
        saludo = enemyData.Saludo;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Accion();
        }
    }

    public void Accion()
    {
        enemyData.PrintData();

    }
}
