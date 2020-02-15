
## Overloading

#### Exercise_122

The exercise template has a class Product, which represents a product in a shop. Every product has a name, location and weight.

Add the following three constructors to the Product class:

- **public Product(string name)** creates a product with the given name. Its location is set to "shelf" and its weight is set to 1.
- **public Product(string name, string location)** creates a product with the given name and the given location. Its weight is set to 1.
- **public Product(string name, int weight)** creates a product with the given name and the given weight. Its location is set to "warehouse".
You can test your program with the following code:

```cs
Product tapeMeasure = new Product("Tape measure");
Product plaster = new Product("Plaster", "home improvement section");
Product tyre = new Product("Tyre", 5);

Console.WriteLine(tapeMeasure);
Console.WriteLine(plaster);
Console.WriteLine(tyre);
```

```console
Tape measure (1 kg) can be found from the shelf. 
Plaster (1 kg) can be found from the home improvement section. 
Tyre (5 kg) can be found from the warehouse.
```

#### Exercise_123

Implement a class called **Counter**. The class contains a number, whichs value can be increased and decreased. The class must have the following constructors:

- **public Counter(int startValue)** sets the start value of the counter to startValue.

- **public Counter()** sets the start value of the counter to 0.

And the following methods and properties:

- **public int value { get; set; }**
- **public void Increase()** increases the value by 1
- **public void Decrease()** decreases the value by 1
- **public void Increase(int increaseBy)** increases the value of the counter by the value of increaseBy. If the value of increaseBy is negative, the value of the counter does not change.
- **public void Decrease(int decreaseBy)** decreases the value of the counter by the value of decreaseBy. If the value of decreaseBy is negative, the value of the counter does not change.