using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


//  윈폼 프로그래밍, ListView Control 

namespace ConsoleApp1
{
    public class Actress
    {
        public string name;
        public int year;

        public Actress(string name, int year) {
            this.name = name;
            this.year = year;
        }
    }

    class MForm : Form {
        private StatusBar sb;

        public MForm() {
            Text = "ListView";
            Size = new Size(350,300);

            List<Actress> actresses = new List<Actress>();

            actresses.Add(new Actress("Jessica Alba", 1981));
            actresses.Add(new Actress("Angelina Jolie", 1975));
            actresses.Add(new Actress("Natalie Portman", 1981));
            actresses.Add(new Actress("Rachel Weiss", 1971));
            actresses.Add(new Actress("Scarlett Johansson", 1984));

            ColumnHeader name = new ColumnHeader();
            name.Text = "Name";
            name.Width = -1;

            ColumnHeader year = new ColumnHeader();
            year.Text = "Year";

            SuspendLayout(); // 잠깐 잡아놈

            ListView lv = new ListView(); // 윈도우 안에 ListView가 그려짐
            lv.Parent = this;
            lv.FullRowSelect = true;
            lv.GridLines = true; // 격자 보이게 
            lv.AllowColumnReorder = true; // Column을 움직임
            //lv.Sorting = SortOrder.Ascending;
            lv.Columns.AddRange(new ColumnHeader[] { name, year });
            lv.ColumnClick += new ColumnClickEventHandler(ColumnClick);

            foreach (Actress act in actresses) { // 네임과 이어가 있다
                ListViewItem item = new ListViewItem();
                item.Text = act.name;
                item.SubItems.Add(act.year.ToString());
                lv.Items.Add(item);
            }

            lv.Dock = DockStyle.Fill;
            lv.Click += new EventHandler(OnChanged);

            sb = new StatusBar();
            sb.Parent = this; // this 윈도우 폼 
            lv.View = View.Details; // 모양이 나옴 

            ResumeLayout();

            CenterToScreen();

        }

        void OnChanged(object sender, EventArgs e) {
            ListView lv = (ListView)sender;
            string name = lv.SelectedItems[0].SubItems[0].Text;
            string born = lv.SelectedItems[0].SubItems[1].Text;
            sb.Text = name + ", " + born;

        }

        void ColumnClick(object sender, ColumnClickEventArgs e) {
            //ListView lv = (ListView)sender; // 에러냄 
            ListView lv = sender as ListView; // 에러 안내고 null값을 넣어줌

            if (lv.Sorting == SortOrder.Ascending)
            {
                lv.Sorting = SortOrder.Descending;
            }
            else {
                lv.Sorting = SortOrder.Ascending;
            }
        }
    }

    class MApplication
    {
        public static void Main(string[] args)
        {
            Application.Run(new MForm());
        }
    }
}
