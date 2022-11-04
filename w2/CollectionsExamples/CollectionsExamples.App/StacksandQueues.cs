using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsExamples.App
{
	public class StacksandQueues
	{
		//fields
		//constructors
		public StacksandQueues()
		{
		}
		//methods
		public void StackTimer(int size)
		{
			Stack stack1 = new Stack(size);
			while(stack1.Count != 0)
			{
				stack1.Pop();
			}

		}
	public void QueueTimer(int size)
		{
			Queue queue1 = new Queue(size);
			while(queue1.Count != 0)
			{
				queue1.Dequeue();
			}
		}

	}
}
