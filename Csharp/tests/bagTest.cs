using Xunit;

// So I know that I am butchering every honroable just and 
// good practice of testing but I don't give a flying frick 
// as the purpose of this is to just make sure the data 
// structs work as implemented not building some sort
// of catherderal of software engineering that will span 
// generations

namespace Csharp {

  public class TestBag {
    [Fact]
      public void TestDaBag() {
        var bag = new Bag<int>();
        bag.addElement(10);
        int result = bag.remove();
        Assert.Equal(result, 10);

        for(int i = 0; i < 10; i++) {
           bag.addElement(i);
        }

        Assert.Equal(true, bag.contains(5));
        Assert.Equal(false, bag.contains(38832));
        Assert.Equal(false, bag.isFull());
        Assert.Equal(false, bag.isEmpty());

        while(!bag.isFull()) {
          bag.addElement(1);
        }
        Assert.Equal(true, bag.isFull());
        bag.clear();
        Assert.Equal(true, bag.isEmpty());
        bag.addElement(1);
        Assert.Equal(bag.remove(1), 1);

        for(int i = 0; i < 10; i++) {
          bag.addElement(1);
        }

        Assert.Equal(bag.numberOf(1), 10);
        int[] daArray = bag.toArray();

        Assert.Equal(daArray.Length, 10);
        for(int i = 0; i < daArray.Length; i++) {
          Assert.Equal(daArray[i], 1);
        }
      }
  }
}


