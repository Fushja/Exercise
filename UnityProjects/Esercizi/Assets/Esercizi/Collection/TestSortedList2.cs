using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace TestSortedList2
{

    public class EnemyComparer : IComparer<Enemy>
    {
        public int Compare(Enemy x, Enemy y)
        {
            int equal_value = x.level.CompareTo(y.level); // ritorna un valre: 0 se uguale, <0 se il primo è + piccolo, >0 se il secondo è + grande
            if (equal_value == 0)
            {
                // se livello è uguale, controlla invece la vita
                equal_value = x.health.CompareTo(y.health);
                if (equal_value == 0)
                {
                    equal_value = x.strength.CompareTo(y.strength);

                }
            }    
            return equal_value;
        }
    }
    public class Enemy : IComparable, IComparable<Enemy>
    {
        public int level;
        public int health;
        public int strength;
        public Enemy(int _level, int _healt, int _strength)
        {
            this.level = _level;
            this.health = _healt;
            this.strength = _strength;
        }
        

        public int CompareTo(object obj)
        {
            if (obj is Enemy)
            {
                Enemy obj_enemy = (Enemy)obj;
                return level.CompareTo(obj_enemy.level);
            }
            else
            {
                return 0; // TODO: add an error here
            }
            
        }

        public int CompareTo(Enemy other)
        {
            return level.CompareTo(other.level);
        }

        public override string ToString()
        {
            return "(L: " + level + " , H: " + health + " , S: " + strength + ")";
        }
    }

    public class TestSortedList2 : MonoBehaviour
    {
        public List<Enemy> enemyList = new List<Enemy>();
        // Use this for initialization
        void Start()
        {
            SortedList<Enemy, string> enemyDescriptionSortedList = new SortedList<Enemy, string>();

            Enemy e1 = new Enemy(1,10,3);

            Enemy e2 = new Enemy(2,5,5);
            
            Enemy e3 = new Enemy(3,2,4);

            Enemy e4 = new Enemy(4, 14, 3);


            enemyDescriptionSortedList.Add(e3, "Nemico 3");
            enemyDescriptionSortedList.Add(e2, "Nemico 2");
            enemyDescriptionSortedList.Add(e1, "Nemico 1");

            foreach (var pair in enemyDescriptionSortedList)
            {
               // Debug.Log(pair.Key + ": " + pair.Value);
            }


            // Ordiniamo una lista di nemici secondo un qualche criterio
            // Ordine livello > vita > forza
            enemyList.Add(new Enemy(2, 4, 2));
            enemyList.Add(new Enemy(1,1,1));
            enemyList.Add(new Enemy(3, 3, 3));
            enemyList.Add(new Enemy(1, 2, 2));
            enemyList.Add(new Enemy(2, 2, 2));
            
            enemyList.Add(new Enemy(2, 2, 4));
            
            enemyList.Add(new Enemy(1, 2, 1));
            enemyList.Add(new Enemy(1, 2, 7));
            enemyList.Add(new Enemy(1, 2, 3));
            enemyList.Add(new Enemy(1, 2, 4));

            EnemyComparer comparer = new EnemyComparer();

            enemyList.Sort(comparer);

            foreach (var item in enemyList)
            {
                //Debug.Log(item);
            }

            Stack<int> ciao = new Stack<int>();

            ciao.Push(9);
            ciao.Push(8);
            ciao.Push(1);
            foreach (var item in ciao)
            {
                Debug.Log(item);
            }
            LinkedList<int> ciaoo = new LinkedList<int>();

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(5);
            queue.Enqueue(4);
            queue.Enqueue(10);

            queue.Dequeue();

            foreach (var item in queue)
            {
                Debug.Log(item);

            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}