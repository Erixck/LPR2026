#include <iostream>
#include <list>
#include <algorithm>

using namespace std;


int main(){
    list<float> notas;

    for(int i = 0; i < 5; i++){
        float nota;
        cout << "Digita a nota do aluno " << i + 1 << ": ";
        cin >> nota;
        notas.push_back(nota);
    }
    
    cout << "--------------------------" << endl;
    cout << "Notas dos alunos: " << endl;
    for(auto nota : notas){
        cout << nota << endl;
    }
    cout << "--------------------------" << endl;
    
    cout << "A maior nota e: " << *max_element(notas.begin(), notas.end()) << endl;
    cout << "A menor nota e: " << *min_element(notas.begin(), notas.end()) << endl;

    cout << "--------------------------" << endl;

    float media = 0;

    for(const auto& nota : notas){
        media += nota;
    }
    cout << "A media das notas e: " << (media / static_cast<float>(notas.size())) << endl;
}