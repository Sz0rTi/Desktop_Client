using ClientRest.Models;
using ClientRest.Models.In;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRest.Forms
{
    public partial class SummariesForm : Form
    {
        public InvoicesDate MinDate { get; set; }
        public DateTime CurrentDate { get; set; } = DateTime.Now;
        RestClass rest = new RestClass();
        public Dictionary<int, string> MonthsDit = new Dictionary<int, string>();
        public List<Month> Months { get; set; } = new List<Month>();
        public List<Year> Years { get; set; } = new List<Year>();
        public List<SummaryIn> Summaries { get; set; }

        public SummariesForm()
        {
            InitializeComponent();

            MonthsDit.Add(1, "Styczeń");
            MonthsDit.Add(2, "Luty");
            MonthsDit.Add(3, "Marzec");
            MonthsDit.Add(4, "Kwiecień");
            MonthsDit.Add(5, "Maj");
            MonthsDit.Add(6, "Czerwiec");
            MonthsDit.Add(7, "Lipiec");
            MonthsDit.Add(8, "Sierpień");
            MonthsDit.Add(9, "Wrzesień");
            MonthsDit.Add(10, "Październik");
            MonthsDit.Add(11, "Listopad");
            MonthsDit.Add(12, "Grudzień");
            var tempMinDate = rest.getRequest<InvoicesDate>(controller.summaries, "/min");
            if(tempMinDate != null)
            {
                MinDate = tempMinDate;
                for(int i = 1; i <= MinDate.Month; i++)
                {
                    Months.Add(new Month { ID = i, Name = MonthsDit[i] });
                }
                for(int i = MinDate.Year; i <= CurrentDate.Year; i++)
                {
                    Years.Add(new Year { ID = i, Name = i.ToString()});
                }
            }

            YearCB.SelectedIndexChanged -= YearCB_SelectedIndexChanged;
            MonthCB.SelectedIndexChanged -= MonthCB_SelectedIndexChanged;

            YearCB.SelectedValue = -1;
            YearCB.ValueMember = "id";
            YearCB.DisplayMember = "name";
            YearCB.DataSource = Years;
            YearCB.SelectedValue = CurrentDate.Year;

            MonthCB.SelectedValue = -1;
            MonthCB.ValueMember = "id";
            MonthCB.DisplayMember = "name";
            MonthCB.DataSource = Months;
            MonthCB.SelectedValue = CurrentDate.Month;

            SummariesCB.SelectedValue = -1;
            SummariesCB.ValueMember = "id";
            SummariesCB.DisplayMember = "date";
            SummariesCB.DataSource = Summaries;

            YearCB.SelectedIndexChanged += YearCB_SelectedIndexChanged;
            MonthCB.SelectedIndexChanged += MonthCB_SelectedIndexChanged;

        }

        private void YearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var month = (Month)MonthCB.SelectedItem;
            var year = (Year)YearCB.SelectedItem;
            Summaries = rest.postRequest<List<SummaryIn>, InvoicesDate>(new InvoicesDate { Month = month.ID, Year = year.ID }, controller.summaries, "/list");
            Summaries = Summaries.OrderByDescending(s => s.Date).ToList();
            SummariesCB.DataSource = Summaries;
            ((CurrencyManager)BindingContext[Summaries]).Refresh();
        }

        private void MonthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var month = (Month)MonthCB.SelectedItem;
            var year = (Year)YearCB.SelectedItem;
            Summaries = rest.postRequest<List<SummaryIn>, InvoicesDate>(new InvoicesDate { Month = month.ID, Year = year.ID }, controller.summaries, "/list");
            Summaries = Summaries.OrderByDescending(s => s.Date).ToList();
            SummariesCB.DataSource = Summaries;
            ((CurrencyManager)BindingContext[Summaries]).Refresh();
        }

        private void SummariesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuyLV.Items.Clear();
            SellLV.Items.Clear();
            SellSumLabel2.Text = "";
            BuySumLabel2.Text = "";
            EarnSumLabel2.Text = "";
            var temp = (SummaryIn)SummariesCB.SelectedItem;
            SummaryIn summary = rest.getRequest<SummaryIn>(controller.summaries,"/"+temp.ID.ToString());
            SellSumLabel2.Text = summary.SumSold.ToString("C2");
            BuySumLabel2.Text = summary.SumBought.ToString("C2");
            EarnSumLabel2.Text = summary.SumEarned.ToString("C2");
            foreach(var item in summary.SummaryProductBuys)
            {
                BuyLV.Items.Add(new ListViewItem(new[]
                {
                    item.ProductName,
                    item.Amount.ToString(),
                    item.AvgBuyPrice.ToString("C2"),
                    (item.AvgBuyPrice*item.Amount).ToString("C2")
                }));
            }

            foreach(var item in summary.SummaryProductSells)
            {
                SellLV.Items.Add(new ListViewItem(new[]
                {
                    item.ProductName,
                    item.Amount.ToString(),
                    item.AvgBuyPrice.ToString("C2"),
                    item.AvgSellPrice.ToString("C2"),
                    item.AvgEarn.ToString("C2"),
                    item.SumSold.ToString("C2"),
                    item.SumEarned.ToString("C2")
                }));
            }
        }

        private void SummariesForm_Load(object sender, EventArgs e)
        {
            BuyLV.View = View.Details;
            SellLV.View = View.Details;
        }
    }
}
