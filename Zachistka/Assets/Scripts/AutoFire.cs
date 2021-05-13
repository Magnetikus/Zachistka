using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoFire : MonoBehaviour
{
    public static bool autoFire = false;
    public Button buttonAutoFire;
    public Button buttonFire;


    // Start is called before the first frame update
    void Start()
    {
        buttonFire.enabled = true;
    }

    public void ButtonAutoFireDown()
    {
        if (autoFire == false)
        {
            autoFire = true;
            buttonAutoFire.GetComponent<Image>().color = Color.red;
            buttonFire.enabled = false;
            buttonFire.GetComponent<Image>().color = Color.gray;
        }
        else
        {
            autoFire = false;
            buttonAutoFire.GetComponent<Image>().color = Color.white;
            buttonFire.enabled = true;
            buttonFire.GetComponent<Image>().color = Color.white;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
