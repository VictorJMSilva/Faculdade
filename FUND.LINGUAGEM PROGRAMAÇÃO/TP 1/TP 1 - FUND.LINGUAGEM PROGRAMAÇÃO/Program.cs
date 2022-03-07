/* Victor de Jesus - RA x - Análise e Desenvolvimento de Sistemas
 * TP 1 

// EXERCÍCIO 1

int a, b, alt;
Console.Write("Digite o valor da base: ");
a = int.Parse(Console.ReadLine());
Console.Write("Digite o valor da altura:");
b = int.Parse(Console.ReadLine());
alt = a * b;
Console.Write("A área do retângulo é:" + alt);
Console.ReadKey();


// EXERCÍCIO 2

int aresta, area;
Console.WriteLine("Digite o valor da aresta do quadrado: ");
aresta = int.Parse(Console.ReadLine());
area = (int)Math.Pow(aresta, 2);
Console.WriteLine("A área do quadrado é: " + area);
Console.ReadKey();

EXERCÍCIO 3
float diag, area;
Console.WriteLine(" Digite o valor da diagonal para saber a area do quadrado:");
diag = int.Parse(Console.ReadLine());
area = (float)Math.Pow(diag, 2) / 2;
Console.WriteLine("O valor da área do quadrado é:" + area);
Console.ReadKey();


// EXERCÍCIO 4

int alt, b, area;
Console.WriteLine("Digite o valor da base do triângulo: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da altura do triângulo: ");
alt = int.Parse(Console.ReadLine());
area = (b * alt) / 2;
Console.WriteLine("A área do triângulo é: " + area);
Console.ReadKey();


// EXERCÍCIO 5

double vol, diam;
Console.WriteLine("Digite o diâmetro da esfera para obter seu volume:");
diam = Convert.ToDouble(Console.ReadLine());
vol = (4 * 3.14 * (Math.Pow(diam, 3))) / 3;
Console.WriteLine("O volume da esfera é de: " + vol);
Console.ReadKey();


// EXERCÍCIO 6

Double media, p1, p2, p3, p4;
Console.WriteLine("Digite o valor da p1: ");
p1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor da p2: ");
p2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor da p3: ");
p3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor da p4: ");
p4 = Convert.ToDouble(Console.ReadLine());
media = (p1 + p2 + p3 + p4) / 4;
Console.WriteLine("A média dos valores é: " + media);
Console.ReadKey();


// EXERCÍCIO 7 

double n1, n2, media;
Console.WriteLine("Digite o valor 1: ");
n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor 2: ");
n2 = Convert.ToDouble(Console.ReadLine());
media = (Math.Sqrt(n1 * n2));
Console.WriteLine("A média geométrica é: " + media);
Console.ReadKey();


//EXERCÍCIO 8

Double milhas, km;
Console.WriteLine("Conversor de milhas para quilômetros.");
Console.WriteLine("milhas: ");
milhas = Convert.ToDouble(Console.ReadLine());
km = milhas * 1.852;
Console.WriteLine("Quilômetros: " + km.ToString("n"));
Console.ReadKey();


// EXERCÍCIO 9

Double tensao, resistencia, corrente;
Console.WriteLine("Calculadora de tensão");
Console.WriteLine("Digite a resistência: ");
resistencia = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a corrente elétrica : ");
corrente = Convert.ToDouble(Console.ReadLine());
tensao = corrente * resistencia;
Console.WriteLine("A tensão do circuito é: " + tensao + "V");
Console.ReadKey();


// EXERCÍCIO 10

Double C, F;
Console.WriteLine("Conversor de temperatura C para °F");
Console.WriteLine("Digite a temperatura em °C: ");
C = Convert.ToDouble(Console.ReadLine());
F = (C * 1.8) + 32;
Console.WriteLine("A temperatura em Fahrenheit é: " + F);
Console.ReadKey();


// EXERCÍCIO 11

Double diametro, area;
Console.WriteLine("Digita o diâmetro do circulo para saber sua área: ");
diametro = Convert.ToDouble(Console.ReadLine());
area = (Math.Pow(diametro, 2)) * 3.14;
Console.WriteLine("A área do circulo é :" + area);
Console.ReadKey();


// EXERCÍCIO 12

Double r, h, v;
Console.WriteLine("Digite a altura do cone: ");
h = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o raio da base do cone: ");
r = Convert.ToDouble(Console.ReadLine());
v = (3.14 * (Math.Pow(r, 2)) * h) / 3;
Console.WriteLine("O volume do cone é: " + v);
Console.ReadKey();


// EXERCÍCIO 13

Double velf, vi, a, t;
Console.WriteLine("Digite a velocidade inicial do veículo (em m/s): ");
vi = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a aceleração do veículo (em m/s): ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o tempo do percurso(em s): ");
t = Convert.ToDouble(Console.ReadLine());
velf = (vi + a * t) * 3.6;
Console.WriteLine("A velocidade final do veículo é: " + velf + "KM/H");
Console.ReadKey();


// EXERCÍCIO 14

Double r, a, l;
Console.WriteLine("Digite o valor do raio da esfera: ");
r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor da aresta do cubo: ");
a = Convert.ToDouble(Console.ReadLine());
l = ((6 * (Math.Pow(a, 2))) - ((4 * 3.14 * (Math.Pow(r, 3))) / 3));
if (r <= a / 2)
    Console.WriteLine(" O volume livre do cubo é: " + l);
else
    Console.WriteLine("Não e possivel realizar o calculo.");
Console.ReadKey();


// EXERCÍCIO 15

Double r, d, c;
Console.WriteLine("Digite a cotação do dólar:");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor que deseja converter para real:");
d = Convert.ToDouble(Console.ReadLine());
r = c * d;
Console.WriteLine("Vale: " + "R$" + r.ToString("n") + " hoje.");
Console.ReadKey();


// EXERCÍCIO 16

Double a, s, c, t, se;
Console.WriteLine("Digite o ângulo que deseja saber as funções trigonometricas:");
a = Convert.ToDouble(Console.ReadLine());
s = (Math.Sin((a * Math.PI) / 180));
c = (Math.Cos((a * Math.PI) / 180));
t = (Math.Tan((a * Math.PI) / 180));
se = (1 / Math.Cos((a * Math.PI) / 180));
Console.WriteLine("Seno do ângulo " + a + " é " + s);
Console.WriteLine("Coseno do ângulo " + a + " é " + c);
Console.WriteLine("Tangente do ângulo " + a + " é " + t);
Console.WriteLine("Secante do ângulo " + a + " é " + se);
Console.ReadKey();


// EXERCÍCIO 18

Double v1, v2, v3, v4, v5, tr, tt, dv;
Console.WriteLine("Digite o valor do produto v1: ");
v1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor do produto v2: ");
v2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor do produto v3: ");
v3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor do produto v4: ");
v4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor do produto v5: ");
v5 = Convert.ToDouble(Console.ReadLine());
tt = v1 + v2 + v3 + v4 + v5;
Console.WriteLine("Valor total é: " + tt);
Console.WriteLine("Digite a quantia que o cliente esta dando para ser feito o calculo do troco:");
dv = Convert.ToDouble(Console.ReadLine());
tr = dv - tt;
Console.WriteLine("O valor a ser devolvido é de: " + tr + " reais.");
Console.ReadKey(); */
