#include <iostream> 

using namespace std;

int main() {
    double raio, area;
    const double PI = 3.14159;
    
    cout << "Insira o valor do raio" << endl;
    cin >> raio;

    area = PI * raio * raio;

    cout << "Area do circulo:" <<area<< endl;
}