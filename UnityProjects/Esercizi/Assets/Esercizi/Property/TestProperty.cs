using UnityEngine;
using System.Collections;

public class TestProperty : MonoBehaviour {

    public class PropertyPlayer
    {
        private int health;
        private GameObject testGo;


        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public GameObject TestGameObject
        {
            get
            {
                if (testGo == null)
                {
                    testGo = new GameObject("Testing");
                    testGo.AddComponent<TestProperty>();
                }

                return testGo;
            }
        }

        
    }

	// Use this for initialization
	void Start () {
        PropertyPlayer pp = new PropertyPlayer();
        pp.Health = 10;

        Debug.Log(pp.Health);

        GameObject ciao = pp.TestGameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
