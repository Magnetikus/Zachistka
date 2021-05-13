using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulya : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag != "Terrain" && col.gameObject.tag != "Gamer")
        {
            Destroy(col.gameObject, 1f); //удаляем врага с !КОТОРЫМ! столкнулись.
        }
        Destroy(gameObject, 1f); //удаляем нашу пулю если она в что либо врезалась.
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 10f); //удаляем нашу пулю если она никуда не врезалась и улетела в далёкие края.
    }
}
