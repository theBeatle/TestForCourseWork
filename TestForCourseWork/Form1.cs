using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TestForCourseWork
{
    public class SimpleBook
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public override string ToString() => $"T: {Title} A:{Authors}";
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LibraryDb ctx = new LibraryDb())
            {
                var res1 =  ctx.Books.Count().ToString(); // 2
                //MessageBox.Show(res1);
                Debug.WriteLine(res1);

                var res2 = ctx.Books.Where(b => b.PagesQuantity > 500);
                Debug.WriteLine(res2.ToList());
                //MessageBox.Show(res2.ToList().ToString());

                var res3 = ctx.Books
                    .Count(b => b.PagesQuantity > 500);

                #region workAbleCode Part1
                //var myList = new List<SimpleBook>();
                //foreach (var item in ctx.Books.Include("Authors"))
                //{
                //    var authors = item.Authors;
                //    string container = String.Empty;
                //    foreach (var str in authors)
                //    {
                //        container += (str.Name+", "); 
                //    }
                //    myList.Add(new SimpleBook
                //    {
                //        Title = item.Title,
                //        Authors = container
                //    });
                //}
                //foreach (var item in myList)
                //{
                //    MessageBox.Show(item.ToString());
                //}
                #endregion

                //10 lines
                #region workAbleCode Part2
                ctx.Books
                    .ToList()
                    .Select(b => new SimpleBook
                    {
                        Title = b.Title,
                        Authors = b.Authors
                        .Aggregate("", (prev, next) => prev + next.Name + ", ")
                    })
                    .ToList()
                    .ForEach(elem => MessageBox.Show(elem.ToString()));
                #endregion



            }
        }
    }
}
