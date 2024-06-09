using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using static Player;
using static Keyput;


public class P1 : MonoBehaviour
{
    private Player Player1 = new Player();

    void Start()
    {
        Player1.speed = 5f;
    }

    void Update()
    {
        Player1.moveSide  = Keyput.GetMovement(KeyCode.D, KeyCode.A);
        Player1.moveUp    = Keyput.GetMovement(KeyCode.Space, KeyCode.C);
        Player1.moveFront = Keyput.GetMovement(KeyCode.W, KeyCode.S);
        Player1.SetVector();        
        Vector3 nextPosition = transform.position + Player1.moveVector * Player1.speed * Time.deltaTime;
        if (!Physics.Raycast(transform.position, Player1.moveVector, Vector3.Distance(transform.position, nextPosition)))
        {
            transform.Translate(Player1.moveVector * Player1.speed * Time.deltaTime, Space.World);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.Debug.Log("Hitbox touchée! : ", other);
    }
}
