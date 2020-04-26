using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteCircular : MonoBehaviour
{
    private Vector3 position;
    [Tooltip("movement speed")][SerializeField] private float speed = 2f;
    private bool direction = true;


    // Start is called before the first frame update
      void Start()
     {
          position = transform.position;
    }

    // Update is called once per frame
    void Update()
   {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = false;
        }

        if(direction)
            speed += Time.deltaTime;
        else
            speed -= Time.deltaTime;


            float x = Mathf.Cos(speed);
            float y = Mathf.Sin(speed);
            float z = 0;
            transform.position = new Vector3(x, y, z);
        

    }

}
