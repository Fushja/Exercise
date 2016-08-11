namespace Monsters
{

    using UnityEngine;
    using System.Collections;

    public class BlackDragon : Dragon
    {
        protected override void SetupVisuals()
        {
            sr.color = Color.black;

        }
        protected override void SetupStats()
        {
            lifePoints = 20;

        }

        override public void DropLoot()
        {

            base.DropLoot();
            string arma = "LO SPADONE LEGGENDARIO";
            Debug.Log(this.name + " droppa " + arma);
        }


    }
}
