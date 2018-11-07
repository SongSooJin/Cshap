using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// C# 윈폼 프로그래밍, ListView Control 

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1() // 생성자
        {
            InitializeComponent(); // 메소드
        }

        public class Actress
        {
            public string name;
            public int year;

            public Actress(string name, int year) {
                this.name = name;
                this.year = year;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "ListView";
            Size = new Size(350, 300);

            //ColumnHeader name = new ColumnHeader();
            //name.Text = "Name";
            //name.Width = -1;
            //name.TextAlign = HorizontalAlignment.Center;

            //ColumnHeader year = new ColumnHeader();
            //year.Text = "Year";
            //lv.Columns.Add(name);
            //lv.Columns.Add(year);

            List<Actress> actresses = new List<Actress>();
            actresses.Add(new Actress("Jessica Alba", 1981));
            actresses.Add(new Actress("Angelina Jolie", 1975));
            actresses.Add(new Actress("Natalie Portman", 1981));
            actresses.Add(new Actress("Rachel Weiss", 1971));
            actresses.Add(new Actress("Scarlett Johansson", 1984));

            foreach (Actress act in actresses)
            {
                ListViewItem item = new ListViewItem();
                item.Text = act.name;
                item.SubItems.Add(act.year.ToString());
                lv.Items.Add(item);
            }


        }

        private void lv_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            ListView lv = (ListView)sender;

            if (lv.Sorting == SortOrder.Ascending) {
                lv.Sorting = SortOrder.Descending;
            }
            else {
                lv.Sorting = SortOrder.Ascending;
            }
        }

        private void lv_Click(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            string name = lv.SelectedItems[0].SubItems[0].Text;
            string born = lv.SelectedItems[0].SubItems[1].Text;
            toolStripStatusLabel1.Text = name + ", " + born;
        }
    }
}
