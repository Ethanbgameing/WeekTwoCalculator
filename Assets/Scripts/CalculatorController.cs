using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore;
using System.Runtime.ExceptionServices;
using System;

public class CalculatorController : MonoBehaviour
{
    #region Button Declarations
    //NUMBER BUTTONS
    [SerializeField] Button button1;
    [SerializeField] Button button2;
    [SerializeField] Button button3;
    [SerializeField] Button button4;
    [SerializeField] Button button5;
    [SerializeField] Button button6;
    [SerializeField] Button button7;
    [SerializeField] Button button8;
    [SerializeField] Button button9;
    [SerializeField] Button button0;
    //OPERATION BUTTONS
    [SerializeField] Button buttonP;
    [SerializeField] Button buttonM;
    [SerializeField] Button buttonT;
    [SerializeField] Button buttonD;
    [SerializeField] Button buttonE;
    [SerializeField] Button buttonC;

    #endregion
    TextMeshProUGUI Display;

    int number1 = 0;
    int number2 = 0;

    bool isNumber1 = true;
    bool isPlus = false;
    bool isMinus = false;
    bool isTimes = false;
    bool isDivide = false;

    string result = string.Empty;

    private void Start()
    {
    Display = GetComponentInChildren<TextMeshProUGUI>();
        Display.text = "";
    }


    public void inputValue(int n)
    {
        Debug.Log(n);
        result += $"{n}";
        Display.text = result;

    }

    public void inputPlus()
    {
        Debug.Log("Plus");
        if(isNumber1)
        {
            Debug.Log("Switch to Second Num");
            number1 = Convert.ToInt32(result);
            result = "";
            Display.text = result;
            isNumber1 = false;
        }
        isPlus = true;
    }

    public void inputMinus()
    {
        Debug.Log("Minus");
        if (isNumber1)
        {
            Debug.Log("Switch to Second Num");
            number1 = Convert.ToInt32(result);
            result = "";
            Display.text = result;
            isNumber1 = false;
        }
        isMinus = true;
    }

    public void inputTimes()
    {
        Debug.Log("Times");
        if (isNumber1)
        {
            Debug.Log("Switch to Second Num");
            number1 = Convert.ToInt32(result);
            result = "";
            Display.text = result;
            isNumber1 = false;
        }
        isTimes = true;
    }

    public void inputDivide()
    {
        Debug.Log("Divide");
        if (isNumber1)
        {
            Debug.Log("Switch to Second Num");
            number1 = Convert.ToInt32(result);
            result = "";
            Display.text = result;
            isNumber1 = false;
        }
        isDivide = true;
    }
    public void inputEquals()
    {
        if(!isNumber1)
        {
            number2 = Convert.ToInt32(result);
            result = "";
            Display.text = result;
        }

        if(isPlus)
        {
            Debug.Log("adding");
            int sum = number1 + number2;
            Debug.Log(sum);
            result = sum.ToString();
            Display.text = result;
        }

        if (isMinus)
        {
            Debug.Log("subtracting");
            int difference = number1 - number2;
            Debug.Log(difference);
            result = difference.ToString();
            Display.text = result;
        }

        if (isTimes)
        {
            Debug.Log("multiplying");
            int product = number1 * number2;
            Debug.Log(product);
            result = product.ToString();
            Display.text = result;
        }

        if (isDivide)
        {
            Debug.Log("dividing");
            int product = number1 / number2;
            Debug.Log(product);
            result = product.ToString();
            Display.text = result;
        }
    }
}

