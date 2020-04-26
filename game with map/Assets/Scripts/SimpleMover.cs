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
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1*Time.deltaTime*speed,0,0);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3((-1)*Time.deltaTime*speed,0,0);
        }
    }
}
