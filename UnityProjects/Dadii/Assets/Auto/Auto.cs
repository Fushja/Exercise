using UnityEngine;

public class Auto
{
    // stato 
    const int nWheels = 4;
    Color color;
    string model;
    string id_telaio;

    bool IsOn = false;
    float speed = 0.0f;


    // comportamento
    public void Initialise(Color _color, string _model, string _id_telaio)
    {
        this.color = _color;
        this.model = _model;
        this.id_telaio = _id_telaio;
    }
        
         
    public void TurnOn()
    {
        IsOn = true;
    }
    public void TurnOff()
    {
        IsOn = false;
    }
    public void Accelerate()
    {
        if (IsOn == true)
        {
            speed += 1.0f;
        }
    }
    public void Brake()
    {
        if(speed > 0)
        {
            speed -= 1.0f;
        }
    }
  
    
    public string GetStatus()
    {
        string s = "Questa auto è accesa? " + IsOn + " e va a velocità " + speed;
        return s;
    }

    
}

internal class color
{
}

// estendere classe auto per far leggere colore e modello
// creare 100 auto e assegna casualmente il colore rosso, verde, blu
// controllare quante auto rosse hai creato