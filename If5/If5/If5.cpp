#include <iostream>

using namespace std;

//Даны три целых числа. Найти количество положительных и количество от-
//rицательных чисел в исходном наборе.

int main()
{
    int a, p = 0, o = 0;
    for (int i = 0; i <= 2; i++) {
        cout << "Enter" << endl;
        cin >> a;
        if (a > 0) {
            p++;
        } else if (a < 0) {
            o++;
        }
    }
    cout << "P =\t" << p << endl;
    cout << "O =\t" << o << endl;
    return 0;
}

