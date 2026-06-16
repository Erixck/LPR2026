#include <iostream>
#include <string>
#include <vector>

using namespace std;

struct Filme {
    string titulo;
    string diretor;
    int anoLancamento;
    int duracao;
};

void lerFilme(Filme &f) {
    cout << "Digite o titulo do filme: " << endl;
    getline(cin, f.titulo);
    cout << "Digite o diretor do filme: " << endl;
    getline(cin, f.diretor);
    cout << "Digite o ano de lancamento do filme: " << endl;
    cin >> f.anoLancamento;
    cout << "Digite a duracao do filme em minutos: " << endl;
    cin >> f.duracao;

    cin.ignore();
}

void exibirFilme(const Filme &f) {
    cout << "Titulo: " << f.titulo << endl;
    cout << "Diretor: " << f.diretor << endl;
    cout << "Ano de Lancamento: " << f.anoLancamento << endl;
    cout << "Duracao: " << f.duracao << " minutos" << endl;
}

int main(){
    Filme f1, f2, f3;
    lerFilme(f1);
    lerFilme(f2);
    lerFilme(f3);
    exibirFilme(f1);
    exibirFilme(f2);
    exibirFilme(f3);
}