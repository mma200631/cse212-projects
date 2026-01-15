using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue once
    // Expected Result: Item with the highest priority is removed first
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("medium", 9);
        priorityQueue.Enqueue("high", 20);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("high", result);
    }

    [TestMethod]
    // Scenario: Multiple item with the same highest priority
    // Expected Result: The item closest to the front is being removed first
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("first", 9);
        priorityQueue.Enqueue("second", 9);
        priorityQueue.Enqueue("third", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("first", result);
    }

    [TestMethod]
    //scenerio:Enqueue items and dequeue all of them
    //exxpected result:items are removes in correct priority order
    //Defect(s) Found:
    // - Queue did not correctly track remaining items after dequeue.

    public void TestPriorityQueue_multipleDequeues()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 3);
        priorityQueue.Enqueue("B", 8);
        priorityQueue.Enqueue("C", 16);

        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());

    }
    [TestMethod]
    //Scenerio: Attempting to dequeue from an empty queue
    //expected result: InvalidOperationException result with message "The queue is empty"
    // Defect(s) Found:
    // - No exception or incorrect exception/message was thrown.

    public void TestPriorityQueue_emptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try 
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty", e.Message);
        }
        
        
            
    
    }
}