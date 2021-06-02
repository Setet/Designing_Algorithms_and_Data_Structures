#include <iostream>
#include <fstream>
using namespace std;
void tr(int** a, int** b, int** c, int n)
{
	int i, j, k;
	for (i = 0; i < n; i++)
		for (j = 0; j < n; j++)
			b[i][j] = a[i][j];
	for (int l = 2; l < n; l++)
	{
		for (i = 0; i < n; i++)
		{
			for (j = 0; j < n; j++)
			{
				c[i][j] = 0;
				for (k = 0; k < n; k++)
					c[i][j] |= a[i][k] & b[k][j];
			}
		}
		for (i = 0; i < n; i++)
			for (j = 0; j < n; j++)
				b[i][j] = c[i][j];
	}
	ofstream out("tranzit.txt");
	for (i = 0; i < n; i++)
	{
		for (j = 0; j < n; j++)
			out << c[i][j] << "  ";
		out << endl;
	}
	out.close();
}
int main()
{
	setlocale(LC_CTYPE, "ru");
	ifstream gr("граф.txt");
	int n;
	gr >> n;
	int** graf;
	graf = new int* [n];
	for (int i = 0; i < n; i++)
		graf[i] = new int[n];
	int** b;
	b = new int* [n];
	for (int i = 0; i < n; i++)
		b[i] = new int[n];
	int** c;
	c = new int* [n];
	for (int i = 0; i < n; i++)
		c[i] = new int[n];
	for (int i=0;i<n;i++)
		for (int j = 0; j < n; j++)
		{
			b[i][j] = 0;
			c[i][j] = 0;
		}
	while (!gr.eof())
	{
		for (int i = 0; i < n; i++)
			for (int j = 0; j < n; j++)
				gr >> graf[i][j];
	}
	gr.close();
	tr(graf,b,c,n);
}