namespace Monsters
{

    using UnityEngine;
    using System.Collections;

    public class Duck : Animal
    {

        protected override void SetupVisuals()
        {
            sr.color = new Color(1f, 1f, 1f);

        }
        protected override void SetupStats()
        {
            lifePoints = 20;

        }

        protected override void Touched()
        {
            Debug.Log("The duck flee away!");
        }

        protected override void Talk()
        {
            Debug.Log("Quack!");
        }
    }
}
