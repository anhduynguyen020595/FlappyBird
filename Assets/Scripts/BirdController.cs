using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float flyPower = 50;
    GameObject obj;
    GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        if(gameController == null)
        {
            gameController = GameObject.FindGameObjectWithTag("GameController");               
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        EndGame();
    }

    void EndGame()
    {
        gameController.GetComponent<GameController>().EndGame();
    }
}
