using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities
    // Expected Result: Items are stored in insertion order dequeue returns from the highest to lowest priority
    // Defect(s) Found: The test initially failed because the expected ToString() value used lowercase "pri" instead of "Pri".
    // This was a test expectation error, not an implementation defect.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("High", 3);

        Assert.AreEqual("[Low (Pri:1), Medium (Pri:2), High (Pri:3)]", priorityQueue.ToString());

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario:  Add two items with equal highest priority and one item with a lower priority
    // Expected Result: The first item added with the highest priority is removed first, followed by the second.
    // Defect(s) Found: The Dequeue method selected the second item when two items had equal priority. The >= comparison caused
    // the later item to be selected instead of following FIFO order.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 2);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
        Assert.AreEqual("[]", priorityQueue.ToString());
    }

    // Scenario: Try to dequeue from an empty priority queue.
    // Expected Result: InvalidOperationException with the message "The queue is empty."
    // Defect(s) Found: No defect found, test passes
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue());

        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}