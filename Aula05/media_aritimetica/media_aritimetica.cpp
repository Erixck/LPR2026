#include <iostream>
using namespace std;

int main() {
    int quantidade, numero;
    int contador = 0;
    int soma = 0;

    cout << "Digite a quantidade de numeros: ";
    cin >> quantidade;

    int i = 0;

    while (i < quantidade) {
        cout << "Digite um numero: ";
        cin >> numero;

        if (numero % 2 == 0) { // verifica se é par
            soma += numero;
            contador++;
        }

        i++;
    }

    if (contador > 0) {
        double media = (double)soma / contador;
        cout << "Media dos numeros pares: " << media << endl;
    } else {
        cout << "Nenhum numero par foi digitado." << endl;
    }

    return 0;
}