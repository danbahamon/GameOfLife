﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        // The universe array
        bool[,] universe = new bool[32, 16];
        int[,] neighbors = new int[32,16];

        int TotalLiving = 0;

        bool isActive = false;

        // Drawing colors
        Color gridColor = Color.LightGray;
        //Color gridColor = Color.FromArgb(1056964863);
        Color cellColor = Color.Green;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;


        //Rand Seed
        int seed = -1;

        int intervalMilliseconds = 100;

        int mapRows = 32;
        int mapCols = 16;


        bool edgeType = true; //False= wrap around            True= ends

        public Form1()
        {
            InitializeComponent();

            // Setup the timer
            timer.Interval = intervalMilliseconds; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = true; // start timer running


            //Use settings to set variables.


            ///////////////////////////


            SetGrid(32, 16);
        }

        private void SetGrid(int rows, int cols)
        {
            // The universe array
            universe = new bool[rows, cols];
            neighbors = new int[rows, cols];
        }


        private int CheckNeighbor(int x, int y)
        {
            if(!edgeType) //Wrap around mode
            {
                if(x<0)
                {
                    x += universe.GetLength(0);
                }
                else if (x==universe.GetLength(0))
                {
                    x = 0;
                }

                if(y<0)
                {
                    y += universe.GetLength(1);
                }
                else if (y == universe.GetLength(1))
                {
                    y = 0;
                }
            }

            if(x>=0 && y>= 0 && x< universe.GetLength(0) && y< universe.GetLength(1) && universe[x,y]) // If x or y is out of bounds, just return 0
            {
                return 1;
            }

            return 0;
        }
        // Calculate the next generation of cells
        private void NextGeneration()
        {

            //Loop all the cells and count the amount of neighbors each has.
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    neighbors[x, y] = 0;
                    neighbors[x, y] += CheckNeighbor(x - 1, y - 1);
                    neighbors[x, y] += CheckNeighbor(x, y - 1);
                    neighbors[x, y] += CheckNeighbor(x + 1, y - 1);
                    neighbors[x, y] += CheckNeighbor(x - 1, y);
                    neighbors[x, y] += CheckNeighbor(x + 1, y);
                    neighbors[x, y] += CheckNeighbor(x - 1, y + 1);
                    neighbors[x, y] += CheckNeighbor(x, y + 1);
                    neighbors[x, y] += CheckNeighbor(x + 1, y + 1);

                }
            }

            TotalLiving = 0;

            //Apply rules to kill or Birth cells
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    
                    if (!universe[x, y])
                    {
                        if (neighbors[x, y] == 3)
                        {
                            universe[x, y] = true;
                            TotalLiving++;
                        }
                    }
                    else
                    {
                        if (neighbors[x, y] == 2 || neighbors[x, y] == 3)
                        {
                            universe[x, y] = true;
                            TotalLiving++;
                        }
                        else
                        {
                            universe[x, y] = false;
                        }
                    }
                }
            }






                // Increment generation count
                generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            livingCells.Text = "Living Cells =" + TotalLiving.ToString();

            // Tell Windows you need to repaint
            graphicsPanel1.Invalidate();
        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {

            if(isActive)
            {
                NextGeneration();
            }
            
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / cellHeight;


                if(universe[x,y])
                {
                    TotalLiving--;
                }
                else
                {
                    TotalLiving++;
                }
                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();


                livingCells.Text = "Living Cells = " + TotalLiving.ToString();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//Next Generation Button
        {
            NextGeneration();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//Play Button
        {
            isActive = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)//Pause Button
        {
            isActive = false;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)//New File
        {
            ClearScreen();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void ClearScreen()
        {
            isActive = false;
            generations = 0;
            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            livingCells.Text = "Living Cells = 0";


            //Set all bools to false;
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }

            // Tell Windows you need to repaint
            graphicsPanel1.Invalidate();
        }

        private void randomizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Random rand;
            if(seed>=0)
            {
                rand = new Random(seed);
            }
            else
            {
                rand = new Random();
            }



            generations = 0;
            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            

            isActive = false;

            TotalLiving= 0;

            //Set all bools to true or false;
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {

                    if (rand.Next(0, 100) < 34)
                    {
                        universe[x, y] = true;

                        TotalLiving++;
                    }
                    else
                    {
                        universe[x, y] = false;
                    }

                }
            }


            livingCells.Text = "Living Cells = "+TotalLiving.ToString();
            // Tell Windows you need to repaint
            graphicsPanel1.Invalidate();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void randomSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeedSettings dlg = new SeedSettings();

            if(seed>=0)
            {
                dlg.numSelect.Enabled = true;
                dlg.numSelect.Value = seed;
                dlg.radioButton1.Checked = true;
            }
            else
            {
                dlg.numSelect.Enabled = false;
                dlg.numSelect.Value = 0;
                dlg.radioButton2.Checked = true;
            }
            if(DialogResult.OK == dlg.ShowDialog())
            {
                if(dlg.radioButton1.Checked) //User wants a specific seed
                {
                    seed = (int)dlg.numSelect.Value;
                }
                else
                {
                    //Use time to seed random
                    seed = -1;
                }
                
            }
        }

        private void millisecondsIntervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntervalForm dlg = new IntervalForm();

            dlg.numSelect.Value = intervalMilliseconds;
          
            if (DialogResult.OK == dlg.ShowDialog())
            {
                intervalMilliseconds = (int)dlg.numSelect.Value;
            }

            timer.Interval = intervalMilliseconds;
        }
    }
}



///////////////////////////////////////////////////////////////////////////////////////////////////////////////
///TODO LIST
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
5) Saving the current universe to a text file. The current state and size of the universe should be able to be saved in PlainText file format. The file name should be chosen by the user with a save file dialog box.
6) Opening a previously saved universe. A previously saved PlainText file should be able to be read in and assigned to the current universe. Opening should also resize the current universe to match the size of the file being read.
10)Controlling the current size of the universe. The width and height of the current universe should be able to be chosen through a modal dialog box.
11)Displaying the neighbor count in each cell. Render the neighbor count for each individual cell. The user should be able to toggle this feature on and off using the View menu.
12)View Menu Items. Implement a View Menu that toggles the grid on an off, toggles the neighbor count display and toggles the heads up display (if the heads up is implemented as an advanced feature.)
2) Game Colors. The user should be able to select individual colors for the grid, the background and living cells through a modal dialog box.
3) Universe boundary behavior. The user should choose how the game is going to treat the edges of the universe. The two basic options would be toroidal (the edges wrap around to the other side) or finite(cells outside the universe are considered dead.)
4) Context sensitive menu. Implement a ContextMenuStrip that allows the user to change various options in the application.
5) Heads up display. A heads up display that indicates current generation, cell count, boundary type, universe size and any other information you wish to display. The user should be able to toggle this display on and off through a View menu and a context sensitive menu (if one is implemented as an advanced feature.)
6) Settings.When universe size, timer interval and color options are changed by the user they should persist even after the program has been closed and then opened again. Also, the user should have two menu items Reset and Reload. Reload will revert back to the last saved settings and Reset will return the applications default settings for these values.

*/
