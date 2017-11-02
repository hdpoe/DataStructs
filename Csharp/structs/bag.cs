using System;

namespace Csharp {

  public class Bag<T> {
    private int numberOfElements;
    private int MAX_SIZE = 25;
    private T[] bag;

    public Bag() {
      bag = new T[MAX_SIZE];
      numberOfElements = 0;
    }

    public bool addElement(T item) {
      if(numberOfElements < bag.Length) {
        bag[numberOfElements] = item;
        numberOfElements++;
        return true;
      } else {
        return false;
      }
    }

    public bool contains(T searchItem) {
      if(indexOf(searchItem) == -1) {
        return false;
      } else {
        return true;
      }
    }

    public bool isEmpty() {
      return numberOfElements == 0;
    }

    public bool isFull() {
      return numberOfElements == MAX_SIZE;
    }

    public T remove() {
      numberOfElements--;
      T item = bag[numberOfElements];
      bag[numberOfElements] = default(T);
      return item;
    }

    public T remove(T item) {
      int itemIndex = indexOf(item);
      if(itemIndex == -1) { return default(T); }

      T resultItem = bag[itemIndex];
      bag[itemIndex] = bag[--numberOfElements];
      bag[numberOfElements] = default(T);
      return resultItem;
    }

    public void clear() {
      while(!isEmpty()) { remove(); }
    }

    public int numberOf(T item) {
      int occurrances = 0;
      foreach(var bagItem in bag) {
        if(item.Equals(bagItem)) { occurrances++; }
      }
      return occurrances;
    }

    public T[] toArray() {
      T[] result = new T[numberOfElements];
      for(var i = 0; i < numberOfElements; i++) {
        result[i] = bag[i];
      }
      return result;
    }

    private int indexOf(T searchItem) {
      for(int i = 0; i < bag.Length; i++) {
        if(searchItem.Equals(bag[i])) { return i; }
      }
      return -1;
    }
  }
}

