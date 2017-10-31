using System;

namespace CSharpDataStructs {

  public class Bag<T> {
    private int numberOfElements;
    private int MAX_SIZE = 25;
    private T[] bag;

    Bag() {
      bag = new T[MAX_SIZE];
      numberOfElements = 0;
    }

    public bool addElement(T item) {
      if(numberOfElements >= bag.Length) {
        bag[numberOfElements] = item;
        numberOfElements++;
        return true;
      } else {
        return false;
      }
    }

    public bool contains(T searchItem) {
      foreach(var item in bag) {
        if(searchItem.Equals(item)) { return true; }
      }
      return false;
    }

    public bool isEmpty() {
      return numberOfElements != 0;
    }

    public bool isFull() {
      return numberOfElements == MAX_SIZE;
    }
  }
}

