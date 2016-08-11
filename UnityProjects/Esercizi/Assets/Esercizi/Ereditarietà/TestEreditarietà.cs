using UnityEngine;
using System.Collections;

public class TestEreditarietà : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Animal a = new Animal();
        Duck d = new Duck();

        d.SayVerso();

        Debug.Log(d.life);

        Dog dog = new Dog();
        int dogLife = dog.life;

        Animal a = new Duck();
        a.SayVerso();

        
	}	
	
}
