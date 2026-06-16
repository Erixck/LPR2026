#include <iostream>
#include <string>
#include <vector>

using namespace std;

struct Produto {
    string nome;
    int codigo;
    double preco;
    int quantidade;
};

void lerProduto(Produto &p) {
    cout << "Digite o nome do produto: " << endl;
    getline(cin, p.nome);
    cout << "Digite o codigo do produto: " << endl;
    cin >> p.codigo;
    cout << "Digite o preco do produto: " << endl;
    cin >> p.preco;
    cout << "Digite a quantidade do produto: " << endl;
    cin >> p.quantidade;

    cin.ignore();
}

void valorTotal(Produto &p) {
    double total = p.preco * p.quantidade;
    cout << "Valor total do produto " << p.nome << ": " << total << endl;
}

int main(){
    Produto p1, p2, p3;
    lerProduto(p1);
    lerProduto(p2);
    lerProduto(p3);

    valorTotal(p1);
    valorTotal(p2);
    valorTotal(p3);
}
