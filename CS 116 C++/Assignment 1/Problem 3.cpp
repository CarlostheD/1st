#include <iostream>
using namespace std;
int main() {
	//declare variables
	double x1;
	double x2;
	int a;
	int b;
	int c;
	int Discriminant;
	cout << "Enter values for a, b, and c:";
	cin >> a;// enter values
	cin >> b;
	cin >> c;
	// formula
	Discriminant = (b * b) - (4 * a * c);
	x1 = (-b + sqrt(Discriminant)) / (2 * a);
	x2 = (-b - sqrt(Discriminant)) / (2 * a);
	// if Discriminant greater than 0 or positive.
	if (Discriminant > 0) {
		cout << "Driscriminant = " << Discriminant << endl;
		cout << "Equation has two real roots" << endl;
		cout << "Roots are as follows:" << endl;
		cout << "x1 = " << x1 << endl;
		cout << "x2 = " << x2 << endl;
		
	}// if discriminant equal to 0
	else if (Discriminant == 0) {
		cout << "Driscriminant = " << Discriminant << endl;
		cout << "The roots are real and equal" << endl;
		cout << "Roots are as follows:" << endl;
		cout << "x1 = " << x1 << endl;
		cout << "x2 = " << x2 << endl;
	}// if discriminant a negative
	else if (Discriminant < 0) {
		cout << "Driscriminant = " << Discriminant << endl;
		cout << "Equation has two complex roots" << endl;
		cout << "Roots are as follows:" << endl;
		cout << "x1 = " << x1 << endl;
		cout << "x2 = " << x2 << endl;
	}
}