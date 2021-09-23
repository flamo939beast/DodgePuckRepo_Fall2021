 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public float xRange;
    public float yRange;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Keep player within x-range (left and right sides)
        if(transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange,transform.position.y);
        }
        float moveHorizontal = Input.GetAxis("Horizontal");
        Debug.Log(moveHorizontal);

        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        transform.Translate(movement * speed * Time.deltaTime);

       //if(Input.GetKeyDown(KeyCode.D))
       // {
       //     Debug.Log(Input.GetAxis("Horizontal"));
       //     transform.Translate(Vector2.right * speed * Time.deltaTime);
       // }
    }
}
