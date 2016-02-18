using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookstoreWPF
{
    /// <summary>
    /// Interaction logic for BookWindow.xaml
    /// </summary>
    public partial class BookWindow : Window
    {

		private Book book;

		public Book Book {
			get { return this.book; }
			set {
				this.Title = "Edit book...";
				this.book = value;
				this.gBook.DataContext = this.book;
			}
		}

        public BookWindow()
        {
            InitializeComponent();
			this.cbCategory.ItemsSource = Enum.GetValues(typeof(BookCategory)).Cast<BookCategory>();
			this.cbCategory.SelectedItem = BookCategory.UNDEFINED;
		}

        private void bOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

		public void createNewBook( String title )
		{
			this.Title = "Add new book...";
			this.book = new Book(title);
			this.gBook.DataContext = this.book;
		}

    }
}
