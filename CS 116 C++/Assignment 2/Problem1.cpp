#include <iostream>

using namespace std;

int main()
{
	
	int number1;
	int number2;;
	cout << "Input 1st integer" << endl;
	cin >> number1;
	cout << "Input 2nd integer" << endl;
	cin >> number2;

	cout << "Sum:" << number1 + number2 << endl;
	cout << "Product:" << number1 * number2 << endl;
	cout << "Average:" << (number1 + number2) / 2 << endl;
	cout << "Remainder:" << number1 % number2 << endl;
	return 0;
}