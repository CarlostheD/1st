#include <iostream>
#include <string>
#include <cstdlib>
#include <cmath>
using namespace std;
//Author: Carlos Davalos
// October, 15 2022
//prototypes
void doTheJob();
string reverse(string str);
string cheese;
int findL(string str);
int main(){
    doTheJob();
    return 0;
}
void doTheJob()
{
    cout << "Input a phrase with letter L's.";
    getline(cin, cheese);
    cout << "Reversed phrase: " << reverse(cheese) << endl;
    cout << "Number of L's: " << findL(cheese) << endl;
}
//string reversal
string reverse(string str){
    string a = "";
    for (int i = str.length() - 1; i >= 0; i--) {
        a += str[i];
    }
    return a;
}
// finding L or l in the string and giving amount of.
int findL(string str) {
        int num = 0;
        
        for (int i = 0; i < str.length(); i++) {
            if (str[i] == 'L' || str[i] == 'l') {
                num++;
            }
        }
        return num;
    }