using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            float X = Input.GetAxis("Mouse X");
            float Y = Input.GetAxis("Mouse Y");

            Vector3 vector = new Vector3(Y, 0, X);

            transform.position += vector * Time.deltaTime * speed;
        }
    }
}
