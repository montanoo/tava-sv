
namespace Tava.Forms
{
    partial class FormProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProductoTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empaque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(569, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos en el inventario";
            // 
            // ProductoTxt
            // 
            this.ProductoTxt.Location = new System.Drawing.Point(965, 62);
            this.ProductoTxt.Name = "ProductoTxt";
            this.ProductoTxt.Size = new System.Drawing.Size(150, 31);
            this.ProductoTxt.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.Product,
            this.Empaque,
            this.Unidades,
            this.Precio,
            this.Stock});
            this.dataGridView1.Location = new System.Drawing.Point(48, 141);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 350);
            this.dataGridView1.TabIndex = 2;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ID";
            this.ProductId.MinimumWidth = 8;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 150;
            // 
            // Product
            // 
            this.Product.HeaderText = "Producto";
            this.Product.MinimumWidth = 8;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 150;
            // 
            // Empaque
            // 
            this.Empaque.HeaderText = "Empaque";
            this.Empaque.MinimumWidth = 8;
            this.Empaque.Name = "Empaque";
            this.Empaque.ReadOnly = true;
            this.Empaque.Width = 150;
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.MinimumWidth = 8;
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            this.Unidades.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Existencias";
            this.Stock.MinimumWidth = 8;
            this.Stock.Name = "Stock";
            this.Stock.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProductoTxt);
            this.Controls.Add(this.label1);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductoTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empaque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Button button1;
    }
}