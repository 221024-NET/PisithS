using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsExamples.App
{
	public class StacksandQueues
	{
		//fields
		Stack stack1 = new Stack();
		Queue queue1 = new Queue();
		int size = 10000000;
		//constructors
		public StacksandQueues()
		{
			for (int i = 0; i < size; i++)
			{
				stack1.Push(i);
			}
			for(int i = 0; i < size; i++)
			{
				queue1.Enqueue(i);
			}
		}
		//methods
		public void StackTimer()
		{

			while(stack1.Count != 0)
			{
				stack1.Pop();
			}

		}
	public void QueueTimer()
		{
			
			while(queue1.Count != 0)
			{
				queue1.Dequeue();
			}
		}

	}
}
