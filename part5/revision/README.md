## Object oriented revision

#### Exercise_119

The exercise template comes with the **"ClockHand"** class described in the course material. Implement a **Timer** class based on the material's Clock class.

The timer has two hands, one for hundredths of a second and one for seconds. As it progresses, the number of hundredths of a second grows by one. When the hand corresponding to hundredths of a second reaches a value of 100, its value is set to zero, and the number of seconds grows by one. In the same way, when the value of the hand corresponding to seconds reaches the value of sixty, its value is set to zero.

- **public Timer()** creates a new timer.
- **public override string ToString()** returns a string representation of the timer. The string representation should be in the form "seconds: hundredths of a second", where both the seconds and the hundredths of a second are represented by two numbers. For example, **"19:83"** would represent the time 19 seconds, 83 hundredths of a second.
- **public void Advance()** moves the timer forward by a hundredth of a second.

You can test out the timer's functionality in the main program whenever you like. The example code below provides you with a program where the timer is printed and it advances once every hundredth of a second.

```cs
static void Main(string[] args)
{
  // Create new timer
  Timer timer = new Timer();
  // Loop until you cancel the loop.
  // You can cancel with the CTRL + C
  while (true)
  {
    Console.WriteLine(timer);
    timer.Advance();
    // Some error proving, we'll talk about this later.
    // Known as try-catch.
    try
    {
      // Wait 100th of a second. 
      // Sleep(1000) waits one second, if you want to test at slower pace.
      System.Threading.Thread.Sleep(10);
    }
    // Other half of try-catch pair. 
    catch (Exception e)
    {
      Console.WriteLine("Error happened: +" + e);
    }
  }
}
```

#### Exercise_120

Create a **Cube** class that represents a cube (i.e., a standard hexahedron). Create a **public Cube (int edgeLength)** constructor for the class, that takes the length of the cube's edge as its parameter.

Make a **public int Volume()** method for the cube, which calculates and returns the cube's volume. The volume of the cube is calculated with the formula **edgeLength * edgeLength * edgeLength**. Moreover, make a **public override string ToString()** method for the cube, which returns a string representation of it. The string representation should take the form **"The length of the edge is l and the volume v"**, where l is the length and v the volume - both the length and volume must be represented as integers.

#### Exercise_121

[**The Karvonen method**](https://en.wikipedia.org/wiki/Heart_rate#Karvonen_method) allows you to calculate your target heart rate for physical exercise. The target heart rate is calculated with the formula **(maximum heart rate - resting heart rate) * (target heart rate percentage) + resting heart rate**, where the target heart rate is given as a percentage of the maximum heart rate.

For example, if a person has a maximum heart rate of 200, a resting heart rate of 50, and a target heart rate of 75% of the maximum heart rate, the target heart rate should be about ((200-50) * (0.75) + 50), i.e., 162.5 beats per minute.

Create an "exercise assistant" class called **Fitbyte**. Its constructor takes both an age and a resting heart rate as its parameters. The exercise assistant should provide a method **TargetHeartRate**, which is passed a number of type double as a parameter that represents a percentual portion of the maximum heart rate. The proportion is given as a number between zero and one. The class should have:

- A constructor **public Fitbyte(int age, int restingHeartRate)**
- A method **public double TargetHeartRate(double percentageOfMaximum)** that calculates and returns the target heart rate.

Use the formula **206.3 - (0.711 * age)** to calculate the maximum heart rate.
Use the formula **(maxHeartRate - restingHeartRate) * percentageOfMaximum + restingHeartRate** to calculate the target heart rate.

Use case:

```cs
public static void Main(string[] args)
{
  Fitbyte assistant = new Fitbyte(30, 60);
  double percentage = 0.5;

  while (percentage < 1.0)
  {
    double target = assistant.TargetHeartRate(percentage);
    Console.WriteLine("Target " + (percentage * 100) + "% of maximum: " + target);
    percentage = percentage + 0.1;
  }
}
```

```console
Target 50% of maximum: 122.48500000000001
Target 60% of maximum: 134.98200000000003
Target 70% of maximum: 147.479
Target 80% of maximum: 159.976
Target 89.99999999999999% of maximum: 172.473
Target 99.99999999999999% of maximum: 184.97000000000003
```

