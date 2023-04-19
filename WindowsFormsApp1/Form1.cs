using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numberOfRow = e.RowIndex;

            if (numberOfRow != -1)
            {
                tbId.Text = dgBooks.Rows[numberOfRow].Cells[0].Value.ToString();
                tbTitle.Text = dgBooks.Rows[numberOfRow].Cells[1].Value.ToString();
                tbDescription.Text = dgBooks.Rows[numberOfRow].Cells[3].Value.ToString();

                spPages.Value = decimal.Parse(dgBooks.Rows[numberOfRow].Cells[4].Value.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Book newBook = new Book();

            newBook.Id = int.Parse(tbId.Text.ToString());
            newBook.Title = tbTitle.Text;
            newBook.PublicationDate = dpDate.Value.ToShortDateString();
            newBook.Description = tbDescription.Text;
            newBook.NumOfPages = int.Parse(spPages.Value.ToString());

            if (!String.IsNullOrEmpty(tbId.Text))
            {
                newBook.Id = int.Parse(tbId.Text.ToString());
            }

            Repository.RepositorySQLServer.ModificarContacto(newBook);

            DataSet ds = Repository.RepositorySQLServer.GetBooks();
            dgBooks.DataSource = ds.Tables[0];
        }
    }
}
