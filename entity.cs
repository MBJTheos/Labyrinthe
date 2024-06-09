using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class EntityGD
{
    public float   speed;               // speed
    public float   moveSide;            // lateral movement
    public float   moveUp;              // vertical movement
    public float   moveFront;           // frontal movement
    public Vector3 moveVector;          // movement Vector


    public EntityGD()
    {
        this.speed          = 0.0f;                     // speed
        this.moveSide       = 0.0f;                     // lateral movement
        this.moveUp         = 0.0f;                     // vertical movement
        this.moveFront      = 0.0f;                     // frontal movement
        this.moveVector     = new Vector3(0, 0, 0);     // movement Vector
    }

    public void SetVector()
    {
        this.moveVector.Set(this.moveSide, this.moveUp, this.moveFront);
    }
}


public class Player : EntityGD
{
    public byte[] inventory;
    public int life;


    public Player()
    {
        //this.inventory[] = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        this.life = 100;
    }
}