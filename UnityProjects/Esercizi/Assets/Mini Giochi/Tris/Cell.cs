using UnityEngine;
using System.Collections;

namespace Tris
{

    public class Cell : MonoBehaviour
    {
       public int state = 0;
	
	void OnMouseUp()
        {
            Debug.Log("Hai premuto " + gameObject.name);


            if(state == 0)

            {
                Grid pippoGrid = FindObjectOfType<Grid>();
                if (pippoGrid.currentPlayer == 1)
                {
                    SpriteRenderer sr = GetComponent<SpriteRenderer>();
                    sr.color = Color.red;
                    state = 1;
                    pippoGrid.currentPlayer = 2;
                }
               else
                {
                    SpriteRenderer sr = GetComponent<SpriteRenderer>();
                    sr.color = Color.green;
                    state = 2;
                    pippoGrid.currentPlayer = 1;
                }
                pippoGrid.CheckWinner();
            }

           
	    }
    }
}