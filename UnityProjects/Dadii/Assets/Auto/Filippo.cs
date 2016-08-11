using UnityEngine;

public class Filippo
{
    // stato

    int strong = 4;
    int agility = 6;
    float life = 25.0f;
    float hit = 5.0f;

    public bool IsDead()
    {
        bool risultato = false;
        if (life <= 0)
        {
            risultato = true;
            return risultato;
        }
        else
        {
            return false;
        }   
        
    } 








}

