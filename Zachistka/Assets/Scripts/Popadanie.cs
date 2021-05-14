using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popadanie : MonoBehaviour
{
    string nameTag;
    
    // Start is called before the first frame update
    void Start()
    {
        Collider coll = GetComponent<Collider>();
        nameTag = coll.tag;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pulya")
        {
            
            //DestroyScript.DestroyMe();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
