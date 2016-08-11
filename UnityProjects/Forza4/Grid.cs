using UnityEngine;
using System.Collections;

namespace Forza4
{

    public class Grid : MonoBehaviour
    {
        public int currentPlayer = 1;

        public int n_rows = 6;
        public int n_cols = 7;

        public int offset_x = -4;
        public int offset_y = 3;

        public GameObject cellprefabToSpawn;    // Cella di 'base' da copiare e incollare
        public GameObject columnPrefabToSpawn;  // Colonna di 'base' da copiare e incollare

        private GameObject[] columnGos;

        private Cell[,] cellGrid;

        void Start()
        {
            // Crea le colonne
            columnGos = new GameObject[n_cols];
            for (int i = 0; i < n_cols; i++)
            {
                GameObject newColumnGo = Instantiate(columnPrefabToSpawn);
                newColumnGo.transform.position = new Vector3(i + offset_x, 0, 0);
                newColumnGo.name = "Column " + i;
                columnGos[i] = newColumnGo;

                // Dico alla colonna che ha N celle
                Column col = newColumnGo.GetComponent<Column>();
                col.SetCellNumber(n_rows);
            }
            Destroy(columnPrefabToSpawn);


            // Crea 6x7 celle
            cellGrid = new Cell[n_rows, n_cols];
            for (int i = 0; i < n_rows; i++)
            {
                for (int j = 0; j < n_cols; j++)
                {
                    // Crea una cella e posizionala (e dagli un nome)
                    GameObject newCellGo;
                    newCellGo = Instantiate(cellprefabToSpawn);
                    newCellGo.transform.position = new Vector3(j + offset_x, i + offset_y, 0);
                    newCellGo.name = "Cell " + i + " " + j;

                    // Metto la cella creata nella colonna corrispondente
                    GameObject columnGo = columnGos[j];
                    Column column = columnGo.GetComponent<Column>();
                    Cell[] cells = column.cells;
                    Cell cellToPlace = newCellGo.GetComponent<Cell>();
                    cells[i] = cellToPlace;

                    cellGrid[i, j] = cellToPlace;
                }
            }
            Destroy(cellprefabToSpawn);
        }

        public void CheckWinner(Cell newCell)
        {
            // Cerchiamo la newCell nella nostra griglia
            int new_i = 0, new_j = 0;
            bool found_new_cell = false;
            for (int i = 0; i < n_rows; i++)
            {
                for (int j = 0; j < n_cols; j++)
                {
                    if (cellGrid[i, j] == newCell)
                    {
                        new_i = i;
                        new_j = j;
                        found_new_cell = true;
                        break;
                    }
                }

                if (found_new_cell)
                    break;
            }

            // definisco 4 direzioni
            Vector2[] direction = new Vector2[4];
            direction[0] = new Vector2(-1, -1);
            direction[1] = new Vector2(0, -1);
            direction[2] = new Vector2(1, -1);
            direction[3] = new Vector2(1, 0);

            foreach (Vector2 dir in direction)

            {
                int nUguali = 1;
                while (CheckCell(new_i, new_j, dir, player)
                {
                    nUguali++;
                }
                while (cellGrid[new_i + (int)dir.x, new_j + (int)dir.y].state == player)
                {
                    nUguali++;
                }


            }



            // prendiamo il giocatore di quella cella
            int player = newCell.state;
            /*
            for (int di = -1; di <= +1; di++)
            {
                for (int dj = -1; dj <= +1; dj++)
                {
                    // Skippo la 0,0
                    if (di == 0 && dj == 0)
                        continue;

                    int step_number = 0;

                    // Ricostruisco l'indice da controllare
                    int check_i = new_i + di;
                    int check_j = new_j + dj;

                    // E' uguale: allora continuo
                    while (cellGrid[check_i, check_j].state == player)
                    {
                        step_number++;

                        check_i += di;
                        check_j += dj;

                        if (step_number == 2)
                        {
                            // HO VINTO!!!
                        }
                    }

                }
            }*/

        }
    }

 }