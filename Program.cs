// See https://aka.ms/new-console-template for more information

MenuCalculator();

static void Sum()
{
  Console.WriteLine("First value: ");
  float value1 = float.Parse(Console.ReadLine()!);

  Console.WriteLine("Second value: ");
  float value2 = float.Parse(Console.ReadLine()!);

  float result = value1 + value2;

  Console.WriteLine("");
  Console.WriteLine($"The result of the sum is: {result}");
  // Console.WriteLine("The result of the sum is: " + result);
  // Console.WriteLine($"The result of the sum is: {value1 + value2}");
  // Console.WriteLine("The result of the sum is: " + value1 + value2); // The result of the sum is: 2525
  // Console.WriteLine("The result of the sum is: " + (value1 + value2)); // The result of the sum is: 50
  Console.ReadKey();
  MenuCalculator();
}

static void Subtraction()
{
  Console.WriteLine("First value: ");
  float value1 = float.Parse(Console.ReadLine()!);

  Console.WriteLine("Second value: ");
  float value2 = float.Parse(Console.ReadLine()!);

  float result = value1 - value2;

  Console.WriteLine("");
  Console.WriteLine($"The result of the subtraction is: {result}");
  Console.ReadKey();
  MenuCalculator();
}

static void Multiplication() {
  Console.WriteLine("First value: ");
  float value1 = float.Parse(Console.ReadLine()!);

  Console.WriteLine("Second value: ");
  float value2 = float.Parse(Console.ReadLine()!);

  float result = value1 * value2;

  Console.WriteLine("");
  Console.WriteLine($"The result of the multiplication is: {result}");
  Console.ReadKey();
  MenuCalculator();
}

static void Division() {
  Console.WriteLine("First value: ");
  float value1 = float.Parse(Console.ReadLine()!);

  Console.WriteLine("Second value: ");
  float value2 = float.Parse(Console.ReadLine()!);

  float result = value1 / value2;

  Console.WriteLine("");
  Console.WriteLine($"The result of the division is: {result}");
  Console.ReadKey();
  MenuCalculator();
}

static void MenuCalculator() {
  Console.Clear();
  Console.WriteLine($"Choose an option on the calculator:");
  Console.WriteLine($"{(int)ECalculatorOptions.Sum} - {ECalculatorOptions.Sum}");
  Console.WriteLine($"{(int)ECalculatorOptions.Subtraction} - {ECalculatorOptions.Subtraction}");
  Console.WriteLine($"{(int)ECalculatorOptions.Multiplication} - {ECalculatorOptions.Multiplication}");
  Console.WriteLine($"{(int)ECalculatorOptions.Division} - {ECalculatorOptions.Division}");
  Console.WriteLine("5 - Exit");

  Console.WriteLine("-----------------");

  short opcao = short.Parse(Console.ReadLine()!);

  switch (opcao) {
    case (int)ECalculatorOptions.Sum: Sum(); break;
    case (int)ECalculatorOptions.Subtraction: Subtraction(); break;
    case (int)ECalculatorOptions.Multiplication: Multiplication(); break;
    case (int)ECalculatorOptions.Division: Division(); break;
    case 5: System.Environment.Exit(0); break;
    default: MenuCalculator(); break;
  }
}

enum ECalculatorOptions {
  Sum = 1,
  Subtraction = 2,
  Multiplication = 3,
  Division = 4
}