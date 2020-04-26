using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteCircular : MonoBehaviour
{
    private Vector3 position;
    [Tooltip("movement speed")][SerializeField] private float speed = 1f;
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

    }

}
