#include <iostream>

using namespace std;

int main() {   
    int origem, destino;
    
    int distancia[4][4] = {
        {0, 524, 521, 882},
        {524, 0, 434, 586},
        {521, 434, 0, 429},
        {882, 586, 429, 0}
    };
    
    string cidades[4] = {"Vitoria", "Belo Horizonte", "Rio de Janeiro", "Sao Paulo"};
    
    cout << "Consulta de distancia " << endl;

    while(1){
        cout << "Escolha uma cidade: " << endl;
        for (int i = 0; i < 4; i++) {
            cout << i << " - " << cidades[i] << endl;
        }

        cout << "Escolha uma cidade de origem (0 a 3)" << endl;
        cin >> origem;
        
        cout << "Escolha uma cidade de destino (0 a 3)" << endl;
        cin >> destino;

        if (origem < 0 || origem > 3 || destino < 0 || destino > 3) {
            cout << "Cidade invalida. Tente novamente." << endl;
            continue;
        }

        if (origem == destino) {
            cout << "\nA cidade de origem e destino sao iguais (" << cidades[origem] << ")." << endl;
            cout << "Encerrando o programa... Obrigado por utilizar!" << endl;
            break; // Quebra o laço 'while' e finaliza o programa
        }

        cout << "\nA distancia rodoviaria entre " << cidades[origem] 
             << " e " << cidades[destino] << " eh de: " 
             << distancia[origem][destino] << " km." << endl;
        
        cout << "---------------------------------------------------" << endl;
    }

    return 0;
}
