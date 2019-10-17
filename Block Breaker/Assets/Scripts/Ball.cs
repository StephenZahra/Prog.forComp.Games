using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Paddle myPaddle;

    Vector2 paddleToBallDistance;

    // Start is called before the first frame update
    void Start()
    {
        //this.transform.position gets position of ball (because we are in script attached to ball)
        paddleToBallDistance = this.transform.position - myPaddle.transform.position; //gets distance of ball and paddle
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePosition = myPaddle.transform.position;

        this.transform.position = paddlePosition + paddleToBallDistance; //sets ball to (0,2) distance from paddle
    }
}
