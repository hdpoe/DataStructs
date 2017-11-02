package hunters.ds;

class BasicQueue<T> {
  private T[] queue; 
  private int tail;
  private int head;

  public BasicQueue(int size) {
    this.tail = -1;
    this.head = -1;
    queue = (T[]) new Object[size];
  }

  public BasicQueue() {
    this(1000);
  }

  public int size() {
    if(head == -1 && tail == -1) {
      return 0;
    } else {
      return tail - head + 1;
    }
  }

  public void enqueue(T item) {
    if((tail + 1) % queue.length == head) {  
      System.out.println("BRAH QUEUE FULL");
    } else if (size() == 0) {
      head++;
    }
    queue[++tail] = item;
  }

  public T dequeue() {
    if(tail < head) { return null; }
    return  queue[tail--];
  }
}
