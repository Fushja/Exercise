namespace Monsters
{
    using UnityEngine;
    using System.Collections;
    using System;

    public class Ghost : Monster
    {

        protected override void SetupVisuals()
        {
            sr.color = new Color(0.5f,0.5f,0.5f);

        }

        protected override void SetupStats()
        {
            lifePoints = 5;

        }

        protected override void Talk()
        {
            Debug.Log("BUUUU!");
        }
    }
}
