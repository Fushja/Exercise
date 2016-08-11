namespace Monsters
{

    using UnityEngine;
    using System.Collections;

    public class Dragon : Monster
    {
        protected override void SetupVisuals()
        {
            sr.color = new Color(1, 0.0f, 0,58f);

        }
        protected override void SetupStats()
        {
            lifePoints = 20;

        }

        override public void DropLoot()
        {
            base.DropLoot();

            string arma = "uno spadone a due mani";
            Debug.Log(this.name + " droppa " + arma);
        }

        protected override void Talk()
        {
            Debug.Log("Blargh!");
        }


    }
}
