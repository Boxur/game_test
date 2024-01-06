#include <iostream>
#include <vector>

using namespace std;

void DFS(const vector <vector <int>> LISTA, vector<bool> &SĄSIEDZI, int WIERZCHOLEK) {

    if(SĄSIEDZI.at(WIERZCHOLEK))
        return;
    else
        SĄSIEDZI.at(WIERZCHOLEK) = true;
        for(int i = 0; i < LISTA.at(WIERZCHOLEK).size(); ++i)
            DFS(LISTA, SĄSIEDZI, i);
}


int main() {

    int ILOSC_WIERZCHOLKOW;
    int ILOSC_KRAWEDZI;
    int A,B;
    cin >> ILOSC_WIERZCHOLKOW >> ILOSC_KRAWEDZI;

    vector <vector <int>> LISTA (ILOSC_WIERZCHOLKOW);
    vector <bool> SĄSIEDZI(ILOSC_WIERZCHOLKOW);

    for(int i = 0; i < ILOSC_KRAWEDZI; ++i) {
        cin >> A >> B;
        LISTA.at(A).push_back(B);
        LISTA.at(B).push_back(A);
    }

    cout << "===========================" << endl;
    cout << "podaj wierzcholek startowy:" << endl;
    cin >> A;

    DFS(LISTA, SĄSIEDZI, A);


}