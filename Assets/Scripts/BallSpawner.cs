using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    GameObject ball;
    
    // Start is called before the first frame update
    void Start()
    {
        ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(ball.transform.position.y >)
    }
}
