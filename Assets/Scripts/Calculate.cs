using System;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{
    [SerializeField] InputField num1InputField = null;
    [SerializeField] InputField num2InputField = null;
    [SerializeField] Dropdown operatorSelect = null;
    [SerializeField] Dropdown num1BaseSelect = null;
    [SerializeField] Dropdown num2BaseSelect = null;
    [SerializeField] Text outputText = null;

    public void PerformCalculation()
    {
        float num1 = ToDecimal(num1InputField.text, num1BaseSelect.value);
        float num2 = ToDecimal(num2InputField.text, num2BaseSelect.value);

        float tempValue = 0f;

        switch (operatorSelect.value)
        {
            case 0:
                tempValue = num1 + num2;
                break;
            case 1:
                tempValue = num1 - num2;
                break;
            case 2:
                tempValue = num1 * num2;
                break;
            case 3:
                tempValue = num1 / num2;
                break;
            default:
                Debug.Log("Operator Dropdown out of bounds!");
                break;
        }

        outputText.text = Convert.ToString(tempValue);

    }

    private float ToDecimal(string numText, int numBase)
    {
        long num = 0;

        switch (numBase)
        {
            case 0:  //Binary
                num = Convert.ToInt64(numText, 2);
                break;
            case 1:  //Octal
                num = Convert.ToInt64(numText, 8);
                break;
            case 2:  //Decimal
                num = Convert.ToInt64(numText, 10);
                break;
            case 3:  //Hexidecimal
                num = Convert.ToInt64(numText, 16);
                break;
            default:
                Debug.Log("Base Dropdown out of bounds!");
                break;
        }

        return (float)num;
    }
}
