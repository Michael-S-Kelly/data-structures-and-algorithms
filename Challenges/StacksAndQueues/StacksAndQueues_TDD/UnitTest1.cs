using System;
using Xunit;
using StacksAndQueues.Classes;
using System.Collections.Generic;
using System.Collections;

namespace StacksAndQueues_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void PushOntoStack()
        {
            //Arrange
            Stack myStack = new Stack();
            var num1 = 4;
            //Act
            myStack.Push(num1);
            var look = myStack.Peek();
            //Assert
            Assert.Equal(4, look);

        }

        [Fact]
        public void PushMultipleNodesOntoStack()
        {
            //Arrange
            Stack myStack = new Stack();
            var num1 = 1;
            var num2 = 2;
            var num3 = 3;
            var num4 = 4;
            var num5 = 5;
            //Act
            myStack.Push(num1);
            myStack.Push(num2);
            myStack.Push(num3);
            myStack.Push(num4);
            myStack.Push(num5);
            var look = myStack.Peek();
            //Assert
            Assert.Equal(5, look);

        }

        [Fact]
        public void PopOffTheStack()
        {
            //Arrange
            Stack myStack = new Stack();
            //Act
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Pop();
            var look = myStack.Peek();
            //Assert
            Assert.Equal(4, look);

        }

        [Fact]
        public void EmptyAfterMultiplePops()
        {
            //Arrange
            Stack myStack = new Stack();
            //Act
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            //Assert
            Assert.Empty(myStack);

        }

        [Fact]
        public void PeekNextItemOnStack()
        {
            //Arrange
            Stack myStack = new Stack();
            //Act
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            var look = myStack.Peek();
            //Assert
            Assert.Equal(5, look);

        }

        [Fact]
        public void InstantiateAnEmptyStack()
        {
            //Arrange
            Stack myStack = new Stack();
            //Act

            //Assert
            Assert.Empty(myStack);

        }

        [Fact]
        public void EnqueueOntoStack()
        {
            //Arrange
            Queue myQueue = new Queue();
            //Act
            myQueue.Enqueue(4);
            var look = myQueue.Peek();
            //Assert
            Assert.Equal(4, look);

        }
        
        [Fact]
        public void PushMultipleNodesOntoQueue()
        {
            //Arrange
            Queue myQueue = new Queue();
            //Act
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            var look1 = myQueue.Peek();
            myQueue.Dequeue();
            var look2 = myQueue.Peek();
            myQueue.Dequeue();
            //Assert
            Assert.Equal(1, look1);
            Assert.Equal(2, look2);
        }
        
        [Fact]
        public void DequeueOffTheQueue()
        {
            //Arrange
            Queue myQueue = new Queue();
            //Act
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Dequeue();
            var look = myQueue.Peek();
            //Assert
            Assert.Equal(2, look);

        }
        
        [Fact]
        public void EmptyAfterMultipleDequeue()
        {
            //Arrange
            Queue myQueue = new Queue();
            //Act
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.Dequeue();
            //Assert
            Assert.Empty(myQueue);

        }
        
        [Fact]
        public void PeekNextItemOnQueue()
        {
            //Arrange
            Queue myQueue = new Queue();
            //Act
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            var look = myQueue.Peek();
            //Assert
            Assert.Equal(1, look);

        }
        
        [Fact]
        public void InstantiateAnEmptyQueue()
        {
            //Arrange
            Queue myQueue = new Queue();
            //Act

            //Assert
            Assert.Empty(myQueue);

        }
        
    }
}
