using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab8
{
    public partial class MainForm : Form
    {
        List<string> listOfChains = new List<string>();
        Grammatics grammatics;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            listOfChains.Add(newChainTextBox.Text);
            chainsLabel.Text = chainsLabel.Text + "  " + newChainTextBox.Text;
            newChainTextBox.Text = "";
            GenerateButton.Enabled = listOfChains.Count > 3 ? true : false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listOfChains.Clear();
            chainsLabel.Text = "";
            GenerateButton.Enabled = false;
            getNextButton.Enabled = false;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            grammatics = new Grammatics();

            grammatics.MakeRules(listOfChains);
            grammatics.MakeRecursiveAutomaticGrammatics();
            grammatics.DeleteEquivalents();

            rulesLabel.Text = grammatics.ToString();
            getNextButton.Enabled = true;
        }

        private void getNextButton_Click(object sender, EventArgs e)
        {
            newChainLabel.Text = grammatics.NextValue();
        }
    }
}
