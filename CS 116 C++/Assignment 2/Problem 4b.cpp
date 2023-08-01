#include <iostream>
using namespace std;
int main() {
	int i;
	int sum = 0;
	long double product = 1;
	for (i = 1; i <= 100; i++) {
		sum = sum + i;
		product = product * i;
	}
	cout << "Sum of numbers 1-100: " << sum << endl;
	cout << "Product of numbers 1-100: " << product << endl;
}