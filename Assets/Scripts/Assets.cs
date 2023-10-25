using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assets : MonoBehaviour
{
    public static Assets Instance { get; private set; } //the code is executed every time the property is read or assigned

    public Sprite tokenSprite;

    private void Awake() //we make sure there is only one instance
    {
        // Singleton -> make a unique script
        if (Instance != null)
        {
            Debug.LogError("There is more than one Instance");
        }

        Instance = this;
    }
}
