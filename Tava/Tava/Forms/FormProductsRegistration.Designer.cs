﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductsRegistration));
            this.PrecioTxt = new System.Windows.Forms.TextBox();
            this.EmpaqueTxt = new System.Windows.Forms.TextBox();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UnidadesTxt = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrecioTxt
            // 
            this.PrecioTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrecioTxt.ForeColor = System.Drawing.Color.DimGray;
            this.PrecioTxt.Location = new System.Drawing.Point(750, 203);
            this.PrecioTxt.Name = "PrecioTxt";
            this.PrecioTxt.Size = new System.Drawing.Size(96, 30);
            this.PrecioTxt.TabIndex = 22;
            this.PrecioTxt.Text = "0.00";
            this.PrecioTxt.Click += new System.EventHandler(this.PrecioTxt_Click);
            // 
            // EmpaqueTxt
            // 
            this.EmpaqueTxt.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpaqueTxt.ForeColor = System.Drawing.Color.DimGray;
            this.EmpaqueTxt.Location = new System.Drawing.Point(604, 311);
            this.EmpaqueTxt.Name = "EmpaqueTxt";
            this.EmpaqueTxt.Size = new System.Drawing.Size(268, 30);
            this.EmpaqueTxt.TabIndex = 21;
            this.EmpaqueTxt.Text = "Caja, bolsa, otros";
            this.EmpaqueTxt.Click += new System.EventHandler(this.EmpaqueTxt_Click);
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescripcionTxt.ForeColor = System.Drawing.Color.DimGray;
            this.DescripcionTxt.Location = new System.Drawing.Point(64, 267);
            this.DescripcionTxt.Multiline = true;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(411, 126);
            this.DescripcionTxt.TabIndex = 20;
            this.DescripcionTxt.Text = "Descripción del producto";
            this.DescripcionTxt.Click += new System.EventHandler(this.DescripcionTxt_Click);
            // 
            // NombreTxt
            // 
            this.NombreTxt.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreTxt.ForeColor = System.Drawing.Color.DimGray;
            this.NombreTxt.Location = new System.Drawing.Point(64, 170);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(411, 30);
            this.NombreTxt.TabIndex = 19;
            this.NombreTxt.Text = "Nombre";
            this.NombreTxt.Click += new System.EventHandler(this.NombreTxt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(399, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 58);
            this.button1.TabIndex = 18;
            this.button1.Text = "Registrar producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(604, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo de empaque:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(604, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(604, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 44);
            this.label4.TabIndex = 15;
            this.label4.Text = "Unidades\r\npor set:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre del producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(344, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registro de productos";
            // 
            // UnidadesTxt
            // 
            this.UnidadesTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnidadesTxt.ForeColor = System.Drawing.Color.DimGray;
            this.UnidadesTxt.Location = new System.Drawing.Point(750, 142);
            this.UnidadesTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UnidadesTxt.Name = "UnidadesTxt";
            this.UnidadesTxt.Size = new System.Drawing.Size(96, 30);
            this.UnidadesTxt.TabIndex = 23;
            this.UnidadesTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // FormProductsRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UnidadesTxt);
            this.Controls.Add(this.PrecioTxt);
            this.Controls.Add(this.EmpaqueTxt);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProductsRegistration";
            this.Text = "FormProductsRegistration";
            this.Load += new System.EventHandler(this.FormProductsRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PrecioTxt;
        private System.Windows.Forms.TextBox EmpaqueTxt;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UnidadesTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}