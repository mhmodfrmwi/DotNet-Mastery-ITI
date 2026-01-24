# Polymorphism in JavaScript - Presentation Slides

_Pre-ES6 Implementation & Modern Solutions_ **Duration: 7-10 minutes**

---

## Slide 1: Title Slide ⏱️ 30 sec

# Polymorphism in JavaScript

## Pre-ES6 Implementation & Modern Solutions

**Your Name** **Date**

---

## Slide 2: What is Polymorphism? ⏱️ 1 min

### Definition

**"Many Forms"** - Different objects responding to the same method call in their own way

> [!quote] Key Principle "Same interface, different implementation"

### Real-World Analogy

- Press "speak" button → Phone rings 📱
- Press "speak" button → Doorbell chimes 🔔
- Press "speak" button → Dog barks 🐕

**The same action produces different results based on the object!**

---

## Slide 3: Types of Polymorphism ⏱️ 45 sec

### A. Method Overriding (Runtime Polymorphism)

- Child constructor overrides parent method
- Different behavior determined at runtime
- Most common form in JavaScript

### B. Duck Typing (JavaScript's Natural Polymorphism)

- _"If it walks like a duck and quacks like a duck..."_
- JavaScript doesn't care about object type
- Only cares if the required method exists

---

## Slide 4: Live Demo - Basic Example (Part 1) ⏱️ 1 min

### Step 1: Parent Constructor

```javascript
function Animal(name) { 
    this.name = name; 
}

Animal.prototype.makeSound = function() {
    return this.name + " makes a sound";
};
```

### Step 2: Child Constructor

```javascript
function Dog(name, breed) {
    Animal.call(this, name);  // Inherit properties
    this.breed = breed;
}
```

---

## Slide 4b: Live Demo - Basic Example (Part 2) ⏱️ 30 sec

### Step 3: Set Up Inheritance

```javascript
Dog.prototype = Object.create(Animal.prototype);
Dog.prototype.constructor = Dog;
```

### Step 4: Override Method - POLYMORPHISM!

```javascript
Dog.prototype.makeSound = function() {
    return this.name + " barks: Woof! Woof!";
};
```

---

## Slide 4c: Live Demo - See It In Action ⏱️ 30 sec

### Step 5: Use Polymorphism

```javascript
var animals = [
    new Animal("Generic"), 
    new Dog("Buddy", "Retriever")
];

animals.forEach(function(animal) {
    console.log(animal.makeSound());
});
```

### Output:

```
Generic makes a sound
Buddy barks: Woof! Woof!
```

> [!important] Key Point Same method call (`makeSound()`), different behaviors!

---

## Slide 5: Real-World Application - Payment System 💳 (Part 1) ⏱️ 1 min

### The Problem

Different payment methods need different processing logic, but we want ONE checkout function.

### Step 1: Parent Constructor

```javascript
function Payment(amount) {
    this.amount = amount;
}

Payment.prototype.processPayment = function() {
    return "Processing $" + this.amount;
};
```

### Step 2: Credit Card Payment

```javascript
function CreditCardPayment(amount, cardNumber) {
    Payment.call(this, amount);
    this.cardNumber = cardNumber;
}

CreditCardPayment.prototype = Object.create(Payment.prototype);
CreditCardPayment.prototype.constructor = CreditCardPayment;

CreditCardPayment.prototype.processPayment = function() {
    return "Charging $" + this.amount + 
           " to card ending in " + this.cardNumber.slice(-4);
};
```

---

## Slide 5b: Payment System (Part 2) ⏱️ 30 sec

### Step 3: PayPal Payment

```javascript
function PayPalPayment(amount, email) {
    Payment.call(this, amount);
    this.email = email;
}

PayPalPayment.prototype = Object.create(Payment.prototype);
PayPalPayment.prototype.constructor = PayPalPayment;

PayPalPayment.prototype.processPayment = function() {
    return "Transferring $" + this.amount + 
           " via PayPal to " + this.email;
};
```

---

## Slide 5c: Payment System - The Magic ✨ ⏱️ 30 sec

### Step 4: One Function for All Payment Types!

```javascript
function checkout(paymentMethod) {
    console.log(paymentMethod.processPayment());
    console.log("Payment completed!");
}
```

### Usage:

```javascript
checkout(new CreditCardPayment(100, "1234567890123456"));
// Output: Charging $100 to card ending in 3456

checkout(new PayPalPayment(75, "user@email.com"));
// Output: Transferring $75 via PayPal to user@email.com
```

> [!success] Real-World Benefit Add new payment methods (Crypto, Apple Pay) without changing checkout function!

---

## Slide 6: Advantages of Polymorphism ✅ ⏱️ 1 min

### Why Use Polymorphism?

| Benefit                | Description                                          |
| ---------------------- | ---------------------------------------------------- |
| ✅ **Code Reusability** | Write once, use with many types                      |
| ✅ **Flexibility**      | Easy to add new types without breaking existing code |
| ✅ **Maintainability**  | Changes to one class don't affect others             |
| ✅ **Cleaner Code**     | Eliminates long if-else chains                       |
| ✅ **Extensibility**    | New behaviors via new constructors                   |
| ✅ **Loose Coupling**   | Objects remain independent                           |

### Example Impact

```javascript
// Without polymorphism ❌
if (paymentType === 'credit') { ... }
else if (paymentType === 'paypal') { ... }
else if (paymentType === 'crypto') { ... }

// With polymorphism ✅
checkout(paymentMethod); // Just works!
```

---

## Slide 7: Pre-ES6 Challenges ❌ ⏱️ 1 min

### The Pain Points

> [!danger] Disadvantages of Pre-ES6 Approach

**❌ Verbose Syntax**

