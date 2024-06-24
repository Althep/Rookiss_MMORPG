using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float moveSpeed = 20.0f;
    void Start()
    {
        
    }
    // GameObject(Player)
        //Transform
        //PlayerController
    void Update()
    {
        InputMoveKey();
    }


    void InputMoveKey()
    {

        //Local->World
        //TransformDirection

        //World->Local
        //InverseTransformDirection


        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward*Time.deltaTime*moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }
    }
}
