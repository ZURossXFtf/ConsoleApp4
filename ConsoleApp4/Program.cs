using ConsoleApp4;



Complex complex1 = new Complex(9, 3);
Complex complex2 = new Complex(4, -4);

Complex complex3 = (Complex)complex1.Add(complex2);
Console.WriteLine(complex3.ToString());

Complex complex4 = (Complex)complex1.Sub(complex2);
Console.WriteLine(complex4.ToString());

Complex complex5 = (Complex)complex1.Mult(complex2);
Console.WriteLine(complex5.ToString());

Complex complex6 = (Complex)complex1.Div(complex2);
Console.WriteLine(complex6.ToString());


Console.WriteLine(complex1.Equ(complex2));

Complex complex7 = (Complex)complex1.Conj();
Console.WriteLine(complex7.ToString());

Rational rational1 = new Rational(9, 3);
Rational rational2 = new Rational(4, -4);


Rational rational3 = (Rational)rational1.Add(rational2);
Console.WriteLine(rational3.ToString());

Rational rational4 = (Rational)rational1.Sub(rational2);
Console.WriteLine(rational4.ToString());

Rational rational5 = (Rational)rational1.Mult(rational2);
Console.WriteLine(rational5.ToString());

Rational rational6 = (Rational)rational1.Div(rational2);
Console.WriteLine(rational6.ToString());

Console.WriteLine(rational1.Equ(rational2));

Console.WriteLine(rational1.Great(rational2));

Console.WriteLine(rational1.Less(rational2));




