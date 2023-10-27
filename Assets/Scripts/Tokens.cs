using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tokens : MonoBehaviour
{
    private Chessboard chessboard;

    private Transform pos;
    public Vector3[] tokensPos; //positions array

    public GameObject tokensPrefab;

    private float gridMoveTimer;
    private float gridMoveTimerMax = 3f;

    private void Update()
    {
        SpawnTokens();
    }

    private void SpawnTokens()
    {
        float posx = Random.Range(-3, 3);
        float posy = Random.Range(-2, 2);
        Vector2 randomPos = new Vector2(posx, posy);

        for (int i = 0; i < tokensPos.Length; i++)
        {
            int tokensIndex = Random.Range(0, tokensPos.Length);
            Instantiate(tokensPrefab, tokensPos[tokensIndex], tokensPrefab.transform.rotation);
            if (gridMoveTimer >= gridMoveTimerMax)
            {
                gridMoveTimer -= gridMoveTimerMax;
            }
        }
    }


    //Scripts connection
    public void Setup(Chessboard chessboard)  //public function that needs info of the script Chessboard
    {
        this.chessboard = chessboard;
    }
}
