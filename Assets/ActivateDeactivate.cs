using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivate : MonoBehaviour
{
    public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {
        myObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //if (myObject.activeInHierarchy)
            //{
            //    myObject.SetActive(false);
            //}

            //else
            //{
            //   myObject.SetActive(true);
            //}

            myObject.SetActive(!myObject.activeInHierarchy);         
        }
    }
}
