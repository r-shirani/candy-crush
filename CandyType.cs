using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace candy_crush
{
    public class CandyType
    {
        public string Name { get; set; }
        public int Score { get; set; }
        //***************************************loading first matrix
        public static void LoadGame(Button[,] buttons, Image candy1, Image candy2, Image candy3, Image candy4, Image candy5, Image candy6, Image candy7)
        {
            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    bool findSameLine = true;
                    bool findSameColumn = true;
                    while (findSameLine || findSameColumn)
                    {
                        int num = random.Next(1, 8);
                        switch (num)
                        {
                            case 1:
                                {
                                    buttons[i, j].BackgroundImage = candy1;
                                    buttons[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                    break;
                                }
                            case 2:
                                {
                                    buttons[i, j].BackgroundImage = candy2;
                                    buttons[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                    break;
                                }
                            case 3:
                                {
                                    buttons[i, j].BackgroundImage = candy3;
                                    buttons[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                    break;
                                }
                            case 4:
                                {
                                    buttons[i, j].BackgroundImage = candy4;
                                    buttons[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                    break;
                                }
                            case 5:
                                {
                                    buttons[i, j].BackgroundImage = candy5;
                                    buttons[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                    break;
                                }
                            case 6:
                                {
                                    buttons[i, j].BackgroundImage = candy6;
                                    buttons[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                    break;
                                }
                            case 7:
                                {
                                    buttons[i, j].BackgroundImage = candy7;
                                    buttons[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                    break;
                                }
                        }
                        if (j > 2)//for checking the lines
                        {
                            if (buttons[i, j].BackgroundImage == buttons[i, j - 1].BackgroundImage && buttons[i, j - 1].BackgroundImage == buttons[i, j - 2].BackgroundImage)
                                findSameLine = true;
                            else
                                findSameLine = false;
                        }
                        else
                            findSameLine = false;
                        if (i > 2)//for checking the columns
                        {
                            if (buttons[i, j].BackgroundImage == buttons[i - 1, j].BackgroundImage && buttons[i - 1, j].BackgroundImage == buttons[i - 2, j].BackgroundImage)
                                findSameColumn = true;
                            else
                                findSameColumn = false;
                        }
                        else
                            findSameColumn = false;
                    }
                }
            }
        }
        //-----------------------------------------move buttons
        public static void MoveButtons(Button button1, Button button2, Image imagebt1, Image imagebt2)
        {
            int linebt1 = (int)button1.Name[6];
            int column1 = (int)button1.Name[7];
            int linebt2 = (int)button2.Name[6];
            int column2 = (int)button2.Name[7];
            if (linebt1 == linebt2 && Math.Abs(column2 - column1) == 1)
            {
                button1.BackgroundImage = imagebt2;
                button2.BackgroundImage = imagebt1;
            }
            else if (column1 == column2 && Math.Abs(linebt2 - linebt1) == 1)
            {
                button1.BackgroundImage = imagebt2;
                button2.BackgroundImage = imagebt1;
            }
            else
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //***********************************************random candy
        public static void RandomCandy(Button button, Image candy1, Image candy2, Image candy3, Image candy4, Image candy5, Image candy6, Image candy7)
        {
            Random random = new Random();
            int num = random.Next(1, 8);
            switch (num)
            {
                case 1:
                    {
                        button.BackgroundImage = candy1;
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    }
                case 2:
                    {
                        button.BackgroundImage = candy2;
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    }
                case 3:
                    {
                        button.BackgroundImage = candy3;
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    }
                case 4:
                    {
                        button.BackgroundImage = candy4;
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    }
                case 5:
                    {
                        button.BackgroundImage = candy5;
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    }
                case 6:
                    {
                        button.BackgroundImage = candy6;
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    }
                case 7:
                    {
                        button.BackgroundImage = candy7;
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    }
            }
        }
        //----------------------------------------check the matrix
        public static int CheckMatrix(Button[,] buttons, Image candy1, Image candy2, Image candy3, Image candy4, Image candy5, Image candy6, Image candy7, string point)
        {
            int Score;
            if (point == "")
                Score = 0;
            else
                Score = Convert.ToInt32(point);
            //check rows
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (buttons[i, j].BackgroundImage == buttons[i, j + 1].BackgroundImage && buttons[i, j + 1].BackgroundImage == buttons[i, j + 2].BackgroundImage)
                    {
                        if (buttons[i, j].BackgroundImage == candy1)
                            Score += 10;
                        else if (buttons[i, j].BackgroundImage == candy2)
                            Score += 10;
                        else if (buttons[i, j].BackgroundImage == candy3)
                            Score += 20;
                        else if (buttons[i, j].BackgroundImage == candy4)
                            Score += 30;
                        else if (buttons[i, j].BackgroundImage == candy5)
                            Score += 30;
                        else if (buttons[i, j].BackgroundImage == candy6)
                            Score += 40;
                        else if (buttons[i, j].BackgroundImage == candy7)
                            Score += 50;
                        //***
                        int line = 1;
                        int changeLine = 0;
                        while (i - line >= 0)
                        {
                            buttons[i - changeLine, j].BackgroundImage = buttons[i - line, j].BackgroundImage;
                            buttons[i - changeLine, j + 1].BackgroundImage = buttons[i - line, j + 1].BackgroundImage;
                            buttons[i - changeLine, j + 2].BackgroundImage = buttons[i - line, j + 2].BackgroundImage;
                            ++line;
                            ++changeLine;
                        }
                    }
                }
            }
            // check columns
            for (int i = 2; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (buttons[i, j].BackgroundImage == buttons[i - 1, j].BackgroundImage && buttons[i - 1, j].BackgroundImage == buttons[i - 2, j].BackgroundImage)
                    {
                        if (buttons[i, j].BackgroundImage == candy1)
                            Score += 10;
                        else if (buttons[i, j].BackgroundImage == candy2)
                            Score += 10;
                        else if (buttons[i, j].BackgroundImage == candy3)
                            Score += 20;
                        else if (buttons[i, j].BackgroundImage == candy4)
                            Score += 30;
                        else if (buttons[i, j].BackgroundImage == candy5)
                            Score += 30;
                        else if (buttons[i, j].BackgroundImage == candy6)
                            Score += 40;
                        else if (buttons[i, j].BackgroundImage == candy7)
                            Score += 50;
                        //***
                        int changeLine = 0;
                        while (i - changeLine - 3 >= 0)
                        {
                            buttons[i - changeLine, j].BackgroundImage = buttons[i - changeLine - 3, j].BackgroundImage;
                            ++changeLine;
                        }                        
                    }
                }
            }
            //chech the hole atrix for the same candies
            bool findSame=false;
            do
            {
                findSame = false;
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        if (buttons[i, j].BackgroundImage == buttons[i + 1, j].BackgroundImage && buttons[i + 1, j].BackgroundImage == buttons[i + 2, j].BackgroundImage)//same in the column
                        {
                            findSame = true;
                            RandomCandy(buttons[i, j], candy1, candy2, candy3, candy4, candy5, candy6, candy7);
                            RandomCandy(buttons[i + 1, j], candy1, candy2, candy3, candy4, candy5, candy6, candy7);
                        }
                        if (buttons[i, j].BackgroundImage == buttons[i, j + 1].BackgroundImage && buttons[i, j + 1].BackgroundImage == buttons[i, j + 2].BackgroundImage)//same in the row
                        {
                            findSame=true;
                            RandomCandy(buttons[i, j], candy1, candy2, candy3, candy4, candy5, candy6, candy7);
                            RandomCandy(buttons[i, j + 1], candy1, candy2, candy3, candy4, candy5, candy6, candy7);
                        }
                    }
                }

            } while(findSame);
            
            
            return Score;
        }
    }
}
