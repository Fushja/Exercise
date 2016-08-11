using UnityEngine;
using System.Collections;


namespace Tris
{// create 3x3 grid
    public class Grid : MonoBehaviour {

        public int currentPlayer = 1;
        
        int[,] grid = new int[3, 3];

        public GameObject cellPrefab;
        public Cell[] allCells;

        // Use this for initialization
        void Start()
        {
            // crea una nuova cella

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    GameObject newCell = Instantiate(cellPrefab);
                    newCell.transform.position = new Vector3(j, -i, 0);
                    newCell.name = "Cell " + i + " " + j;

                }
            }
            Destroy(cellPrefab);

		}


        // Update is called once per frame

        public void CheckWinner()

        {
            // prende tutte le celle 
            allCells = FindObjectsOfType<Cell>();
            for (int i = 0; i < allCells.Length; i++)
            {
                Debug.Log("La cella " + i + " è " + allCells[i].name);
            }

            // controlla i valori delle celle (state)
            // se trova 3 celle con state 1 (o 2) sulla stessa riga , sulla stessa colonna, o in diagonale

            int result = DidSomeoneWin(allCells[8].state, allCells[7].state, allCells[6].state);
            if (result > 0)
            {
                Debug.Log("Ha visto il giocatore " + result);
                return;
            }

            result = DidSomeoneWin(allCells[5].state, allCells[4].state, allCells[3].state);
            if (result > 0)
            {
                Debug.Log("Ha visto il giocatore " + result);
                return;
            }

            result = DidSomeoneWin(allCells[2].state, allCells[1].state, allCells[0].state);
            if (result > 0)
            {
                Debug.Log("Ha visto il giocatore " + result);
                return;
            }
            // diogonali
            result = DidSomeoneWin(allCells[8].state, allCells[4].state, allCells[0].state);
            if (result > 0)
            {
                Debug.Log("Ha visto il giocatore " + result);
                return;
            }
            result = DidSomeoneWin(allCells[6].state, allCells[4].state, allCells[2].state);
            if (result > 0)
            {
                Debug.Log("Ha visto il giocatore " + result);
                return;
            }
            // nessuno ha vito finora
            int productForDraw = 1;
            for (int i = 0; i < allCells.Length; i++)
            {
                productForDraw *= allCells[i].state;
            }
            if (productForDraw > 0)
            {
                Debug.Log(" NON HA VINTO NESSUNO! PARITA'");
            }
            // ...allora giocatore 1 (o 2) ha vinto!
        }
        private int DidSomeoneWin(int v1, int v2, int v3)
        {
            int product = v1 * v2 * v3;
            if (product == 0)
            {
                return 0;
            }
            else if (product == 1)
            {
                return 1;
            }
            else if (product == 8)
            {
                return 2;
            }
            else
            {
                return 0;
            }

        }

    }

}