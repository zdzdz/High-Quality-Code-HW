# Specification

### Short Description
* **Summary**
    - The specification pattern is a particular software design pattern, whereby business rules can be recombined by chaining the business rules together using boolean logic.
* **Description**
    - A specification pattern outlines a business rule that is combinable with other business rules. In this pattern, a unit of business logic inherits its functionality from the abstract aggregate Composite Specification class. The Composite Specification class has one function called IsSatisfiedBy that returns a boolean value. After instantiation, the specification is "chained" with other specifications, making new specifications easily maintainable, yet highly customizable business logic. Furthermore upon instantiation the business logic may, through method invocation or inversion of control, have its state altered in order to become a delegate of other classes such as a persistence repository.
    
### C# Example
~~~c#
namespace Specification.Behavioral
{
  public interface ISpecification
  {
    bool IsSatisfiedBy(object candidate);
    ISpecification And(ISpecification other);
    ISpecification Or(ISpecification other);
    ISpecification Not();
  }

  public abstract class CompositeSpecification : ISpecification 
  {
    public abstract bool IsSatisfiedBy(object candidate);

    public ISpecification And(ISpecification other) 
    {
        return new AndSpecification(this, other);
    }

    public ISpecification Or(ISpecification other) 
    {
        return new OrSpecification(this, other);
    }

    public ISpecification Not() 
    {
       return new NotSpecification(this);
    }
  }

  public class AndSpecification : CompositeSpecification 
  {
    private ISpecification One;
    private ISpecification Other;

    public AndSpecification(ISpecification x, ISpecification y) 
    {
        One = x;
        Other = y;
    }

    public override bool IsSatisfiedBy(object candidate) 
    {
        return One.IsSatisfiedBy(candidate) && Other.IsSatisfiedBy(candidate);
    }
  }

  public class OrSpecification : CompositeSpecification
  {
    private ISpecification One;
    private ISpecification Other;

    public OrSpecification(ISpecification x, ISpecification y) 
    {
        One = x;
        Other = y;
    }

    public override bool IsSatisfiedBy(object candidate) 
    {
        return One.IsSatisfiedBy(candidate) || Other.IsSatisfiedBy(candidate);
    }
  }

  public class NotSpecification : CompositeSpecification 
  {
    private ISpecification Wrapped;

    public NotSpecification(ISpecification x) 
    {
        Wrapped = x;
    }

    public override bool IsSatisfiedBy(object candidate) 
    {
        return !Wrapped.IsSatisfiedBy(candidate);
    }
  }
}
~~~

### UML Diagram
![Specification Pattern](http://blog.xebia.fr/wp-content/uploads/2009/12/pattern-specification.png "Specification Design Pattern UML Diagram")