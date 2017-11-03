package datastructs;

public interface QueueInterface<E>{
  public int size();
  public E dequeue();
  public void enqueue(E item);
  public boolean contains(E item);
  public E access(int pos);
}
