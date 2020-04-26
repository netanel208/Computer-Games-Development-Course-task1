using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMover : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
    }
}
