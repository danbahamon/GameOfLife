using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        int[,] heatMap = new int[32, 16]; //Tracks how often the cell has been alive.
        int[,] activeGen = new int[32, 16]; //Tracks how long the cell has been alive.

        int TotalLiving = 0;

        bool isActive = false;
        bool showHUD = false;
        bool showNeighbors = false;
        bool showGrid = true;
        bool showHeatMap = false;
        int maxHeat = 0;

        // Drawing colors
        Color backColor = Color.White;
        Color gridColor = Color.LightGray;
        //Color gridColor = Color.FromArgb(1056964863);
        Color HUDColor = Color.FromArgb(185, 255, 255, 255);
        Color cellColor = Color.Green;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        float moldLevel = 0.0f;


        //Rand Seed
        int seed = -1;

        int intervalMilliseconds = 100;

        int mapRows = 32;
        int mapCols = 16;


        bool edgeType = false; //False= wrap around            True= ends

        public Form1()
        {
            InitializeComponent();



            //Use settings to set variables.
            intervalMilliseconds = Properties.Settings.Default.Interval;
            mapRows = Properties.Settings.Default.Rows;
            mapCols = Properties.Settings.Default.Cols;
            backColor = Properties.Settings.Default.BackColor;
            cellColor = Properties.Settings.Default.AliveColor;

            graphicsPanel1.BackColor = backColor;


            ///////////////////////////

            // Setup the timer
            timer.Interval = intervalMilliseconds; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = true; // start timer running

            MoldModeText.Text = "Mold Mode = OFF";
            SetGrid(mapRows, mapCols);
        }
        //Resets the arrays to match the new size.
        private void SetGrid(int rows, int cols)
        {
            // The universe array
            universe = new bool[rows, cols];
            neighbors = new int[rows, cols];
            heatMap = new int[rows, cols];
            activeGen = new int[rows, cols];


            ClearScreen();

            // Tell Windows you need to repaint
            graphicsPanel1.Invalidate();
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


        private void CountNeighbors()
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
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            CountNeighbors();
            

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
                            activeGen[x, y] = generations;
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

                    if(universe[x,y])
                    {
                        
                        heatMap[x, y]+=95;
                        if(heatMap[x,y]>maxHeat)
                        {
                            maxHeat = heatMap[x, y];
                        }
                    }
                    else
                    {
                        heatMap[x,y] = (int)(heatMap[x, y]*0.999);
                    }
                }
            }






                // Increment generation count
                generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            livingCells.Text = "Living Cells =" + TotalLiving.ToString();

            CountNeighbors();
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
            float cellWidth = (float)graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            float cellHeight = (float)graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen;
            if (showGrid)
            {
                gridPen = new Pen(gridColor, 1);
            }
            else
            {
                gridPen = new Pen(Color.FromArgb(0,255,255,255),1);
            }
            

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            if (showHeatMap && maxHeat>0)
            {
                // Iterate through the universe in the y, top to bottom
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    // Iterate through the universe in the x, left to right
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        // A rectangle to represent each cell in pixels
                        RectangleF cellRect = RectangleF.Empty;
                        cellRect.X = (float)(x * cellWidth);
                        cellRect.Y = (float)(y * cellHeight);
                        cellRect.Width = (float)(cellWidth);
                        cellRect.Height = (float)(cellHeight);

                        moldLevel = (activeGen[x, y] / (float)generations)*255;


                        if (heatMap[x, y] < 255)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb((heatMap[x, y]), 0, (int)(uint)moldLevel, 0)), cellRect);
                        }
                        else
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, (int)(uint)moldLevel, 0)), cellRect);

                        }







                    }
                }
            }
            else
            {

                // Iterate through the universe in the y, top to bottom
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    // Iterate through the universe in the x, left to right
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        // A rectangle to represent each cell in pixels
                        Rectangle cellRect = Rectangle.Empty;
                        cellRect.X = (int)(x * cellWidth);
                        cellRect.Y = (int)(y * cellHeight);
                        cellRect.Width = (int)(cellWidth);
                        cellRect.Height = (int)(cellHeight);

                        // Fill the cell with a brush if alive
                        if (universe[x, y] == true)
                        {
                            e.Graphics.FillRectangle(cellBrush, cellRect);
                        }

                        // Outline the cell with a pen
                        e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);


                        //////////////////////////////////////////////////////////////////////////
                        if (showNeighbors)
                        {
                            if (neighbors[x, y] > 0)
                            {
                                Font font = new Font("Arial", 5f);

                                StringFormat stringFormat = new StringFormat();
                                stringFormat.Alignment = StringAlignment.Center;
                                stringFormat.LineAlignment = StringAlignment.Center;

                                Rectangle rect = new Rectangle(cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);


                                e.Graphics.DrawString(neighbors[x, y].ToString(), font, Brushes.Gray, rect, stringFormat);
                            }
                        }



                        //////////////////////////////////////////////////////////////////////////
                    }
                }

                

            }
            //HUD current generation, cell count, boundary type, universe size
            if (showHUD)
            {
                Font font = new Font("Arial", 10f);



                Rectangle rect = new Rectangle(0, 0, 0, 0);

                string HUDText = "";
                HUDText += "Current Generation: " + generations.ToString() + "\n";
                HUDText += "Cell Count: " + livingCells.ToString() + "\n";
                if (edgeType)
                {
                    HUDText += "Boundary Type: Finite" + "\n";
                }
                else
                {
                    HUDText += "Boundary Type: Wrap Around" + "\n";
                }
                HUDText += "Universe Size: " + mapRows.ToString() + "x" + mapCols.ToString() + "\n";




                e.Graphics.DrawString(HUDText, font, Brushes.Black, rect);
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

                if(x>=0 && x<mapRows && y>=0 && y< mapCols)
                {
                    if (universe[x, y])
                    {
                        TotalLiving--;
                    }
                    else
                    {
                        TotalLiving++;
                    }
                    // Toggle the cell's state
                    universe[x, y] = !universe[x, y];
                    CountNeighbors();
                    // Tell Windows you need to repaint
                    graphicsPanel1.Invalidate();


                    livingCells.Text = "Living Cells = " + TotalLiving.ToString();

                }

                
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//Next Generation Button
        {
            isActive = false;
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
            maxHeat = 0;
            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            livingCells.Text = "Living Cells = 0";


            //Set all bools to false;
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                    neighbors[x, y] = 0;
                    heatMap[x, y] = 0;
                    activeGen[x, y] = 0;
                }
            }
            CountNeighbors();
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

            ClearScreen();

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
            CountNeighbors();
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

        private void mapSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapDialog dlg = new MapDialog();

            dlg.rowsCount.Value = mapRows;
            dlg.colsCount.Value = mapCols;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                mapRows = (int)dlg.rowsCount.Value;
                mapCols = (int)dlg.colsCount.Value;

                SetGrid(mapRows, mapCols);
            }


        }

        private void wrapAroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdgeStyle dlg = new EdgeStyle();


            if(edgeType) //true = finite, false =wrap
            {
                dlg.finiteBtn.Checked = true;
            }
            else
            {
                dlg.wrapBtn.Checked = true;
            }
            

            if (DialogResult.OK == dlg.ShowDialog())
            {
                if(dlg.finiteBtn.Checked)
                {
                    edgeType = true;
                }
                else
                {
                    edgeType = false;
                }
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = backColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                backColor = dlg.Color;
                graphicsPanel1.BackColor = backColor;
            }
        }

        private void cellColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = cellColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                cellColor = dlg.Color;

                graphicsPanel1.Invalidate();
            }

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2; dlg.DefaultExt = "cells";


            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                // Write any comments you want to include first.
                // Prefix all comment strings with an exclamation point.
                // Use WriteLine to write the strings to the file. 
                // It appends a CRLF for you.
                writer.WriteLine("!Current State");

                // Iterate through the universe one row at a time.
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    // Create a string to represent the current row.
                    String currentRow = string.Empty;

                    // Iterate through the current row one cell at a time.
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        // If the universe[x,y] is alive then append 'O' (capital O)
                        // to the row string.
                        // Else if the universe[x,y] is dead then append '.' (period)
                        // to the row string.
                        if (universe[x,y])
                        {
                            currentRow += 'O';
                        }
                        else
                        {
                            currentRow += '.';
                        }

                        
                    }

                    // Once the current row has been read through and the 
                    // string constructed then write it to the file using WriteLine.
                    writer.WriteLine(currentRow);
                }

                // After all rows and columns have been written then close the file.
                writer.Close();
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(dlg.FileName);

                // variables to calculate the width and height
                // of the data in the file.
                mapRows = 0;
                mapCols = 0;

                // Iterate through the file once to get its size.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then it is a comment
                    // and should be ignored.
                    if(row.Length>0)
                    {
                        if (row[0] == '!')
                        {
                            //It is a comment
                        }
                        else
                        {
                            // If the row is not a comment then it is a row of cells.
                            // Increment the maxHeight variable for each row read.
                            mapCols++;

                            // Get the length of the current row string
                            // and adjust the maxWidth variable if necessary.
                            if (row.Length > mapCols)
                            {
                                mapRows = row.Length;
                            }


                        }
                    }
                   


                }

                // Resize the current universe and scratchPad
                // to the width and height of the file calculated above.
                SetGrid(mapRows, mapCols);

                // Reset the file pointer back to the beginning of the file.
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                // Iterate through the file again, this time reading in the cells.
                int currRow = 0;
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();
                    if (row.Length > 0)
                    {
                        // If the row begins with '!' then
                        // it is a comment and should be ignored.
                        if (row[0] == '!')
                        {
                            //It is a comment
                        }
                        else
                        {
                            // If the row is not a comment then 
                            // it is a row of cells and needs to be iterated through.
                            for (int xPos = 0; xPos < row.Length; xPos++)
                            {
                                // If row[xPos] is a 'O' (capital O) then
                                // set the corresponding cell in the universe to alive.
                                if (row[xPos] == 'O')
                                {
                                    universe[xPos,currRow] = true;
                                }

                                // If row[xPos] is a '.' (period) then
                                // set the corresponding cell in the universe to dead.
                            }
                            currRow++;

                        }
                    }
                    

                    
                }

                // Close the file.
                reader.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Use settings to set variables.
            Properties.Settings.Default.Interval = intervalMilliseconds;
            Properties.Settings.Default.Rows = mapRows;
            Properties.Settings.Default.Cols = mapCols;
            Properties.Settings.Default.BackColor = backColor;
            Properties.Settings.Default.AliveColor = cellColor;

            Properties.Settings.Default.Save();
        }

        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intervalMilliseconds = 100;
            mapRows = 150;
            mapCols = 75;
            backColor = Color.White;
            cellColor = Color.Green;

            Properties.Settings.Default.Interval = intervalMilliseconds;
            Properties.Settings.Default.Rows = mapRows;
            Properties.Settings.Default.Cols = mapCols;
            Properties.Settings.Default.BackColor = backColor;
            Properties.Settings.Default.AliveColor = cellColor;



            Properties.Settings.Default.Save();


            graphicsPanel1.BackColor = backColor;
            timer.Interval = intervalMilliseconds;
            SetGrid(mapRows, mapCols);
        }

        private void reloadSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Use settings to set variables.
            intervalMilliseconds = Properties.Settings.Default.Interval;
            mapRows = Properties.Settings.Default.Rows;
            mapCols = Properties.Settings.Default.Cols;
            backColor = Properties.Settings.Default.BackColor;
            cellColor = Properties.Settings.Default.AliveColor;

            graphicsPanel1.BackColor = backColor;
            timer.Interval = intervalMilliseconds; // milliseconds
            SetGrid(mapRows, mapCols);
        }

        private void hUDToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            showHUD = !showHUD;

            graphicsPanel1.Invalidate();
        }

        private void neighborsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            showNeighbors = !showNeighbors;

            graphicsPanel1.Invalidate();
        }

        private void gridToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            showGrid = !showGrid;

            graphicsPanel1.Invalidate();
        }

        private void backgroundColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gridToolStripMenuItem.Checked = !showGrid;
        }

        private void aliveColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hUDToolStripMenuItem.Checked = !showHUD;
        }

        private void moldModeToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            showHeatMap = !showHeatMap;
            graphicsPanel1.Invalidate();

            if(showHeatMap)
            {
                MoldModeText.Text = "Mold Mode = ON";
            }
            else
            {
                MoldModeText.Text = "Mold Mode = OFF";
            }
        }
    }
}



///////////////////////////////////////////////////////////////////////////////////////////////////////////////
///TODO LIST
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*

*/
