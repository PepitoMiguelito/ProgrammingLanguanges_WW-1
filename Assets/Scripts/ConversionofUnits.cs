using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class ConversionofUnits : MonoBehaviour
{
    public float PHP;
    public float Dollars;
    public float Won;
    public float Yen;
    public float Euro;
    public float Canadian;

    //funchtion that converts PHP to Dollars
    public TMP_InputField inputField;
    public TextMeshProUGUI convertedValue;

    public void ToDollars()
    {
        string inputValue = inputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            /* Debug.Log(numericValue);*/
            PHP = numericValue * Dollars;
            convertedValue.text = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }

    public void ToWon()
    {
        string inputValue = inputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            /* Debug.Log(numericValue);*/
            PHP = numericValue * Won;
            convertedValue.text = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }
    public void ToYen()
    {
        string inputValue = inputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            /* Debug.Log(numericValue);*/
            PHP = numericValue * Yen;
            convertedValue.text = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }

    public void ToEuro()
    {
        string inputValue = inputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            /* Debug.Log(numericValue);*/
            PHP = numericValue * Euro;
            convertedValue.text = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }

    public void ToCanadian()
    {
        string inputValue = inputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            /* Debug.Log(numericValue);*/
            PHP = numericValue * Canadian;
            convertedValue.text = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }
}
