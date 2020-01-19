#include <iostream>
#include <cmath>

using namespace std;

//Дана длина ребра куба a. Найти объем куба V = a3 и площадь его по-
//верхности S = 6·a2.

int main()
{
    int a;
    cout << "Enter a" << endl;
    cin >> a;
    cout << "V =\t" << pow(a, 3) << endl;
    cout << "S -\t" << pow(a, 2) * 6 << endl;


    return 0;
}

