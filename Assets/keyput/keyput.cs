using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public static class Keyput
{
    public static float GetMovement(KeyCode code1, KeyCode code2)
    {
     
        if (Input.GetKey(code1)){
            return 1.0f;}
        else if (Input.GetKey(code2)){
            return -1.0f;}
        else{
            return 0.0f;}
        
    }
}

