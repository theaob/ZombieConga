using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour {
    public Texture2D miniScope;

    void OnMouseEnter()
    {
        Cursor.SetCursor(miniScope, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}
