using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // [Tooltip("first position")] [SerializeField] Vector3 firstPosition;
    Vector3 firstPosition;
    

    // Start is called before the first frame update

    void Start()
    {
        firstPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        GameObject camera2 = GameObject.Find("Main Camera");
        var camera2_bounds = camera2.GetComponent<Camera>().pixelRect;
        //var h = Camera.main.orthographicSize;
        //var w = h * Screen.width / Screen.height;
        //var h = Screen.height;
        //var w = Screen.width;
        transform.position = new Vector3(transform.position.x+w, transform.position.y, transform.position.z);
        Debug.Log("h = "+h+" w = "+w);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
