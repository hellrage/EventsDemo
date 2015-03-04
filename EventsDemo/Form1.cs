using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CollisionManager.InitializeObjects();
            QuestManager.GenerateRandomQuests(3);
            QuestManager.InitializeQuests();
            CollisionManager.SimulateCollisions(10);
            reportTextBox.Text = Logger.Report;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.CloseLog();
        }
    }
}
