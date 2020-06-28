using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBackground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Camera.main.transform.position.x + 23f, transform.position.y, 40f);
    }
}
