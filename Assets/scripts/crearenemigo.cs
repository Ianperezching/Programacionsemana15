using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearenemigo : MonoBehaviour
{
    public GameObject enemigo;
    private Transform transformxd;
    public GameManagercontrol GameManager;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CrearEnemigo", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CrearEnemigo()
    {
        float rnd = Random.Range(-8.00f, 8.90f);
        GameObject enemy = Instantiate(enemigo, new Vector2(rnd, 3.4f), transform.rotation);
        enemy.GetComponent<enemigos>().setgameManager(GameManager);
        Invoke("CrearEnemigo", 3);
        
    }
}
