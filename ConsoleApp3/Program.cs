using System.Net.Security;

salom:
/*if1 - misol
int a = int.Parse(Console.ReadLine());
if (a > 0)
{
    Console.WriteLine(++a);
}
else
{
    Console.WriteLine(a);
}*/
/*if2 - misol
int a = int.Parse(Console.ReadLine());
if (a > 0)
{
    Console.WriteLine(++a);
}
else
{
    Console.WriteLine(a - 2);
}*/
/*if3 - misol
int a = int.Parse(Console.ReadLine());
if (a > 0)
{
    Console.WriteLine(++a);
}
else if (a < 0)
{
    Console.WriteLine(a - 2);
}
else
{
    Console.WriteLine(a + 10);
}*/
/*if4 - misol
int a, b, c; 
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
if(a > 0 && b > 0 && c > 0)
{
    Console.WriteLine("Musbat son 3 ta");
}
else if ((a > 0 && b > 0 && c < 0) || (a > 0 && b < 0 && c > 0) || (a < 0 && c > 0 && b > 0))
{
    Console.WriteLine("Musbat son 2 ta");
}
else if (a == 0 && b == 0 && c == 0)
{
    Console.WriteLine("Barcha sonlar 0 ga teng");
}
else
{
    Console.WriteLine("Musbat son 1 ta");
}*/
/*if5 - misol
int a, b, c;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
if (a > 0 && b > 0 && c > 0)
{
    Console.WriteLine("Musbat son 3 ta Manfiy son 0 ta");
}
else if ((a > 0 && b > 0 && c < 0) || (a > 0 && b < 0 && c > 0) || (a < 0 && c > 0 && b > 0))
{
    Console.WriteLine("Musbat son 2 ta Manfiy son 1 ta");
}
else if (a == 0 && b == 0 && c == 0)
{
    Console.WriteLine("Barcha sonlar 0 ga teng ");
}
else if (a < 0 && b < 0 && c < 0)
{
    Console.WriteLine("Musbat son 0 ta Manfiy son 3 ta");
}
else
{
    Console.WriteLine("Musbat son 1 ta Manfiy son 2 ta");
}*/
/*if6 - misol
int a, b;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Eng katta son  " + a);
}
else
{
    Console.WriteLine("Eng katta son  " + b);
}*/
/*if7 - misol
int a, b;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
if (a < b)
{
    Console.WriteLine("Eng kichik sonning tartib raqami   " + 1);
}
else if (a == b)
{
    Console.WriteLine("Ekkala son teng");
}
else
{
    Console.WriteLine("Eng kichik sonning tartib raqami   " + 2);
}*/
/*if8 - misol
int a, b;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Katta son  " + a + " Katta son  " + b);
}
else if (a == b)
{
    Console.WriteLine("Ekkala son teng");
}
else
{
    Console.WriteLine("Katta son  " + b + " Kichik son  " + a);
}*/
/*if9 - misol
double A, B, C;     Console.Write("A = ");
A = double.Parse(Console.ReadLine());       Console.Write("B = ");
B = double.Parse(Console.ReadLine());
C = A;
if (A < B)
{
    Console.WriteLine("A = " + A + "  B = " + B);
}
else if (A > B)
{
    Console.WriteLine("A = " + (A = B) + "  B = " + (B = C));
}
else
{
    Console.WriteLine("Bu sonlar teng");
}*/
/*if10 - misol
int A, B, C; Console.Write("A = ");
A = int.Parse(Console.ReadLine()); Console.Write("B = ");
B = int.Parse(Console.ReadLine());
C = A + B;
if (A != B)
{
    Console.WriteLine("A = " + (A = C) + "  B = " + (B = C));
}
else
{
    Console.WriteLine("A = 0" + "  B = 0");
}*/
/* if11 - misol
int a, b;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
if (a != b && (a > b))
{

    Console.WriteLine("A = " + a + "  B = " + (b = a)); 
}
else if (a !=b && a < b)
{
    Console.WriteLine("A = " + (a = b) + "  B = " + b);
}
else
{
       Console.WriteLine("A = 0  B = 0 ");
}*/
/*if12 - misol
int a, b, c;  Console.Write("a = ");
a = int.Parse(Console.ReadLine());  Console.Write("b = ");
b = int.Parse(Console.ReadLine());  Console.Write("c = ");
c = int.Parse(Console.ReadLine());
if (a < b && a < c)
{
    Console.WriteLine("Eng kichik son " + a);
}
else if (a > b && b < c)
{
    Console.WriteLine("Eng kichik son " + b);
}
else if (c < b && a > c)
{
    Console.WriteLine("Eng kichik son " + c);
}
else
{
    Console.WriteLine(" 3 ta son ham teng");
}*/
/*if13 - misol
int a, b, c;        Console.Write("a = ");
a = int.Parse(Console.ReadLine());      Console.Write("b = ");
b = int.Parse(Console.ReadLine());      Console.Write("c = ");
c = int.Parse(Console.ReadLine());
if ((a > b && b > c) || (a < b && b < c))
{
    Console.WriteLine("Urtancha son  " + b);
}
else if ((a < b && c < a) || (a > b && c > a))
{
    Console.WriteLine("Urtancha son  " + a);
}
else if (((a > b && b == c) || (a < b && b == c) || (b > a && a == c) || (b < a && a == c) || (c > b && b == a) || (c < b && b == a)))
{
    Console.WriteLine("Ekta son bir biriga teng");
}
else if (a == b && b == c)
{
    Console.WriteLine("Uchchala son teng");
}
else
{
    Console.WriteLine("Urtancha son  " + c);
}*/
/*if14 - misol
int a, b, c; Console.Write("a = ");
a = int.Parse(Console.ReadLine()); Console.Write("b = ");
b = int.Parse(Console.ReadLine()); Console.Write("c = ");
c = int.Parse(Console.ReadLine());
if (a < b && b > c && a < c)
{
    Console.WriteLine("Kichik son " + a + "  Katta son " + b);
}
else if (a > b && a > c && b < c)
{
    Console.WriteLine("Kichik son " + b + "  Katta son " + a);
}
 else if (a < c && a < b && b < c)
{
    Console.WriteLine("Kichik son " + a + "  Katta son " + c);
}
else if (a > b && a > c && b > c)
{
    Console.WriteLine("Kichik son " + c + "  Katta son " + a);
}
else if (b < c && b < a && a < c)
{
    Console.WriteLine("Kichik son " + b + "  Katta son " + c);
}
else if (b > a && b > c && a > c)
{
    Console.WriteLine("Kichik son " + c + "  Katta son " + b);
}
else if (a == b && b == c)
{
    Console.WriteLine("Uchta son bir biriga teng");
}
else
{
    Console.WriteLine("2 ta son bir biriga ting");
}*/
/*if15 - misol
int a, b, c; Console.Write("a = ");
a = int.Parse(Console.ReadLine()); Console.Write("b = ");
b = int.Parse(Console.ReadLine()); Console.Write("c = ");
c = int.Parse(Console.ReadLine());
if (a == b && b == c)
{
    Console.WriteLine("Uchta son bir biriga ting ");
}
else if ((a + c == b + c) || (a + b == a + c) || (a + b == b + c))
{
    Console.WriteLine("Ekta son bir biriga ting");
}
else if ((a + b > a + c) && (a + b > b + c))
{
    Console.WriteLine(a + "  va  " + b + "  sonlar yig'indisi eng katta");
}
else if ((a + b < a + c) && (a + c > b + c))
{
    Console.WriteLine(a + "  va  " + c + "  sonlar yig'indisi eng katta");
}
else if ((b + c > b + a) && (b + c > a + c))
{
    Console.WriteLine(c + "  va  " + b + "  sonlar yig'indisi eng katta");
}*/
/*if16 - misol
double a, b, c; Console.Write("a = ");
a = double.Parse(Console.ReadLine()); Console.Write("b = ");
b = double.Parse(Console.ReadLine()); Console.Write("c = ");
c = double.Parse(Console.ReadLine());
if (a < b && b < c)
{
    Console.WriteLine("A = " + 2 * a + " B = " + 2 * b + " C = " + 2 * c);
}
else
{
    Console.WriteLine("A = " + a * (-1) + " B = " + b * (-1) + " C = " + c * (-1));
}*/
/*if17 - misol
double a, b, c; Console.Write("a = ");
a = double.Parse(Console.ReadLine()); Console.Write("b = ");
b = double.Parse(Console.ReadLine()); Console.Write("c = ");
c = double.Parse(Console.ReadLine());
if ((a < b && b < c) || (a > b && b > c))
{
    Console.WriteLine("A = " + 2 * a + " B = " + 2 * b + " C = " + 2 * c);
}
else
{
    Console.WriteLine("A = " + a * (-1) + " B = " + b * (-1) + " C = " + c * (-1));
}*/
/*if18 - misol
int a, b, c;     Console.Write("a = ");
a = int.Parse(Console.ReadLine());    Console.Write("b = ");
b = int.Parse(Console.ReadLine());     Console.Write("c = "); 
c = int.Parse(Console.ReadLine());
if (a == b && b == c)
{
    Console.WriteLine("Uchchala son ham teng");
}
else if (a == b)
{
    Console.WriteLine("Teng bulmaganining tartib raqami 3");
}
else if (a == c)
{
    Console.WriteLine("Teng bulmaganining tartib raqami 2");
}
else if (c == b)
{
    Console.WriteLine("Teng bulmaganining tartib raqami 1");
}
else
{
    Console.WriteLine("Ikta bir xil son kiriting");
}*/
/*if19 - misol
int a, b, c, d; Console.Write("a = ");
a = int.Parse(Console.ReadLine()); Console.Write("b = ");
b = int.Parse(Console.ReadLine()); Console.Write("c = ");
c = int.Parse(Console.ReadLine()); Console.Write("d = ");
d = int.Parse(Console.ReadLine());
if (a == b && b == c && d == c)
{
    Console.WriteLine("Turttala son ham teng");
}
else if (a == b && b == c)
{
    Console.WriteLine("Teng bulmaganining tartib raqami 4");
}
else if (a == b && b == d)
{
    Console.WriteLine("Teng bulmaganining tartib raqami 3");
}
else if (c == a && a == d)
{
    Console.WriteLine("Teng bulmaganining tartib raqami 2");
}
else if (b == c && c == d)
{
    Console.WriteLine("Teng bulmaganining tartib raqami 1");
}
else
{
    Console.WriteLine("Uchta bir xil son kiriting");
}*/
/*if20 - misol
int a, b, c, d; Console.Write("a = ");
a = int.Parse(Console.ReadLine()); Console.Write("b = ");
b = int.Parse(Console.ReadLine()); Console.Write("c = ");
c = int.Parse(Console.ReadLine()); 
if (Math.Abs(a - b) < Math.Abs(a - c))
{
    Console.WriteLine("Son uqida A ga yaqini B");
}
else if (Math.Abs(a - c) < Math.Abs(a - b))
{
    Console.WriteLine("Son uqida A ga yaqini C");
}
else if (a == b && b == c)
{
    Console.WriteLine("Uchchala son teng");
}
else if (b == c)
{
    Console.WriteLine("B va C  teng");
}
else
{
    Console.WriteLine("B va C  A dan bir xil uzoqlikda");
}*/
//if21 - misol


