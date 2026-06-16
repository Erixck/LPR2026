#include <iostream>
#include <string>
#include <vector>

using namespace std;

struct Livro {
    string titulo;
    string autor;
    int anoPublicacao;
    int NumeroPaginas;
    double preco;
};

void lerLivro(Livro &l) {
    cout << "Digite o titulo do livro: " << endl;
    getline(cin, l.titulo);
    cout << "Digite o autor do livro: " << endl;
    getline(cin, l.autor);
    cout << "Digite o ano de publicacao do livro: " << endl;
    cin >> l.anoPublicacao;
    cout << "Digite o numero de paginas do livro: " << endl;
    cin >> l.NumeroPaginas;
    cout << "Digite o preco do livro: " << endl;
    cin >> l.preco;

    cin.ignore();
}

void soma(const Livro &l1, const Livro &l2, const Livro &l3) {
    double soma = l1.preco + l2.preco + l3.preco;
    cout << "A soma dos precos dos livros e: " << soma << endl;
}
void media(const Livro &l1, const Livro &l2, const Livro &l3) {
    double media = (l1.preco + l2.preco + l3.preco) / 3;
    cout << "A media dos precos dos livros e: " << media << endl;
}

int main(){
    Livro l1, l2, l3;
    lerLivro(l1);
    lerLivro(l2);
    lerLivro(l3);
    soma(l1, l2, l3);
    media(l1, l2, l3);
}