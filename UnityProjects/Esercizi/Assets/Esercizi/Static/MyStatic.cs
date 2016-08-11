using UnityEngine;
using System.Collections;

public static class MyStatic{

    public static string ciaoString = "Ciao";

	public static void SayCiao()
    {
        Debug.Log(MyStatic.ciaoString);
    }
}
