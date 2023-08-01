#include <iostream>
using namespace std;
int main() {
	// declared variables
	int num;
	int max = 0.0;
	int min = 0.0;
	double average = 0.0;
	int count = 0;
	int sum = 0.0;
	cout << "Enter Integers" << endl;
	cin >> num; // input integer
	min = num;
	max = num;
	// one while loop that displays results after -99 is input
	while (num != -99) {
		cin >> num;
		sum = sum + num;
		count++;
		average = sum / count;
		if (num > max) {
			max = num;
			
		}
		if (num < min) {
			min = num;
			
		}
	}
	// results
	cout << "Average: " << average << endl;
	cout << "Max: " << max << endl;
	cout << "Minimum: " << min << endl;
}