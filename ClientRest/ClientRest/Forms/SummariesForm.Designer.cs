namespace ClientRest.Forms
{
    partial class SummariesForm
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
            this.MonthCB = new System.Windows.Forms.ComboBox();
            this.YearCB = new System.Windows.Forms.ComboBox();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.SummariesCB = new System.Windows.Forms.ComboBox();
            this.BuyLV = new System.Windows.Forms.ListView();
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ilość = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Suma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SellLV = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.earn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sumsell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sumearn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EarnSumLabel2 = new System.Windows.Forms.Label();
            this.SellSumLabel2 = new System.Windows.Forms.Label();
            this.BuySumLabel2 = new System.Windows.Forms.Label();
            this.EarnSumLabel1 = new System.Windows.Forms.Label();
            this.SellSumLabel1 = new System.Windows.Forms.Label();
            this.BuySumLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MonthCB
            // 
            this.MonthCB.FormattingEnabled = true;
            this.MonthCB.Location = new System.Drawing.Point(291, 63);
            this.MonthCB.Name = "MonthCB";
            this.MonthCB.Size = new System.Drawing.Size(121, 21);
            this.MonthCB.TabIndex = 0;
            this.MonthCB.SelectedIndexChanged += new System.EventHandler(this.MonthCB_SelectedIndexChanged);
            // 
            // YearCB
            // 
            this.YearCB.FormattingEnabled = true;
            this.YearCB.Location = new System.Drawing.Point(104, 63);
            this.YearCB.Name = "YearCB";
            this.YearCB.Size = new System.Drawing.Size(121, 21);
            this.YearCB.TabIndex = 1;
            this.YearCB.SelectedIndexChanged += new System.EventHandler(this.YearCB_SelectedIndexChanged);
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(242, 66);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(43, 13);
            this.MonthLabel.TabIndex = 2;
            this.MonthLabel.Text = "Miesiąc";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(71, 66);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(27, 13);
            this.YearLabel.TabIndex = 3;
            this.YearLabel.Text = "Rok";
            // 
            // SummariesCB
            // 
            this.SummariesCB.FormattingEnabled = true;
            this.SummariesCB.Location = new System.Drawing.Point(571, 63);
            this.SummariesCB.Name = "SummariesCB";
            this.SummariesCB.Size = new System.Drawing.Size(158, 21);
            this.SummariesCB.TabIndex = 4;
            this.SummariesCB.SelectedIndexChanged += new System.EventHandler(this.SummariesCB_SelectedIndexChanged);
            // 
            // BuyLV
            // 
            this.BuyLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nazwa,
            this.Ilość,
            this.cena,
            this.Suma});
            this.BuyLV.FullRowSelect = true;
            this.BuyLV.HideSelection = false;
            this.BuyLV.Location = new System.Drawing.Point(394, 151);
            this.BuyLV.MultiSelect = false;
            this.BuyLV.Name = "BuyLV";
            this.BuyLV.Size = new System.Drawing.Size(479, 176);
            this.BuyLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.BuyLV.TabIndex = 10;
            this.BuyLV.UseCompatibleStateImageBehavior = false;
            // 
            // Nazwa
            // 
            this.Nazwa.Text = "Nazwa towaru";
            this.Nazwa.Width = 150;
            // 
            // Ilość
            // 
            this.Ilość.Text = "Ilość";
            // 
            // cena
            // 
            this.cena.Text = "Śr. Cena";
            this.cena.Width = 100;
            // 
            // Suma
            // 
            this.Suma.Text = "Suma";
            this.Suma.Width = 100;
            // 
            // SellLV
            // 
            this.SellLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.amount,
            this.buy,
            this.sell,
            this.earn,
            this.sumsell,
            this.sumearn});
            this.SellLV.HideSelection = false;
            this.SellLV.Location = new System.Drawing.Point(104, 375);
            this.SellLV.Name = "SellLV";
            this.SellLV.Size = new System.Drawing.Size(769, 207);
            this.SellLV.TabIndex = 6;
            this.SellLV.UseCompatibleStateImageBehavior = false;
            // 
            // name
            // 
            this.name.Text = "Nazwa towaru";
            this.name.Width = 180;
            // 
            // amount
            // 
            this.amount.Text = "Ilość";
            // 
            // buy
            // 
            this.buy.Text = "Śr. Cena zakupu";
            this.buy.Width = 90;
            // 
            // sell
            // 
            this.sell.Text = "Śr. Cena sprzedaży";
            this.sell.Width = 100;
            // 
            // earn
            // 
            this.earn.Text = "Śr. Zarobek";
            this.earn.Width = 100;
            // 
            // sumsell
            // 
            this.sumsell.Text = "Suma sprzedaży";
            this.sumsell.Width = 100;
            // 
            // sumearn
            // 
            this.sumearn.Text = "Suma zarobku";
            this.sumearn.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EarnSumLabel2);
            this.groupBox1.Controls.Add(this.SellSumLabel2);
            this.groupBox1.Controls.Add(this.BuySumLabel2);
            this.groupBox1.Controls.Add(this.EarnSumLabel1);
            this.groupBox1.Controls.Add(this.SellSumLabel1);
            this.groupBox1.Controls.Add(this.BuySumLabel1);
            this.groupBox1.Location = new System.Drawing.Point(104, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 176);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podsumowanie";
            // 
            // EarnSumLabel2
            // 
            this.EarnSumLabel2.AutoSize = true;
            this.EarnSumLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EarnSumLabel2.Location = new System.Drawing.Point(141, 110);
            this.EarnSumLabel2.Name = "EarnSumLabel2";
            this.EarnSumLabel2.Size = new System.Drawing.Size(0, 16);
            this.EarnSumLabel2.TabIndex = 5;
            // 
            // SellSumLabel2
            // 
            this.SellSumLabel2.AutoSize = true;
            this.SellSumLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SellSumLabel2.Location = new System.Drawing.Point(141, 72);
            this.SellSumLabel2.Name = "SellSumLabel2";
            this.SellSumLabel2.Size = new System.Drawing.Size(0, 16);
            this.SellSumLabel2.TabIndex = 4;
            // 
            // BuySumLabel2
            // 
            this.BuySumLabel2.AutoSize = true;
            this.BuySumLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BuySumLabel2.Location = new System.Drawing.Point(141, 32);
            this.BuySumLabel2.Name = "BuySumLabel2";
            this.BuySumLabel2.Size = new System.Drawing.Size(0, 16);
            this.BuySumLabel2.TabIndex = 3;
            // 
            // EarnSumLabel1
            // 
            this.EarnSumLabel1.AutoSize = true;
            this.EarnSumLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EarnSumLabel1.Location = new System.Drawing.Point(41, 110);
            this.EarnSumLabel1.Name = "EarnSumLabel1";
            this.EarnSumLabel1.Size = new System.Drawing.Size(94, 16);
            this.EarnSumLabel1.TabIndex = 2;
            this.EarnSumLabel1.Text = "Suma zarobku";
            // 
            // SellSumLabel1
            // 
            this.SellSumLabel1.AutoSize = true;
            this.SellSumLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SellSumLabel1.Location = new System.Drawing.Point(27, 72);
            this.SellSumLabel1.Name = "SellSumLabel1";
            this.SellSumLabel1.Size = new System.Drawing.Size(108, 16);
            this.SellSumLabel1.TabIndex = 1;
            this.SellSumLabel1.Text = "Suma sprzedaży";
            // 
            // BuySumLabel1
            // 
            this.BuySumLabel1.AutoSize = true;
            this.BuySumLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BuySumLabel1.Location = new System.Drawing.Point(36, 32);
            this.BuySumLabel1.Name = "BuySumLabel1";
            this.BuySumLabel1.Size = new System.Drawing.Size(99, 16);
            this.BuySumLabel1.TabIndex = 0;
            this.BuySumLabel1.Text = "Suma zakupów";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(390, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista zakupów";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(100, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lista sprzedaży";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Zestawienie z";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Nowe zestawienie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SummariesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SellLV);
            this.Controls.Add(this.BuyLV);
            this.Controls.Add(this.SummariesCB);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.YearCB);
            this.Controls.Add(this.MonthCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SummariesForm";
            this.Text = "SumarriesForm";
            this.Load += new System.EventHandler(this.SummariesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MonthCB;
        private System.Windows.Forms.ComboBox YearCB;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.ComboBox SummariesCB;
        private System.Windows.Forms.ListView BuyLV;
        private System.Windows.Forms.ColumnHeader Nazwa;
        private System.Windows.Forms.ColumnHeader Ilość;
        private System.Windows.Forms.ColumnHeader cena;
        private System.Windows.Forms.ColumnHeader Suma;
        private System.Windows.Forms.ListView SellLV;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader buy;
        private System.Windows.Forms.ColumnHeader sell;
        private System.Windows.Forms.ColumnHeader earn;
        private System.Windows.Forms.ColumnHeader sumsell;
        private System.Windows.Forms.ColumnHeader sumearn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label EarnSumLabel2;
        private System.Windows.Forms.Label SellSumLabel2;
        private System.Windows.Forms.Label BuySumLabel2;
        private System.Windows.Forms.Label EarnSumLabel1;
        private System.Windows.Forms.Label SellSumLabel1;
        private System.Windows.Forms.Label BuySumLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}