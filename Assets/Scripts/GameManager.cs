using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Chessboard chessboard;
    private Tokens tokens;

    private Vector2 gridPosition; // Posición 2D

    private void Start() //tokens configuration
    {
        GameObject tokensGameObject = new GameObject("Tokens");
        SpriteRenderer tokensSpriteRenderer = tokensGameObject.AddComponent<SpriteRenderer>();
        tokensSpriteRenderer.sprite = Assets.Instance.tokenSprite;
        tokensSpriteRenderer.transform.position = new Vector3(0, 0, 0);
        tokens = tokensGameObject.AddComponent<Tokens>();

        //Chessboard configuration

        chessboard = new Chessboard(7, 5);
        tokens.Setup(chessboard);
        chessboard.Setup(tokens);

    }
}
