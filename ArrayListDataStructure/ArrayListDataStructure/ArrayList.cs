using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDataStructure
{
    public class ArrayList
    {
        int _count;
        int _capacity;
        bool _isEmpty;
        int[] _myArray;
        //(12)
        int _growthFactor;

        public int GrowthFactor
        {
            get { return _growthFactor; }
            set { _growthFactor = value; }
        }

        public int Capacity1
        {
            get { return _capacity; }
            set { _capacity = GrowthFactor; }
        }

        public int[] MyArray
        {
            get { return _myArray; }
        }

        public bool IsEmpty
        {
            get { return _isEmpty; }
        }

        public int Capacity
        {
            get { return _capacity; }
        }

        public int Count
        {
            get { return _count; }
        }

        public ArrayList()
        {
            _capacity = 4;
            _myArray = new int[_capacity];
        }

        public bool lastIsEmpty()
        {
            if (_myArray[_myArray.Length - 1] == 0)
            {
                _isEmpty = true;
            }
            else
            {
                _isEmpty = false;
            }
            return _isEmpty;
        }

        //Given the index, return the value at the given index location.
        public int Get(int index)
        {
            int x = 0;
            for (int i = 0; i < _myArray.Length; i++)
            {
                if (i == index)
                {
                    x = _myArray[i];
                }
            }
            return x;
        }

        //Set or Update the value in the given index location.
        public void Set(int index, int value)
        {
            //for (int i = 0; i < _myArray.Length; i++)
            //{
            //    if (i == index)
            //    {
            _myArray[index] = value;
            //    }
            //}
        }

        //Insert the given value at the specified index location, by moving other elements to the right.
        public void Insert(int index, int value)
        {
            if (lastIsEmpty())
            {
                for (int i = _myArray.Length - 1; i > index; i--)
                {
                    _myArray[i] = _myArray[i - 1];
                }
                _myArray[index] = value;
            }
            else
            {
                ReSize();
                Insert(index, value);
            }
            _count++;
        }

        /*Delete or remove the value at the given index location by moving the other elements to the left,
        thereby replacing the value in the given index.*/
        public void Delete(int index)
        {
            for (int i = index; i < _myArray.Length - 1; i++)
            {
                _myArray[i] = _myArray[i + 1];
            }
            _count--;
        }

        //Check if the given value is available in the ArrayList and return a boolean as output.
        public bool Contains(int value)
        {
            bool contain = false;
            for (int i = 0; i < _myArray.Length; i++)
            {
                if (_myArray[i] == value)
                {
                    contain = true;
                }
            }
            return contain;
        }

        //Add the given value to the end of the ArrayList.
        public void Add(int value)
        {
            if (lastIsEmpty())
            {
                _myArray[_count] = value;
                _count++;
            }
            else
            {
                ReSize();
                Add(value);
            }
        }

        //Double the size of the internal array as it reaches/exceeds the size limit.
        //public void ReSize()
        //{
        //    int[] newarray = new int[_myArray.Length * 2];
        //    for (int i = 0; i < _myArray.Length; i++)
        //    {
        //        newarray[i] = _myArray[i];
        //    }
        //    _myArray = newarray;
        //}

        //Display the elements of the array in the same order in which they are stored.
        public string Print()
        {
            string x = "";
            for (int i = 0; i < Count; i++)
            {
                x += i + "\t" + _myArray[i] + "\n";
            }
            return x;
        }

        //EXTENSIONS TO THE ArrayList.
        //(1)
        /*Given the value, return the index position/location of that value in the array list. 
        If multiple such items were found, return the index of the first occurrence of that value.*/
        public int IndexOf(int value)
        {
            int Index = 0;
            for (int i = 0; i < _myArray.Length; i++)
            {
                if (_myArray[i] == value)
                {
                    Index = i;
                    break;
                }
            }
            return Index;
        }

        //(2)
        //Take a collection of integers as input and add that to the end of the existing ArrayList.
        public void AddAll(IEnumerable<int> Values)
        {
            foreach (int items in Values)
            {
                Add(items);
            }
        }

        //(3)
        /*Given a value, remove all occurrences of that value from the array list if the RemoveAll Boolean is true or 
        remove the first occurrence of that value in the array list if RemoveAll is false.*/
        public void DeleteValue(int Value, bool RemoveAll)
        {
            int firstindex = 0;
            if (RemoveAll == true)
            {
                for (int i = 0; i < _myArray.Length; i++)
                {
                    if (_myArray[i] == Value)
                    {
                        _count--;
                    }
                }

                _myArray = _myArray.Where(e => e != Value).ToArray();
            }
            else if (RemoveAll == false)
            {
                for (int i = 0; i < _myArray.Length; i++)
                {
                    if (_myArray[i] == Value)
                    {
                        firstindex = i;
                        _count--;
                        break;
                    }
                }

                _myArray = _myArray.Where((item, index) => index != firstindex).ToArray();
            }
        }

        //(4)
        /*Take a collection of integers as input and Insert those values starting from the specified index location
        by moving other elements to the right.*/
        public void InsertAll(int Index, IEnumerable<int> Values)
        {
            foreach (int items in Values)
            {
                Insert(Index, items);
                Index++;
            }
        }

        //(5)
        //Return the Maximum value in the array list.
        public int Max()
        {
            int MaxValue = 0;
            for (int i = 0; i < _myArray.Length; i++)
            {
                if (MaxValue < _myArray[i])
                {
                    MaxValue = _myArray[i];
                }
            }
            return MaxValue;
        }

        //(6)
            //Return the minimum value in the array list.
        public int Min()
        {
            int MinValue = Max();
            for (int i = 0; i < Count; i++)
            {
                if (_myArray[i] < MinValue)
                {
                    MinValue = _myArray[i];
                }
            }
            return MinValue;
        }

        //(7)
        //Return the sum of all elements in the array list.
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < _myArray.Length; i++)
            {
                sum += _myArray[i];
            }
            return sum;
        }

        //(8)
        //Return a new ArrayList containing the elements of the current array list in reverse order.
        public string Reverse()
        {
            string x = "";
            int[] NewArray = new int[_myArray.Length];
            for (int i = 0; i < _myArray.Length; i++)
            {
                NewArray[i] = _myArray[i];
            }
            for (int i = Count - 1; i >= 0; i--)
            {
                x += i + "\t" + NewArray[i] + "\n";
            }
            return x;
        }

        //(9)
        //Return a new Array containing the elements of the array list in the same order.
        public string ToArray()
        {
            string x = "";
            int[] NewArray = new int[_myArray.Length];
            for (int i = 0; i < Count; i++)
            {
                NewArray[i] = _myArray[i];
                x += NewArray[i] + "\t";
            }
            return x;
        }

        //(10)
        //Return a new Array containing the elements of the array list starting from the startIndex in the same order.
        public string ToArray(int StartIndex)
        {
            string x = "";
            int[] NewArray = new int[Count];
            for (int i = StartIndex; i < Count; i++)
            {
                NewArray[i] = _myArray[i];
                x += NewArray[i] + "\t";
            }
            return x;
        }

        //(11)
        //Return a new Array containing the elements of the array list from startIndex to endIndex in the same order.
        public string ToArray(int startIndex, int endIndex)
        {
            string x = "";
            int[] NewArray = new int[_myArray.Length];
            for (int i = startIndex; i <= endIndex; i++)
            {
                NewArray[i] = _myArray[i];
                x += NewArray[i] + "\t";
            }
            return x;
        }

        //(15)
        /*Return a new ArrayList containing only the distinct elements of the arraylist in any order if the bool InOrder is false and 
        in the same order as in the array list if InOrder is set to true.*/
        public string Distinct(bool InOrder)
        {
            string x = "";
            int[] NewArray = new int[_myArray.Length];
            if (InOrder == true)
            {
                for (int i = 0; i < Count; i++)
                {
                    NewArray[i] = _myArray[i];
                    bool IsDuplicate = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (NewArray[i] == NewArray[j])
                        {
                            IsDuplicate = true;
                            break;
                        }
                    }
                    if (IsDuplicate == false)
                    {
                        x += NewArray[i] + "\t";
                    }
                }
            }
            else if (InOrder == true)
            {

            }
            return x;
        }

        //(16)
        /*Return a new ArrayList containing the elements of the array list in ascending order,
        if the bool InDescending is set to false and in descending order if InDescending is set to true.*/
        public string Sort(bool InDescending)
        {
            string x = "";
            int[] NewArray = new int[_myArray.Length];
            for (int i = 0; i < Count; i++)
            {
                NewArray[i] = _myArray[i];
            }
            if (InDescending == true)
            {
                for (int i = 0; i < Count; i++)
                {
                    for (int j = i + 1; j < NewArray.Length; j++)
                    {
                        if (NewArray[i] < NewArray[j])
                        {

                            int temp = NewArray[i];
                            NewArray[i] = NewArray[j];
                            NewArray[j] = temp;
                        }
                    }
                    x += NewArray[i] + "\t";
                }
            }
            else if (InDescending == false)
            {
                int temp;

                for (int i = 0; i < Count; i++)
                {
                    for (int j = i + 1; j < Count; j++)
                    {
                        if (NewArray[i] > NewArray[j])
                        {

                            temp = NewArray[i];
                            NewArray[i] = NewArray[j];
                            NewArray[j] = temp;

                        }
                    }
                    x += NewArray[i] + "\t";
                }
            }
            return x;
        }

        //(17)
        //Clear the ArrayList and Reset it to the Initial State.
        public void Clear()
        {
            for (int i = 0; i < Count; i++)
            {
                DeleteValue(_myArray[i], true);
            }
            ReSize();
            _count = 0;
        }

        //DOUBT!!!

        //(13)
        //Add a new Overloaded Constructor that takes GrowthFactor as aninput. 
        public ArrayList(int growthfactor)
        {
            GrowthFactor = growthfactor;
        }

        //(14)
        //Rewrite the ReSize() method to grow the current ArrayList size by GrowthFactor times (instead of 2), each time the limit is reached.
        public void ReSize()
        {
            int[] newarray = new int[_myArray.Length * Capacity1];
            for (int i = 0; i < _myArray.Length; i++)
            {
                newarray[i] = _myArray[i];
            }
            _myArray = newarray;
        }
    }
}