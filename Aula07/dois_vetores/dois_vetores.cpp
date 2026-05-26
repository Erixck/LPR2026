#include <iostream>
#include <vector>

using namespace std;
int main() {
    vector<int> numeros(10);
    vector<int> pares;
    vector<int> impares;

    cout << "Digite 10 numeros inteiros:" << endl;
    for (int i = 0; i < 10; i++) {
        cout << "Numero " << (i + 1) << ": ";
        cin >> numeros[i];
    }

    for (int i = 0; i < 10; i++){
        if (numeros[i] % 2 == 0){
            pares.push_back(numeros[i]);
        }
        else {
            impares.push_back(numeros[i]);
        }
    }

    cout << "------------------------" << endl;

    cout << "Numeros pares:" << endl;
    if (pares.empty()) {
        cout << "Nenhum numero par foi digitado." << endl;
    } else {
        for (int num : pares) {
            cout << num << endl;
        }
    }

    cout << "------------------------" << endl;
    
    cout << "Numeros impares:" << endl;
    if (impares.empty()) {
        cout << "Nenhum numero impar foi digitado." << endl;
    } else {
        for (int num : impares) {
            cout << num << endl;
        }
    }
    return 0;
}