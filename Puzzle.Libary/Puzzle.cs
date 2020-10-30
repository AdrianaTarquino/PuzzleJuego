using System;

using System.Linq;
namespace JuegoPuzzle
{
        public class Puzzle
        {
            private int[,] matriz = new int[3, 3];
            public int segundo = 0;
                
            public void play(int[,] matriz,int row,int col)
            {
               
                if (row < 2 && matriz[row + 1, col] == 0)
                {
                    matriz[row + 1, col] = matriz[row, col];
                    matriz[row, col] = 0;
                }
                if (row > 0 && matriz[row - 1, col] == 0)
                {
                    matriz[row - 1, col] = matriz[row, col];
                    matriz[row, col] = 0;
                }
                if (col < 2 && matriz[row, col + 1] == 0)
                {
                    matriz[row, col + 1] = matriz[row, col];
                    matriz[row, col] = 0;
                }
                if (col > 0 && matriz[row, col - 1] == 0)
                {
                    matriz[row, col - 1] = matriz[row, col];
                    matriz[row, col] = 0;
                }
            }
            public int show(int row,int col)
            {
                int num = matriz[row, col];

            return num;
            }
            public void WinGame()
            {
               // if (matriz[0, 0] == 1 && matriz[0, 1] == 2 && matriz[0, 2] == 3 && matriz[1, 0] == 4 && matriz[1, 1] == 5 && matriz[1, 2] == 6 && matriz[2, 0] == 7 && matriz[2, 1] == 8 && matriz[2, 2] == 0)
                   //MessageBox.Show("FELICIDADES GANASTEE");
            }
       
            public void GenerarNumero()
            { 
                Random aleatorio = new Random();
                int num, num2, repetido, numMat = 0;
                int aux;
                int[] vec = Enumerable.Range(1, 9).OrderBy(c => aleatorio.Next()).ToArray();
                for (int i = 0; i < vec.Count(); i++)
                {
                    num = vec[i];
                    aux = i + 1;
                    for (int j = aux; j < vec.Count(); j++)
                    {
                        num2 = vec[j];
                        if (num == num2)
                        {
                            repetido = aleatorio.Next(1, 9);
                            vec[j] = repetido;
                        }
                    }
                }
                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        matriz[i, j] = vec[numMat];
                        numMat += 1;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matriz[i, j] == 9)
                        {
                            matriz[i, j] = 0;
                        }
                    }
                }
                //acomodar(matriz);
            }
        }

    
}
