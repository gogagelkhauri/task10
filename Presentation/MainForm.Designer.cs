namespace Presentation
{
    partial class MainForm
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
            this.bookDataGrid = new System.Windows.Forms.DataGridView();
            this.books_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bookDataGrid
            // 
            this.bookDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bookDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bookDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.bookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGrid.Location = new System.Drawing.Point(12, 60);
            this.bookDataGrid.Name = "bookDataGrid";
            this.bookDataGrid.RowTemplate.Height = 25;
            this.bookDataGrid.Size = new System.Drawing.Size(418, 150);
            this.bookDataGrid.TabIndex = 0;
            // 
            // books_label
            // 
            this.books_label.AutoSize = true;
            this.books_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.books_label.Location = new System.Drawing.Point(12, 9);
            this.books_label.Name = "books_label";
            this.books_label.Size = new System.Drawing.Size(72, 30);
            this.books_label.TabIndex = 1;
            this.books_label.Text = "Books";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.books_label);
            this.Controls.Add(this.bookDataGrid);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView bookDataGrid;
        private Label books_label;
    }
}