using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOut : MonoBehaviour
{
    public GameObject[] enemyOutArr;
    public GameObject enemy;
    public float secondEnemy = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("EnemyDroop", 2f);
    }

    void EnemyDroop ()
    {
        enemy = Instantiate<GameObject>(enemy);
        enemy.transform.position = transform.position;
        Invoke("EnemyDroop", secondEnemy);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
