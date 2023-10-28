using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Candy : MonoBehaviour
{
    public TextMeshProUGUI CandyText;

    private int _candyAmount;
    // Start is called before the first frame update
    private void Start()
    {
        _candyAmount = 0;
        UpdateCandyAmount();
    }

    public void UpdateCandyAmount()
    {
        CandyText.text = _candyAmount.ToString();
    }

   public void IncreaseCandyAmount(int amount)
    {
        _candyAmount += amount;
    }
}
