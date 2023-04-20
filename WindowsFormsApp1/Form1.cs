using System;
using System.Collections.Generic;
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

            if (tbId.Text == "" && tbTitle.Text == "")
            {
                btnModify.Enabled = false;
                btnDelete.Enabled = false;

            }

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


        }

        private void ClearForm()
        {
            tbId.Text = "";
            tbTitle.Text = "";
            tbDescription.Text = "";
            dpDate.Text = DateTime.Today.ToString();

            spPages.Value = 1;

            btnDelete.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Books l = GetDataOfFormBooks();


            if (Repository.RepositoryEntityFramework.AddBook(l))
            {
                UpdateForm();

                ClearForm();

                MessageBox.Show("Libro añadido con éxito.");

            }
            else
            {
                MessageBox.Show("No ha sido posible añadir el libro.");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Books l = GetDataOfFormBooks();

            if (Repository.RepositoryEntityFramework.ModifyBook(l))
            {
                UpdateForm();

                MessageBox.Show("Libro modificado con éxito.");
                ClearForm();
            }
            else
            {
                MessageBox.Show("No ha sido posible modificar el libro.");
            }


        }

        private void UpdateForm()
        {

            var source = new BindingSource();
            List<Books> list = Repository.RepositoryEntityFramework.GetBooks();
            source.DataSource = list;
            dgBooks.DataSource = source;

        }

        private Book GetDataOfForm()
        {
            Book newBook = new Book();

            newBook.Id = int.Parse(tbId.Text.ToString());
            newBook.Title = tbTitle.Text;
            newBook.PublicationDate = dpDate.Value.ToShortDateString();
            newBook.Description = tbDescription.Text;
            newBook.NumOfPages = int.Parse(spPages.Value.ToString());



            return newBook;
        }

        private Books GetDataOfFormBooks()
        {
            Books l = new Books();

            if (!tbId.Text.Equals(""))
            {

                l.Id = int.Parse(tbId.Text);

            }

            l.Title = tbTitle.Text;
            l.Description = tbDescription.Text;
            l.PublicationDate = dpDate.Value;
            l.NumOfPages = int.Parse(spPages.Value.ToString());


            return l;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Books l = GetDataOfFormBooks();

            DialogResult buttonConfirm = MessageBox.Show("¿Estás seguro de que desea eliminarlo?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (buttonConfirm == DialogResult.OK)
            {
                if (Repository.RepositoryEntityFramework.DeleteBook(l))
                {
                    UpdateForm();
                    ClearForm();

                    MessageBox.Show("Libro eliminado con éxito.");

                }
                else
                {
                    MessageBox.Show("No ha sido posible eliminar el libro..");
                }
            }

        }

        private void dpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgBooks_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgBooks_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numberOfRow = e.RowIndex;


            if (numberOfRow != -1)
            {

                tbId.Text = dgBooks.Rows[numberOfRow].Cells[0].Value.ToString();
                tbTitle.Text = dgBooks.Rows[numberOfRow].Cells[1].Value.ToString();
                tbDescription.Text = dgBooks.Rows[numberOfRow].Cells[3].Value.ToString();
                dpDate.Text = dgBooks.Rows[numberOfRow].Cells[2].Value.ToString();

                spPages.Value = decimal.Parse(dgBooks.Rows[numberOfRow].Cells[4].Value.ToString());

                btnSave.Enabled = false;
                btnModify.Enabled = true;
                btnDelete.Enabled = true;

            }

        }

        private void dgBooks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
            btnSave.Enabled = true;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgBooks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgBooks_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            int numberOfRow = e.RowIndex;


            if (numberOfRow != -1)
            {

                tbId.Text = dgBooks.Rows[numberOfRow].Cells[0].Value.ToString();
                tbTitle.Text = dgBooks.Rows[numberOfRow].Cells[1].Value.ToString();
                tbDescription.Text = dgBooks.Rows[numberOfRow].Cells[3].Value.ToString();
                dpDate.Text = dgBooks.Rows[numberOfRow].Cells[2].Value.ToString();

                spPages.Value = decimal.Parse(dgBooks.Rows[numberOfRow].Cells[4].Value.ToString());

                btnSave.Enabled = false;
                btnModify.Enabled = true;
                btnDelete.Enabled = true;

            }
        }
    }
}
