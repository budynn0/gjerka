using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    void Start()
    {
        PrintInstructions();
    }
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game.");
        Debug.Log("Move your player with WSAD.");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(x,0,z);
    }
}
