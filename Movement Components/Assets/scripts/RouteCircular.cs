using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteCircular : MonoBehaviour
{
    private Vector3 position;
    [Tooltip("movement speed")][SerializeField] private float speed = 2f;
    private bool direction = true;
    [Tooltip("radius")] [SerializeField] private float radius = 5f;
    private float dirObje;

    // Start is called before the first frame update
    void Start()
     {
          position = transform.position;
        dirObje = speed;
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

        if(!direction)
            dirObje += Time.deltaTime;
        else
            dirObje -= Time.deltaTime;


            float x = Mathf.Cos(dirObje) * radius;
            float y = Mathf.Sin(dirObje) * radius;
            float z = 0;
            transform.position = position+new Vector3(x, y, z);
        

    }

}
