# C# Day 2 - Complete Study Guide

## 📋 Table of Contents

1. [Variables and Data Types](#variables-and-data-types)
2. [Value Types vs Reference Types](#value-types-vs-reference-types)
3. [String Formatting and I/O](#string-formatting-and-io)
4. [Parsing and Type Conversion](#parsing-and-type-conversion)
5. [Conditional Statements](#conditional-statements)
6. [Arrays](#arrays)
7. [Type Conversions](#type-conversions)

---

## 1. Variables and Data Types

### What is a Variable?

A variable is a named storage location in memory that holds a value. Think of it as a labeled box where you can store data.

```
Syntax: datatype name;
Example: int x;
```

### Numeric Data Types

#### Integer Types (Whole Numbers)

|Type|Size|Range|Example|
|---|---|---|---|
|`short`|16 bits|-32,768 to 32,767|`short y = 56;`|
|`int`|32 bits|-2.1B to 2.1B|`int x = 4;`|
|`long`|64 bits|Very large numbers|`long l = 123456553535355;`|

#### Floating-Point Types (Decimal Numbers)

|Type|Size|Precision|Suffix|Example|
|---|---|---|---|---|
|`float`|32 bits|7 digits|F|`float x = 1.2F;`|
|`double`|64 bits|15-16 digits|d (optional)|`double x = 1.234d;`|
|`decimal`|128 bits|28-29 digits|M|`decimal y = 1.2345M;`|

**Important:** Floating-point literals are `double` by default, so you need to add `F` for float or `M` for decimal.

### Other Basic Types

**Character Type:**

```csharp
char c = 'a';  // Single character in single quotes
int x = c;     // Gets ASCII value (97 for 'a')
```

**Boolean Type:**

```csharp
bool b = true;  // Can only be true or false
```

### Nullable Types

By default, value types cannot be null. To allow null:

```csharp
// Regular int - cannot be null
int x = 123;
// x = null;  // ❌ Error!

// Nullable versions
Nullable<int> x = 123;  // Long form
x = null;  // ✅ Works

int? xyz = 123;  // Short form (preferred)
xyz = null;  // ✅ Works
```

**Visual Representation:**

```
Regular int:     [123] ← Must have a value
Nullable int:    [123] or [null] ← Can be empty
```

---

## 2. Value Types vs Reference Types

This is one of the **most important concepts** in C#!

### Value Types

Value types store data directly. When you copy them, you get a **complete separate copy**.

```csharp
int x = 123;
int y = 456;
x = y;      // x now has its own copy of 456
y = 3;      // Changing y doesn't affect x
// Result: x = 456, y = 3
```

**Memory Diagram:**

```
┌─────────┐         ┌─────────┐
│ x: 456  │         │ y: 3    │
└─────────┘         └─────────┘
 Separate            Separate
 location            location
```

### Reference Types

Reference types store a **reference (pointer)** to the data. When you copy them, both variables point to the **same object**.

```csharp
student s = new student();
s.id = 3; 
s.age = 10;

student s2 = new student();
s2.id = 4; 
s2.age = 20;

s = s2;        // s now points to same object as s2
s.id = 30;     // Changes the shared object
// Result: Both s and s2 show id=30, age=20
```

**Memory Diagram:**

```
Before s = s2:
┌────┐      ┌──────────────┐
│ s  │─────→│ id:3, age:10 │
└────┘      └──────────────┘

┌────┐      ┌──────────────┐
│ s2 │─────→│ id:4, age:20 │
└────┘      └──────────────┘

After s = s2:
┌────┐      
│ s  │─────┐
└────┘     │   ┌──────────────┐
           └──→│ id:30, age:20│
┌────┐     ┌──→│ (shared!)    │
│ s2 │─────┘   └──────────────┘
└────┘     
```

### Quick Reference

|Category|Value Types|Reference Types|
|---|---|---|
|Examples|int, float, double, bool, char, struct|class, string, array|
|Storage|Stack|Heap|
|Copy behavior|Creates new copy|Copies reference|
|Default value|0, false, '\0'|null|

---

## 3. String Formatting and I/O

### Output Methods

#### Console.Write vs Console.WriteLine

```csharp
Console.Write("ali");    // No newline
Console.Write("ahmed");  // Continues on same line
// Output: aliahmed

Console.WriteLine("ali");    // Adds newline
Console.WriteLine("ahmed");  // New line
// Output:
// ali
// ahmed
```

### String Formatting Techniques

#### 1. String Concatenation (Old Way)

```csharp
int id = 1;
string name = "ahmed";
int age = 14;

Console.WriteLine("id=" + id + ",name=" + name + ",age=" + age);
// Output: id=1,name=ahmed,age=14
```

**Pros:** Simple for short strings  
**Cons:** Hard to read with many variables, poor performance

#### 2. String Holders (Composite Formatting)

```csharp
Console.WriteLine("id={0},name={1},age={2}", id, name, age);
// {0} is replaced by id, {1} by name, {2} by age
```

**Pros:** More organized, reusable placeholders  
**Cons:** Need to count positions

#### 3. String Interpolation (Modern - Best)

```csharp
Console.WriteLine($"id={id}, name={name}, age={age}");
// $ prefix allows variables directly in {}
```

**Pros:** Most readable, easiest to maintain  
**Cons:** None really!

### Escape Sequences

Special characters that modify string behavior:

|Sequence|Meaning|Example|
|---|---|---|
|`\n`|New line|`"Hello\nWorld"` → Hello<br>World|
|`\t`|Tab|`"Name:\tJohn"` → Name:    John|
|`\\`|Backslash|`"C:\\Users"` → C:\Users|
|`\"`|Quote|`"He said \"Hi\""` → He said "Hi"|

#### Verbatim Strings (@ prefix)

Treats everything literally, no escape sequences needed:

```csharp
// Without @:
Console.WriteLine("C:\\Users\\ITI\\Desktop\\C#46\\Day2");

// With @:
Console.WriteLine(@"C:\Users\ITI\Desktop\C#46\Day2");
// Both produce: C:\Users\ITI\Desktop\C#46\Day2
```

### Input Methods

#### Console.ReadLine()

Reads an entire line of text as a string.

```csharp
string txt = Console.ReadLine();
Console.WriteLine(txt);
```

**To read numbers:**

```csharp
Console.WriteLine("enter number");
int n = int.Parse(Console.ReadLine());
n++;
Console.WriteLine(n);
```

#### Console.Read()

Reads a **single character** and returns its ASCII code.

```csharp
int x = Console.Read();  // Type 'A', get 65
Console.WriteLine(x);     // Prints: 65
```

#### Console.ReadKey()

Reads a single key press with detailed information.

```csharp
ConsoleKeyInfo k = Console.ReadKey();
Console.WriteLine(k.Key);  // Prints key name (e.g., "A", "Enter")
```

---

## 4. Parsing and Type Conversion

### What is Parsing?

Converting a string representation into another data type.

```csharp
string x = "123";    // This is text
int y = int.Parse(x); // Convert to number
y++;                 // Now you can do math
Console.WriteLine(y); // Output: 124
```

**Common Parsing Methods:**

- `int.Parse(string)`
- `double.Parse(string)`
- `bool.Parse(string)`
- `DateTime.Parse(string)`

---

## 5. Conditional Statements

### If Statement

```csharp
int x = 1;
if (x == 1)  // Note: == for comparison, = for assignment
{
    // Code here
}
```

**Common Mistakes:**

```csharp
// ❌ Wrong:
if (1)           // Error: need boolean
if (x = 1)       // Error: assignment, not comparison
if (x)           // Error: int is not bool

// ✅ Correct:
if (x == 1)      // Comparison returns boolean
if (x > 0)       
if (isValid)     // If isValid is bool
```

### Switch Statement

```csharp
string txt = "ali";
switch (txt)
{
    case "ali":
    case "mostafa":  // Multiple cases
        Console.WriteLine("ali");
        break;
    case "ahmed":
        Console.WriteLine("ahmed");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}
```

**Note:** Cases without `break` fall through to the next case.

---

## 6. Arrays

### Array Declaration

```csharp
// Method 1: Declare with size
int[] arr = new int[5];  // 5 empty slots

// Method 2: Initialize with values
int[] arr1 = new int[] { 1, 2, 3, 4 };

// Method 3: Shorthand
int[] arr3 = { 1, 2, 3, 4, 5 };

// Method 4: Collection expression (C# 12+)
int[] arr4 = [1, 2, 3, 4, 5];
```

### Accessing Array Elements

Arrays are **zero-indexed** (first element is at position 0).

```csharp
int[] arr = [10, 20, 30, 40, 50];

arr[0]  // First element: 10
arr[3]  // Fourth element: 40
arr[4]  // Fifth element: 50

arr[3] = 45;  // Change value
Console.WriteLine(arr[3]);  // Output: 45
```

**Visual:**

```
Index:   0   1   2   3   4
       ┌───┬───┬───┬───┬───┐
Array: │10 │20 │30 │40 │50 │
       └───┴───┴───┴───┴───┘
```

### Working with Arrays

#### Dynamic Size

```csharp
Console.WriteLine("enter student number");
int studentnumber = int.Parse(Console.ReadLine());

int[] studentages = new int[studentnumber];
```

#### Filling an Array

```csharp
for(int i = 0; i < studentnumber; i++)
{
    Console.WriteLine($"enter age of student {i+1}");
    studentages[i] = int.Parse(Console.ReadLine());
}
```

#### Array Methods

**Array.Sort() - Ascending Order**

```csharp
int[] arr = {5, 2, 8, 1, 9};
Array.Sort(arr);
// Result: {1, 2, 5, 8, 9}
```

**Array.Reverse() - Reverse Order**

```csharp
int[] arr = {1, 2, 3, 4, 5};
Array.Reverse(arr);
// Result: {5, 4, 3, 2, 1}
```

#### Calculating Sum and Average

```csharp
int sum = 0;
for(int i = 0; i < studentages.Length; i++)
{
    sum += studentages[i];
    Console.WriteLine($"age of student {i+1}={studentages[i]}");
}

Console.WriteLine($"avg={sum/studentnumber}");
```

---

## 7. Type Conversions

### Implicit Conversion (Automatic)

Happens when there's **no risk of data loss**.

```csharp
int x = 123;
long y = x;  // ✅ int fits in long, automatic
```

**Rule:** Smaller → Larger type

```
byte → short → int → long → float → double → decimal
```

### Explicit Conversion (Manual - Casting)

Required when there's **potential data loss**.

```csharp
long x = 5000;
int y = (int)x;  // Manual cast required
```

**Warning:** Can lose data if value is too large!

```csharp
long x = int.MaxValue;
x += 10;
int y = (int)x;  // Overflow! Result is negative
```

#### Checked Context

Detect overflow errors:

```csharp
checked
{
    long x = int.MaxValue;
    x += 10;
    int y = (int)x;  // Throws OverflowException
}
```

### Helper Methods

#### ToString() - Any Type → String

```csharp
int id = 123;
string txt = id.ToString();  // "123"
```

#### Parse() - String → Specific Type

```csharp
string txt = "123";
int x = int.Parse(txt);  // 123
```

**Important:** `Parse()` throws exception if string is null or invalid!

```csharp
string txt = null;
int x = int.Parse(txt);  // ❌ Exception!
```

#### Convert Class - Between Types

```csharp
string txt = null;
int x = Convert.ToInt32(txt);  // Returns 0 for null (safer)
```

**Parse vs Convert:**

|Method|Null Handling|Invalid Input|
|---|---|---|
|`Parse()`|Exception|Exception|
|`Convert`|Returns 0|Exception|

### Conversion Methods Summary

```csharp
// String to number
int.Parse("123")
double.Parse("1.5")
Convert.ToInt32("123")
Convert.ToDouble("1.5")

// Number to string
(123).ToString()
(1.5).ToString()

// Between numbers
(int)longValue      // Explicit cast
(double)intValue    // Implicit or explicit
```

---

## 🎯 Study Tips

1. **Practice the concepts** - Type out the code examples yourself
2. **Understand Value vs Reference** - This is crucial for avoiding bugs
3. **Use String Interpolation** - Modern and readable: `$"Value is {x}"`
4. **Remember Parse can throw exceptions** - Always validate input
5. **Arrays are zero-indexed** - First element is [0], not [1]

---

## 📝 Quick Reference Card

```csharp
// Variable declaration
int x = 10;
string name = "John";

// Nullable
int? y = null;

// String formatting
Console.WriteLine($"x={x}, name={name}");

// Input
string input = Console.ReadLine();
int num = int.Parse(input);

// Array
int[] arr = new int[5];
arr[0] = 10;

// Conversion
int a = Convert.ToInt32("123");
string b = a.ToString();
```

---

## ✅ Practice Exercises

1. Create a program that reads 5 numbers and calculates their average
2. Write code demonstrating value vs reference types
3. Create an array of student names and sort them alphabetically
4. Practice all three string formatting methods
5. Write a safe number parser that handles invalid input

Good luck with your studies! 🚀