## Flyweight

### Short Description
* **Summary**
    - A flyweight is an object that minimizes memory use by sharing as much data as possible with other similar objects; it is a way to use objects in large numbers when a simple repeated representation would use an unacceptable amount of memory. Often some parts of the object state can be shared, and it is common practice to hold them in external data structures and pass them to the flyweight objects temporarily when they are used.
* **Use**
    - The Abstract Factory, Builder, and Prototype patterns can use Singletons in their implementation.
Facade objects are often singletons because only one Facade object is required.
State objects are often singletons.
Singletons are often preferred to global variables because they do not pollute the global namespace (or, in languages with namespaces, their containing namespace) with unnecessary variables and they permit lazy allocation and initialization, whereas global variables in many languages will always consume resources.
* **Implementation**
    - Implementation of a singleton pattern must satisfy the single instance and global access principles. It requires a mechanism to access the singleton class member without creating a class object and a mechanism to persist the value of class members among class objects. The singleton pattern is implemented by creating a class with a method that creates a new instance of the class if one does not exist. If an instance already exists, it simply returns a reference to that object. To make sure that the object cannot be instantiated any other way, the constructor is made private.
* **Problems**
    - Special consideration must be made in scenarios where Flyweight objects are created on multiple threads. If the list of values is finite and known in advance the Flyweights can be instantiated ahead of time and retrieved from a container on multiple threads with no contention. If Flyweights are instantiated on multiple threads there are two options:
        - Make Flyweight instantiation single threaded thus introducing contention and ensuring one instance per value.
        - Allow concurrent threads to create multiple Flyweight instances thus eliminating contention and allowing multiple instances per value. This option is only viable if the equality criterion is met.

### C# Example
~~~c#
using System;
using System.Collections;
 
namespace Flyweight.Structural
{
  class MainApp
  {
    static void Main()
    {
      // Arbitrary extrinsic state
      int extrinsicstate = 22;
 
      FlyweightFactory factory = new FlyweightFactory();
 
      // Work with different flyweight instances
      Flyweight fx = factory.GetFlyweight("X");
      fx.Operation(--extrinsicstate);
 
      Flyweight fy = factory.GetFlyweight("Y");
      fy.Operation(--extrinsicstate);
 
      Flyweight fz = factory.GetFlyweight("Z");
      fz.Operation(--extrinsicstate);
 
      UnsharedConcreteFlyweight fu = new
        UnsharedConcreteFlyweight();
 
      fu.Operation(--extrinsicstate);
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'FlyweightFactory' class
  /// </summary>
  class FlyweightFactory
  {
    private Hashtable flyweights = new Hashtable();
 
    // Constructor
    public FlyweightFactory()
    {
      flyweights.Add("X", new ConcreteFlyweight());
      flyweights.Add("Y", new ConcreteFlyweight());
      flyweights.Add("Z", new ConcreteFlyweight());
    }
 
    public Flyweight GetFlyweight(string key)
    {
      return ((Flyweight)flyweights[key]);
    }
  }
 
  /// <summary>
  /// The 'Flyweight' abstract class
  /// </summary>
  abstract class Flyweight
  {
    public abstract void Operation(int extrinsicstate);
  }
 
  /// <summary>
  /// The 'ConcreteFlyweight' class
  /// </summary>
  class ConcreteFlyweight : Flyweight
  {
    public override void Operation(int extrinsicstate)
    {
      Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
    }
  }
 
  /// <summary>
  /// The 'UnsharedConcreteFlyweight' class
  /// </summary>
  class UnsharedConcreteFlyweight : Flyweight
  {
    public override void Operation(int extrinsicstate)
    {
      Console.WriteLine("UnsharedConcreteFlyweight: " +
        extrinsicstate);
    }
  }
}
~~~

### UML Diagram
![Flyweight Pattern](http://www.dofactory.com/images/diagrams/net/flyweight.gif "Flyweight Design Pattern UML Diagram")