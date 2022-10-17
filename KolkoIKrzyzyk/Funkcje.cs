using System;
using System.Collections.Generic;
using System.Text;

namespace KolkoIKrzyzyk
{
    class Funkcje
    {
        
        char[,] plansza = new char[3,3];
        char gracz { get; set; }
        bool wygrana { get; set; }
        public Funkcje()
        {
            gracz = 'X';
            wygrana = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    plansza[i, j] = ' ';
                }
            }
        }
        public void start()
        {
            while (wygrana == false)
            {
                if (gracz == 'X')
                {
                    gracz = 'O';
                }
                else if (gracz == 'O')
                {
                    gracz = 'X';
                }
                DrawGame();
                Move();
                IsWin(gracz);
                Console.Clear();
            }
            DrawGame();
            Console.WriteLine("\nGratuluje, wygrał gracz: " + gracz);
        }
        void IsWin(char gracz)
        {
            int wynik = 0;
            for (int i = 0; i < 3; i++)
            {
                wynik = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (plansza[i,j] == gracz)
                    {
                        wynik++;
                    }
                }
                if (wynik == 3)
                {
                    wygrana = true;
                }
            }
            wynik = 0;
            for (int i = 0; i < 3; i++)
            {
                wynik = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (plansza[j,i] == gracz)
                    {
                        wynik++;
                    }
                }
                if (wynik == 3)
                {
                    wygrana = true;
                }
            }
            wynik = 0;
            for (int j = 0; j < 3; j++)
            {
                if (plansza[j,j] == gracz)
                {
                    wynik++;
                }
            }
            if (wynik == 3)
            {
                wygrana = true;
            }
            wynik = 0;
            for (int j = 0; j < 3; j++)
            {
                if (plansza[j,2 - j] == gracz)
                {
                    wynik++;
                }
            }

            if (wynik == 3)
            {
                wygrana = true;
            }
        }
        void DrawGame()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(plansza[i, j]);
                    if (j < 2)
                    {
                        Console.Write("|");
                    }
                }
            }
        }
        void Move()
        {
            bool death = true;
            
            while(death)
            {
                var cki = System.Console.ReadKey(true);
                char wybor = cki.KeyChar;
                switch (wybor)
                {
                    case '1':
                        if (plansza[2, 0] == ' ')
                        {
                            plansza[2, 0] = gracz;
                            death = false;
                        }
                        else
                        {
                            Console.WriteLine("\nPole zajęte");
                            continue;
                        }
                        break;
                    case '2':
                        if (plansza[2, 1] == ' ')
                        {
                            plansza[2, 1] = gracz;
                            death = false;
                        }
                        else
                        {
                            Console.WriteLine("\nPole zajęte");
                            continue;
                        }
                        break;
                    case '3':
                        if (plansza[2, 2] == ' ')
                        {
                            plansza[2, 2] = gracz;
                            death = false;
                        }
                        else
                        {
                            Console.WriteLine("\nPole zajęte");
                            continue;
                        }
                        break;
                    case '4':
                        if (plansza[1, 0] == ' ')
                        {
                            plansza[1, 0] = gracz;
                            death = false;
                        }
                        else
                        {
                            Console.WriteLine("\nPole zajęte");
                            continue;
                        }
                        break;
                    case '5':
                        if (plansza[1, 1] == ' ')
                        {
                            plansza[1, 1] = gracz;
                            death = false;
                        }
                        else
                        {
                            Console.WriteLine("\nPole zajęte");
                            continue;
                        }
                        break;
                    case '6':
                        if (plansza[1, 2] == ' ')
                        {
                            plansza[1, 2] = gracz;
                            death = false;
                        }
                        else
                        {
                            Console.WriteLine("\nPole zajęte");
                            continue;
                        }
                        break;
                    case '7':
                        if (plansza[0, 0] == ' ')
                        {
                            plansza[0, 0] = gracz;
                            death = false;
                        }
                        else
                        {
                            Console.WriteLine("\nPole zajęte");
                            continue;
                        }
                        break;
                    case '8':
                        if (plansza[0, 1] == ' ')
                        {
                            plansza[0, 1] = gracz;
                            death = false;
                        }
                        else
                        {
                            Console.WriteLine("\nPole zajęte");
                            continue;
                        }
                        break;
                    case '9':
                        if (plansza[0, 2] == ' ')
                        {
                            plansza[0, 2] = gracz;
                            death = false;
                        }
                        else
                        {
                            Console.WriteLine("\nPole zajęte");
                            continue;
                        }
                        break;
                }
            }
        }
    }
}
