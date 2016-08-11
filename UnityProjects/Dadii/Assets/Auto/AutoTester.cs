using UnityEngine;
using System.Collections;

public class AutoTester : MonoBehaviour
{


    void Start()
    {
        // creiamo 3 macchine (gialla, rossa, blu) e la portiamo a  10 m/s

        Auto a;
        Auto b;
        Auto c;
        // auto a
        a = new Auto();
        a.Initialise(Color.yellow, "Panda", "0001");
        a.TurnOn();
        for (int i = 0; i < 10; i++)
        {
            a.Accelerate();
        }
        Debug.Log(a.GetStatus());

        // auto b
        b = new Auto();
        b.Initialise(Color.red, "Spider", "0002");
        b.TurnOn();
        for (int i = 0; i < 10; i++)
        {
            b.Accelerate();
        }
        Debug.Log(b.GetStatus());

        // auto c
        c = new Auto();
        c.Initialise(Color.blue, "Delta", "0003");
        c.TurnOn();
        for (int i = 0; i < 10; i++)
        {
            c.Accelerate();
        }
        for (int i = 0; i < 10; i++)
        {
            c.Brake();
        }
        Debug.Log(c.GetStatus());



    }
}
