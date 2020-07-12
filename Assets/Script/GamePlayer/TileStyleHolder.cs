using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TileStyle
{
    public int number;
    public Color32 titleColor;
    public Color32 textColor;
}

public class TileStyleHolder : MonoBehaviour
{
    public static TileStyleHolder Instance;

    public TileStyle[] TileStyles;

    private void Awake()
    {
        Instance = this;
    }
}
