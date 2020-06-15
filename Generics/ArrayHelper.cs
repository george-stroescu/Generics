using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Generics
{
    class ArrayHelper<T>
        where T: IEquatable<T>
    {
        public ArrayHelper()
        {

        }

        public int ReturnIndexOfElement(T[] array, T element)
        {
            int arrayLength = array.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i].Equals(element))
                    return i;
            }

            return -1;
        }

        public bool SearchResult<T>(T[] array, int index, out T element)
        {
            if (index < array.Length)
            {
                element = array[index];
                return true;
            }

            element = default;
            return false;
        }

        public T[] ReturnSubArray(T[] array, int startIndex, int subArrayLength)
        {
            int length = array.Length;

            if (length <= startIndex)
                return default;

            if (length < startIndex + subArrayLength)
                subArrayLength = length - startIndex;

            T[] subArray = new T[subArrayLength];

            for (int i = 0; i < subArrayLength; i++)
            {
                subArray[i] = array[startIndex];
                startIndex++;
            }

            return subArray;
        }

        public T[] ArraySort<T>(T[] array)
            where T: IComparable<T>
        {
            int length = array.Length;

            bool changed = false;

            do
            {
                changed = false;

                for (int i = 0; i < length; i++)
                {
                    if (i.Equals(length - 1))
                        continue;

                    int result = array[i].CompareTo(array[i + 1]);

                    switch (result)
                    {
                        case 0:
                        case -1:
                            continue;
                        case 1:
                            T temp = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = temp;
                            changed = true;
                            break;
                    }
                }
            }
            while (changed);

            return array;
        }
    }
}
