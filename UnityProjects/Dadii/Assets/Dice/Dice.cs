using UnityEngine;
public class Dice {

    private int nFaces;

    public void SetFaces(int a)
    {
        this.nFaces = a;
    }

    public int Throw()
    {
        return Random.Range(1, nFaces + 1);
    }

}