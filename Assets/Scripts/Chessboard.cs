using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessboard : MonoBehaviour
{
    private int width;
    private int height;

    private Tokens tokens;

    public List<Vector3> listOfPosition = new List<Vector3>();
   


    public Chessboard(int w, int h) //chess board size
    {
        width = w;
        height = h;
    }

    //Scripts connection
    public void Setup(Tokens tokens) //public function that needs info of the script Tokens
    {
        this.tokens = tokens;
    }

    private void SpawnTokens()
    {

    }

}