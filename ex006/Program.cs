﻿int a = 1;
int b = 5;
int c = 10;
int d = 2;
int e = 9;

int max = a;
if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.Write(max);