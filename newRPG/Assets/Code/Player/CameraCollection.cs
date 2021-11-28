using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollection : MonoBehaviour
{

    public float speed;
    private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * speed;
        float mouseY = Input.GetAxis("Mouse Y") * speed;
        camera.transform.localRotation = camera.transform.localRotation * Quaternion.Euler(-mouseY, 0, 0);
        transform.localRotation = transform.localRotation * Quaternion.Euler(0, mouseX, 0);
        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");
        //transform.Translate(x, 0, z);
    }
}
