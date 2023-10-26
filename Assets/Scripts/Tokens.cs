using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tokens : MonoBehaviour
{
    private float timeInstance = 1.5f;

    private Chessboard chessboard;

    //Scripts connection
    public void Setup(Chessboard chessboard)  //public function that needs info of the script Chessboard
    {
        this.chessboard = chessboard;
    }
}
