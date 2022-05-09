
namespace Tava.Forms
{
    partial class FormProductsRegistration
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
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UnidadesTxt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PrecioTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpaqueTxt = new System.Windows.Forms.TextBox();
            this.RegistrarProdbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(84, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto";
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(84, 204);
            this.Nombretxt.Multiline = true;
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(356, 51);
            this.Nombretxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(416, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registro de productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(84, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción:";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(84, 337);
            this.DescripcionTxt.Multiline = true;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(356, 223);
            this.DescripcionTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(689, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 74);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unidades \r\n por set\r\n";
            // 
            // UnidadesTxt
            // 
            this.UnidadesTxt.Location = new System.Drawing.Point(891, 144);
            this.UnidadesTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UnidadesTxt.Name = "UnidadesTxt";
            this.UnidadesTxt.Size = new System.Drawing.Size(67, 31);
            this.UnidadesTxt.TabIndex = 8;
            this.UnidadesTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(689, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 74);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio\r\n\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(865, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "$";
            // 
            // PrecioTxt
            // 
            this.PrecioTxt.Location = new System.Drawing.Point(906, 271);
            this.PrecioTxt.MaxLength = 5;
            this.PrecioTxt.Multiline = true;
            this.PrecioTxt.Name = "PrecioTxt";
            this.PrecioTxt.Size = new System.Drawing.Size(76, 38);
            this.PrecioTxt.TabIndex = 11;
            this.PrecioTxt.Text = "0.00";
            this.PrecioTxt.Click += new System.EventHandler(this.PrecioTxt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(689, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo de empaque";
            // 
            // EmpaqueTxt
            // 
            this.EmpaqueTxt.Location = new System.Drawing.Point(710, 424);
            this.EmpaqueTxt.Multiline = true;
            this.EmpaqueTxt.Name = "EmpaqueTxt";
            this.EmpaqueTxt.Size = new System.Drawing.Size(307, 46);
            this.EmpaqueTxt.TabIndex = 13;
            this.EmpaqueTxt.Text = "Caja, bolsa,otros";
            this.EmpaqueTxt.Click += new System.EventHandler(this.EmpaqueTxt_Click);
            // 
            // RegistrarProdbtn
            // 
            this.RegistrarProdbtn.Location = new System.Drawing.Point(536, 580);
            this.RegistrarProdbtn.Name = "RegistrarProdbtn";
            this.RegistrarProdbtn.Size = new System.Drawing.Size(156, 64);
            this.RegistrarProdbtn.TabIndex = 14;
            this.RegistrarProdbtn.Text = "Registrar Producto";
            this.RegistrarProdbtn.UseVisualStyleBackColor = true;
            this.RegistrarProdbtn.Click += new System.EventHandler(this.RegistrarProdbtn_Click);
            // 
            // FormProductsRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 673);
            this.Controls.Add(this.RegistrarProdbtn);
            this.Controls.Add(this.EmpaqueTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PrecioTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UnidadesTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombretxt);
            this.Controls.Add(this.label1);
            this.Name = "FormProductsRegistration";
            this.Text = "Registro de productos";
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown UnidadesTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PrecioTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmpaqueTxt;
        private System.Windows.Forms.Button RegistrarProdbtn;
    }
}