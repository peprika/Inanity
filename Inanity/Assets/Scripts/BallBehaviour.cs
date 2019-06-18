using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallBehaviour : MonoBehaviour
{
    //Sprite Renderer
    private SpriteRenderer Sprite;

    public Text scoreUIText;

    //Variables
    private bool isPressed = false;
    public int score = 0;

    void Start()
    {
        //Intialisation
        Sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Pressed();

        if (transform.position.y <= -6)
        {
            Destroy(gameObject);
            score += score;
        }
    }

    void OnMouseDown()
    {
        isPressed = true;
    }
    void OnMouseUp()
    {
        isPressed = false;
    }

    void Pressed()
    {
        if (isPressed)
        {
            Vector3 MousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(MousePosition);
            transform.position = objPosition;
        }
    }
}
