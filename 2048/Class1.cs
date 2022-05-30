using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public class play2048
    {
        public int[,] playing_field = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        public long score = 0;
        public bool end = false;
        Random rnd = new Random();
        public void random() //добавление случайного числа на свободную ячейку поля 
        {
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (playing_field[i, k] == 0) count = count + 1; //проходим по всему полю и находим количество нулевых элементов
                }
            }
            int d;
            d = rnd.Next(1, count + 1); //получаем случайный номер нулевого элемента 
            int temp = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (playing_field[i, k] == 0) //если элемент поля не 0 - добовляем 1 
                    {
                        temp = temp + 1;
                    }
                    if(temp == d) //если второй счетчик совпал со случайным индексом, то в эту ячейку добовляем 2 или 4
                    {
                        int m;
                        m = rnd.Next(1, 15); //случайное число просто для создания шансов выпадения 2 и 4
                        if (m < 14)
                        {
                            playing_field[i, k] = 2;
                        }
                        else
                        {
                            playing_field[i, k] = 4;
                        }
                        return;
                    }
                }
            }
        }
        public bool CheckEnd() //проверяет налиние нулей в поле, если нулей нет - новое число добавить некуда, а значит игра проиграна 
        {
            bool lose = true;
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (playing_field[i, k] == 0)
                    {
                        lose = false;
                        return lose;
                    }
                }
            }
            return lose;
        }
        public void newplay() //начинает новую игру - обнуляет поле, счет и счетчик для конца игры
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    playing_field[i, j] = 0;
                }
            }
            score = 0;
            end = false;
        }
        public void print() //так как класс изначально писался на консоли, осталась эта процедура (она выводит поле 2048 на консоль)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int l = 0; l < 4; l++)
                {
                    Console.Write(playing_field[i, l]);
                }
                Console.WriteLine();
            }

        }
        public void up()
        {
            bool check = false;
            Stack<int> temp = new Stack<int>();
            for (int j = 3; j > 0; j--)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (playing_field[0, k] == playing_field[1, k] && playing_field[1, k] == playing_field[2, k] && playing_field[2, k] == playing_field[3, k])
                        {
                            check = true;        // особый случай, когда поле выглядит вот так [ 2 * * * ] из него, при свайпе вверх должно получиться поле [ 4 * * * ]
                            temp.Push(k);        //                                            [ 2 * * * ]                                                  [ 0 * * * ]
                                                 //                                            [ 2 * * * ]                                                  [ 4 * * * ]   
                                                 //                                            [ 2 * * * ]                                                  [ 0 * * * ]
                        }
                        if (playing_field[i + 1, k] == playing_field[i, k]) //если 2 элемента равны - "cдвигаем" ячейки(из одной удаляем а другую удваиваем)
                        {
                            playing_field[i, k] = playing_field[i, k] * 2;
                            score = score + playing_field[i, k];
                            if (playing_field[i, k] == 2048) //если при сложении мы получили 2048 - значит игра пройдена
                            {
                                end = true;
                            }
                            playing_field[i + 1, k] = 0;
                        }
                        if (playing_field[i, k] == 0 && playing_field[i + 1, k] != 0)
                        {
                            playing_field[i, k] = playing_field[i + 1, k];
                            playing_field[i + 1, k] = 0;
                        }
                    }
                }
            }
            if (check == true)
            {
                for (int i = temp.Count; i > 0; i--)
                {
                    int l = playing_field[0, temp.Peek()];
                    playing_field[0, temp.Peek()] = l / 2;
                    playing_field[1, temp.Peek()] = l / 2;
                    playing_field[2, temp.Peek()] = 0;
                    playing_field[3, temp.Peek()] = 0;
                    temp.Pop();
                }
            }
            if (CheckEnd() == false)
            {
                random();
            }
        }
        public void down() //все так же как и в up(), но только последовательность сдвига меняется 
        { 
            bool check = false;
            Stack<int> temp = new Stack<int>();
            for (int j = 0; j < 3; j++)
            {
                for (int i = 3; i > 0; i--)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (playing_field[0, k] == playing_field[1, k] && playing_field[1, k] == playing_field[2, k] && playing_field[2, k] == playing_field[3, k])
                        {
                            check = true;        // особый случай, когда поле выглядит вот так [ 2 * * * ] из него, при свайпе вверх должно получиться поле [ 4 * * * ]
                            temp.Push(k);        //                                            [ 2 * * * ]                                                  [ 0 * * * ]
                                                 //                                            [ 2 * * * ]                                                  [ 4 * * * ]   
                                                 //                                            [ 2 * * * ]                                                  [ 0 * * * ]
                        }
                        if (playing_field[i - 1, k] == playing_field[i, k])
                        {
                            playing_field[i, k] = playing_field[i, k] * 2;
                            score = score + playing_field[i, k];
                            if (playing_field[i, k] == 2048)
                            {
                                end = true;
                            }
                            playing_field[i - 1, k] = 0;
                        }
                        if (playing_field[i, k] == 0 && playing_field[i - 1, k] != 0)
                        {
                            playing_field[i, k] = playing_field[i - 1, k];
                            playing_field[i - 1, k] = 0;
                        }
                    }
                }
            }
            if (check == true)
            {
                for (int i = temp.Count; i > 0; i--)
                {
                    int l = playing_field[3, temp.Peek()];
                    playing_field[0, temp.Peek()] = 0;
                    playing_field[1, temp.Peek()] = 0;
                    playing_field[2, temp.Peek()] = l / 2;
                    playing_field[3, temp.Peek()] = l / 2;
                    temp.Pop();
                }
            }
            if (CheckEnd() == false)
            {
                random();
            }
        }
        public void left()
        {

            bool check = false;
            Stack<int> temp = new Stack<int>();
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (playing_field[i, 0] == playing_field[i, 1] && playing_field[i, 1] == playing_field[i, 2] && playing_field[i, 2] == playing_field[i, 3])
                        {
                            check = true;        // особый случай, когда поле выглядит вот так [ 2 2 2 2 ] из него, при свайпе вверх должно получиться поле [ 4 4 0 0 ]
                            temp.Push(i);        //                                            [ * * * * ]                                                  [ * * * * ]
                                                 //                                            [ * * * * ]                                                  [ * * * * ]   
                                                 //                                            [ * * * * ]                                                  [ * * * * ]
                        }
                        if (playing_field[i, k] == playing_field[i, k + 1])
                        {
                            playing_field[i, k] = playing_field[i, k] * 2;
                            score = score + playing_field[i, k];
                            if (playing_field[i, k] == 2048)
                            {
                                end = true;
                            }
                            playing_field[i, k + 1] = 0;
                        }
                        if (playing_field[i, k + 1] != 0 && playing_field[i, k] == 0)
                        {
                            playing_field[i, k] = playing_field[i, k + 1];
                            playing_field[i, k + 1] = 0;
                        }
                    }
                }
            }
            if (check == true)
            {
                for (int i = temp.Count; i > 0; i--)
                {
                    int l = playing_field[temp.Peek(), 0];
                    playing_field[temp.Peek(), 0] = l / 2;
                    playing_field[temp.Peek(), 1] = l / 2;
                    playing_field[temp.Peek(), 2] = 0;
                    playing_field[temp.Peek(), 3] = 0;
                    temp.Pop();
                }
            }
            if (CheckEnd() == false)
            {
                random();
            }
        }
        public void right()
        {

            bool check = false;
            Stack<int> temp = new Stack<int>();
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int k = 3; k > 0; k--)
                    {
                        if (playing_field[i, 0] == playing_field[i, 1] && playing_field[i, 1] == playing_field[i, 2] && playing_field[i, 2] == playing_field[i, 3])
                        {
                            check = true;        // особый случай, когда поле выглядит вот так [ 2 2 2 2 ] из него, при свайпе вправо должно получиться поле[ 0 0 4 4 ]
                            temp.Push(i);        //                                            [ * * * * ]                                                  [ * * * * ]
                                                 //                                            [ * * * * ]                                                  [ * * * * ]   
                                                 //                                            [ * * * * ]                                                  [ * * * * ]
                        }
                        if (playing_field[i, k - 1] == playing_field[i, k])
                        {
                            playing_field[i, k] = playing_field[i, k] * 2;
                            score = score + playing_field[i, k];
                            if (playing_field[i, k] == 2048)
                            {
                                end = true;
                            }
                            playing_field[i, k - 1] = 0;
                        }
                        if (playing_field[i, k - 1] != 0 && playing_field[i, k] == 0)
                        {
                            playing_field[i, k] = playing_field[i, k - 1];
                            playing_field[i, k - 1] = 0;
                        }
                    }
                }
            }
            if (check == true)
            {
                for (int i = temp.Count; i > 0; i--)
                {
                    int l = playing_field[temp.Peek(), 0];
                    playing_field[temp.Peek(), 0] = l / 2;
                    playing_field[temp.Peek(), 1] = l / 2;
                    playing_field[temp.Peek(), 2] = 0;
                    playing_field[temp.Peek(), 3] = 0;
                    temp.Pop();
                }
            }
            if (CheckEnd() == false)
            {
                random();
            }
        }
    }
}
