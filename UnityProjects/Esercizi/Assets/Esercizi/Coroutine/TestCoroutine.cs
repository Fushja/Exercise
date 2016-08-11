using UnityEngine;
using System.Collections;

public class TestCoroutine : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //StartCoroutine(SayCiaoAfterSeconds(2));
        //StartCoroutine(SayCiaoTenTimes(1));
        StartCoroutine(DoSomeStuff());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator SayCiaoForever()
    {
        // skippa un frame
        // esegue fino a questa istruzione, poi aspetta il frame successivo, poi esegue il resto
        yield return null;

        while (true)
        {
            Debug.Log("Ciao");
            yield return null;
        }

    }

    IEnumerator SayCiaoAfterSeconds(int seconds){
        
        //while (true)
        {
            yield return new WaitForSeconds(seconds);
            Debug.Log("Ciao");
        }
        
    }

    IEnumerator SayCiaoTenTimes(int seconds)
    {
        int count = 0;
        while (true)
        {
            yield return new WaitForSeconds(seconds);
            Debug.Log("Ciao");
            count++;
            if (count == 10)
            {
                yield break;
            }
        }
    }

    IEnumerator DoSomeStuff()
    {
        // diciamo ciao dopo due secondi
        yield return StartCoroutine(SayCiaoAfterSeconds(2));

        // diciamo e basta ciao

        yield return new WaitForSeconds(1);
        Debug.Log("E basta ciao");

        // diciamo scusa dopo 3 secondi

        yield return new WaitForSeconds(3);
        Debug.Log("scusa");
    }
}
