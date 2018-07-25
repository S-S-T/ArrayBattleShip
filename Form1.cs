<<<<<<< HEAD
﻿
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace BattleBoard
{// SST--comments are not enabled for this project
    public partial class Form1 : Form
    {
        public List<string> lstBoat1 = new List<string>();
        public List<string> lstBoat2 = new List<string>();
        public List<string> lstBoat3 = new List<string>();
        public List<string> lstBoat4 = new List<string>();
        public Button tmpButton = null;
        public Form1()
        {
            InitializeComponent();
            int ButtonWidth = 40;
            int ButtonHeight = 40;
            int Distance = 20;
            int start_x = 10;
            int start_y = 10;
            int counter_x = 0;
            int counter_y = 0;
            string[] aryAlphaChars = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            string[] aryNumericChars = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            string[,] boatmatrix = new string[10, 10];
            Point p1;

            for (int x = 0; x < 10; x++)
            {// set on the fly or hard-coded here. //string[] aryBoat1 = new string[4] { "C2", "C3", "C4", "C5" }; //string[] aryBoat2 = new string[4] { "E3", "E4", "E5", "E6" }; //string[] aryBoat3 = new string[4] { "D9", "E9", "F9", "G9" }; //string[] aryBoat4 = new string[4] { "I4", "J4", "I6", "C5" };                
                for (int y = 0; y < 10; y++)
                {
                    tmpButton = new Button();
                    boatmatrix[x, y] = aryAlphaChars[x] + aryNumericChars[y];
                    p1 = new Point(); // set and collect each point on the board (x,y)
                    p1.X = x;
                    p1.Y = y;
                    tmpButton.Top = start_x + (x * ButtonHeight + Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth + Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    if (boatmatrix[x, y] == "C2" || boatmatrix[x, y] == "C3" || boatmatrix[x, y] == "C4" || boatmatrix[x, y] == "C5")
                    {
                        if (lstBoat1.Count < 4)
                        {
                            lstBoat1.Add(boatmatrix[x, y]);
                            tmpButton.BackColor = Color.LightBlue;
                            tmpButton.Text = "Boat";
                            tmpButton.GetChildAtPoint(p1);
                            tmpButton.Name = boatmatrix[x, y];
                            counter_y++;
                            counter_x++;
                            tmpButton.Click += TmpButton_Click;
                            this.Controls.Add(tmpButton);
                            continue;
                        }
                    }

                    if (boatmatrix[x, y] == "E3" || boatmatrix[x, y] == "E4" || boatmatrix[x, y] == "E5" || boatmatrix[x, y] == "E6" || boatmatrix[x, y] == "E7")
                    {
                        if (lstBoat2.Count < 5)
                        {
                            lstBoat2.Add(boatmatrix[x, y]);
                            tmpButton.BackColor = Color.LightBlue;
                            tmpButton.Text = "Boat";
                            tmpButton.GetChildAtPoint(p1);
                            tmpButton.Name = boatmatrix[x, y];
                            counter_y++;
                            counter_x++;
                            tmpButton.Click += TmpButton_Click;
                            this.Controls.Add(tmpButton);
                            continue;
                        }
                    }

                    if (boatmatrix[x, y] == "D9" || boatmatrix[x, y] == "E9" || boatmatrix[x, y] == "F9" || boatmatrix[x, y] == "G9")
                    {
                        if (lstBoat3.Count < 4)
                        {
                            lstBoat3.Add(boatmatrix[x, y]);
                            tmpButton.BackColor = Color.LightBlue;
                            tmpButton.Text = "Boat";
                            tmpButton.GetChildAtPoint(p1);
                            tmpButton.Name = boatmatrix[x, y];
                            counter_y++;
                            counter_x++;
                            tmpButton.Click += TmpButton_Click;
                            this.Controls.Add(tmpButton);
                            continue;
                        }
                    }

                    if (boatmatrix[x, y] == "I4" || boatmatrix[x, y] == "J4" || boatmatrix[x, y] == "I5" || boatmatrix[x, y] == "J5")
                    {
                        if (lstBoat4.Count < 4)
                        {
                            lstBoat4.Add(boatmatrix[x, y]);
                            tmpButton.BackColor = Color.LightBlue;
                            tmpButton.Text = "Boat";
                            tmpButton.GetChildAtPoint(p1);
                            tmpButton.Name = boatmatrix[x, y];
                            counter_y++;
                            counter_x++;
                            tmpButton.Click += TmpButton_Click;
                            this.Controls.Add(tmpButton);
                            continue;
                        }
                    }
                    else
                    {
                        tmpButton.BackColor = Color.LightGreen;
                        tmpButton.Text = "H20";
                        tmpButton.GetChildAtPoint(p1);
                        tmpButton.Name = boatmatrix[x, y];
                        counter_y++;
                        counter_x++;
                        tmpButton.Click += TmpButton_Click;
                        this.Controls.Add(tmpButton);
                    }
                }
            }
        }

        public void TmpButton_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            string strButtonPosition = myButton.Name.ToString();
            int x = 0;
            if (myButton.Text == "Boat")
            {
                foreach (string item in lstBoat1)
                {
                    if (lstBoat1[x].ToString().Contains(strButtonPosition))
                    {
                        int intRemoval = lstBoat1.IndexOf(strButtonPosition);
                        lstBoat1.RemoveAt(intRemoval);
                        myButton.Text = "HIT!";
                        myButton.BackColor = Color.LightCoral;
                        myButton.Enabled = false;
                        if (lstBoat1.Count == 0)
                        {
                            myButton.Width = 50;
                            myButton.Height = 50;
                            myButton.BackColor = Color.Red;
                            myButton.Text = "SUNK SHIP!";
                        }
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (string item in lstBoat2)
                {
                    if (lstBoat2[x].ToString().Contains(strButtonPosition))
                    {
                        int intRemoval = lstBoat2.IndexOf(strButtonPosition);
                        lstBoat2.RemoveAt(intRemoval);
                        myButton.Text = "HIT!";
                        myButton.BackColor = Color.LightCoral;
                        myButton.Enabled = false;
                        if (lstBoat2.Count == 0)
                        {
                            myButton.Width = 50;
                            myButton.Height = 50;
                            myButton.BackColor = Color.Red;
                            myButton.Text = "SUNK SHIP!";
                        }
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (string item in lstBoat3)
                {
                    if (lstBoat3[x].ToString().Contains(strButtonPosition))
                    {
                        int intRemoval = lstBoat3.IndexOf(strButtonPosition);
                        lstBoat3.RemoveAt(intRemoval);
                        myButton.Text = "HIT!";
                        myButton.BackColor = Color.LightCoral;
                        myButton.Enabled = false;
                        if (lstBoat3.Count == 0)
                        {
                            myButton.Width = 50;
                            myButton.Height = 50;
                            myButton.BackColor = Color.Red;
                            myButton.Text = "SUNK SHIP!";
                        }
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (string item in lstBoat4)
                {
                    if (lstBoat4[x].ToString().Contains(strButtonPosition))
                    {
                        int intRemoval = lstBoat4.IndexOf(strButtonPosition);
                        lstBoat4.RemoveAt(intRemoval);
                        myButton.Text = "HIT!";
                        myButton.BackColor = Color.LightCoral;
                        myButton.Enabled = false;
                        if (lstBoat4.Count == 0)
                        {
                            myButton.Width = 50;
                            myButton.Height = 50;
                            myButton.BackColor = Color.Red;
                            myButton.Text = "SUNK SHIP!";
                        }
                        break;
                    }
                    x++;
                }
            }
            else
            {
                // update postion on board 
                myButton.Text = "miss";
                myButton.BackColor = Color.Yellow;
                myButton.Enabled = false;
            }
        }
    }
=======
﻿
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace BattleBoard
{
    public partial class Form1 : Form
    {
        public List<string> lstBoat1 = new List<string>();
        public List<string> lstBoat2 = new List<string>();
        public List<string> lstBoat3 = new List<string>();
        public List<string> lstBoat4 = new List<string>();
        public Button tmpButton = null;
        public Form1()
        {
            InitializeComponent();
            int ButtonWidth = 40;
            int ButtonHeight = 40;
            int Distance = 20;
            int start_x = 10;
            int start_y = 10;
            int counter_x = 0;
            int counter_y = 0;
            string[] aryAlphaChars = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            string[] aryNumericChars = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            string[,] boatmatrix = new string[10, 10];
            Point p1;

            for (int x = 0; x < 10; x++)
            {// set on the fly or hard-coded here. //string[] aryBoat1 = new string[4] { "C2", "C3", "C4", "C5" }; //string[] aryBoat2 = new string[4] { "E3", "E4", "E5", "E6" }; //string[] aryBoat3 = new string[4] { "D9", "E9", "F9", "G9" }; //string[] aryBoat4 = new string[4] { "I4", "J4", "I6", "C5" };                
                for (int y = 0; y < 10; y++)
                {
                    tmpButton = new Button();
                    boatmatrix[x, y] = aryAlphaChars[x] + aryNumericChars[y];
                    p1 = new Point(); // set and collect each point on the board (x,y)
                    p1.X = x;
                    p1.Y = y;
                    tmpButton.Top = start_x + (x * ButtonHeight + Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth + Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    if (boatmatrix[x, y] == "C2" || boatmatrix[x, y] == "C3" || boatmatrix[x, y] == "C4" || boatmatrix[x, y] == "C5")
                    {
                        if (lstBoat1.Count < 4)
                        {
                            lstBoat1.Add(boatmatrix[x, y]);
                            tmpButton.BackColor = Color.LightBlue;
                            tmpButton.Text = "Boat";
                            tmpButton.GetChildAtPoint(p1);
                            tmpButton.Name = boatmatrix[x, y];
                            counter_y++;
                            counter_x++;
                            tmpButton.Click += TmpButton_Click;
                            this.Controls.Add(tmpButton);
                            continue;
                        }
                    }

                    if (boatmatrix[x, y] == "E3" || boatmatrix[x, y] == "E4" || boatmatrix[x, y] == "E5" || boatmatrix[x, y] == "E6" || boatmatrix[x, y] == "E7")
                    {
                        if (lstBoat2.Count < 5)
                        {
                            lstBoat2.Add(boatmatrix[x, y]);
                            tmpButton.BackColor = Color.LightBlue;
                            tmpButton.Text = "Boat";
                            tmpButton.GetChildAtPoint(p1);
                            tmpButton.Name = boatmatrix[x, y];
                            counter_y++;
                            counter_x++;
                            tmpButton.Click += TmpButton_Click;
                            this.Controls.Add(tmpButton);
                            continue;
                        }
                    }

                    if (boatmatrix[x, y] == "D9" || boatmatrix[x, y] == "E9" || boatmatrix[x, y] == "F9" || boatmatrix[x, y] == "G9")
                    {
                        if (lstBoat3.Count < 4)
                        {
                            lstBoat3.Add(boatmatrix[x, y]);
                            tmpButton.BackColor = Color.LightBlue;
                            tmpButton.Text = "Boat";
                            tmpButton.GetChildAtPoint(p1);
                            tmpButton.Name = boatmatrix[x, y];
                            counter_y++;
                            counter_x++;
                            tmpButton.Click += TmpButton_Click;
                            this.Controls.Add(tmpButton);
                            continue;
                        }
                    }

                    if (boatmatrix[x, y] == "I4" || boatmatrix[x, y] == "J4" || boatmatrix[x, y] == "I5" || boatmatrix[x, y] == "J5")
                    {
                        if (lstBoat4.Count < 4)
                        {
                            lstBoat4.Add(boatmatrix[x, y]);
                            tmpButton.BackColor = Color.LightBlue;
                            tmpButton.Text = "Boat";
                            tmpButton.GetChildAtPoint(p1);
                            tmpButton.Name = boatmatrix[x, y];
                            counter_y++;
                            counter_x++;
                            tmpButton.Click += TmpButton_Click;
                            this.Controls.Add(tmpButton);
                            continue;
                        }
                    }
                    else
                    {
                        tmpButton.BackColor = Color.LightGreen;
                        tmpButton.Text = "H20";
                        tmpButton.GetChildAtPoint(p1);
                        tmpButton.Name = boatmatrix[x, y];
                        counter_y++;
                        counter_x++;
                        tmpButton.Click += TmpButton_Click;
                        this.Controls.Add(tmpButton);
                    }
                }
            }
        }

        public void TmpButton_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            string strButtonPosition = myButton.Name.ToString();
            int x = 0;
            if (myButton.Text == "Boat")
            {
                foreach (string item in lstBoat1)
                {
                    if (lstBoat1[x].ToString().Contains(strButtonPosition))
                    {
                        int intRemoval = lstBoat1.IndexOf(strButtonPosition);
                        lstBoat1.RemoveAt(intRemoval);
                        myButton.Text = "HIT!";
                        myButton.BackColor = Color.LightCoral;
                        myButton.Enabled = false;
                        if (lstBoat1.Count == 0)
                        {
                            myButton.Width = 50;
                            myButton.Height = 50;
                            myButton.BackColor = Color.Red;
                            myButton.Text = "SUNK SHIP!";
                        }
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (string item in lstBoat2)
                {
                    if (lstBoat2[x].ToString().Contains(strButtonPosition))
                    {
                        int intRemoval = lstBoat2.IndexOf(strButtonPosition);
                        lstBoat2.RemoveAt(intRemoval);
                        myButton.Text = "HIT!";
                        myButton.BackColor = Color.LightCoral;
                        myButton.Enabled = false;
                        if (lstBoat2.Count == 0)
                        {
                            myButton.Width = 50;
                            myButton.Height = 50;
                            myButton.BackColor = Color.Red;
                            myButton.Text = "SUNK SHIP!";
                        }
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (string item in lstBoat3)
                {
                    if (lstBoat3[x].ToString().Contains(strButtonPosition))
                    {
                        int intRemoval = lstBoat3.IndexOf(strButtonPosition);
                        lstBoat3.RemoveAt(intRemoval);
                        myButton.Text = "HIT!";
                        myButton.BackColor = Color.LightCoral;
                        myButton.Enabled = false;
                        if (lstBoat3.Count == 0)
                        {
                            myButton.Width = 50;
                            myButton.Height = 50;
                            myButton.BackColor = Color.Red;
                            myButton.Text = "SUNK SHIP!";
                        }
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (string item in lstBoat4)
                {
                    if (lstBoat4[x].ToString().Contains(strButtonPosition))
                    {
                        int intRemoval = lstBoat4.IndexOf(strButtonPosition);
                        lstBoat4.RemoveAt(intRemoval);
                        myButton.Text = "HIT!";
                        myButton.BackColor = Color.LightCoral;
                        myButton.Enabled = false;
                        if (lstBoat4.Count == 0)
                        {
                            myButton.Width = 50;
                            myButton.Height = 50;
                            myButton.BackColor = Color.Red;
                            myButton.Text = "SUNK SHIP!";
                        }
                        break;
                    }
                    x++;
                }
            }
            else
            {
                // update postion on board 
                myButton.Text = "miss";
                myButton.BackColor = Color.Yellow;
                myButton.Enabled = false;
            }
        }
    }
>>>>>>> 78e73f90ff6a274b02ffeaa94f492a05813759e6
}