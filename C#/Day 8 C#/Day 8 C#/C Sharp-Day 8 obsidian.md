# C# Inheritance and Polymorphism - Day 8 Lecture

## Table of Contents

1. [Overview](#overview)
2. [Class Hierarchy](#class-hierarchy)
3. [Key Concepts](#key-concepts)
4. [Detailed Code Analysis](#detailed-code-analysis)
5. [Polymorphism Examples](#polymorphism-examples)
6. [Important Keywords](#important-keywords)
7. [Practice Exercises](#practice-exercises)

---

## Overview

This lecture covers **Object-Oriented Programming (OOP)** in C#, specifically:

- **Inheritance**: Creating class hierarchies
- **Polymorphism**: Objects taking multiple forms
- **Method Overriding**: Changing inherited behavior
- **Method Hiding**: Creating new implementations
- **Constructor Chaining**: Passing values through inheritance levels

---

## Class Hierarchy

```
┌─────────────┐
│   parent    │
│             │
│ - int z     │
│ + int x     │
│ + show()    │
└──────┬──────┘
       │
       │ inherits
       ▼
┌─────────────┐
│   child     │
│             │
│ + int y     │
│ + show()    │ (overrides)
└──────┬──────┘
       │
       │ inherits
       ▼
┌─────────────┐
│  subchild   │
│             │
│ + int a     │
│ + show()    │ (hides)
└─────────────┘
```

**Relationship**: `subchild` IS-A `child` IS-A `parent`

---

## Key Concepts

### 1. Inheritance Basics

**Inheritance** allows a class to inherit members (properties, methods) from another class.

**Syntax:**

```csharp
class ChildClass : ParentClass
{
    // Additional members
}
```

**Benefits:**

- Code reusability
- Establishes IS-A relationship
- Enables polymorphism

---

### 2. Access Modifiers

|Modifier|Visibility|
|---|---|
|`public`|Accessible everywhere|
|`private`|Only within the same class|
|`protected`|Within class and derived classes|

**In the lecture:**

- `z` is **private** (accessible only in `parent`)
- `x` and `y` are **public** (accessible everywhere)

---

### 3. Constructor Chaining with `base`

Constructor chaining passes initialization from child to parent.

```
subchild(1,2,3,4)
       │
       └──> calls base(1,2,3)
                   │
                   └──> calls base(3)
                              │
                              └──> initializes z=3
```

**Code Example:**

```csharp
public child(int x, int y, int z) : base(z)  // Calls parent(int z)
{
    this.x = x;
    this.y = y;
}
```

---

## Detailed Code Analysis

### Parent Class

```csharp
class parent
{
    int z;                    // Private field
    public int x { get; set; } // Auto-property

    public parent() { }       // Default constructor
    
    public parent(int z)      // Parameterized constructor
    {
        this.z = z;
    }
    
    public virtual void show() // Virtual method (can be overridden)
    {
        Console.WriteLine($"x={x}, z={z}");
    }
}
```

**Key Points:**

- `virtual` keyword allows method to be **overridden** in derived classes
- `z` is private, so child classes cannot directly access it

---

### Child Class

```csharp
class child : parent
{
    public int y { get; set; }
    
    public child(int x, int y, int z) : base(z) // Calls parent(z)
    {
        this.x = x;  // Sets inherited property
        this.y = y;
    }
    
    public override void show() // Overrides parent's show()
    {
        base.show();  // Calls parent's show() first
        Console.WriteLine($"y={y}");
    }
}
```

**Key Points:**

- `override` keyword replaces parent's virtual method
- `base.show()` calls parent's implementation
- Inherits `x` from parent, adds new property `y`

---

### Subchild Class

```csharp
class subchild : child
{
    public int a { get; set; }
    
    public subchild(int x, int y, int z, int a) : base(x, y, z)
    {
        this.a = a;
    }
    
    public new void show() // Hides child's show() method
    {
        base.show();  // Calls child's show()
        Console.WriteLine($"a={a}");
    }
}
```

**Key Points:**

- `new` keyword **hides** the inherited method (not override)
- Creates a completely new method
- Still can call parent's version with `base.show()`

---

## Polymorphism Examples

### What is Polymorphism?

**Polymorphism** means "many forms" - a parent reference can point to child objects.

```
┌──────────────────────────────────────┐
│  parent p = new child(1,2,3);        │
│                                       │
│  Reference Type: parent               │
│  Object Type: child                   │
└──────────────────────────────────────┘
```

---

### Example 1: Basic Polymorphism

```csharp
parent p = new child(3, 4, 5);
p.show();
```

**Output:**

```
x=3, z=5
y=4
```

**Why?**

- Reference type is `parent`
- Actual object is `child`
- Since `show()` is **overridden**, child's version executes
- This is **runtime polymorphism**

---

### Example 2: Display Method (Polymorphic Parameter)

```csharp
static void display(parent p)
{
    p.show();
}

// Usage:
display(new parent(1));
display(new child(1, 2, 3));
display(new subchild(1, 2, 3, 4));
```

**Explanation:**

```
┌─────────────────────────────────────────┐
│ display(new parent(1))                  │
│ → Calls parent.show()                   │
│ → Output: x=0, z=1                      │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ display(new child(1, 2, 3))             │
│ → Calls child.show() (override)         │
│ → Output: x=1, z=3                      │
│           y=2                            │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ display(new subchild(1, 2, 3, 4))       │
│ → Calls child.show() (NOT subchild!)    │
│ → Output: x=1, z=3                      │
│           y=2                            │
└─────────────────────────────────────────┘
```

**Important:** For `subchild`, only `child.show()` is called because `subchild` uses `new` (method hiding), not `override`.

---

### Override vs New - Critical Difference

```
┌─────────────────────────────────────────────────┐
│              OVERRIDE (Runtime Binding)         │
├─────────────────────────────────────────────────┤
│  parent p = new child(1,2,3);                   │
│  p.show(); → Calls child.show()                 │
│                                                  │
│  ✓ Virtual table lookup at runtime              │
│  ✓ Calls most derived override                  │
└─────────────────────────────────────────────────┘

┌─────────────────────────────────────────────────┐
│              NEW (Compile-time Binding)         │
├─────────────────────────────────────────────────┤
│  parent p = new subchild(1,2,3,4);              │
│  p.show(); → Calls child.show() (NOT subchild!) │
│                                                  │
│  ✓ Reference type determines method             │
│  ✓ Does NOT participate in polymorphism         │
└─────────────────────────────────────────────────┘
```

---

## Important Keywords

### 1. `virtual`

- Declared in **base class**
- Allows method to be overridden
- Enables runtime polymorphism

```csharp
public virtual void show() { }
```

---

### 2. `override`

- Declared in **derived class**
- Replaces base class virtual method
- Participates in polymorphism

```csharp
public override void show() { }
```

---

### 3. `new`

- Hides inherited member
- Creates new method with same name
- Does NOT participate in polymorphism

```csharp
public new void show() { }
```

---

### 4. `base`

- Calls parent class constructor or method
- Used for constructor chaining
- Access parent's implementation

```csharp
base.show();      // Call parent's method
: base(z)         // Call parent's constructor
```

---

### 5. `sealed`

- Prevents inheritance (commented in code)
- Makes class final

```csharp
sealed class test { }
// class b : test { } ❌ Error!
```

---

## Practice Exercises

### Exercise 1: Predict the Output

```csharp
parent p1 = new parent(10);
p1.x = 5;
p1.show();
```

**Answer:**

```
x=5, z=10
```

---

### Exercise 2: What happens here?

```csharp
child c = new child(1, 2, 3);
c.show();
```

**Answer:**

```
x=1, z=3
y=2
```

---

### Exercise 3: Polymorphism Challenge

```csharp
parent p = new subchild(10, 20, 30, 40);
p.show();
```

**Answer:**

```
x=10, z=30
y=20
```

**Why not showing `a=40`?**

- Reference type is `parent`
- `subchild.show()` uses `new`, not `override`
- Only `child.show()` executes (last override in chain)

---

## Summary Table

|Concept|Keyword|Behavior|
|---|---|---|
|Allow override|`virtual`|Base class method can be replaced|
|Replace method|`override`|Derived class replaces base method|
|Hide method|`new`|Derived class creates new method|
|Call parent|`base`|Access parent's members|
|Prevent inheritance|`sealed`|Class cannot be inherited|

---

## Complete Working Implementation

```csharp
using System;

namespace Day8
{
    class parent
    {
        private int z;
        public int x { get; set; }
        
        public parent() { }
        
        public parent(int z)
        {
            this.z = z;
        }
        
        public virtual void show()
        {
            Console.WriteLine($"x={x}, z={z}");
        }
    }

    class child : parent
    {
        public int y { get; set; }
        
        public child(int x, int y, int z) : base(z)
        {
            this.x = x;
            this.y = y;
        }
        
        public override void show()
        {
            base.show();
            Console.WriteLine($"y={y}");
        }
    }
    
    class subchild : child
    {
        public int a { get; set; }
        
        public subchild(int x, int y, int z, int a) : base(x, y, z)
        {
            this.a = a;
        }
        
        public new void show()
        {
            base.show();
            Console.WriteLine($"a={a}");
        }
    }
    
    class Program
    {
        static void display(parent p)
        {
            p.show();
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("=== Test 1: parent object ===");
            display(new parent(1));
            
            Console.WriteLine("\n=== Test 2: child object ===");
            display(new child(1, 2, 3));
            
            Console.WriteLine("\n=== Test 3: subchild object ===");
            display(new subchild(1, 2, 3, 4));
            
            Console.WriteLine("\n=== Test 4: Direct subchild call ===");
            subchild s = new subchild(10, 20, 30, 40);
            s.show();
        }
    }
}
```

**Expected Output:**

```
=== Test 1: parent object ===
x=0, z=1

=== Test 2: child object ===
x=1, z=3
y=2

=== Test 3: subchild object ===
x=1, z=3
y=2

=== Test 4: Direct subchild call ===
x=10, z=30
y=20
a=40
```

---

## Key Takeaways

✅ **Inheritance** creates IS-A relationships  
✅ **virtual/override** enables runtime polymorphism  
✅ **new** hides methods (compile-time binding)  
✅ **base** accesses parent class members  
✅ Constructor chaining passes initialization up the hierarchy  
✅ Reference type vs Object type determines which method executes

---

_Study this guide thoroughly and run the code examples to understand inheritance and polymorphism in C#!_