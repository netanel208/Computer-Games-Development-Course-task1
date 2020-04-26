using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Tooltip("speed of rotation")][SerializeField] float speed = 50f;
    [Tooltip("Direction of rotation(the default is'right')")] [SerializeField] string direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(direction == "left")
            transform.Rotate(-Vector3.back * speed * Time.deltaTime);
        else
            transform.Rotate(Vector3.back * speed * Time.deltaTime);
    }
}
