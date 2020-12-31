using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftDigitalProject
{
    class Task6
    {

		public class MyStructure
		{
			// A resizable array 
			private readonly List<int> arr = new List<int>();

			// A hash where keys are array elements and vlaues are 
			// indexes in arr[] 
			private readonly SortedDictionary<int, int> Map = new SortedDictionary<int, int>();

			// A Theta(1) function to add an element to MyDS 
			// data structure 
			public void Add(int x)
			{
				// If ekement is already present, then noting to do 
				if (Map.ContainsKey(x))
				{
					return;
				}

				// Else put element at the end of arr[] 
				int index = arr.Count;
				arr.Add(x);

				// and hashmap also 
				Map.Add(x, index);
			}

			// function to remove a number to DS in O(1) 
			public void Remove(int x)
			{
				// element not found then return 
				if (!Map.ContainsKey(x))
				{
					return;
				}

				// remove element from map 
				int index = Map[x];
				Map.Remove(x);

				// swap with last element in arr 
				// then remove element at back 
				int last = arr.Count - 1;
				(arr[index], arr[last]) = (arr[last],arr[index]);
				arr.RemoveAt(arr.Count - 1);

				// Update hash table for new index of last element 
				Map[arr[index]] = index;
			}

		}

		public static void Tasksix()
		{	
				MyStructure ds = new MyStructure();
				ds.Add(10);
				ds.Add(20);
				ds.Add(30);
				ds.Add(40);
				Console.Write("\n");
				ds.Remove(20);
				ds.Add(50);
				Console.Write("\n");
				Console.Write("\n");
		}

	}
}