//if22 - misol


//if23 - misol


/*if24 - misol
double x;
Console.Write("x = ");    x = double.Parse(Console.ReadLine());
if (x > 0)
{
    Console.WriteLine(2 * Math.Asinh(x));
}
else if (x <= 0)
{
    Console.WriteLine(x - 6);
}*/
/*if25 - misol
double x;
Console.Write("x = "); x = double.Parse(Console.ReadLine());
if (x < -2 || x > 2)
{
    Console.WriteLine(x * 2);
}
else
{
    Console.WriteLine(- 3 * x);
}*/
/*if26 - misol
double x;
Console.Write("x = "); x = double.Parse(Console.ReadLine());
if (x <= 0)
{
    Console.WriteLine(- x);
}
else if (0 < x && x < 2)
{
    Console.WriteLine(Math.Pow(x, 2));
}
else if (x >= 2)
{
    Console.WriteLine("4");
}*/
/*if27 - misol
double x;
Console.Write("x = "); x = double.Parse(Console.ReadLine());
if (x < 0)
{
    Console.WriteLine("0");
}
else if (x == 0 || x % 2 == 0)
{
    Console.WriteLine("1");
}
else if (x % 2 == 1)
{
    Console.WriteLine("- 1");
}*/
/*if28 - misol
int x;  Console.Write("Yilni kiriteng  ");
x = int.Parse(Console.ReadLine());   
if (x % 100 != 0 && x % 4 == 0)
{
    Console.WriteLine("366  kun bor");
}
else if (x % 100 == 0 && x % 400 == 0)
{
    Console.WriteLine("366  kun bor");
}
else
{
    Console.WriteLine("365  kun bor");
}*/
/*if29 - misol 
int a;   Console.Write("Son kiriting  ");
a = int.Parse(Console.ReadLine());
if (a > 0 && a % 2 == 1)
{
    Console.WriteLine("Musbat toq son");
}
else if (a < 0 && a % 2 == 0)
{
    Console.WriteLine("Manfiy juft son");
}
else if (a == 0)
{
    Console.WriteLine("Son nolga teng");
}
else
{
    Console.WriteLine("x.k");
}*/
/*if30 - misol 
int a;   Console.Write("1 da 999 gacha Son kiriting  ");
a = int.Parse(Console.ReadLine());
if (a >= 10 && a <= 99 && a % 2 == 0)
{
    Console.WriteLine("Ikki xonali juft son");
}
else if (a >= 100 && a <= 999 & a % 2 == 1)
{
    Console.WriteLine("Uch xonali toq son");
}
else
{
    Console.WriteLine("x.k");
}*/
/*Case2 - misol
int K; 
Console.Write("K = "); 
K = int.Parse(Console.ReadLine());
switch(K)
{
    case 1:
        Console.WriteLine("yomon"); break;
    case 2:
        Console.WriteLine("qoniqarsiz"); break;
    case 3:
        Console.WriteLine("qoniqarli"); break;
    case 4:
        Console.WriteLine("yaxshi"); break;
    case 5:
        Console.WriteLine("a'lo"); break;
        default:  Console.WriteLine("xato"); break;
}*/
    



Console.WriteLine("_____________________________________");
goto salom;