namespace Monsters
{
    using UnityEngine;
    using System.Collections;

    public abstract class Animal : Creature
    {

        protected abstract void Touched();

        

        void OnMouseUp()
        {
            Touched();
            Talk();

        }
    }
}
