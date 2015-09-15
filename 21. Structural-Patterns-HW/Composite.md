## Composite

### Short Description
* **Summary**
    - The composite pattern describes that a group of objects is to be treated in the same way as a single instance of an object. The intent of a composite is to "compose" objects into tree structures to represent part-whole hierarchies. Implementing the composite pattern lets clients treat individual objects and compositions uniformly
* **Description**
    - When dealing with Tree-structured data, we often have to discriminate between a leaf-node and a branch. This makes code more complex, and therefore, error prone. The solution is an interface that allows treating complex and primitive objects uniformly. In object-oriented programming, a composite is an object designed as a composition of one-or-more similar objects, all exhibiting similar functionality. This is known as a "has-a" relationship between objects.The key concept is that you can manipulate a single instance of the object just as you would manipulate a group of them. The operations you can perform on all the composite objects often have a least common denominator relationship. For example, if defining a system to portray grouped shapes on a screen, it would be useful to define resizing a group of shapes to have the same effect (in some sense) as resizing a single shape.
* **Use**
    - Composite should be used when clients ignore the difference between compositions of objects and individual objects.If programmers find that they are using multiple objects in the same way, and often have nearly identical code to handle each of them, then composite is a good choice; it is less complex in this situation to treat primitives and composites as homogeneous.
    
### C# Example
~~~c#
using System;
using System.Collections.Generic;
 
namespace Composite.Structural
{
  class MainApp
  {
    static void Main()
    {
      // Create a tree structure
      Composite root = new Composite("root");
      root.Add(new Leaf("Leaf A"));
      root.Add(new Leaf("Leaf B"));
 
      Composite comp = new Composite("Composite X");
      comp.Add(new Leaf("Leaf XA"));
      comp.Add(new Leaf("Leaf XB"));
 
      root.Add(comp);
      root.Add(new Leaf("Leaf C"));
 
      // Add and remove a leaf
      Leaf leaf = new Leaf("Leaf D");
      root.Add(leaf);
      root.Remove(leaf);
 
      // Recursively display tree
      root.Display(1);
 
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Component' abstract class
  /// </summary>
  abstract class Component
  {
    protected string name;
 
    // Constructor
    public Component(string name)
    {
      this.name = name;
    }
 
    public abstract void Add(Component c);
    public abstract void Remove(Component c);
    public abstract void Display(int depth);
  }
 
  /// <summary>
  /// The 'Composite' class
  /// </summary>
  class Composite : Component
  {
    private List<Component> _children = new List<Component>();
 
    // Constructor
    public Composite(string name)
      : base(name)
    {
    }
 
    public override void Add(Component component)
    {
      _children.Add(component);
    }
 
    public override void Remove(Component component)
    {
      _children.Remove(component);
    }
 
    public override void Display(int depth)
    {
      Console.WriteLine(new String('-', depth) + name);
 
      // Recursively display child nodes
      foreach (Component component in _children)
      {
        component.Display(depth + 2);
      }
    }
  }
 
  /// <summary>
  /// The 'Leaf' class
  /// </summary>
  class Leaf : Component
  {
    // Constructor
    public Leaf(string name)
      : base(name)
    {
    }
 
    public override void Add(Component c)
    {
      Console.WriteLine("Cannot add to a leaf");
    }
 
    public override void Remove(Component c)
    {
      Console.WriteLine("Cannot remove from a leaf");
    }
 
    public override void Display(int depth)
    {
      Console.WriteLine(new String('-', depth) + name);
    }
  }
}
~~~

### UML Diagram
![Composite Pattern](http://www.dofactory.com/images/diagrams/net/composite.gif "Composite Design Pattern UML Diagram")

