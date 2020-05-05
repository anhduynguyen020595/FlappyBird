using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGreenMove : MonoBehaviour
{
    public float moveSpeed;
    public float minY;
    public float maxY;
    public float oldPosition;

    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        moveSpeed = 3;
        oldPosition = 20;
        minY = -1;
        maxY = 2;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("ResetPipeGreen"))
        {
            float random = Random.Range(minY, maxY);
            obj.transform.position = new Vector3(oldPosition, random, 0);
        }
    }
}
