using System;
using System.Windows.Forms;

namespace DBAutoShop.MainForms
{
    public partial class FullTextSearchForm : Form
    {
        DataGridView DG;
        int TableID;
        string SearchString;
        int CountRecords;
        public FullTextSearchForm()
        {
            InitializeComponent();
        }

        public void Call(DataGridView DataGrid, int PageID)
        {
            DG = DataGrid;
            TableID = PageID;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchString = textBox1.Text;
            CountRecords = Convert.ToInt32(numericUpDown1.Value);
            MainForm.FullTextSearchResult(DG, TableID, SearchString, CountRecords);
        }
    }
}
