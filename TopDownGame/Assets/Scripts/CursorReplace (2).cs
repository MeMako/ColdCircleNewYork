using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorReplace : MonoBehaviour
{
    public Texture2D cursor;

    private void Awake()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
        
    }
}
