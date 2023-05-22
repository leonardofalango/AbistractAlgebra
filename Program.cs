using static FunctionUtil;
// Linear Function is x
// You can use it like a variable

Function f = x; // static FunctionUtil for this
// ! Normally FunctionUtil.x;

// Same with sin and cos
Function s = sin(x);
Function c = cos(x);

// Because of the operator overload
// You can use Function * Function and Function + Function
Function g = x;
Sum sum = (Sum)(f + g);
Mult mult = (Mult)(f * g);

// You can also print the Functions
System.Console.WriteLine(sum);
System.Console.WriteLine(mult);

System.Console.WriteLine(c);
System.Console.WriteLine(s);
System.Console.WriteLine();

// Indexers for using the function
// Printing the Function sum(5) and mult(5)
System.Console.WriteLine(sum[5]);
System.Console.WriteLine(mult[5]);
System.Console.WriteLine();

var fundamental = (sin(x) * sin(x)) + (cos(x) * cos(x));
System.Console.Write(fundamental);
System.Console.Write(" = ");
System.Console.WriteLine(fundamental[2]);
System.Console.WriteLine();

// Testing pow
// fundamental = (sin(x) ^ new Constant(2)) + (cos(x) ^ new Constant(2));
// System.Console.WriteLine(fundamental);
// System.Console.WriteLine(fundamental[1]);

var test = 10.ToConstant() * 2.ToConstant() / x ^ sin(x);
System.Console.WriteLine(test);
System.Console.WriteLine(test[2]);


