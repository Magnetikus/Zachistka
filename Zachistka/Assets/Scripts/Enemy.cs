using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 posCell;
    public Vector3 posThis;
    public float speed = 3f;
    //public bool start = true;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody>().useGravity = true;
    }

    
    // Update is called once per frame
    void Update()
    {
        //if (start == true)
        //{
            
            posThis = transform.position;
            posCell = Cell.pos;
            posCell.y -= 1f;
            transform.LookAt(posCell);
            //transform.Translate(0, 0, speed * Time.deltaTime);
        //}
    }
/*
    void GravityOn ()
    {
        start = true; 
    }*/
}
