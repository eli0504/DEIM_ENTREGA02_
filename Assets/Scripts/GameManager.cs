using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Chessboard chessboard;
    private Tokens tokens;

    private void Start() //tokens configuration
    {
        GameObject tokensGameObject = new GameObject("Tokens");
        SpriteRenderer tokensSpriteRenderer = tokensGameObject.AddComponent<SpriteRenderer>();
        tokensSpriteRenderer.sprite = Assets.Instance.tokenSprite;
        tokens = tokensGameObject.AddComponent<Tokens>();

        //Chessboard configuration

        chessboard = new Chessboard(8, 8);
        tokens.Setup(chessboard);
        chessboard.Setup(tokens);

    }
}
