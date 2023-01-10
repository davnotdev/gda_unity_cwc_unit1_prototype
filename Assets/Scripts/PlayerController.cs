using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float vehicle_speed = 24.0f;
    private float vehicle_turn = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        float vertical_input = Input.GetAxis("Vertical");
        float horizontal_input = Input.GetAxis("Horizontal");

        //  Move Vehicle forward with Vertical Input 
        transform.Translate(Vector3.forward * Time.deltaTime * vehicle_speed * vertical_input);

        //  Rotate Vehicle forward with Horizontal Input 
        transform.Rotate(Vector3.up * Time.deltaTime * vehicle_turn * horizontal_input);
    }
}
