using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    bool hasFallen;
    bool hasNotifiedController;
    PinObserver pinObserver;
    //[SerializeField]
    //Vector3 rot = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        hasFallen = false;
        hasNotifiedController = false;
        pinObserver = FindAnyObjectByType<PinObserver>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localEulerAngles.z > Mathf.Abs(5) && hasFallen == false) 
        {
            hasFallen = true;
        }

        if (hasFallen && hasNotifiedController == false)
        {
            pinObserver.AddToScore();
            hasNotifiedController = true;
        }
    }
}