```javascript
// All this boilerplate just for inheritance!
Dog.prototype = Object.create(Animal.prototype);
Dog.prototype.constructor = Dog;
```

**❌ Prototype Confusion**

- Easy to forget `Object.create()`
- Easy to forget constructor reassignment
- Prototype chain mysteries

**❌ No Built-in Super**

```javascript
Animal.call(this, name); // Manual parent constructor call
```

**❌ Constructor Issues**

```javascript
var dog = Dog("Buddy"); // Forgot 'new' - 'this' is now global! 💥
```

**❌ Readability**

- Complex for beginners
- Not intuitive coming from other languages

---

## Slide 8: ES6 to the Rescue! 🎉 (Part 1) ⏱️ 45 sec

### The Problem with Pre-ES6

```javascript
function Dog(name, breed) {
    Animal.call(this, name);  // Confusing
    this.breed = breed;
}

Dog.prototype = Object.create(Animal.prototype);  // Verbose
Dog.prototype.constructor = Dog;  // Easy to forget

Dog.prototype.makeSound = function() {
    return this.name + " barks!";
};
```

**Too much boilerplate!** 😫

---

## Slide 8b: ES6 to the Rescue! 🎉 (Part 2) ⏱️ 45 sec

### The ES6 Solution

```javascript
class Dog extends Animal {
    constructor(name, breed) {
        super(name);  // Built-in super!
        this.breed = breed;
    }
    
    makeSound() {
        return this.name + " barks!";
    }
}
```

**Much cleaner!** 🎉

### What Changed?

|Pre-ES6|ES6|
|---|---|
|`Object.create()`|`extends`|
|`Parent.call(this)`|`super()`|
|Manual prototype setup|Automatic|

> [!tip] Key Insight Same polymorphism underneath, just better syntax!

---

## Slide 9: How It Works - The Prototype Chain 

### When You Call a Method

```javascript
var dog = new Dog("Buddy", "Retriever");
dog.makeSound(); // How does JS find this?
```

### The Lookup Process:

```
Step 1: Check dog object itself
        ❌ Not found
        ↓
Step 2: Check Dog.prototype
        ✅ FOUND makeSound()!
        ↓
Step 3: Execute with correct 'this'
```

### The Chain:

```
dog → Dog.prototype → Animal.prototype → Object.prototype → null
```

> [!note] Engine Behavior JavaScript walks up the chain until it finds the method or reaches `null`

---

## Slide 10: Performance Insights  

### V8 Engine Optimizations

|Type|Speed|Example|
|---|---|---|
|🚀 **Monomorphic**|Fastest|Always `Dog`|
|⚡ **Polymorphic**|Fast|`Dog`, `Cat`, `Bird`|
|🐌 **Megamorphic**|Slower|5+ different types|

### Example:

```javascript
// Monomorphic - FASTEST 🚀
function process(dog) {
    return dog.makeSound(); 
}
```

```javascript
// Polymorphic - STILL FAST ⚡
function process(animal) {
    return animal.makeSound(); // Dog or Cat
}
```

### Best Practice

- Keep inheritance shallow (3-4 levels max)
- Use consistent types in hot code paths

---

## Slide 11: Key Takeaways 📝 ⏱️ 30 sec

### Summary

1. **Polymorphism** = Same method name, different behaviors
2. **Pre-ES6** uses prototypes (verbose but powerful)
3. **ES6 classes** make it much cleaner
4. **Real benefit**: Flexible, maintainable, extensible code
5. **Performance**: Engine optimizes for type consistency

> [!abstract] The Big Picture Polymorphism allows you to write generic code that works with multiple object types, making your applications easier to extend and maintain.

### When to Use

- Building extensible systems (plugins, payment methods)
- Working with collections of related objects
- Creating frameworks or libraries
- Any time you need "same interface, different implementation"

---

## Slide 12: Questions? ❓ ⏱️ 30 sec

### Common Interview Questions

**Q: What's the difference between polymorphism and inheritance?** A: Inheritance is the _mechanism_ (how objects share code), polymorphism is the _behavior_ (how objects respond differently to the same call).

**Q: Can JavaScript do method overloading?** A: No true overloading (same name, different parameters). JavaScript only has method _overriding_. You can simulate overloading with argument checking.

**Q: What if a child doesn't override a parent method?** A: The parent's method is used through inheritance.

---

# Thank You! 🙏

---

## Presentation Notes

### Timing Breakdown

- **Slides 1-3** (2 min): Foundation & concepts
- **Slides 4a-4c** (2 min): **LIVE CODE** basic example step-by-step
- **Slides 5a-5c** (2 min): **LIVE CODE** payment system
- **Slides 6-7** (2 min): Pros & cons
- **Slides 8a-8b** (1.5 min): ES6 evolution
- **Slides 9-10** (1.5 min): Technical depth
- **Slides 11-12** (1 min): Wrap up & questions

**Total: ~12 minutes** (you can skip some sub-slides if running short)

### Delivery Tips

> [!tip] Presentation Strategy
> 
> 1. **Start with the analogy** - Gets everyone on same page
> 2. **Live code Slides 4-5** - Most impactful, shows real usage
> 3. **Draw prototype chain** on board during Slide 9
> 4. **Compare Pre-ES6 vs ES6** side-by-side on Slide 8
> 5. **End with performance** - Shows deep understanding

### What to Emphasize

- The payment system example (Slide 5) - very practical
- The "same interface, different implementation" mantra
- How ES6 improved the syntax (but concept remains same)
- Real-world benefits over theoretical knowledge

---

## Tags

#presentation #javascript #oop #polymorphism #slides #pre-es6

## Related

- [[Polymorphism in JavaScript (Pre-ES6)]]
- [[Inheritance]]
- [[ES6 Classes]]