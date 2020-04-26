using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer2 : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
    }
}
