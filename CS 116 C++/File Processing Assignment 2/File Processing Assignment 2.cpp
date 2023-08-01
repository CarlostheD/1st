#include <iostream>
#include <fstream>
#include <cstring>
#include <string>
#include <cctype>
using namespace std;
bool isDigit(char ch);
int main() {
ifstream infile;
ofstream outfile;
outfile.open("C:/Users/carlos/OneDrive/Desktop/Courses/CS 116/output.txt");
infile.open("C:/Users/carlos/OneDrive/Desktop/Courses/CS 116/input.txt");
if (infile.fail()) {
	cout << "file is not found\n";
	exit(0);
}
int count = 0;
int upper = 0;
int lower = 0;
int space = 0;
int linecount = 0;
int other = 0;
char ch;
while (infile.get(ch))
{
	if (isDigit(ch)) {
		count++;
	}
	if (isupper(ch)) {
		upper++;
	}
	if (islower(ch)) {
		lower++;
	}
	if (isspace(ch)) {
		space++;
	}
	if (ch == '\n') {
		linecount++;
	}
    else {
   	   other++;
	}
}
outfile << "1. Total number of upper case alphabet: " << upper << endl;
outfile << "2. Total number of lower case alphabet: " << lower << endl;
outfile << "3. Total number of white space (blank, ‘\n’ and ‘\t’): " << space << endl;
outfile << "4. Total number of lines: " << linecount << endl;
outfile << "5. Total number of digits: " << count << endl;
outfile << "6. Total number any other type of characters: " << other << endl;

infile.close();
outfile.close();
system("pause");
return 0;
}

bool isDigit(char ch)
{
	return ch >= '0' && ch <= '9';
}