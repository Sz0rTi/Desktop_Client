namespace ClientRest.Forms
{
    partial class InvoiceSellShowForm
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
            this.PAYDATE = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Summary = new System.Windows.Forms.GroupBox();
            this.SummaryBrutto = new System.Windows.Forms.Label();
            this.SummaryBrutttoLabel = new System.Windows.Forms.Label();
            this.SummaryNetto = new System.Windows.Forms.Label();
            this.SummaryNettoLabel = new System.Windows.Forms.Label();
            this.ClientGB = new System.Windows.Forms.GroupBox();
            this.ClientNIPLabel = new System.Windows.Forms.Label();
            this.ClientCityPostCodeLabel = new System.Windows.Forms.Label();
            this.ClientStreetNumberLabel = new System.Windows.Forms.Label();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.productSellOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CNameLabel = new System.Windows.Forms.Label();
            this.CStreetLabel = new System.Windows.Forms.Label();
            this.CCodeLabel = new System.Windows.Forms.Label();
            this.CNipLabel = new System.Windows.Forms.Label();
            this.Summary.SuspendLayout();
            this.ClientGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSellOutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PAYDATE
            // 
            this.PAYDATE.Location = new System.Drawing.Point(630, 431);
            this.PAYDATE.Name = "PAYDATE";
            this.PAYDATE.Size = new System.Drawing.Size(200, 20);
            this.PAYDATE.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(139, 209);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(691, 135);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 270;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ilość";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "J.M";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cena netto";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Wartość netto";
            // 
            // Summary
            // 
            this.Summary.Controls.Add(this.SummaryBrutto);
            this.Summary.Controls.Add(this.SummaryBrutttoLabel);
            this.Summary.Controls.Add(this.SummaryNetto);
            this.Summary.Controls.Add(this.SummaryNettoLabel);
            this.Summary.Location = new System.Drawing.Point(630, 350);
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
            this.ClientGB.Location = new System.Drawing.Point(139, 12);
            this.ClientGB.Name = "ClientGB";
            this.ClientGB.Size = new System.Drawing.Size(485, 191);
            this.ClientGB.TabIndex = 18;
            this.ClientGB.TabStop = false;
            this.ClientGB.Text = "Dane klienta";
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
            // productSellOutBindingSource
            // 
            this.productSellOutBindingSource.DataSource = typeof(ClientRest.Models.Out.ProductSellOut);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(631, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 190);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Płatność";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(139, 510);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 96);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marża itd";
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
            // CStreetLabel
            // 
            this.CStreetLabel.AutoSize = true;
            this.CStreetLabel.Location = new System.Drawing.Point(116, 49);
            this.CStreetLabel.Name = "CStreetLabel";
            this.CStreetLabel.Size = new System.Drawing.Size(35, 13);
            this.CStreetLabel.TabIndex = 10;
            this.CStreetLabel.Text = "label2";
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
            // CNipLabel
            // 
            this.CNipLabel.AutoSize = true;
            this.CNipLabel.Location = new System.Drawing.Point(116, 102);
            this.CNipLabel.Name = "CNipLabel";
            this.CNipLabel.Size = new System.Drawing.Size(35, 13);
            this.CNipLabel.TabIndex = 12;
            this.CNipLabel.Text = "label2";
            // 
            // InvoiceSellShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 685);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClientGB);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.PAYDATE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceSellShowForm";
            this.Text = "InvoiceSell";
            this.Load += new System.EventHandler(this.InvoiceSell_Load);
            this.Summary.ResumeLayout(false);
            this.Summary.PerformLayout();
            this.ClientGB.ResumeLayout(false);
            this.ClientGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSellOutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker PAYDATE;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label CNipLabel;
        private System.Windows.Forms.Label CCodeLabel;
        private System.Windows.Forms.Label CStreetLabel;
        private System.Windows.Forms.Label CNameLabel;
    }
}