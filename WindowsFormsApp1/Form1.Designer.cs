
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new WindowsFormsApp1.LibraryDataSet();
            this.booksTableAdapter = new WindowsFormsApp1.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.spPages = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgBooks = new System.Windows.Forms.DataGridView();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfPagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRERÍA";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(226, 73);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(100, 22);
            this.tbId.TabIndex = 3;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(226, 113);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(268, 22);
            this.tbTitle.TabIndex = 5;
            this.tbTitle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Título:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = " Fecha de publicación:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(227, 157);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(267, 22);
            this.dpDate.TabIndex = 7;
            this.dpDate.ValueChanged += new System.EventHandler(this.dpDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = " Número de páginas: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // spPages
            // 
            this.spPages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.spPages.Location = new System.Drawing.Point(227, 196);
            this.spPages.Maximum = new decimal(new int[] {
            35000,
            0,
            0,
            0});
            this.spPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spPages.Name = "spPages";
            this.spPages.Size = new System.Drawing.Size(120, 22);
            this.spPages.TabIndex = 9;
            this.spPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descripción:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(554, 113);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(553, 115);
            this.tbDescription.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(158, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(271, 263);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(107, 35);
            this.btnModify.TabIndex = 13;
            this.btnModify.Text = " MODIFICAR";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(387, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "ELIMINAR";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(554, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 35);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(341, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // dgBooks
            // 
            this.dgBooks.AllowUserToAddRows = false;
            this.dgBooks.AllowUserToDeleteRows = false;
            this.dgBooks.AllowUserToResizeColumns = false;
            this.dgBooks.AllowUserToResizeRows = false;
            this.dgBooks.AutoGenerateColumns = false;
            this.dgBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.publicationDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.numOfPagesDataGridViewTextBoxColumn});
            this.dgBooks.DataSource = this.booksBindingSource1;
            this.dgBooks.Location = new System.Drawing.Point(25, 334);
            this.dgBooks.Name = "dgBooks";
            this.dgBooks.ReadOnly = true;
            this.dgBooks.RowHeadersVisible = false;
            this.dgBooks.RowHeadersWidth = 51;
            this.dgBooks.RowTemplate.Height = 24;
            this.dgBooks.Size = new System.Drawing.Size(1135, 150);
            this.dgBooks.TabIndex = 17;
            this.dgBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBooks_CellContentClick_1);
            this.dgBooks.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBooks_RowEnter_1);
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.libraryDataSetBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publicationDateDataGridViewTextBoxColumn
            // 
            this.publicationDateDataGridViewTextBoxColumn.DataPropertyName = "PublicationDate";
            this.publicationDateDataGridViewTextBoxColumn.HeaderText = "PublicationDate";
            this.publicationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publicationDateDataGridViewTextBoxColumn.Name = "publicationDateDataGridViewTextBoxColumn";
            this.publicationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numOfPagesDataGridViewTextBoxColumn
            // 
            this.numOfPagesDataGridViewTextBoxColumn.DataPropertyName = "NumOfPages";
            this.numOfPagesDataGridViewTextBoxColumn.HeaderText = "NumOfPages";
            this.numOfPagesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numOfPagesDataGridViewTextBoxColumn.Name = "numOfPagesDataGridViewTextBoxColumn";
            this.numOfPagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1203, 617);
            this.Controls.Add(this.dgBooks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.spPages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1225, 668);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown spPages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private System.Windows.Forms.DataGridView dgBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfPagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource booksBindingSource1;
    }
}

