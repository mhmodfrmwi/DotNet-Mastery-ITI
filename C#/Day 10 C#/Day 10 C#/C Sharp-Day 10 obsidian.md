# C# Generics and Collections - Day 10 Study Guide

## Table of Contents

1. [Introduction to Generics](#introduction-to-generics)
2. [Generic Methods](#generic-methods)
3. [Generic Classes](#generic-classes)
4. [Generic Interfaces](#generic-interfaces)
5. [Collections Overview](#collections-overview)
6. [Non-Generic Collections (ArrayList)](#non-generic-collections)
7. [Generic Collections](#generic-collections)
8. [Dictionary and Key-Value Pairs](#dictionary-and-key-value-pairs)

---

## Introduction to Generics

**Generics** allow you to define type-safe data structures without committing to actual data types. They provide:

- **Type Safety**: Compile-time type checking
- **Code Reusability**: Write once, use with multiple types
- **Performance**: No boxing/unboxing for value types
- **Cleaner Code**: Eliminate code duplication

### The Problem Generics Solve

```
Without Generics:
┌─────────────────┐  ┌─────────────────┐  ┌─────────────────┐
│  stackOfint     │  │ stackOfstring   │  │ stackOfDouble   │
│  - int[] arr    │  │ - string[] arr  │  │ - double[] arr  │
│  - push(int)    │  │ - push(string)  │  │ - push(double)  │
│  - int pop()    │  │ - string pop()  │  │ - double pop()  │
└─────────────────┘  └─────────────────┘  └─────────────────┘
     Code             Code                 Code
     Duplication      Duplication          Duplication

With Generics:
┌─────────────────────────┐
│    stack<T>             │
│    - T[] arr            │
│    - push(T item)       │
│    - T pop()            │
└─────────────────────────┘
         │
         ├──> stack<int>
         ├──> stack<string>
         └──> stack<double>
```

---

## Generic Methods

Generic methods allow you to write a method that works with any data type.

### Syntax

```csharp
public void MethodName<T>(T parameter)
{
    // Method body
}
```

### Example: Generic Swap Method

```csharp
public class Operation
{
    // Generic swap method - works with ANY type
    public void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
    
    // Can have multiple type parameters
    public void Display<T1, T2>(T1 first, T2 second)
    {
        Console.WriteLine($"First: {first}, Second: {second}");
    }
}

// Usage
Operation op = new Operation();

// Swapping integers
int a = 5, b = 7;
op.Swap<int>(ref a, ref b);  // Explicit type
op.Swap(ref a, ref b);        // Type inference
Console.WriteLine($"a={a}, b={b}"); // a=7, b=5

// Swapping strings
string x = "Hello", y = "World";
op.Swap(ref x, ref y);
Console.WriteLine($"x={x}, y={y}"); // x=World, y=Hello
```

**Key Points:**

- `<T>` is the type parameter placeholder
- Can use explicit type: `Swap<int>(...)`
- Can use type inference: `Swap(...)`
- Multiple type parameters: `<T1, T2, T3>`

---

## Generic Classes

Generic classes are templates that can work with any data type.

### Evolution from Non-Generic to Generic

#### Before Generics: Separate Stack Classes

```csharp
// Stack for integers only
class StackOfInt
{
    int[] arr;
    int tos;  // top of stack
    
    public StackOfInt(int size = 8)
    {
        arr = new int[size];
        tos = 0;
    }
    
    public void Push(int item)
    {
        if (tos < arr.Length)
            arr[tos++] = item;
        else
            throw new ArgumentOutOfRangeException();
    }
    
    public int Pop()
    {
        if (tos > 0)
            return arr[--tos];
        else
            return 0;
    }
}

// Need separate class for strings!
class StackOfString
{
    string[] arr;
    int tos;
    // ... same code, different type
}
```

#### After Generics: One Stack for All Types

```csharp
class Stack<T>
{
    T[] arr;
    int tos;
    
    public Stack(int size = 8)
    {
        arr = new T[size];
        tos = 0;
    }
    
    public void Push(T item)
    {
        if (tos < arr.Length)
            arr[tos++] = item;
        else
            throw new ArgumentOutOfRangeException();
    }
    
    public T Pop()
    {
        if (tos > 0)
            return arr[--tos];
        else
            return default(T);  // Returns default value for type T
    }
}
```

### Understanding `default(T)`

```
Type          default(T) Value
────────────────────────────────
int           0
double        0.0
bool          false
string        null
DateTime      01/01/0001 00:00:00
object        null
struct        All fields set to default
```

### Using Generic Stack

```csharp
// Stack of integers
Stack<int> intStack = new Stack<int>();
intStack.Push(33);
intStack.Push(25);
intStack.Push(40);
Console.WriteLine(intStack.Pop());  // 40
Console.WriteLine(intStack.Pop());  // 25

// Stack of strings
Stack<string> stringStack = new Stack<string>(10);
stringStack.Push("ali");
stringStack.Push("mostafa");
stringStack.Push("mohamed");
Console.WriteLine(stringStack.Pop());  // mohamed
Console.WriteLine(stringStack.Pop());  // mostafa

// Stack of custom objects
Stack<Student> studentStack = new Stack<Student>(10);
studentStack.Push(new Student(1, "ali", 22));
studentStack.Push(new Student(2, "mohamed", 22));
Console.WriteLine(studentStack.Pop());  // Student: 2-mohamed-22years old
```

### Inheriting from Generic Classes

```csharp
// Option 1: Inherit with specific type
class IntStack : Stack<int>
{
    // This class is now a Stack<int>
}

// Option 2: Inherit and keep it generic
class MyStack<T> : Stack<T>
{
    // This class is still generic
    // Can add additional functionality
}

// Usage
IntStack intStack = new IntStack();
intStack.Push(42);

MyStack<string> stringStack = new MyStack<string>();
stringStack.Push("Hello");
```

---

## Generic Interfaces

Interfaces can also be generic, allowing flexible contracts.

### Syntax and Implementation

```csharp
// Generic interface with two type parameters
interface ITypeA<T1, T2>
{
    T1 Show();
    void Display(T2 x);
}

// Implementation with specific types
class Test : ITypeA<int, float>
{
    public int Show()
    {
        return 42;
    }
    
    public void Display(float x)
    {
        Console.WriteLine($"Float value: {x}");
    }
}

// Generic implementation
class GenericTest<T1, T2> : ITypeA<T1, T2>
{
    public T1 Show()
    {
        return default(T1);
    }
    
    public void Display(T2 x)
    {
        Console.WriteLine($"Value: {x}");
    }
}
```

### Built-in Generic Interface: IComparable

```csharp
class Student : IComparable<Student>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Student(int id = 0, string name = " ", int age = 6)
    {
        Id = id;
        Name = name;
        Age = age;
    }
    
    // Compare students by age
    public int CompareTo(Student other)
    {
        if (other == null) return 1;
        return this.Age.CompareTo(other.Age);
    }
    
    public override string ToString()
    {
        return $"{Id}-{Name}-{Age} years old";
    }
}

// Usage
Student s1 = new Student(1, "Ali", 22);
Student s2 = new Student(2, "Ahmed", 25);
int result = s1.CompareTo(s2);  // -1 (Ali is younger)
```

---

## Collections Overview

Collections are data structures that store and manage groups of objects.

```
C# Collections Hierarchy
═══════════════════════════════════════════
┌─────────────────────────────────────────┐
│         System.Collections              │
│         (Non-Generic)                   │
│  ┌──────────┐  ┌──────────┐            │
│  │ArrayList │  │Hashtable │  etc.      │
│  └──────────┘  └──────────┘            │
└─────────────────────────────────────────┘
                    │
                    ▼
┌─────────────────────────────────────────┐
│    System.Collections.Generic           │
│         (Generic - Preferred)           │
│  ┌──────┐  ┌────────────┐  ┌─────────┐ │
│  │List<T>│  │Dictionary  │  │Queue<T> │ │
│  └──────┘  │<TKey,TValue>│  └─────────┘ │
│            └────────────┘               │
└─────────────────────────────────────────┘
```

---

## Non-Generic Collections

### ArrayList - Dynamic Array (Avoid in Modern Code)

```csharp
using System.Collections;

ArrayList list = new ArrayList(10) { 1, 2, 3, 44, "ali", 33, 66 };

// Adding elements
list.Add(5);
list.Add("string");
list.AddRange(new int[] { 4, 5, 6 });

// Accessing elements
Console.WriteLine(list[2]);  // Returns object type
int x = (int)list[2];        // Requires casting

// Modification
list[3] = 55;

// Removing elements
list.Remove(3);           // Removes first occurrence of 3
list.RemoveAt(7);         // Removes element at index 7
list.RemoveRange(4, 3);   // Removes 3 elements starting at index 4

// Properties
Console.WriteLine(list.Capacity);  // Current capacity
Console.WriteLine(list.Count);     // Number of elements

// Iteration
foreach (object obj in list)
{
    Console.WriteLine(obj);
}
```

**Problems with ArrayList:**

```
┌─────────────────────────────────────────┐
│  ArrayList Issues                       │
├─────────────────────────────────────────┤
│  ❌ No Type Safety                      │
│     Can add ANY type to same list      │
│                                         │
│  ❌ Boxing/Unboxing                     │
│     Performance overhead for value     │
│     types (int, double, etc.)          │
│                                         │
│  ❌ Runtime Errors                      │
│     Casting errors only caught at      │
│     runtime, not compile time          │
└─────────────────────────────────────────┘
```

---

## Generic Collections

### List<T> - Type-Safe Dynamic Array

```csharp
using System.Collections.Generic;

// List of integers
List<int> numbers = new List<int>() { 1, 55, 4, 3 };
numbers.Add(44);
numbers.Add(55);
numbers.Remove(55);  // Removes first occurrence

Console.WriteLine($"Count: {numbers.Count}");
Console.WriteLine($"Capacity: {numbers.Capacity}");

foreach (int num in numbers)
{
    Console.WriteLine(num);
}
```

### List<T> vs ArrayList Comparison

```
┌────────────────────┬────────────────────┐
│    ArrayList       │      List<T>       │
├────────────────────┼────────────────────┤
│ object type        │ Type-safe          │
│ Requires casting   │ No casting needed  │
│ Boxing/Unboxing    │ No boxing          │
│ Runtime errors     │ Compile-time check │
│ Slower             │ Faster             │
└────────────────────┴────────────────────┘
```

### Working with Custom Objects

```csharp
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Student(int id = 0, string name = " ", int age = 6)
    {
        Id = id;
        Name = name;
        Age = age;
    }
    
    public override string ToString()
    {
        return $"{Id}-{Name}-{Age} years old";
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, Age);
    }
    
    public override bool Equals(object obj)
    {
        Student s = obj as Student;
        if (s == null) return false;
        return (Id == s.Id && Name == s.Name && Age == s.Age);
    }
}

// Using List<Student>
List<Student> students = new List<Student>()
{
    new Student(1, "ali", 22),
    new Student(2, "aya", 22),
    new Student(3, "mostafa", 22),
    new Student(4, "salem", 22),
};

students.RemoveAt(2);  // Remove by index
students.Remove(new Student(3, "mostafa", 22));  // Remove by value (uses Equals)

foreach (Student student in students)
{
    Console.WriteLine(student);
}
```

### Custom List Class

```csharp
class StudentList : List<Student>
{
    // Override Add to add custom behavior
    public new void Add(Student item)
    {
        base.Add(item);
        Console.WriteLine($"Added: {item}");
    }
    
    // Custom ToString for the entire list
    public override string ToString()
    {
        string txt = "";
        foreach (Student st in this)
        {
            txt += st + "\n";
        }
        return txt;
    }
}

// Usage
StudentList students = new StudentList()
{
    new Student(1, "ali", 22),
    new Student(2, "aya", 22),
    new Student(3, "mostafa", 22),
};

students.Add(new Student(7, "testuser", 20));
Console.WriteLine(students);  // Prints all students
```

---

## Dictionary and Key-Value Pairs

### Dictionary<TKey, TValue> - Hash Table

Dictionary stores data as key-value pairs, providing fast lookups.

```
Dictionary Structure:
┌─────────┬──────────────────────┐
│   Key   │       Value          │
├─────────┼──────────────────────┤
│ "ahmed" │ "3 djjdjd jdjdj..."  │
│ "ali"   │ "2 djjdjd jdjdj..."  │
│ "john"  │ "5 dhdhdh hdhdh..."  │
└─────────┴──────────────────────┘
         Fast O(1) lookup
```

### Basic Dictionary Usage

```csharp
Dictionary<string, string> phoneBook = new Dictionary<string, string>();

// Adding entries
phoneBook.Add("ahmed ali", "3 djjdjd jdjdj jdjdj");
phoneBook.Add("ali mohamed", "2 djjdjd jdjdj jdjdj");
phoneBook.Add("ahmed mamdouh", "1 djjdjd jdjdj jdjdj");

// Alternative syntax for adding/updating
phoneBook["abd elrahman salah"] = "5 dhdhdh hdhdh hdhdh";
phoneBook["ahmed mamdouh"] = "7 dhdhdh hdhdh hdhdh";  // Updates existing

// Accessing values
Console.WriteLine(phoneBook["ali mohamed"]);

// Removing entries
phoneBook.Remove("abd elrahman salah");

// Iterating through dictionary
foreach (KeyValuePair<string, string> entry in phoneBook)
{
    Console.WriteLine($"Name: {entry.Key}");
    Console.WriteLine($"Phone: {entry.Value}");
}

// Iterate only keys
foreach (string name in phoneBook.Keys)
{
    Console.WriteLine(name);
}

// Iterate only values
foreach (string phone in phoneBook.Values)
{
    Console.WriteLine(phone);
}
```

### Complex Dictionary Example

Storing students with their enrolled subjects:

```csharp
class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Duration { get; set; }
    
    public Subject(int id = 0, string name = " ", int duration = 6)
    {
        Id = id;
        Name = name;
        Duration = duration;
    }
    
    public override string ToString()
    {
        return $"{Id}-{Name}-{Duration} Hours";
    }
}

// Dictionary of Student -> List of Subjects
Dictionary<Student, List<Subject>> enrollment = new Dictionary<Student, List<Subject>>();

// Shared subjects list
List<Subject> commonSubjects = new List<Subject>() 
{
    new Subject(3, "C#", 60),
    new Subject(2, "DS", 24),
    new Subject(5, "DB", 30)
};

// Adding students with their subjects
enrollment.Add(
    new Student(1, "ali", 22), 
    new List<Subject>() 
    {
        new Subject(3, "C#", 60),
        new Subject(2, "DS", 24),
        new Subject(5, "DB", 30),
    }
);

enrollment.Add(new Student(2, "ahmed", 33), commonSubjects);
enrollment.Add(new Student(3, "mostafa", 33), commonSubjects);

// Display all students and their subjects
foreach (KeyValuePair<Student, List<Subject>> entry in enrollment)
{
    Console.WriteLine($"\n{entry.Key}");
    Console.WriteLine("Enrolled in:");
    foreach (Subject subject in entry.Value)
    {
        Console.WriteLine($"  - {subject}");
    }
}
```

**Output:**

```
1-ali-22 years old
Enrolled in:
  - 3-C#-60 Hours
  - 2-DS-24 Hours
  - 5-DB-30 Hours

2-ahmed-33 years old
Enrolled in:
  - 3-C#-60 Hours
  - 2-DS-24 Hours
  - 5-DB-30 Hours

3-mostafa-33 years old
Enrolled in:
  - 3-C#-60 Hours
  - 2-DS-24 Hours
  - 5-DB-30 Hours
```

---

## Key Concepts Summary

### When to Use What

```
┌───────────────────────────────────────────────┐
│  ArrayList                                    │
│  ❌ Avoid - Use List<T> instead              │
└───────────────────────────────────────────────┘

┌───────────────────────────────────────────────┐
│  List<T>                                      │
│  ✅ Use when:                                 │
│    - Need ordered collection                  │
│    - Access by index                          │
│    - Can have duplicates                      │
└───────────────────────────────────────────────┘

┌───────────────────────────────────────────────┐
│  Dictionary<TKey, TValue>                     │
│  ✅ Use when:                                 │
│    - Need key-value pairs                     │
│    - Fast lookup by key                       │
│    - Keys must be unique                      │
└───────────────────────────────────────────────┘
```

### Override Methods Importance

For custom objects in collections:

1. **ToString()** - For readable output
2. **GetHashCode()** - For hash-based collections (Dictionary, HashSet)
3. **Equals()** - For comparison operations (Remove, Contains)

---

## Practice Exercises

### Exercise 1: Generic Method

Create a generic method `FindMax<T>` that finds the maximum element in an array.

### Exercise 2: Generic Queue

Implement a generic `Queue<T>` class with `Enqueue()` and `Dequeue()` methods.

### Exercise 3: Student Management

Create a student management system using:

- `List<Student>` for storing students
- `Dictionary<int, Student>` for quick lookup by ID
- Methods to add, remove, and search students

### Exercise 4: Inventory System

Build an inventory system using `Dictionary<string, int>` where:

- Key: Product name
- Value: Quantity in stock

---

## Important Notes

⚠️ **Remember:**

- Generic collections (`List<T>`, `Dictionary<TKey,TValue>`) are **always preferred** over non-generic collections
- Always override `Equals()` and `GetHashCode()` for custom objects used as dictionary keys
- `default(T)` returns the default value for type T
- Dictionary keys must be **unique**
- List allows **duplicates**, Dictionary keys do not

---

## Additional Resources

- Microsoft Docs: [Generics in C#](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/)
- Microsoft Docs: [Collections](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections)

---

_Study Tip: Practice implementing each generic class and collection type yourself to solidify understanding!_