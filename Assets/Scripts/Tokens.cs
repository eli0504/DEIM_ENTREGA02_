using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tokens : MonoBehaviour
{
    private float timeInstance = 1.5f;


    private Chessboard chessboard;

    private Vector2Int gridPosition; // Posición 2D
    private Vector2Int startPosition;

    //private List<TokensPositions> tokensPositionsList; //list of occupied positions


    private void Awake()
    {
        startPosition = new Vector2Int(1, 0); //where is instantiated when starting the game
        gridPosition = startPosition;

        //tokensPositionsList = new List<TokensPositions>(); 
    }

    //Scripts connection
    public void Setup(Chessboard chessboard)  //public function that needs info of the script Chessboard
    {
        this.chessboard = chessboard;
    }

   
}
