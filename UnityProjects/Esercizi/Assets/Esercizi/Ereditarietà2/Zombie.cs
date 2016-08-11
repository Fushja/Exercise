
namespace Monsters
{
    using UnityEngine;
    using System.Collections;

    public class Zombie : Monster
    {

        protected override void SetupVisuals()
        {
            sr.color = new Color(0, 0.3f, 0, 8f);

        }
        

        protected override void SetupStats()
        {
            lifePoints = 5;

        }

        protected override void Talk()
        {
            Debug.Log("HOUUUUW!");
        }
    }
}