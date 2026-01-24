# C# Day 3: Advanced Arrays & Structs

## Table of Contents

1. [Multi-Dimensional Arrays](#multi-dimensional-arrays)
2. [Jagged Arrays (Array of Arrays)](#jagged-arrays)
3. [Structs in C#](#structs-in-csharp)
4. [Properties vs Setters/Getters](#properties-vs-settersgetters)

---

## Multi-Dimensional Arrays

### What is a Multi-Dimensional Array?

A multi-dimensional array is an array with more than one dimension. Think of it like a table or spreadsheet with rows and columns.

### Visual Representation

```
Regular Array (1D):
[0] [1] [2] [3] [4]
 3   4   5   6   7

Multi-Dimensional Array (2D):
        Column 0  Column 1  Column 2
Row 0      3         4         5
Row 1      4         2         3
Row 2      7         8         9
Row 3      5         4         5
```

### Syntax and Declaration

```csharp
// Declaration with size
int[,] arr = new int[4, 3];  // 4 rows, 3 columns

// Declaration with initialization
int[,] arr1 = new int[4, 3] { 
    { 3, 4, 5 }, 
    { 4, 2, 3 }, 
    { 7, 8, 9 }, 
    { 5, 4, 5 } 
};
```

**Key Points:**

- Use `[,]` notation (comma inside brackets)
- First number = rows, second number = columns
- All rows must have the same number of columns

### Accessing Elements

```csharp
// Reading a value
Console.WriteLine(arr1[2, 1]);  // Output: 8 (row 2, column 1)

// Writing a value
arr1[1, 2] = 4;  // Sets row 1, column 2 to 4
```

### Important Methods

|Method|Description|Example|
|---|---|---|
|`GetLength(0)`|Returns number of rows|`arr.GetLength(0)`|
|`GetLength(1)`|Returns number of columns|`arr.GetLength(1)`|

### Practical Example: Student Tracking System

```csharp
// Step 1: Get dimensions
int numOfTracks = 3;      // 3 tracks
int numOfStudent = 5;     // 5 students per track

// Step 2: Create array
string[,] studentnames = new string[numOfTracks, numOfStudent];

// Step 3: Input data (nested loops)
for (int i = 0; i < studentnames.GetLength(0); i++) {
    Console.WriteLine($"Track num {i+1}");
    for (int j = 0; j < studentnames.GetLength(1); j++) {
        Console.WriteLine($"Enter name of student {j+1}");
        studentnames[i, j] = Console.ReadLine();
    }
}

// Step 4: Display data
for (int i = 0; i < numOfTracks; i++) {
    Console.WriteLine($"Track num {i + 1}");
    for (int j = 0; j < numOfStudent; j++) {
        Console.WriteLine($"Student {j+1} name: {studentnames[i,j]}");
    }
}
```

**Loop Structure Diagram:**

```
Outer Loop (i): Tracks
    ├── Track 1
    │   └── Inner Loop (j): Students
    │       ├── Student 1
    │       ├── Student 2
    │       └── Student 3
    ├── Track 2
    │   └── Inner Loop (j): Students
    └── Track 3
        └── Inner Loop (j): Students
```

---

## Jagged Arrays

### What is a Jagged Array?

A jagged array is an **array of arrays** where each row can have a different number of columns. Think of it as irregular or "jagged" rows.

### Visual Comparison

```
Multi-Dimensional (Regular):
Row 0: [3] [4] [5] [6]
Row 1: [1] [2] [3] [4]
Row 2: [7] [8] [9] [0]
       ↑ All rows same length

Jagged Array (Irregular):
Row 0: [3] [4] [5] [6]
Row 1: [1] [2] [3]
Row 2: [7] [8] [9] [0] [1]
       ↑ Different lengths!
```

### Syntax and Declaration

```csharp
// Declaration
int[][] arr = new int[3][];  // 3 rows, columns undefined

// Initialize each row separately
arr[0] = new int[4];  // Row 0 has 4 columns
arr[1] = new int[3];  // Row 1 has 3 columns
arr[2] = new int[4];  // Row 2 has 4 columns

// Accessing elements
arr[0][0] = 4;  // Notice double brackets [][]
```

**Key Differences from Multi-Dimensional:**

- Use `[][]` notation (two separate brackets)
- Each row is independently sized
- Must initialize each row separately

### Why Use Jagged Arrays?

**Advantages:**

1. **Memory Efficiency**: Only allocate space you need
2. **Flexibility**: Each row can have different sizes
3. **Real-world modeling**: Matches scenarios where groups have different sizes

### Practical Example: Flexible Student System

```csharp
int numOfTracks = 3;
string[][] studentnames = new string[numOfTracks][];

// Each track can have different number of students
for (int i = 0; i < numOfTracks; i++) {
    Console.WriteLine("Enter number of students");
    int numOfStudent = int.Parse(Console.ReadLine());
    
    // Initialize this specific row
    studentnames[i] = new string[numOfStudent];
    
    // Input student names
    for (int j = 0; j < numOfStudent; j++) {
        Console.WriteLine($"Enter name of student num {j+1}");
        studentnames[i][j] = Console.ReadLine();
    }
}

// Display all data
for (int i = 0; i < studentnames.Length; i++) {
    Console.WriteLine($"Track number {i+1}");
    for (int j = 0; j < studentnames[i].Length; j++) {
        Console.WriteLine($"Name of student number {j+1}: {studentnames[i][j]}");
    }
}
```

### Accessing Length

```csharp
int[][] arr = new int[3][];
arr[0] = new int[4];
arr[1] = new int[3];
arr[2] = new int[5];

// Get number of rows
Console.WriteLine(arr.Length);        // Output: 3

// Get length of specific row
Console.WriteLine(arr[0].Length);     // Output: 4
Console.WriteLine(arr[1].Length);     // Output: 3
Console.WriteLine(arr[2].Length);     // Output: 5
```

---

## Structs in C#

### What is a Struct?

A struct (structure) is a **value type** that groups related data together. Think of it as a lightweight custom data type.

### Basic Struct Example

```csharp
struct ComplexNum
{
    public int real;
    public int img;
}

// Usage
ComplexNum c;
c.real = 5;
c.img = 4;
Console.WriteLine($"{c.real}+{c.img}i");  // Output: 5+4i
```

### Struct vs Class (Value Type Behavior)

**Important Concept**: Structs are **value types**, meaning they are copied when assigned.

```csharp
time t = new time();
t.set_hours(22);

time t2 = new time();
t2.set_hours(10);

t = t2;              // t is now a COPY of t2
t2.set_hours(20);    // This changes t2, NOT t

Console.WriteLine(t.get_hours());  // Output: 10 (not 20!)
```

**Memory Diagram:**

```
Before assignment:
t  → [hours: 22]
t2 → [hours: 10]

After t = t2:
t  → [hours: 10] (copy of t2)
t2 → [hours: 10]

After t2.set_hours(20):
t  → [hours: 10] (unchanged)
t2 → [hours: 20]
```

### Encapsulation with Structs

Encapsulation means hiding internal data and controlling access through methods.

---

## Properties vs Setters/Getters

### The Old Way: Setters and Getters

```csharp
struct time
{
    int hours;  // Private field
    
    // Setter method
    public void set_hours(int _hours)
    {
        if (_hours >= 0 && _hours < 24) 
            hours = _hours;
        else 
            throw new Exception("Invalid hour value");
    }
    
    // Getter method
    public int get_hours()
    {
        return hours;
    }
}

// Usage
time t = new time();
t.set_hours(22);
int currentHour = t.get_hours();
```

**Problems with Setters/Getters:**

- Verbose syntax
- Can't use increment operators directly
- Need temporary variables for operations

```csharp
// To increment, you need:
int x = t.get_hours();
x++;
t.set_hours(x);
// That's 3 lines just to increment!
```

### The Modern Way: Properties

```csharp
struct time
{
    int hours;  // Private field
    
    // Property
    public int Hour
    {
        set {
            if (value >= 0 && value < 24) 
                hours = value;
            else 
                throw new Exception("Invalid value");
        }
        get { 
            return hours; 
        }
    }
}

// Usage
time t = new time();
t.Hour = 22;           // Uses set
t.Hour++;              // Uses get, increments, then set
Console.WriteLine(t.Hour);  // Uses get
```

**Advantages of Properties:**

- Clean, field-like syntax
- Can use operators directly (`++`, `--`, `+=`, etc.)
- Still provides validation and encapsulation
- `value` is a special keyword representing the assigned value

### Complete Time Struct Example

```csharp
struct time
{
    int hours;
    int minutes;
    int seconds;
    
    public int Hour
    {
        set {
            if (value >= 0 && value < 24) 
                hours = value;
            else 
                throw new Exception("Invalid value");
        }
        get { return hours; }
    }
    
    public int Minute
    {
        set {
            if (value >= 0 && value < 60) 
                minutes = value;
            else 
                throw new Exception("Invalid value");
        }
        get { return minutes; }
    }
    
    public int Second
    {
        set {
            if (value >= 0 && value < 60) 
                seconds = value;
            else 
                throw new Exception("Invalid value");
        }
        get { return seconds; }
    }
    
    public string getstring()
    {
        return $"{hours}H:{minutes}M:{seconds}S";
    }
}

// Usage
time t = new time();
t.Hour = 12;
t.Minute = 33;
t.Second = 20;
Console.WriteLine(t.getstring());  // Output: 12H:33M:20S
```

### Property Syntax Breakdown

```csharp
public int Hour        // Property name (like a field)
{
    set {              // Called when: t.Hour = 22
        // value is what user assigned (22 in this case)
        if (value >= 0 && value < 24)
            hours = value;
    }
    get {              // Called when: x = t.Hour
        return hours;  // Returns the private field
    }
}
```

---

## Key Takeaways

### Multi-Dimensional Arrays

- Fixed rectangular structure (all rows same size)
- Use `[,]` notation
- Good for grids, tables, matrices

### Jagged Arrays

- Flexible irregular structure (rows can differ)
- Use `[][]` notation
- More memory efficient for varying sizes
- Initialize each row separately

### Structs

- Value types (copied on assignment)
- Group related data
- Use for small, simple data structures

### Properties

- Modern replacement for setters/getters
- Allow validation while maintaining clean syntax
- Enable use of operators (`++`, `+=`, etc.)
- `value` keyword represents assigned data

---

## Practice Questions

1. **When would you use a jagged array instead of a multi-dimensional array?**
    
    - When each row needs a different number of elements
2. **What's the output of this code?**
    
    ```csharp
    int[,] arr = new int[2, 3] {{1,2,3}, {4,5,6}};
    Console.WriteLine(arr[1, 2]);
    ```
    
    - Answer: 6
3. **Why are properties better than setters/getters?**
    
    - Cleaner syntax, can use operators, still provide encapsulation
4. **What happens when you assign one struct to another?**
    
    - A copy is made (value type behavior)