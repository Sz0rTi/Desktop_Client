namespace ClientRest.Forms
{
    partial class InvoiceSell
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ProductNameCB = new System.Windows.Forms.ComboBox();
            this.NameCBLabel = new System.Windows.Forms.Label();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.CategoryCBLabel = new System.Windows.Forms.Label();
            this.PricePerItemNUD = new System.Windows.Forms.NumericUpDown();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AmountTB = new System.Windows.Forms.NumericUpDown();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.productSellOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductsList = new System.Windows.Forms.ToolStrip();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ilość = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jednostka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Netto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brutto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.PricePerItemNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSellOutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(509, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(191, 364);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 23);
            this.AddProductButton.TabIndex = 2;
            this.AddProductButton.Text = "Dodaj ";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ProductNameCB
            // 
            this.ProductNameCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductNameCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductNameCB.FormattingEnabled = true;
            this.ProductNameCB.Location = new System.Drawing.Point(191, 423);
            this.ProductNameCB.Name = "ProductNameCB";
            this.ProductNameCB.Size = new System.Drawing.Size(142, 21);
            this.ProductNameCB.TabIndex = 3;
            // 
            // NameCBLabel
            // 
            this.NameCBLabel.AutoSize = true;
            this.NameCBLabel.Location = new System.Drawing.Point(145, 426);
            this.NameCBLabel.Name = "NameCBLabel";
            this.NameCBLabel.Size = new System.Drawing.Size(40, 13);
            this.NameCBLabel.TabIndex = 4;
            this.NameCBLabel.Text = "Nazwa";
            // 
            // CategoryCB
            // 
            this.CategoryCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoryCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(191, 396);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(121, 21);
            this.CategoryCB.TabIndex = 5;
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // CategoryCBLabel
            // 
            this.CategoryCBLabel.AutoSize = true;
            this.CategoryCBLabel.Location = new System.Drawing.Point(133, 399);
            this.CategoryCBLabel.Name = "CategoryCBLabel";
            this.CategoryCBLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryCBLabel.TabIndex = 6;
            this.CategoryCBLabel.Text = "Kategoria";
            // 
            // PricePerItemNUD
            // 
            this.PricePerItemNUD.DecimalPlaces = 2;
            this.PricePerItemNUD.Location = new System.Drawing.Point(191, 450);
            this.PricePerItemNUD.Name = "PricePerItemNUD";
            this.PricePerItemNUD.Size = new System.Drawing.Size(120, 20);
            this.PricePerItemNUD.TabIndex = 7;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(105, 452);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(80, 13);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "Cena za sztuke";
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(191, 477);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(120, 20);
            this.AmountTB.TabIndex = 9;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(156, 479);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(29, 13);
            this.AmountLabel.TabIndex = 10;
            this.AmountLabel.Text = "Ilosc";
            // 
            // productSellOutBindingSource
            // 
            this.productSellOutBindingSource.DataSource = typeof(ClientRest.Models.Out.ProductSellOut);
            // 
            // ProductsList
            // 
            this.ProductsList.Location = new System.Drawing.Point(0, 0);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(995, 25);
            this.ProductsList.TabIndex = 12;
            this.ProductsList.Text = "toolStrip1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nazwa,
            this.Ilość,
            this.Jednostka,
            this.Netto,
            this.Brutto});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(191, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(518, 187);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nazwa
            // 
            this.Nazwa.Text = "Nazwa";
            this.Nazwa.Width = 152;
            // 
            // Ilość
            // 
            this.Ilość.Text = "Ilość";
            this.Ilość.Width = 73;
            // 
            // Jednostka
            // 
            this.Jednostka.Text = "Jednostka";
            this.Jednostka.Width = 71;
            // 
            // Netto
            // 
            this.Netto.Text = "Cena Netto";
            this.Netto.Width = 85;
            // 
            // Brutto
            // 
            this.Brutto.Text = "Cena Brutto";
            this.Brutto.Width = 91;
            // 
            // InvoiceSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 685);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ProductsList);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PricePerItemNUD);
            this.Controls.Add(this.CategoryCBLabel);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.NameCBLabel);
            this.Controls.Add(this.ProductNameCB);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "InvoiceSell";
            this.Text = "InvoiceSell";
            ((System.ComponentModel.ISupportInitialize)(this.PricePerItemNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSellOutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.ComboBox ProductNameCB;
        private System.Windows.Forms.Label NameCBLabel;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Label CategoryCBLabel;
        private System.Windows.Forms.NumericUpDown PricePerItemNUD;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.NumericUpDown AmountTB;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.BindingSource productSellOutBindingSource;
        private System.Windows.Forms.ToolStrip ProductsList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nazwa;
        private System.Windows.Forms.ColumnHeader Ilość;
        private System.Windows.Forms.ColumnHeader Jednostka;
        private System.Windows.Forms.ColumnHeader Netto;
        private System.Windows.Forms.ColumnHeader Brutto;
    }
}