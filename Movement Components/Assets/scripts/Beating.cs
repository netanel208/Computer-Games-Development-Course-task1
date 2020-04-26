using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beating : MonoBehaviour
{
    [SerializeField] float max_size = 1f;
    [SerializeField] float speed_beating = 1f;
    float min_size;
    bool is_scale_down = false;
    // Start is called before the first frame update
    void Start()
    {
        min_size = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x >= max_size)
            is_scale_down = true;
        if (transform.localScale.x <= min_size)
            is_scale_down = false;
        if(!is_scale_down)
            transform.localScale += new Vector3(speed_beating * Time.deltaTime, speed_beating * Time.deltaTime, speed_beating * Time.deltaTime);
        else
            transform.localScale -= new Vector3(speed_beating * Time.deltaTime, speed_beating * Time.deltaTime, speed_beating * Time.deltaTime);
    }
}
