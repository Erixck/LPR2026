#include <iostream>
#include <list>
#include <string>

using namespace std;

int main() {
    int x;
    cout << "Digite a quantidade de nomes" << endl;
    cin >> x;

    list<string> nomes;
    string nome;

    cout << "Nomes" << endl;
    for (int i = 0; i < x; i++) {
        cin >> nome;
        nomes.push_back(nome);
    }

    while (!nomes.empty()) {

        list<string::size_type> tamanhosUsados;
        bool primeiro = true;

        for (auto it = nomes.begin(); it != nomes.end(); ) {

            bool existe = false;

            for (auto t : tamanhosUsados) {
                if (t == it->size()) {
                    existe = true;
                    break;
                }
            }

            if (!existe) {

                if (!primeiro) {
                    cout << ", ";
                }

                cout << *it;
                primeiro = false;

                tamanhosUsados.push_back(it->size());

                it = nomes.erase(it);
            }
            else {
                ++it;
            }
        }

        cout << endl;
    }

    return 0;
}