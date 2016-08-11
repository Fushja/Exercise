using UnityEngine;
using System.Collections;

public class BitField : MonoBehaviour {

	// Use this for initialization
	void Start () {
        BitArray barray = new BitArray(new bool[] { true, true, false, false });
        //BitArray andarray = barray.And(barray);
        //BitArray orarray = barray.Or(barray);
        //BitArray notarray = barray.Not();

        foreach (var item in barray)
        {
            Debug.Log(item);
        }


        int bmask = 179;
        string binaryString = "";
        for (int i = 0; i < 96; i++)
        {
            int tempByte = (bmask >> i);
            bool result = (tempByte & 1) == 1;
            string resultString = result ? "1" : "0";
            binaryString = resultString + binaryString;
        }

        Debug.Log(binaryString);



        bool[] barrayBool = new bool[] { true, true, false, false, true, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        bmask = 0;
        for (int i = 0; i < 32; i++)
        {
            bool result = barrayBool[i];
            int unoShiftato = result ? 1 << i : 0;
            bmask = bmask | unoShiftato;
        }
        Debug.Log(bmask);

    }



	
	// Update is called once per frame
	void Update () {
	
	}
}
