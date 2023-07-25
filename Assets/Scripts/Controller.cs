using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Controller : MonoBehaviour
{
    public ImageScriptableObject imageScriptable;

    private string _characterName => imageScriptable.charcterName;
    private Sprite[] _charactersSprites => imageScriptable.sprites;
}
