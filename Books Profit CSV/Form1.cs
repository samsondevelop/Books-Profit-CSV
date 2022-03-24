using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Books_Profit_CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void datagridBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        double total = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            // setting up open file Dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\\Downloads";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Open The CSV books file";
            openFileDialog.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt"; // only allow csv files or text files

            openFileDialog.ShowDialog(); // showing file dialog
            this.TopMost = true; // bringing form back to the top (I noticed that when you usually use file dialog the form gets minimized)
            
            string[] arrReadAllLines = File.ReadAllLines(openFileDialog.FileName);
            for (int i = 0; i < arrReadAllLines.Length; i++)
            {
                List<string> items = arrReadAllLines[i].Split(',').ToList<string>(); // convert to list because you can add to lists after theyre defined
                string name = items[0];
                double purchasePrice = double.NaN;
                double salePrice = double.NaN;
                double profit = 0;
                // use tryparse
                if (Double.TryParse(items[4], out purchasePrice) && Double.TryParse(items[5], out salePrice)) // Checking that both are valid and converting them
                {
                    profit = salePrice - purchasePrice;
                }
                else
                {
                    profit = -purchasePrice;
                }
                profit = Math.Round(profit, 1); // round because some times theres a lot of decimal places
                total += profit; // adds to total profit count because its easier to do it here
                items.Add(profit.ToString());
                datagridBooks.Rows.Add(items.ToArray()); // convert back to an array because thats all it takes
            }
        }

        private void btnCalcProfit_Click(object sender, EventArgs e)
        {
            datagridBooks.Rows[datagridBooks.RowCount - 1].Cells[5].Value = "Total Profit: ";
            datagridBooks.Rows[datagridBooks.RowCount-1].Cells[6].Value = total.ToString();
        }
    }
}

