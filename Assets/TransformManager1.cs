using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformManager1 : MonoBehaviour
{
    public GameObject myCube;
    public GameObject rotado;
    public GameObject escalado;
    public GameObject rotadoYEscalado;

    public Vector3 originalRotation;
    public Vector3 originalScale;

    public bool isRotated;
    public bool isScaled;
    public bool isScaledAndRotated;

    // Start is called before the first frame update
    void Start()
    {
        isRotated = false;
        isScaled = false;
        isScaledAndRotated = false;
        originalRotation = myCube.transform.eulerAngles;
        originalScale = myCube.transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isRotated)
            {
                myCube.transform.eulerAngles = originalRotation;
                isRotated = false;
            }

            else
            {
                myCube.transform.eulerAngles = rotado.transform.eulerAngles;
                isRotated = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (isScaled)
            {
                myCube.transform.localScale = originalScale;
                isScaled = false;
            }

            else
            {
                myCube.transform.localScale = escalado.transform.localScale;
                isScaled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isScaledAndRotated)
            {
                myCube.transform.localScale = originalScale;
                myCube.transform.eulerAngles = originalRotation;
                isScaledAndRotated = false;
            }

            else
            {
                myCube.transform.localScale = rotadoYEscalado.transform.localScale;
                myCube.transform.eulerAngles = rotadoYEscalado.transform.eulerAngles;
                isScaledAndRotated = true;
            }
        }
    }
}
