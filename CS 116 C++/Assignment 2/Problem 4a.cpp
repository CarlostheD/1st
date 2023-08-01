#include <iostream>
using namespace std;
int main() {
	int i = 1;
	int sum=0;
	long double product = 1;
	while (i <= 100) {
		sum = sum + i;
		product = product * i;
		++i;
	}
	cout << "Sum: " << sum << endl;
	cout << "Product: " << product << endl;
	
}