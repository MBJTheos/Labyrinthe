using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using static Player;
using static Keyput;


public class P2 : MonoBehaviour
{
    private Player Player2 = new Player();

    void Start()
    {
        Player2.speed = 5f;
    }

    void Update()
    {
        Player2.moveSide  = Keyput.GetMovement(KeyCode.J, KeyCode.G);
        Player2.moveUp    = Keyput.GetMovement(KeyCode.B, KeyCode.N);
        Player2.moveFront = Keyput.GetMovement(KeyCode.Y, KeyCode.H);
        Player2.SetVector();
        Vector3 nextPosition = transform.position + Player2.moveVector * Player2.speed * Time.deltaTime;
        if (!Physics.Raycast(transform.position, Player2.moveVector, Vector3.Distance(transform.position, nextPosition)))
        {
            transform.Translate(Player2.moveVector * Player2.speed * Time.deltaTime, Space.World);
        }
    }
}
