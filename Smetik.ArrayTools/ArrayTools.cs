namespace Smetik.ArrayTools;

public static class ArrayTools
{
    public static int[] SortAscending(int[]? array)
    {
        if (array == null || array.Length == 0)
            return Array.Empty<int>();

        int[] result = new int[array.Length];
        Array.Copy(array, result, array.Length);
        Array.Sort(result);

        return result;
    }

    public static int[] FilterGreaterThan(int[]? array, int minValue)
    {
        if (array == null || array.Length == 0)
            return Array.Empty<int>();

        List<int> result = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > minValue)
                result.Add(array[i]);
        }

        return result.ToArray();
    }

    public static int IndexOf(int[]? array, int value)
    {
        if (array == null || array.Length == 0)
            return -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
                return i;
        }

        return -1;
    }

    public static int GetElementAt(int[]? array, int index)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array), "Массив не должен быть null.");

        if (index < 0 || index >= array.Length)
            throw new ArgumentOutOfRangeException(nameof(index), "Индекс выходит за пределы массива.");

        return array[index];
    }
}