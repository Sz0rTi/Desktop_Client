namespace ClientRest.Forms
{
    partial class InvoiceBuyShowForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Summary = new System.Windows.Forms.GroupBox();
            this.SummaryBrutto = new System.Windows.Forms.Label();
            this.SummaryBrutttoLabel = new System.Windows.Forms.Label();
            this.SummaryNetto = new System.Windows.Forms.Label();
            this.SummaryNettoLabel = new System.Windows.Forms.Label();
            this.ClientGB = new System.Windows.Forms.GroupBox();
            this.CNipLabel = new System.Windows.Forms.Label();
            this.CCodeLabel = new System.Windows.Forms.Label();
            this.CStreetLabel = new System.Windows.Forms.Label();
            this.CNameLabel = new System.Windows.Forms.Label();
            this.ClientNIPLabel = new System.Windows.Forms.Label();
            this.ClientCityPostCodeLabel = new System.Windows.Forms.Label();
            this.ClientStreetNumberLabel = new System.Windows.Forms.Label();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PaidButton = new System.Windows.Forms.Button();
            this.IsPaidLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PDLabel = new System.Windows.Forms.Label();
            this.PMLabel = new System.Windows.Forms.Label();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.PaymentDeadlineLabel = new System.Windows.Forms.Label();
            this.DateLabel2 = new System.Windows.Forms.Label();
            this.DateLabel1 = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.productSellOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Summary.SuspendLayout();
            this.ClientGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSellOutBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(142, 283);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(709, 217);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // Summary
            // 
            this.Summary.Controls.Add(this.SummaryBrutto);
            this.Summary.Controls.Add(this.SummaryBrutttoLabel);
            this.Summary.Controls.Add(this.SummaryNetto);
            this.Summary.Controls.Add(this.SummaryNettoLabel);
            this.Summary.Location = new System.Drawing.Point(651, 506);
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
            // ClientGB
            // 
            this.ClientGB.Controls.Add(this.CNipLabel);
            this.ClientGB.Controls.Add(this.CCodeLabel);
            this.ClientGB.Controls.Add(this.CStreetLabel);
            this.ClientGB.Controls.Add(this.CNameLabel);
            this.ClientGB.Controls.Add(this.ClientNIPLabel);
            this.ClientGB.Controls.Add(this.ClientCityPostCodeLabel);
            this.ClientGB.Controls.Add(this.ClientStreetNumberLabel);
            this.ClientGB.Controls.Add(this.ClientNameLabel);
            this.ClientGB.Location = new System.Drawing.Point(142, 103);
            this.ClientGB.Name = "ClientGB";
            this.ClientGB.Size = new System.Drawing.Size(485, 174);
            this.ClientGB.TabIndex = 18;
            this.ClientGB.TabStop = false;
            this.ClientGB.Text = "Dane sprzedawcy";
            // 
            // CNipLabel
            // 
            this.CNipLabel.AutoSize = true;
            this.CNipLabel.Location = new System.Drawing.Point(116, 102);
            this.CNipLabel.Name = "CNipLabel";
            this.CNipLabel.Size = new System.Drawing.Size(35, 13);
            this.CNipLabel.TabIndex = 12;
            this.CNipLabel.Text = "label2";
            // 
            // CCodeLabel
            // 
            this.CCodeLabel.AutoSize = true;
            this.CCodeLabel.Location = new System.Drawing.Point(116, 76);
            this.CCodeLabel.Name = "CCodeLabel";
            this.CCodeLabel.Size = new System.Drawing.Size(35, 13);
            this.CCodeLabel.TabIndex = 11;
            this.CCodeLabel.Text = "label2";
            // 
            // CStreetLabel
            // 
            this.CStreetLabel.AutoSize = true;
            this.CStreetLabel.Location = new System.Drawing.Point(116, 49);
            this.CStreetLabel.Name = "CStreetLabel";
            this.CStreetLabel.Size = new System.Drawing.Size(35, 13);
            this.CStreetLabel.TabIndex = 10;
            this.CStreetLabel.Text = "label2";
            // 
            // CNameLabel
            // 
            this.CNameLabel.AutoSize = true;
            this.CNameLabel.Location = new System.Drawing.Point(116, 23);
            this.CNameLabel.Name = "CNameLabel";
            this.CNameLabel.Size = new System.Drawing.Size(67, 13);
            this.CNameLabel.TabIndex = 9;
            this.CNameLabel.Text = "ClientNameL";
            // 
            // ClientNIPLabel
            // 
            this.ClientNIPLabel.AutoSize = true;
            this.ClientNIPLabel.Location = new System.Drawing.Point(81, 102);
            this.ClientNIPLabel.Name = "ClientNIPLabel";
            this.ClientNIPLabel.Size = new System.Drawing.Size(28, 13);
            this.ClientNIPLabel.TabIndex = 8;
            this.ClientNIPLabel.Text = "NIP:";
            // 
            // ClientCityPostCodeLabel
            // 
            this.ClientCityPostCodeLabel.AutoSize = true;
            this.ClientCityPostCodeLabel.Location = new System.Drawing.Point(12, 76);
            this.ClientCityPostCodeLabel.Name = "ClientCityPostCodeLabel";
            this.ClientCityPostCodeLabel.Size = new System.Drawing.Size(97, 13);
            this.ClientCityPostCodeLabel.TabIndex = 7;
            this.ClientCityPostCodeLabel.Text = "Kod i miejscowość:";
            // 
            // ClientStreetNumberLabel
            // 
            this.ClientStreetNumberLabel.AutoSize = true;
            this.ClientStreetNumberLabel.Location = new System.Drawing.Point(38, 49);
            this.ClientStreetNumberLabel.Name = "ClientStreetNumberLabel";
            this.ClientStreetNumberLabel.Size = new System.Drawing.Size(71, 13);
            this.ClientStreetNumberLabel.TabIndex = 6;
            this.ClientStreetNumberLabel.Text = "Ulica i numer:";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(66, 23);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(43, 13);
            this.ClientNameLabel.TabIndex = 5;
            this.ClientNameLabel.Text = "Nazwa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PaidButton);
            this.groupBox1.Controls.Add(this.IsPaidLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PDLabel);
            this.groupBox1.Controls.Add(this.PMLabel);
            this.groupBox1.Controls.Add(this.PaymentMethodLabel);
            this.groupBox1.Controls.Add(this.PaymentDeadlineLabel);
            this.groupBox1.Location = new System.Drawing.Point(634, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 173);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Płatność";
            // 
            // PaidButton
            // 
            this.PaidButton.Location = new System.Drawing.Point(93, 131);
            this.PaidButton.Name = "PaidButton";
            this.PaidButton.Size = new System.Drawing.Size(75, 23);
            this.PaidButton.TabIndex = 11;
            this.PaidButton.Text = "Opłacono";
            this.PaidButton.UseVisualStyleBackColor = true;
            this.PaidButton.Click += new System.EventHandler(this.PaidButton_Click);
            // 
            // IsPaidLabel
            // 
            this.IsPaidLabel.AutoSize = true;
            this.IsPaidLabel.Location = new System.Drawing.Point(132, 92);
            this.IsPaidLabel.Name = "IsPaidLabel";
            this.IsPaidLabel.Size = new System.Drawing.Size(35, 13);
            this.IsPaidLabel.TabIndex = 10;
            this.IsPaidLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Opłacona?";
            // 
            // PDLabel
            // 
            this.PDLabel.AutoSize = true;
            this.PDLabel.Location = new System.Drawing.Point(132, 60);
            this.PDLabel.Name = "PDLabel";
            this.PDLabel.Size = new System.Drawing.Size(35, 13);
            this.PDLabel.TabIndex = 8;
            this.PDLabel.Text = "label2";
            // 
            // PMLabel
            // 
            this.PMLabel.AutoSize = true;
            this.PMLabel.Location = new System.Drawing.Point(133, 22);
            this.PMLabel.Name = "PMLabel";
            this.PMLabel.Size = new System.Drawing.Size(35, 13);
            this.PMLabel.TabIndex = 7;
            this.PMLabel.Text = "label1";
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.AutoSize = true;
            this.PaymentMethodLabel.Location = new System.Drawing.Point(36, 22);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(90, 13);
            this.PaymentMethodLabel.TabIndex = 6;
            this.PaymentMethodLabel.Text = "Sposób płatności";
            // 
            // PaymentDeadlineLabel
            // 
            this.PaymentDeadlineLabel.AutoSize = true;
            this.PaymentDeadlineLabel.Location = new System.Drawing.Point(40, 60);
            this.PaymentDeadlineLabel.Name = "PaymentDeadlineLabel";
            this.PaymentDeadlineLabel.Size = new System.Drawing.Size(86, 13);
            this.PaymentDeadlineLabel.TabIndex = 5;
            this.PaymentDeadlineLabel.Text = "Termin płatności";
            // 
            // DateLabel2
            // 
            this.DateLabel2.AutoSize = true;
            this.DateLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateLabel2.Location = new System.Drawing.Point(776, 55);
            this.DateLabel2.Name = "DateLabel2";
            this.DateLabel2.Size = new System.Drawing.Size(46, 18);
            this.DateLabel2.TabIndex = 27;
            this.DateLabel2.Text = "label2";
            // 
            // DateLabel1
            // 
            this.DateLabel1.AutoSize = true;
            this.DateLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateLabel1.Location = new System.Drawing.Point(640, 55);
            this.DateLabel1.Name = "DateLabel1";
            this.DateLabel1.Size = new System.Drawing.Size(130, 18);
            this.DateLabel1.TabIndex = 26;
            this.DateLabel1.Text = "Data wystawienia: ";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CodeLabel.Location = new System.Drawing.Point(151, 37);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(86, 31);
            this.CodeLabel.TabIndex = 25;
            this.CodeLabel.Text = "label2";
            // 
            // productSellOutBindingSource
            // 
            this.productSellOutBindingSource.DataSource = typeof(ClientRest.Models.Out.ProductSellOut);
            // 
            // InvoiceBuyShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 685);
            this.Controls.Add(this.DateLabel2);
            this.Controls.Add(this.DateLabel1);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClientGB);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceBuyShowForm";
            this.Text = "InvoiceSell";
            this.Load += new System.EventHandler(this.InvoiceBuy_Load);
            this.Summary.ResumeLayout(false);
            this.Summary.PerformLayout();
            this.ClientGB.ResumeLayout(false);
            this.ClientGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSellOutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource productSellOutBindingSource;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox Summary;
        private System.Windows.Forms.Label SummaryNetto;
        private System.Windows.Forms.Label SummaryNettoLabel;
        private System.Windows.Forms.Label SummaryBrutto;
        private System.Windows.Forms.Label SummaryBrutttoLabel;
        private System.Windows.Forms.GroupBox ClientGB;
        private System.Windows.Forms.Label ClientNIPLabel;
        private System.Windows.Forms.Label ClientCityPostCodeLabel;
        private System.Windows.Forms.Label ClientStreetNumberLabel;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CNipLabel;
        private System.Windows.Forms.Label CCodeLabel;
        private System.Windows.Forms.Label CStreetLabel;
        private System.Windows.Forms.Label CNameLabel;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label IsPaidLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PDLabel;
        private System.Windows.Forms.Label PMLabel;
        private System.Windows.Forms.Label PaymentMethodLabel;
        private System.Windows.Forms.Label PaymentDeadlineLabel;
        private System.Windows.Forms.Button PaidButton;
        private System.Windows.Forms.Label DateLabel2;
        private System.Windows.Forms.Label DateLabel1;
        private System.Windows.Forms.Label CodeLabel;
    }
}