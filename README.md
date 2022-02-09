# KOHL_Aurelien_TP6_ST2TRD

=========================================================
                      EXERCICE 1 : 
=========================================================

1.What is clean code? What is the role played byrefactoringone’s code?

  Good variable naming
  Simple classes and methods
  minimal number of classes
  codes passes all test 

2.Do you think you can “over-refactor”and do too much?How?

  When you’re doing something for the first time, just get it done.
  When you’re doing something similar for the second time, cringe at having to repeat but do the same thing anyway.
  When you’re doing something for the third time, start refactoring.
  

3.What is a code smell? Why should you bother?

  Bloaters : Bloaters are code, methods and classes that have increased to such gargantuan proportions that they are hard to work with. Usually these smells do not crop up right away, rather they accumulate over time as the program evolves (and especially when nobody makes an effort to eradicate them).
  
      Long Method
      Large Class
      Primitive Obsession
      Long Parameter List
      Data Clumps

  Object-Orientation Abusers : All these smells are incomplete or incorrect application of object-oriented programming principles.
  
      Alternative Classes with Different Interfaces
      Refused Bequest
      Switch Statements
      Temporary Field
      
  Change Preventers : These smells mean that if you need to change something in one place in your code, you have to make many changes in other places too. Program development becomes much more complicated and expensive as a result.
  
      Divergent Change
      Parallel Inheritance Hierarchies
      Shotgun Surgery
      
  Dispensables : A dispensable is something pointless and unneeded whose absence would make the code cleaner, more efficient and easier to understand.
  
      Comments
      Duplicate Code
      Data Class
      Dead Code
      Lazy Class
      Speculative Generality
      
  Couplers : All the smells in this group contribute to excessive coupling between classes or show what happens if coupling is replaced by excessive delegation.
  
      Feature Envy
      Inappropriate Intimacy
      Incomplete Library Class
      Message Chains
      Middle Man
  

4.Can you identify a few code smells in the original GuildedRose?

    Long Method : A method contains too many lines of code. Generally, any method longer than ten lines should make you start asking questions.

    Duplicate Code : Two code fragments look almost identical.

    Many conditionals 

    Negativ logic 

    Similar Patterns 

    Poorly formatted   

5.What are some refactoring techniques you could have used in the GuildedRose?
  
  The refactoring techniques are :
  
  Composing Methods
        Extract Method 
        Inline Method 
        Extract Variable 
        Inline Temp 
        Replace Temp with Query 
        Split Temporary Variable 
        Remove Assignments to Parameters 
        Replace Method with Method Object 
        Substitute Algorithm
        
  Moving Features between Objects
        Move Method
        Move Field
        Extract Class
        Inline Class
        Hide Delegate
        Remove Middle Man
        Introduce Foreign Method
        Introduce Local Extension
        
  Organizing Data
        Change Value to Reference
        Change Reference to Value
        Duplicate Observed Data
        Self Encapsulate Field
        Replace Data Value with Object
        Replace Array with Object
        Change Unidirectional Association to Bidirectional
        Change Bidirectional Association to Unidirectional
        Encapsulate Field
        Encapsulate Collection
        Replace Magic Number with Symbolic Constant
        Replace Type Code with Class
        Replace Type Code with Subclasses
        Replace Type Code with State/Strategy
        Replace Subclass with Fields
  
  Simplifying Conditional Expressions
        Consolidate Conditional Expression
        Consolidate Duplicate Conditional Fragments
        Decompose Conditional
        Replace Conditional with Polymorphism
        Remove Control Flag
        Replace Nested Conditional with Guard Clauses
        Introduce Null Object
        Introduce Assertion
  
  Simplifying Method Calls
        Add Parameter
        Remove Parameter
        Rename Method
        Separate Query from Modifier
        Parameterize Method
        Introduce Parameter Object
        Preserve Whole Object
        Remove Setting Method
        Replace Parameter with Explicit Methods
        Replace Parameter with Method Call
        Hide Method
        Replace Constructor with Factory Method
        Replace Error Code with Exception
        Replace Exception with Test

  Dealing with Generalization
        Pull Up Field
        Pull Up Method
        Pull Up Constructor Body
        Push Down Field
        Push Down Method
        Extract Subclass
        Extract Superclass
        Extract Interface
        Collapse Hierarchy
        Form Template Method
        Replace Inheritance with Delegation
        Replace Delegation with Inheritance
  
  For Guilded Roses we can use 
  
  Extract Method : Move the if code to a separate new method (exemple add quality) and replace the old code with a call to the method.
  
  Decompose Conditional : we have a complex conditional (if-then/else) , we can Decompose the complicated parts of the conditional into separate methods: the condition, then and else
  
  Replace Conditional with Polymorphism : we can create a override upgrade method in each subitem , so when we call upgrade, the upgrade are done for each subitem with specific conditions.
  
  Extract Subclass : create subclass for each item type (aged brie, sulfuras, concert tickets ...)
  
  
  
=========================================================
                      EXERCICE 2 : 
=========================================================

1.In simple terms, and a few sentencesat most, what’s a design pattern?

design patern are classic solution to occuring problems in software design, they are pre made solution that can be customized to solve this classic problems.

a.When should you use one?
  when you face one of this specific problem and also when you have a problem with principles of object-oriented design
  
b.When shouldn’t you?
  if it is not necessary, so if simpler code would do just fine.

2.Write  a  small  program  that  build  a pizza  with  various  toppings  using  the builder pattern. Why is this a good idea?Thinkabout scalability for instance


3.Find an original idea to implement a decorator pattern (not the one from the website). Can you think of any limitations?
No need to code here.

4.Write  a  small  program  to  implement  the behavioral design  pattern  of  your  choice. Once again, do not use the examplegiven by the website, but feel free to use them as guidance.
  
