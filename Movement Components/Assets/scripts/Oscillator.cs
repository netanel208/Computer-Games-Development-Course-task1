using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Unity.Mathematics;

using UnityEngine;


public class Oscillator : MonoBehaviour
{
    [SerializeField] float speed = 40;
    [Tooltip("The direction of object oscillator(the default is 'right')")][SerializeField] string direction;
    Vector3 object_position;
    float min_x_bound;
    float max_x_bound;
    bool is_right = true;

    // Start is called before the first frame update
    void Start()
    {
        object_position = transform.position;
        if(direction == "left") { is_right = false; }
        var camera_pos = GameObject.Find("Main Camera").GetComponent<Transform>().position;
        var size = GameObject.Find("Main Camera").GetComponent<Camera>().orthographicSize * Screen.width / Screen.height;
        min_x_bound = camera_pos.x - size;
        max_x_bound = camera_pos.x + size;

        Debug.Log("camera_pos = "+ camera_pos+ " min_x_bound = " + min_x_bound + " max_x_bound = " + max_x_bound);
    }

    // Update is called once per frame
    void Update()
    {
        float curr_x_pos = transform.position.x;
        float diff_from_start_pos = (float)math.abs(curr_x_pos - object_position.x);
        if(diff_from_start_pos == 0) { diff_from_start_pos = 0.00001f; }
        if (curr_x_pos >= max_x_bound)
        {
            is_right = false;
        }
        else if (curr_x_pos <= min_x_bound)
        {
            is_right = true;
        }
        if (is_right)
        {
            float standard = (1 * Time.deltaTime * speed);
            float slow = standard / (diff_from_start_pos+1f);
            transform.position += new Vector3(slow, 0, 0);
        }
        else
        {
            float standard = ((-1) * Time.deltaTime * speed);
            float slow = standard / (diff_from_start_pos +1f);
            transform.position += new Vector3(slow, 0, 0);
        }
    }

}
