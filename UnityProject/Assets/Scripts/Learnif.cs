using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learnif : MonoBehaviour
{
    public bool open;
    public int combo;
    private void Start()
    {
        if (open)
        {
            print("嗨");

        }
        else
        {
            print("關門");
        }


        if (combo>=50&&combo< 100)
        {
            print("攻擊x2");
        }
        else if (combo >= 100 && combo < 150)
        {
            print("攻擊x5");
        }
        else if (combo >= 150 && combo < 200)
        {
            print("攻擊x10");
        }
    }

}
