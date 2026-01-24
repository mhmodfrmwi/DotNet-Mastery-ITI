
# Day 5: C# Advanced Concepts - Parameter Passing & Exception Handling

## Table of Contents

1. [[#Parameter Passing Mechanisms]]
2. [[#Method Overloading & Parameters]]
3. [[#Exception Handling]]
4. [[#Custom Exceptions]]

---

## Parameter Passing Mechanisms

### Overview

C# provides different ways to pass parameters to methods, each affecting how data is transferred and modified.

### 1. Pass by Value (Default)

```mermaid
graph LR
    A[Original Variable<br/>a = 5] -->|Copy Value| B[Method Parameter<br/>x = 5]
    B -->|Swap Operation| C[x = 7]
    A -.->|No Change| D[a = 5<br/>Still Original]
    
    style A fill:#e1f5ff
    style D fill:#e1f5ff
    style B fill:#fff4e1
    style C fill:#fff4e1
```

**Commented Out Code Example:**

```csharp
public void swap(int x , int y)
{
    int temp = x;
    x = y;
    y = temp;
}
// ❌ This DOESN'T work - changes only affect copies
```

**Why it fails:** The method receives **copies** of the original values. Changes inside the method don't affect the original variables.

---

### 2. Pass by Reference (`ref`)

```mermaid
graph LR
    A[Original Variable<br/>a = 5] -->|Reference| B[Method Parameter<br/>ref x]
    B -->|Points to same memory| A
    B -->|Swap Operation| C[a = 7<br/>b = 5]
    
    style A fill:#c8e6c9
    style B fill:#c8e6c9
    style C fill:#a5d6a7
```

**Working Code Example:**

```csharp
public void swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}

// Usage:
int a = 5, b = 7;
op.swap(ref a, ref b);
// ✅ Result: a = 7, b = 5
```

**Key Points:**

- Variable **must be initialized** before passing
- Changes affect the **original variable**
- Use `ref` keyword at both **declaration and call site**
- Works with **value types** (int, double) and **reference types** (arrays, objects)

#### Reference Type Behavior with Arrays

```mermaid
graph TB
    subgraph "Array Reference Swap"
        A1["Before: a → {1,2,3}<br/>b → {5,6,7}"]
        A2["After: a → {5,6,7}<br/>b → {1,2,3}"]
        A1 -.->|swap references| A2
    end
    
    subgraph "Array Content Modification"
        C1["arr → {1,2,3}"]
        C2["arr → {2,3,4}"]
        C1 -->|modify elements| C2
    end
    
    style A2 fill:#ffeb3b
    style C2 fill:#4caf50
```

**Array Swap Example:**

```csharp
int[] a = { 1, 2, 3 };
int[] b = { 5, 6, 7 };
op.swap(ref a, ref b);
// Result: a = {5,6,7}, b = {1,2,3}
```

**Array Content Modification Example:**

```csharp
public void increase(int[] x)
{
    for (int i = 0; i < x.Length; i++) 
        x[i]++;
}

int[] a = { 1, 2, 3 };
op.increase(a);
// Result: a = {2,3,4} - Changed without ref because array is reference type
```

---

### 3. Output Parameters (`out`)

```mermaid
graph TD
    A[Method Call] --> B[out mul]
    A --> C[out sub]
    B --> D[Must be assigned<br/>before return]
    C --> D
    D --> E[Values returned<br/>to caller]
    
    style B fill:#f8bbd0
    style C fill:#f8bbd0
    style E fill:#c5e1a5
```

**Code Example:**

```csharp
public int calc(int x, int y, out int mul, out int sub, in int z)
{
    mul = x * y;  // ✅ Must assign before return
    sub = x - y;  // ✅ Must assign before return
    return x + y;
}

// Usage:
int s, m, sub;
s = op.calc(7, 3, out m, out sub, in someValue);
// Result: s = 10, m = 21, sub = 4
```

**Comparison Table:**

|Feature|`ref`|`out`|
|---|---|---|
|**Initialization Required**|✅ Yes, before passing|❌ No|
|**Assignment Required**|❌ No|✅ Yes, before return|
|**Use Case**|Modify existing value|Return multiple values|
|**Reading Before Assignment**|✅ Allowed|❌ Not allowed|

---

### 4. Read-Only Reference (`in`)

```csharp
public int calc(int x, int y, out int mul, out int sub, in int z)
{
    // z is read-only
    // z = 10; ❌ Compilation error
    return x + y + z;
}
```

**Purpose:** Pass by reference for **performance** (avoid copying large structs) while **preventing modification**.

**When to Use:**

- Passing large structs (e.g., custom structures with many fields)
- Want efficiency of `ref` but safety of pass-by-value
- Ensuring the method doesn't accidentally modify the parameter

---

## Method Overloading & Parameters

### 1. Default Parameter Values

```mermaid
graph TD
    A[Method Call] --> B{How many<br/>arguments?}
    B -->|2 args| C[sum 1, 2]
    B -->|3 args| D[sum 1, 2, 3]
    B -->|4 args| E[sum 1, 2, 3, 4]
    C --> F[z=0, a=0<br/>defaults used]
    D --> G[a=0<br/>default used]
    E --> H[No defaults<br/>needed]
    
    style F fill:#ffe0b2
    style G fill:#ffe0b2
```

**Code Example:**

```csharp
public int sum(int x, int y, int z=0, int a=0)
{
    return x + y + z + a;  
}

// Usage:
sum(1, 2)       // Returns 3  (z=0, a=0)
sum(1, 2, 3)    // Returns 6  (a=0)
sum(1, 2, 3, 4) // Returns 10
```

**Rules:**

- Default parameters must be **at the end**
- Once you add a default, **all following parameters** must have defaults
- Can't have: `int sum(int x=0, int y)` ❌

**Employee Constructor Example:**

```csharp
public employee(int _id=0, string _name="", int _age=6)
{
    id = _id;
    name = _name;
    age = _age;
}

employee em1 = new employee(1, "ali", 22);  // All specified
employee em2 = new employee();              // All defaults
employee em3 = new employee(1);             // Only id specified
employee em4 = new employee(1, "ali");      // id and name specified
```

---

### 2. Named Parameters

```csharp
employee em5 = new employee(_name:"ali");           // Only name
employee em6 = new employee(_age:6);                // Only age
employee em7 = new employee(_age:6, _name:"mostafa"); // Any order
employee em8 = new employee(_age:5, _id:4);         // Any order
employee em9 = new employee(_name:"ali", _id:4);    // Any order
```

**Benefits:**

- Skip parameters with defaults
- **Any order** when all are named
- Improves code **readability**
- Avoid confusion with many parameters

```mermaid
graph LR
    A[Constructor Call] --> B[_name: ali]
    A --> C[_age: 6]
    A --> D[_id: 4]
    B --> E[Can specify<br/>in any order]
    C --> E
    D --> E
    
    style E fill:#b2dfdb
```

**Rules for Named Parameters:**

- Can mix positional and named
- Once you use named, all following must be named
- Example: `sum(1, 2, a:5)` ✅ - Positional then named
- Example: `sum(x:1, 2)` ❌ - Can't go back to positional after named

---

### 3. Params Keyword (Variable Arguments)

```csharp
public int sum(params int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

// Usage - Both work identically:
int s = op.sum(new int[] { 1, 2, 3, 4, 5 });
int s = op.sum(1, 2, 3, 4, 5, 33, 44, 55);
```

```mermaid
graph TD
    A[Method Call with<br/>Variable Args] --> B[params int arr]
    B --> C[Automatically<br/>creates array]
    C --> D[1, 2, 3, 4, 5...]
    D --> E[Process as<br/>normal array]
    
    style C fill:#dcedc8
```

**Key Points:**

- Must be the **last parameter**
- Only **one params** parameter per method
- Can pass **zero or more** arguments
- Compiler creates array automatically

**Examples:**

```csharp
op.sum()                    // Valid - empty array
op.sum(5)                   // Valid - array with one element
op.sum(1, 2, 3, 4, 5)       // Valid - array with five elements
op.sum(new int[]{1,2,3})    // Valid - explicit array
```

---

## Exception Handling

### Exception Hierarchy

```mermaid
graph TD
    A[Exception<br/>Base Class] --> B[SystemException]
    A --> C[ApplicationException]
    B --> D[FormatException]
    B --> E[DivideByZeroException]
    B --> F[NullReferenceException]
    B --> G[IndexOutOfRangeException]
    C --> H[InvalidAgeException<br/>Custom]
    
    style A fill:#ef5350
    style H fill:#ffa726
```

**Common Exception Types:**

|Exception|When It Occurs|Example|
|---|---|---|
|**FormatException**|Invalid string conversion|`int.Parse("abc")`|
|**DivideByZeroException**|Division by zero|`100 / 0`|
|**NullReferenceException**|Accessing null object|`string s = null; s.Length`|
|**IndexOutOfRangeException**|Invalid array index|`arr[100]` when arr length is 10|
|**ArgumentNullException**|Null argument passed|Method receives null when not expected|

---

### Try-Catch-Finally Structure

```mermaid
graph TD
    A[Start] --> B[Try Block]
    B -->|No Exception| C[Finally Block]
    B -->|Exception Occurs| D{Which Exception?}
    D -->|FormatException| E[Catch 1]
    D -->|DivideByZeroException| F[Catch 2]
    D -->|Other| G[Catch General]
    E --> C
    F --> C
    G --> C
    C --> H[End]
    
    style B fill:#81c784
    style E fill:#ffb74d
    style F fill:#ffb74d
    style G fill:#ffb74d
    style C fill:#64b5f6
```

**Structure:**

- **Try Block**: Code that might throw an exception
- **Catch Block(s)**: Handle specific exceptions
- **Finally Block**: Always executes (cleanup code)

---

### Code Example with Multiple Catch Blocks

```csharp
try
{
    Console.WriteLine("enter number");
    int n = int.Parse(Console.ReadLine());
    int r = 100 / n;
    Console.WriteLine(r);
}
catch(FormatException ex)
{
    Console.WriteLine("invalid value");
}
catch(DivideByZeroException ex)
{
    Console.WriteLine("invalid operation: divide by zero");
}
catch(Exception ex)
{
    // Logging error
    Console.WriteLine(ex.InnerException);
    Console.WriteLine($"{DateTime.Now} \t {ex.Message} \t {ex.Source} \t {ex.StackTrace}");
}
finally
{
    Console.WriteLine("finally");
}
```

**Execution Flow Table:**

|Input|Exception Type|Caught By|Output|Finally Executes?|
|---|---|---|---|---|
|"abc"|FormatException|Catch 1|"invalid value"|✅ Yes|
|"0"|DivideByZeroException|Catch 2|"invalid operation..."|✅ Yes|
|"5"|None|-|"20"|✅ Yes|
|null|ArgumentNullException|Catch 3|Exception details|✅ Yes|

**Important Rules:**

1. **Order matters**: Catch specific exceptions before general `Exception`
2. **Finally always runs**: Even if exception occurs or not
3. **One catch executes**: Once caught, other catch blocks are skipped

---

### Exception Properties

```mermaid
graph LR
    A[Exception Object] --> B[Message<br/>Error description]
    A --> C[Source<br/>Application name]
    A --> D[StackTrace<br/>Call stack]
    A --> E[InnerException<br/>Nested exception]
    
    style A fill:#ce93d8
    style B fill:#f3e5f5
    style C fill:#f3e5f5
    style D fill:#f3e5f5
    style E fill:#f3e5f5
```

**Properties Explained:**

|Property|Description|Example|
|---|---|---|
|**Message**|Human-readable error description|"Input string was not in a correct format."|
|**Source**|Name of application/assembly|"Day5"|
|**StackTrace**|Method call sequence leading to error|"at Day5.Program.Main(String[] args) in..."|
|**InnerException**|Original exception if this is a wrapper|The underlying exception that caused this one|

**Logging Example:**

```csharp
catch(Exception ex)
{
    string logEntry = $"{DateTime.Now} \t {ex.Message} \t {ex.Source} \t {ex.StackTrace}";
    // Save to file or database for debugging
}
```

---

## Custom Exceptions

### Creating Custom Exception Class

```csharp
class InvalidAgeException : Exception
{
    public int agevalue { get; set; }
    
    public InvalidAgeException(int age)
        : base("error: invalid age, age must be between 20 and 60")
    {
        agevalue = age;
    }
}
```

```mermaid
classDiagram
    Exception <|-- InvalidAgeException
    
    class Exception {
        +string Message
        +string Source
        +string StackTrace
        +Exception InnerException
    }
    
    class InvalidAgeException {
        +int agevalue
        +InvalidAgeException(int age)
    }
```

**Key Components:**

1. **Inherit from Exception**: `class InvalidAgeException : Exception`
2. **Call base constructor**: `: base("error message")`
3. **Add custom properties**: `public int agevalue { get; set; }`
4. **Store context data**: Save the invalid age value for debugging

---

### Using Custom Exception in Property

```csharp
class employee
{
    public int id { get; set; }
    public string name { get; set; }
    int age;
    
    public int Age
    {
        set
        {
            if (value > 20 && value < 60)
                age = value;
            else
                throw new InvalidAgeException(value);
        }
        get
        {
            return age;
        }
    }
}
```

**Property Validation Pattern:**

- Use **properties** to encapsulate validation logic
- **Throw custom exceptions** when validation fails
- Provide **meaningful error messages** to users

**Usage:**

```csharp
try
{
    employee em = new employee() { id = 1, name = "ali", Age = 18 };
}
catch(InvalidAgeException ex)
{
    Console.WriteLine(ex.agevalue); // Outputs: 18
    Console.WriteLine(ex.Message);   // Outputs: error: invalid age...
}
```

---

### Custom Exception Flow

```mermaid
sequenceDiagram
    participant Client
    participant Employee
    participant InvalidAgeException
    
    Client->>Employee: Set Age = 18
    Employee->>Employee: Validate: 18 > 20 && 18 < 60?
    Employee->>InvalidAgeException: throw new InvalidAgeException(18)
    InvalidAgeException->>Client: Exception thrown
    Client->>Client: catch(InvalidAgeException ex)
    Client->>Client: Console.WriteLine(ex.agevalue)
```

**Why Create Custom Exceptions?**

1. **Domain-specific errors**: Represent business rule violations
2. **Additional context**: Store relevant data (like the invalid age)
3. **Better error handling**: Catch specific business logic errors
4. **Clearer code**: Makes intent obvious to other developers

---

## Key Takeaways

### Parameter Passing Quick Reference

|Keyword|Initialize Before?|Assign Inside?|Can Modify?|Use Case|
|---|---|---|---|---|
|**none**|✅|❌|❌|Default (copy)|
|**ref**|✅|❌|✅|Modify original|
|**out**|❌|✅|✅|Return multiple|
|**in**|✅|❌|❌|Performance + safety|
|**params**|-|-|✅|Variable args|

### Exception Handling Best Practices

1. **Catch specific exceptions first**, general exceptions last
2. **Always include finally** for cleanup (closing files, connections)
3. **Log exceptions** with timestamp, message, source, and stack trace
4. **Create custom exceptions** for domain-specific errors
5. **Validate input** to prevent exceptions when possible
6. **Don't catch exceptions** you can't handle meaningfully
7. **Use try-catch around** risky operations (I/O, parsing, database)

### Method Parameter Best Practices

1. **Use `out`** when returning multiple values
2. **Use `ref`** when you need to modify the original value
3. **Use `in`** for large structs to avoid copying
4. **Use `params`** for flexible argument count
5. **Use default parameters** to reduce overloads
6. **Use named parameters** for clarity with many parameters

---

## Practice Questions

### Understanding Check

1. **What happens if you pass an array to a method without `ref` and modify its elements?**
    
    - The elements ARE modified (arrays are reference types)
    - But the array reference itself cannot be changed
2. **Why must `out` parameters be assigned before the method returns?**
    
    - Because `out` promises to return a value
    - Compiler enforces this to prevent uninitialized variables
3. **When would you use `params` instead of accepting an array parameter?**
    
    - When you want flexibility in calling syntax
    - Makes the method easier to call without creating arrays explicitly
4. **Why should specific exceptions be caught before general `Exception`?**
    
    - More specific handlers should run first
    - Prevents general handler from catching everything
5. **What's the difference between throwing `Exception` vs custom `InvalidAgeException`?**
    
    - Custom exception provides domain-specific context
    - Allows catching specific business rule violations
    - Can include additional data (like the invalid age value)

### Code Analysis Exercises

**Exercise 1:** What's the output?

```csharp
int x = 5, y = 10;
swap(ref x, ref y);
Console.WriteLine($"{x}, {y}");
```

**Exercise 2:** Will this compile?

```csharp
public void method(out int x)
{
    // x = 5; (commented out)
    return;
}
```

**Exercise 3:** What values are returned?

```csharp
int sum, mul, sub;
sum = calc(10, 5, out mul, out sub);
// sum = ?, mul = ?, sub = ?
```

---

## Summary Diagram

```mermaid
mindmap
  root((Day 5 C#))
    Parameter Passing
      Pass by Value
        Default behavior
        Creates copy
      Pass by Reference ref
        Must initialize
        Can modify original
      Output Parameters out
        No initialization needed
        Must assign inside
      Read Only in
        Performance optimization
      Variable Arguments params
        Flexible argument count
    Exception Handling
      Try Catch Finally
        Multiple catch blocks
        Order matters
      Exception Properties
        Message
        StackTrace
        Source
      Custom Exceptions
        Inherit from Exception
        Add custom properties
        Business rule validation
    Method Features
      Default Parameters
        Optional arguments
        Must be at end
      Named Parameters
        Any order
        Better readability
      Method Overloading
        Same name different signature
```

---

## Additional Notes

### When NOT to Use Exceptions

- **Expected conditions**: Use return values or bool flags
- **Control flow**: Don't use exceptions for normal program flow
- **Performance-critical code**: Exceptions are expensive

### When to Use Exceptions

- **Unexpected errors**: File not found, network failure
- **Validation failures**: Invalid input, business rule violations
- **External system failures**: Database connection, API calls

### Memory Diagram: Value vs Reference

```mermaid
graph TB
    subgraph "Pass by Value"
        A[Stack: a = 5] -->|Copy| B[Stack: x = 5]
        C[Stack: b = 7] -->|Copy| D[Stack: y = 7]
    end
    
    subgraph "Pass by Reference ref"
        E[Stack: a = 5] <-->|Reference| F[Method uses same memory]
        G[Stack: b = 7] <-->|Reference| H[Method uses same memory]
    end
    
    style A fill:#ffcdd2
    style C fill:#ffcdd2
    style E fill:#c8e6c9
    style G fill:#c8e6c9
```

---

_End of Study Guide_