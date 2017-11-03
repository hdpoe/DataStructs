package datastructs;
import junit.framework.TestCase;
import datastructs.QueueTest;

public class QueueTest extends TestCase {

  public void testQueue() {
    BasicQueue<Integer> queue = new BasicQueue<Integer>(100);
    assertEquals(queue.size(), 0);
    Integer temp1 = 1000;
    queue.enqueue(temp1);
    assertEquals(queue.dequeue(), temp1);
    queue.enqueue(temp1);
    assertEquals(queue.contains(1000), true);
    assertEquals(queue.contains(100), false);

    assertEquals(queue.access(0), temp1);
    assertEquals(queue.access(10030), null);
  }
}
