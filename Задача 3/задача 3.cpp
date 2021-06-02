// задача 3.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <fstream>
using namespace std;
int n, m;
struct list
{
	int* info;
	list* next;

};

list* Bron_Ker(int** klika, int* m_tec, int* m_zap, list* p, int n)
{
	bool f = 1;
	int* mas_pot = new int[n];
	int* mas_zap = new int[n];
	int i, j;
	for (i = 0; i < n; i++)
	{
		mas_zap[i] = m_zap[i];
	}

	for (i = 0; i < n; i++)
	{
		mas_pot[i] = 1;
	}
	for (i = 0; i < n; i++)
	{
		if (m_tec[i] == 1)
		{
			for (j = 0; j < n; j++)
			{
				if (klika[i][j] != mas_pot[j])
					mas_pot[j] = 0;
			}
		}
	}
	for (i = 0; i < n; i++)
	{
		if (mas_pot[i] == 1)
			f = 0;
		if ((mas_pot[i] == 1) && (mas_zap[i] != 1))
		{
			m_tec[i] = 1;
			p = Bron_Ker(klika, m_tec, m_zap, p, n);
			m_tec[i] = 0;
			m_zap[i] = 1;
		}
	}
	if (f)
	{
		p->info = new int[n];
		for (i = 0; i < n; i++)
		{
			p->info[i] = m_tec[i];
		}
		p->next = new list;
		p = p->next;
	}
	return p;
}

int main()
{

	setlocale(LC_ALL, "RUS");
	int  i, j;
	ifstream gr("graf.txt");
	gr >> n;
	gr >> m;
	int** graf;
	graf = new int* [n];
	for (i = 0; i < n; i++)
		graf[i] = new int[n];
	
	for (i = 0; i < n; i++)
		for (j = 0; j < n; j++)
			graf[i][j] = 0;
	int x, y;
	for (i = 0; i < m; i++)
	{
		gr >> x >> y;
		graf[x][y] = 1;
		graf[y][x] = 1;
	}
	gr.close();

	int* m_tec = new int[n];
	int* m_zap = new int[n];
	for (i = 0; i < n; i++)
	{
		m_tec[i] = 0;
	}

	for (i = 0; i < n; i++)
	{
		m_zap[i] = 0;
	}
	list* beg = new list;
	list* p = beg;
	for (i = 0; i < n; i++)
	{
		m_tec[i] = 1;
		p = Bron_Ker(graf, m_tec, m_zap, p, n);
		m_zap[i] = 1;
		for (j = 0; j < n; j++)
		{
			m_tec[j] = 0;
		}

	}
	p->next = NULL;
	ofstream rez("rez.txt");
	rez << "Максимальные клики в графе:" << endl;
	p = beg;
	while (p->next != NULL)
	{
		rez << "{ ";
			for (i = 0; i < n; i++)
			{	
				
				if (p->info[i] == 1)
					rez << i << " ";
				
			}
			rez << "}";
		rez << endl;
		p = p->next;
	}

	return 0;
}
