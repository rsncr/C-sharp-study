﻿int a = 1;
int b = 8;
int c = 6;
int d = 5;
int e = 22;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);