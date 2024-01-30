using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinObserver : MonoBehaviour
{
    int numberOfFallenPins;

    // Start is called before the first frame update
    void Start()
    {
        numberOfFallenPins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToScore()
    {
        numberOfFallenPins++;
        Debug.Log($"Score: {numberOfFallenPins}");
    }
}
