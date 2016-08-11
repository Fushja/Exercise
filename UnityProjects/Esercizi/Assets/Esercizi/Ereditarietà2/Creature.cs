
namespace Monsters
{

    using UnityEngine;
    using System.Collections;

    public abstract class Creature : MonoBehaviour
    {
        
        protected SpriteRenderer sr;
        
        protected int lifePoints;

        void Awake()
        {
            sr = GetComponent<SpriteRenderer>();
            SetupVisuals();
            SetupStats();
        }

        //protected tutte i figli e se stesso possono chiamare questo metodo (o variabili)
        protected abstract void SetupVisuals();

        protected abstract void SetupStats();

        protected abstract void Talk();

        void OnMouseUp()
        {
            Talk();
        }
    }
}
