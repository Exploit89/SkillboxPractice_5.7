using UnityEngine;

public class SumOfEvenNumbersInArray : MonoBehaviour
{
    public void OnSumEvenNumbersInArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = 214;
        int got = SumEvenNumbersInArray(array);
        string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Сумма четных чисел в заданном массиве: {got} - {message}");
    }

    private int SumEvenNumbersInArray(int[] array)
    {
        int sum = 0;

        foreach (int item in array)
        {
            if (item % 2 == 0)
                sum += item;
        }
        return sum;
    }
}