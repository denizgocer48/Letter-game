using System;
using System.IO;
namespace Deniz_Göçer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;
            string[] letter = { "A", "B", "C", "D" };
            string[] cardcolor = { "R", "G", "B" };
            Random rastgele = new Random();
            bool istrue = true;
            string[] memoryco = new string[9];
            string[] memorylet = new string[9];
            int point;
            int sum = 0;
            string[] regular = new string[3];
            int[] score = new int[7];
            while (istrue == true)
            {
                Console.Write("Randomly generated array:");

                int r = 1;
                int g = 1;
                int b = 1;
                int x = 0;

                int c = rastgele.Next(3);
                while (x < 9)
                {
                    while (cardcolor[c] == "R")
                    {
                        if (r <= 3)
                        {
                            memoryco[x] = cardcolor[c];
                            r++;
                            x++;
                            c = rastgele.Next(3);
                        }
                        else
                        {
                            c = rastgele.Next(3);
                        }
                    }
                    while (cardcolor[c] == "G")
                    {
                        if (g <= 3)
                        {
                            memoryco[x] = cardcolor[c];
                            g++;
                            x++;
                            c = rastgele.Next(3);
                        }
                        else
                        {
                            c = rastgele.Next(3);
                        }
                    }
                    while (cardcolor[c] == "B")
                    {
                        if (b <= 3)
                        {
                            memoryco[x] = cardcolor[c];
                            b++;
                            x++;
                            c = rastgele.Next(3);
                        }
                        else
                        {
                            c = rastgele.Next(3);
                        }
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    int l = rastgele.Next(4);
                    memorylet[i] = letter[l];

                    if (memoryco[i] == "R")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(letter[l] + " ");
                    }
                    else if (memoryco[i] == "B")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(letter[l] + " ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(letter[l] + " ");
                    }
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                for (int i = 0; i < 7; i++)
                {
                    regular[0] = memorylet[i];
                    regular[1] = memorylet[i + 1];
                    regular[2] = memorylet[i + 2];
                    point = 0;
                    if (memoryco[i] == memoryco[i + 1] && memoryco[i + 2] == memoryco[i + 1])
                    {
                        if (memorylet[i] == memorylet[i + 1] && memorylet[i + 2] == memorylet[i + 1])
                        {
                            point = point + 33;
                        }
                        else if ((regular[0] == "A" && regular[1] == "B" && regular[2] == "C") || (regular[0] == "A" && regular[1] == "C" && regular[2] == "B"))
                        {
                            point = point + 18;
                        }
                        else if ((regular[0] == "B" && regular[1] == "C" && regular[2] == "D") || (regular[0] == "B" && regular[1] == "D" && regular[2] == "C") || (regular[0] == "B" && regular[1] == "C" && regular[2] == "A") || (regular[0] == "B" && regular[1] == "A" && regular[2] == "C"))
                        {
                            point = point + 18;
                        }
                        else if ((regular[0] == "C" && regular[1] == "B" && regular[2] == "A") || (regular[0] == "C" && regular[1] == "A" && regular[2] == "B") || (regular[0] == "C" && regular[1] == "D" && regular[2] == "B") || (regular[0] == "C" && regular[1] == "B" && regular[2] == "D"))
                        {
                            point = point + 18;
                        }
                        else if ((regular[0] == "D" && regular[1] == "C" && regular[2] == "B") || (regular[0] == "D" && regular[1] == "B" && regular[2] == "C"))
                        {
                            point = point + 18;
                        }
                        else
                        {
                            point = point + 12;
                        }
                    }
                    else if (memoryco[i] != memoryco[i + 1] || memoryco[i + 2] != memoryco[i + 1] || memoryco[i + 2] != memoryco[i])
                    {
                        if (memoryco[i] != memoryco[i + 1] && memoryco[i + 2] != memoryco[i + 1] && memoryco[i + 2] != memoryco[i])
                        {
                            if (memorylet[i] == memorylet[i + 1] && memorylet[i + 2] == memorylet[i + 1])
                            {
                                point = point + 28;
                            }
                            else if ((regular[0] == "A" && regular[1] == "B" && regular[2] == "C") || (regular[0] == "A" && regular[1] == "C" && regular[2] == "B"))
                            {
                                point = point + 16;
                            }
                            else if ((regular[0] == "B" && regular[1] == "C" && regular[2] == "D") || (regular[0] == "B" && regular[1] == "D" && regular[2] == "C") || (regular[0] == "B" && regular[1] == "C" && regular[2] == "A") || (regular[0] == "B" && regular[1] == "A" && regular[2] == "C"))
                            {
                                point = point + 16;
                            }
                            else if ((regular[0] == "C" && regular[1] == "B" && regular[2] == "A") || (regular[0] == "C" && regular[1] == "A" && regular[2] == "B") || (regular[0] == "C" && regular[1] == "D" && regular[2] == "B") || (regular[0] == "C" && regular[1] == "B" && regular[2] == "D"))
                            {
                                point = point + 16;
                            }
                            else if ((regular[0] == "D" && regular[1] == "C" && regular[2] == "B") || (regular[0] == "D" && regular[1] == "B" && regular[2] == "C"))
                            {
                                point = point + 16;
                            }
                            else
                            {
                                point = point + 10;
                            }
                        }
                        else
                        {
                            if (memorylet[i] == memorylet[i + 1] && memorylet[i + 2] == memorylet[i + 1])
                            {
                                point = point + 22;
                            }
                            else if ((regular[0] == "A" && regular[1] == "B" && regular[2] == "C") || (regular[0] == "A" && regular[1] == "C" && regular[2] == "B"))
                            {
                                point = point + 14;
                            }
                            else if ((regular[0] == "B" && regular[1] == "C" && regular[2] == "D") || (regular[0] == "B" && regular[1] == "D" && regular[2] == "C") || (regular[0] == "B" && regular[1] == "C" && regular[2] == "A") || (regular[0] == "B" && regular[1] == "A" && regular[2] == "C"))
                            {
                                point = point + 14;
                            }
                            else if ((regular[0] == "C" && regular[1] == "B" && regular[2] == "A") || (regular[0] == "C" && regular[1] == "A" && regular[2] == "B") || (regular[0] == "C" && regular[1] == "D" && regular[2] == "B") || (regular[0] == "C" && regular[1] == "B" && regular[2] == "D"))
                            {
                                point = point + 14;
                            }
                            else if ((regular[0] == "D" && regular[1] == "C" && regular[2] == "B") || (regular[0] == "D" && regular[1] == "B" && regular[2] == "C"))
                            {
                                point = point + 14;
                            }
                        }
                    }
                    else
                    {
                        point = point + 0;
                    }
                    sum = sum + point;
                    score[i] = point;
                    if (score[i] != 0)
                    {
                        for (int j = 0; j < 3; j++)
                        {

                            if (memoryco[i + j] == "R")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(memorylet[i + j] + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else if (memoryco[i + j] == "B")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(memorylet[i + j] + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(memorylet[i + j] + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        Console.Write("  " + Convert.ToString(score[i]) + " points\n");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("You get " + sum + " points !!!");
                Console.WriteLine();
                string name;
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("High Score Table");
                string path =  "D:\\HighScoreTable.txt";
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
                string line1;

                StreamReader readtext = File.OpenText(path);
                int border = 0;
                string[] readedtext = new string[21];
                while (border < 20)
                {
                    line1 = readtext.ReadLine();
                    readedtext[border] = line1.Split(';')[0];
                    readedtext[border + 1] = line1.Split(';')[1];
                    border += 2;
                }

                readtext.Close();


                StreamWriter f = File.CreateText(path);
                for (int i = 0; i < readedtext.Length - 1; i += 2)
                {
                    f.Write(readedtext[i] + ";" + readedtext[i + 1] + "\n");
                }
                f.WriteLine(name + ";" + sum);
                f.Close();

                string line2;
                StreamReader q = File.OpenText(path);
                line2 = q.ReadToEnd();
                int max = 1;


                string[] list = line2.Split(';', '\n');
                string[] regularly = new string[20];
                int sayi = 0;
                int pointindex = 0;

                while (max != 0 && sayi != 10)
                {
                    max = 0;
                    for (int i = 1; i < list.Length; i += 2)
                    {
                        int str_to_int;
                        str_to_int = Convert.ToInt32(list[i]);
                        if (str_to_int > max)
                        {
                            max = str_to_int;
                            pointindex = i;
                        }
                    }
                    if (max != 0)
                    {
                        regularly[2 * sayi] = Convert.ToString(list[pointindex - 1]);
                        regularly[(2 * sayi) + 1] = Convert.ToString(list[pointindex]);
                        list[pointindex] = Convert.ToString(0);
                        sayi++;
                    }

                }
                q.Close();
                for (int i = 0; i < regularly.Length - 1; i += 2)
                {
                    Console.WriteLine(regularly[i] + " " + regularly[i + 1]);
                }
                StreamWriter s_writer = File.CreateText(path);
                for (int i = 0; i < regularly.Length - 1; i += 2)
                {
                    s_writer.Write(regularly[i] + ";" + regularly[i + 1] + "\n");
                }
                s_writer.Close();
                string y;
                Console.WriteLine();
                Console.WriteLine("Do you want to play again? (Y or N)");
                y = Console.ReadLine();
                sum = 0;
                bool isreturn = true;
                while (isreturn == true)
                {
                    if (y.ToUpper() == "N")
                    {
                        istrue = false;
                        isreturn = false;
                        Console.ReadKey();
                    }
                    else if (y.ToUpper() == "Y")
                    {
                        istrue = true;
                        isreturn = false;
                    }
                    else
                    {
                        Console.WriteLine("Do you want to play again? (Y or N)");
                        y = Console.ReadLine();
                    }
                }
            }

        }
    }
}