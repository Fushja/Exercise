using UnityEngine;

public class DiceMono : MonoBehaviour
{
    public Sprite baseSprite;


    private int nFaces;


    private TextMesh numberTextMesh;


    public void Awake()
    {
        SpriteRenderer sr = this.gameObject.AddComponent<SpriteRenderer>();
        sr.sprite = baseSprite;


        Transform tr = this.transform;
        tr.localScale = new Vector3(5, 5, 5);

        GameObject childGO = new GameObject("TextMeshGo");
        childGo.transform.position = tr.position + new Vector3(0, 0, -1);
        childGO.transform.localScale = Vector3.one * 0.5f;

        TextMesh textMesh = childGO.AddComponent<TextMesh>();
        textMesh.text = "5";
        textMesh.color = Color.black;
        textMesh.alignment = TextAlignment.Center;
        textMesh.anchor = TextAnchor.MiddleCenter;


        SetFaces(6);
        Throw();


    }


    public void SetFaces(int _nFaces)
    {
        this.nFaces = n_Faces;
    }
    public int Throw()
    {
        int n = Random.Range(1, nFaces + 1);
        numberTextMesh.text = n.ToString();
        return n;

    }
}
