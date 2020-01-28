namespace ClientRest.Forms
{
    partial class NewInvoiceBuyForm
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
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ProductNameCB = new System.Windows.Forms.ComboBox();
            this.NameCBLabel = new System.Windows.Forms.Label();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.CategoryCBLabel = new System.Windows.Forms.Label();
            this.PricePerItemNUD = new System.Windows.Forms.NumericUpDown();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AmountTB = new System.Windows.Forms.NumericUpDown();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitsCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.Summary = new System.Windows.Forms.GroupBox();
            this.SummaryBrutto = new System.Windows.Forms.Label();
            this.SummaryBrutttoLabel = new System.Windows.Forms.Label();
            this.SummaryNetto = new System.Windows.Forms.Label();
            this.SummaryNettoLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SellerGB = new System.Windows.Forms.GroupBox();
            this.SellerNameCB = new System.Windows.Forms.ComboBox();
            this.SellerNIPLabel = new System.Windows.Forms.Label();
            this.SellerCityPostCodeLabel = new System.Windows.Forms.Label();
            this.SellerStreetNumberLabel = new System.Windows.Forms.Label();
            this.SellerNameLabel = new System.Windows.Forms.Label();
            this.SellerCityPostCodeTB = new System.Windows.Forms.TextBox();
            this.NIPButton = new System.Windows.Forms.Button();
            this.SellerNIPTB = new System.Windows.Forms.TextBox();
            this.SellerStreetNumberTB = new System.Windows.Forms.TextBox();
            this.ProductAmountLabel1 = new System.Windows.Forms.Label();
            this.ProductAmountLabel2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TaxStageCB = new System.Windows.Forms.ComboBox();
            this.NewCategoryButton = new System.Windows.Forms.Button();
            this.productSellOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CodeLabel = new System.Windows.Forms.Label();
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.IsPaidChB = new System.Windows.Forms.CheckBox();
            this.PaymentMethodCB = new System.Windows.Forms.ComboBox();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.PaymentDeadlineLabel = new System.Windows.Forms.Label();
            this.PaymentDeadline = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PricePerItemNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTB)).BeginInit();
            this.Summary.SuspendLayout();
            this.SellerGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSellOutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(389, 544);
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
            this.ProductNameCB.Location = new System.Drawing.Point(251, 485);
            this.ProductNameCB.Name = "ProductNameCB";
            this.ProductNameCB.Size = new System.Drawing.Size(142, 21);
            this.ProductNameCB.TabIndex = 3;
            this.ProductNameCB.DropDown += new System.EventHandler(this.ProductNameCB_DropDown);
            this.ProductNameCB.SelectedIndexChanged += new System.EventHandler(this.ProductNameCB_SelectedIndexChanged);
            // 
            // NameCBLabel
            // 
            this.NameCBLabel.AutoSize = true;
            this.NameCBLabel.Location = new System.Drawing.Point(205, 489);
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
            this.CategoryCB.Location = new System.Drawing.Point(251, 458);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(142, 21);
            this.CategoryCB.TabIndex = 5;
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // CategoryCBLabel
            // 
            this.CategoryCBLabel.AutoSize = true;
            this.CategoryCBLabel.Location = new System.Drawing.Point(193, 461);
            this.CategoryCBLabel.Name = "CategoryCBLabel";
            this.CategoryCBLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryCBLabel.TabIndex = 6;
            this.CategoryCBLabel.Text = "Kategoria";
            // 
            // PricePerItemNUD
            // 
            this.PricePerItemNUD.DecimalPlaces = 2;
            this.PricePerItemNUD.Location = new System.Drawing.Point(251, 512);
            this.PricePerItemNUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.PricePerItemNUD.Name = "PricePerItemNUD";
            this.PricePerItemNUD.Size = new System.Drawing.Size(120, 20);
            this.PricePerItemNUD.TabIndex = 7;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(136, 514);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(97, 13);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "Cena zakupu netto";
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(251, 539);
            this.AmountTB.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(120, 20);
            this.AmountTB.TabIndex = 9;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(216, 541);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(29, 13);
            this.AmountLabel.TabIndex = 10;
            this.AmountLabel.Text = "Ilosc";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(139, 286);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(715, 135);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ilość";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "J.M";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cena netto";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cena brutto";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "VAT";
            this.columnHeader6.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Wartość netto";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Wartość brutto";
            this.columnHeader8.Width = 90;
            // 
            // UnitsCB
            // 
            this.UnitsCB.FormattingEnabled = true;
            this.UnitsCB.Location = new System.Drawing.Point(470, 486);
            this.UnitsCB.Name = "UnitsCB";
            this.UnitsCB.Size = new System.Drawing.Size(121, 21);
            this.UnitsCB.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "J.M.";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(755, 629);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 14;
            this.CreateButton.Text = "Wystaw";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // Summary
            // 
            this.Summary.Controls.Add(this.SummaryBrutto);
            this.Summary.Controls.Add(this.SummaryBrutttoLabel);
            this.Summary.Controls.Add(this.SummaryNetto);
            this.Summary.Controls.Add(this.SummaryNettoLabel);
            this.Summary.Location = new System.Drawing.Point(654, 427);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(200, 75);
            this.Summary.TabIndex = 15;
            this.Summary.TabStop = false;
            this.Summary.Text = "Podsumowanie";
            // 
            // SummaryBrutto
            // 
            this.SummaryBrutto.AutoSize = true;
            this.SummaryBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SummaryBrutto.Location = new System.Drawing.Point(109, 43);
            this.SummaryBrutto.Name = "SummaryBrutto";
            this.SummaryBrutto.Size = new System.Drawing.Size(0, 13);
            this.SummaryBrutto.TabIndex = 3;
            this.SummaryBrutto.DoubleClick += new System.EventHandler(this.SummaryBrutto_DoubleClick);
            // 
            // SummaryBrutttoLabel
            // 
            this.SummaryBrutttoLabel.AutoSize = true;
            this.SummaryBrutttoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SummaryBrutttoLabel.Location = new System.Drawing.Point(7, 44);
            this.SummaryBrutttoLabel.Name = "SummaryBrutttoLabel";
            this.SummaryBrutttoLabel.Size = new System.Drawing.Size(95, 13);
            this.SummaryBrutttoLabel.TabIndex = 2;
            this.SummaryBrutttoLabel.Text = "Wartość brutto:";
            // 
            // SummaryNetto
            // 
            this.SummaryNetto.AutoSize = true;
            this.SummaryNetto.Location = new System.Drawing.Point(96, 20);
            this.SummaryNetto.Name = "SummaryNetto";
            this.SummaryNetto.Size = new System.Drawing.Size(0, 13);
            this.SummaryNetto.TabIndex = 1;
            this.SummaryNetto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SummaryNetto_MouseDoubleClick);
            // 
            // SummaryNettoLabel
            // 
            this.SummaryNettoLabel.AutoSize = true;
            this.SummaryNettoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SummaryNettoLabel.Location = new System.Drawing.Point(7, 20);
            this.SummaryNettoLabel.Name = "SummaryNettoLabel";
            this.SummaryNettoLabel.Size = new System.Drawing.Size(91, 13);
            this.SummaryNettoLabel.TabIndex = 0;
            this.SummaryNettoLabel.Text = "Wartość netto:";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(470, 544);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 16;
            this.EditButton.Text = "Edytuj";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(551, 544);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 17;
            this.RemoveButton.Text = "Usuń";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SellerGB
            // 
            this.SellerGB.Controls.Add(this.SellerNameCB);
            this.SellerGB.Controls.Add(this.SellerNIPLabel);
            this.SellerGB.Controls.Add(this.SellerCityPostCodeLabel);
            this.SellerGB.Controls.Add(this.SellerStreetNumberLabel);
            this.SellerGB.Controls.Add(this.SellerNameLabel);
            this.SellerGB.Controls.Add(this.SellerCityPostCodeTB);
            this.SellerGB.Controls.Add(this.NIPButton);
            this.SellerGB.Controls.Add(this.SellerNIPTB);
            this.SellerGB.Controls.Add(this.SellerStreetNumberTB);
            this.SellerGB.Location = new System.Drawing.Point(139, 89);
            this.SellerGB.Name = "SellerGB";
            this.SellerGB.Size = new System.Drawing.Size(485, 191);
            this.SellerGB.TabIndex = 18;
            this.SellerGB.TabStop = false;
            this.SellerGB.Text = "Dane sprzedawcy";
            // 
            // SellerNameCB
            // 
            this.SellerNameCB.FormattingEnabled = true;
            this.SellerNameCB.Location = new System.Drawing.Point(112, 19);
            this.SellerNameCB.Name = "SellerNameCB";
            this.SellerNameCB.Size = new System.Drawing.Size(317, 21);
            this.SellerNameCB.TabIndex = 9;
            this.SellerNameCB.SelectedIndexChanged += new System.EventHandler(this.SellerNameCB_SelectedIndexChanged);
            // 
            // SellerNIPLabel
            // 
            this.SellerNIPLabel.AutoSize = true;
            this.SellerNIPLabel.Location = new System.Drawing.Point(81, 102);
            this.SellerNIPLabel.Name = "SellerNIPLabel";
            this.SellerNIPLabel.Size = new System.Drawing.Size(25, 13);
            this.SellerNIPLabel.TabIndex = 8;
            this.SellerNIPLabel.Text = "NIP";
            // 
            // SellerCityPostCodeLabel
            // 
            this.SellerCityPostCodeLabel.AutoSize = true;
            this.SellerCityPostCodeLabel.Location = new System.Drawing.Point(12, 76);
            this.SellerCityPostCodeLabel.Name = "SellerCityPostCodeLabel";
            this.SellerCityPostCodeLabel.Size = new System.Drawing.Size(94, 13);
            this.SellerCityPostCodeLabel.TabIndex = 7;
            this.SellerCityPostCodeLabel.Text = "Kod i miejscowość";
            // 
            // SellerStreetNumberLabel
            // 
            this.SellerStreetNumberLabel.AutoSize = true;
            this.SellerStreetNumberLabel.Location = new System.Drawing.Point(38, 49);
            this.SellerStreetNumberLabel.Name = "SellerStreetNumberLabel";
            this.SellerStreetNumberLabel.Size = new System.Drawing.Size(68, 13);
            this.SellerStreetNumberLabel.TabIndex = 6;
            this.SellerStreetNumberLabel.Text = "Ulica i numer";
            // 
            // SellerNameLabel
            // 
            this.SellerNameLabel.AutoSize = true;
            this.SellerNameLabel.Location = new System.Drawing.Point(66, 23);
            this.SellerNameLabel.Name = "SellerNameLabel";
            this.SellerNameLabel.Size = new System.Drawing.Size(40, 13);
            this.SellerNameLabel.TabIndex = 5;
            this.SellerNameLabel.Text = "Nazwa";
            // 
            // SellerCityPostCodeTB
            // 
            this.SellerCityPostCodeTB.Location = new System.Drawing.Point(112, 73);
            this.SellerCityPostCodeTB.Name = "SellerCityPostCodeTB";
            this.SellerCityPostCodeTB.Size = new System.Drawing.Size(318, 20);
            this.SellerCityPostCodeTB.TabIndex = 4;
            // 
            // NIPButton
            // 
            this.NIPButton.Location = new System.Drawing.Point(208, 148);
            this.NIPButton.Name = "NIPButton";
            this.NIPButton.Size = new System.Drawing.Size(75, 23);
            this.NIPButton.TabIndex = 3;
            this.NIPButton.Text = "Szukaj";
            this.NIPButton.UseVisualStyleBackColor = true;
            this.NIPButton.Click += new System.EventHandler(this.NIPButton_Click);
            // 
            // SellerNIPTB
            // 
            this.SellerNIPTB.Location = new System.Drawing.Point(112, 99);
            this.SellerNIPTB.Name = "SellerNIPTB";
            this.SellerNIPTB.Size = new System.Drawing.Size(194, 20);
            this.SellerNIPTB.TabIndex = 2;
            // 
            // SellerStreetNumberTB
            // 
            this.SellerStreetNumberTB.Location = new System.Drawing.Point(112, 46);
            this.SellerStreetNumberTB.Name = "SellerStreetNumberTB";
            this.SellerStreetNumberTB.Size = new System.Drawing.Size(318, 20);
            this.SellerStreetNumberTB.TabIndex = 1;
            // 
            // ProductAmountLabel1
            // 
            this.ProductAmountLabel1.AutoSize = true;
            this.ProductAmountLabel1.Location = new System.Drawing.Point(513, 461);
            this.ProductAmountLabel1.Name = "ProductAmountLabel1";
            this.ProductAmountLabel1.Size = new System.Drawing.Size(55, 13);
            this.ProductAmountLabel1.TabIndex = 19;
            this.ProductAmountLabel1.Text = "Na stanie:";
            // 
            // ProductAmountLabel2
            // 
            this.ProductAmountLabel2.AutoSize = true;
            this.ProductAmountLabel2.Location = new System.Drawing.Point(574, 462);
            this.ProductAmountLabel2.Name = "ProductAmountLabel2";
            this.ProductAmountLabel2.Size = new System.Drawing.Size(0, 13);
            this.ProductAmountLabel2.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IsPaidChB);
            this.groupBox1.Controls.Add(this.PaymentMethodCB);
            this.groupBox1.Controls.Add(this.PaymentMethodLabel);
            this.groupBox1.Controls.Add(this.PaymentDeadlineLabel);
            this.groupBox1.Controls.Add(this.PaymentDeadline);
            this.groupBox1.Location = new System.Drawing.Point(631, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 190);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Płatność";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Stawka VAT";
            // 
            // TaxStageCB
            // 
            this.TaxStageCB.FormattingEnabled = true;
            this.TaxStageCB.Location = new System.Drawing.Point(470, 513);
            this.TaxStageCB.Name = "TaxStageCB";
            this.TaxStageCB.Size = new System.Drawing.Size(121, 21);
            this.TaxStageCB.TabIndex = 23;
            // 
            // NewCategoryButton
            // 
            this.NewCategoryButton.Location = new System.Drawing.Point(400, 458);
            this.NewCategoryButton.Name = "NewCategoryButton";
            this.NewCategoryButton.Size = new System.Drawing.Size(95, 23);
            this.NewCategoryButton.TabIndex = 24;
            this.NewCategoryButton.Text = "Nowa kategoria";
            this.NewCategoryButton.UseVisualStyleBackColor = true;
            this.NewCategoryButton.Click += new System.EventHandler(this.NewCategoryButton_Click);
            // 
            // productSellOutBindingSource
            // 
            this.productSellOutBindingSource.DataSource = typeof(ClientRest.Models.Out.ProductSellOut);
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CodeLabel.Location = new System.Drawing.Point(135, 38);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(126, 24);
            this.CodeLabel.TabIndex = 25;
            this.CodeLabel.Text = "Numer faktury";
            // 
            // CodeTB
            // 
            this.CodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CodeTB.Location = new System.Drawing.Point(267, 38);
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(307, 29);
            this.CodeTB.TabIndex = 26;
            // 
            // IsPaidChB
            // 
            this.IsPaidChB.AutoSize = true;
            this.IsPaidChB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IsPaidChB.Location = new System.Drawing.Point(102, 98);
            this.IsPaidChB.Name = "IsPaidChB";
            this.IsPaidChB.Size = new System.Drawing.Size(86, 19);
            this.IsPaidChB.TabIndex = 9;
            this.IsPaidChB.Text = "Opłacona?";
            this.IsPaidChB.UseVisualStyleBackColor = true;
            // 
            // PaymentMethodCB
            // 
            this.PaymentMethodCB.FormattingEnabled = true;
            this.PaymentMethodCB.Location = new System.Drawing.Point(102, 23);
            this.PaymentMethodCB.Name = "PaymentMethodCB";
            this.PaymentMethodCB.Size = new System.Drawing.Size(99, 21);
            this.PaymentMethodCB.TabIndex = 8;
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.AutoSize = true;
            this.PaymentMethodLabel.Location = new System.Drawing.Point(6, 26);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(90, 13);
            this.PaymentMethodLabel.TabIndex = 7;
            this.PaymentMethodLabel.Text = "Sposób płatności";
            // 
            // PaymentDeadlineLabel
            // 
            this.PaymentDeadlineLabel.AutoSize = true;
            this.PaymentDeadlineLabel.Location = new System.Drawing.Point(10, 64);
            this.PaymentDeadlineLabel.Name = "PaymentDeadlineLabel";
            this.PaymentDeadlineLabel.Size = new System.Drawing.Size(86, 13);
            this.PaymentDeadlineLabel.TabIndex = 6;
            this.PaymentDeadlineLabel.Text = "Termin płatności";
            // 
            // PaymentDeadline
            // 
            this.PaymentDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PaymentDeadline.Location = new System.Drawing.Point(102, 60);
            this.PaymentDeadline.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.PaymentDeadline.Name = "PaymentDeadline";
            this.PaymentDeadline.Size = new System.Drawing.Size(99, 20);
            this.PaymentDeadline.TabIndex = 5;
            this.PaymentDeadline.Value = new System.DateTime(2020, 1, 28, 18, 3, 19, 0);
            // 
            // NewInvoiceBuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 685);
            this.Controls.Add(this.CodeTB);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.NewCategoryButton);
            this.Controls.Add(this.TaxStageCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProductAmountLabel2);
            this.Controls.Add(this.ProductAmountLabel1);
            this.Controls.Add(this.SellerGB);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnitsCB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PricePerItemNUD);
            this.Controls.Add(this.CategoryCBLabel);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.NameCBLabel);
            this.Controls.Add(this.ProductNameCB);
            this.Controls.Add(this.AddProductButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewInvoiceBuyForm";
            this.Text = "InvoiceSell";
            this.Load += new System.EventHandler(this.InvoiceSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PricePerItemNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTB)).EndInit();
            this.Summary.ResumeLayout(false);
            this.Summary.PerformLayout();
            this.SellerGB.ResumeLayout(false);
            this.SellerGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSellOutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox UnitsCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.GroupBox Summary;
        private System.Windows.Forms.Label SummaryNetto;
        private System.Windows.Forms.Label SummaryNettoLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label SummaryBrutto;
        private System.Windows.Forms.Label SummaryBrutttoLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.GroupBox SellerGB;
        private System.Windows.Forms.Button NIPButton;
        private System.Windows.Forms.TextBox SellerNIPTB;
        private System.Windows.Forms.TextBox SellerStreetNumberTB;
        private System.Windows.Forms.TextBox SellerCityPostCodeTB;
        private System.Windows.Forms.Label SellerNIPLabel;
        private System.Windows.Forms.Label SellerCityPostCodeLabel;
        private System.Windows.Forms.Label SellerStreetNumberLabel;
        private System.Windows.Forms.Label SellerNameLabel;
        private System.Windows.Forms.Label ProductAmountLabel1;
        private System.Windows.Forms.Label ProductAmountLabel2;
        private System.Windows.Forms.ComboBox SellerNameCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TaxStageCB;
        private System.Windows.Forms.Button NewCategoryButton;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.CheckBox IsPaidChB;
        private System.Windows.Forms.ComboBox PaymentMethodCB;
        private System.Windows.Forms.Label PaymentMethodLabel;
        private System.Windows.Forms.Label PaymentDeadlineLabel;
        private System.Windows.Forms.DateTimePicker PaymentDeadline;
    }
}