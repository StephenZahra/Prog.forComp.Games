using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float screenWidthInUnits = 16f; //serialize field makes the variable editable in unity (note that if you set a different variable ovverides C# variable)
    Vector2 paddlePosition;
    Vector2 ballPosition;
    Vector2 paddleToBallDistance;

    // Start is called before the first frame update
    void Start()
    {
         paddlePosition = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        float mousePos = Input.mousePosition.x / Screen.width * screenWidthInUnits;

        //limits mouse position to (1, 15) in scene so paddle doesn't exit scene
        float limitMousePos = Mathf.Clamp(mousePos, 1f, 15f);

        paddlePosition.x = mousePos; //moves paddle with current mouse position

        paddlePosition.x = limitMousePos;
        this.transform.position = paddlePosition;
    }
}
