using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashTask : InteractiveObject
{
    [Header("Trash")]
    public GameObject UICanvas;
    public GameObject[] Balls;
    public int randomballsNumber;
    public int collectballNumber=0;
    public int trashballNumber = 0;
    public bool ballisThere=true;
    public Text scoreText;
    public GameObject LeaveBallButton;
    public int counter;
    public Text balltext;
    public void Trash()
    {
        UICanvas.SetActive(true);
    }
    public void StartMiniGame()
    {
        bool activation;
        for (int i = 0; i <= randomballsNumber; i++)
        {
            if ((Random.Range(0, 2) == 1) && (counter <= 5))
            {
                activation = true;
                counter++;
            }
            else
            {
                activation = false;
            }

            Balls[i].SetActive(activation);
            
        }
        counter = 0;
    }
    public void FinishMiniGame()
    {
        UICanvas.SetActive(false);
        for (int i = 0; i < Balls.Length; i++)
        {
            if (Balls[i] != null)
            {
                Balls[i].SetActive(false); 
            }
        }
    }
    public void DropTheBall()
    {

    }
    public override void ExecuteTask()
    {
        Trash();
    }
    public void CollectTheBalls()
    {
        if(trashballNumber==collectballNumber)
        {
            collectballNumber++;
            LeaveBallButton.SetActive(true);
            StartCoroutine(BallWait());
        }   
    }
    public void TrashBall()
    {
        trashballNumber++;
        ballisThere = true;
        scoreText.text= trashballNumber.ToString();
        LeaveBallButton.SetActive(false);
    }
    IEnumerator BallWait()
    {
        balltext.enabled = true;
        yield return new WaitForSeconds(2f);
        balltext.enabled = false;
    }
}
