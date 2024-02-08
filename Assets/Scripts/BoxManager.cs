using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoxManager : MonoBehaviour
{
    [SerializeField] private string _correctGemOrder = "BlueRedGreen";
    private string _enteredGemOrder = "";

    public Animator boxAnimator;

    private int _amountOfGems = 3;
    private int _currentGem = 0;

    public Gem[] gemsInScene;

    public UnityEvent gameIsWon;
    
    public void GemSelect(Gem currentSelectedGem)
    {
        _enteredGemOrder += currentSelectedGem.gemColorName;

        _currentGem += 1;

        currentSelectedGem.ChangeEmission(true);

        if (_currentGem == _amountOfGems)
        {
            CompareGemOrder();
        }

        Debug.Log("Gem Selected");
    }

    private void CompareGemOrder()
    {
        if (_enteredGemOrder == _correctGemOrder)
        {
            Debug.Log("Order is correct");
            CompleteGame();
        }
        else
        {
            Debug.Log("Order is incorrect");
            ResetGame();
        }
    }

    public void CompleteGame()
    {
        //boxAnimator.SetTrigger("Open");
        gameIsWon.Invoke();
    }

    public void ResetGame()
    {
        _currentGem = 0;
        _enteredGemOrder = "";

        foreach(var gem in gemsInScene)
        {
            gem.ChangeEmission(false);
        }
    }
}
