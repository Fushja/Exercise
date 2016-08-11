namespace Monsters
{

    using UnityEngine;
    using System.Collections;
    using System;

    public class Dog : Animal
    {

        protected override void SetupVisuals()
        {
            sr.color = new Color(0.8f, 0.4f, 0.1f);

        }
        protected override void SetupStats()
        {
            lifePoints = 20;

        }

        protected override void Touched()
        {
            Debug.Log("The dog begins to wag its tail");
        }

        protected override void Talk()
        {
            Debug.Log("Bau!");
        }
    }
}
