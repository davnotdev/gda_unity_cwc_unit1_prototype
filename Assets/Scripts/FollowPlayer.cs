using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 camera_offset = new Vector3(0.0f, 4.83f, -5.75f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //  transform.position = player.transform.position + camera_offset;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + camera_offset;
    }
}
