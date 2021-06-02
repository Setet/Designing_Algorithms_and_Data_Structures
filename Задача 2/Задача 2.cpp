// Задача 2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <fstream>
using namespace std;
int w1, w2,n,m;
void matr(int** a)
{
	ifstream sc("graf.txt");
	int i,j,x,y,r;
	sc >> n >> m;
	for (i = 1; i <= n; i++)
		for (j = 1; j <= n; j++)
		{
			a[i][j] = 0;
		}
	for (i = 0; i < m; i++)
	{
		sc >> x >> y >> r;
		a[x][y] = r;
		a[y][x] = a[x][y];
	}
	sc.close();
	for (i = 1; i <= n; i++)
		for (j = 1; j <= n; j++)
		{
			if (a[i][j] == 0)
				a[i][j] = 1000;
		}
}
void min(int** a)
{
	int i, j;
	int m = 1000;
	for (i = 1; i <= n; i++)
		for (j = 1; j <= n; j++)
			if (m > a[i][j])
			{
				m = a[i][j];
				w1 = i;
				w2 = j;
			}
	if (m != 1000)
		a[w1][w2] = 1000;
	else
		w1 = -1;
	
}

int main()
{
	ifstream sc("graf.txt");
	int i, j;
	sc >> n>>m;
	sc.close();
	int** a;
	a = new int*[n+1];
	for (int i = 1; i <= n; i++)
		a[i] = new int[n+1];
	int** t;
	t = new int* [n+1];
	for (int i = 0; i < n; i++)
		t[i] = new int[n + 1];
	int* v = new int [n+1];
	int index = 0;
	matr(a);
	for (i = 1; i <= n; i++)
		v[i] = i;

	do
	{
		min(a);
		if (v[w1] != v[w2])
		{
			t[0][index] = w1;
			t[1][index] = w2;
			index++;
			int temp = v[w2];
			for (i = 1; i <= n; i++)
			{
				if (v[i] == temp)
					v[i] = v[w1];

			}
		}
		else 
			a[w1][w2] = 1000;
		
	} while (w1 > -1);
	ofstream rez("rez.txt");
	rez << "Ребра остовного дерева" << endl;
	for (i = 0; i < index-1; i++)
		rez << "(" << t[0][i] << " ; " << t[1][i] << ")" << endl;
}


