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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookstoreWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
			this.lbBooks.Items.Add(new Book("A vak órásmester", "Richard Dawkins", BookCategory.SCIENCE, true));
			this.lbBooks.Items.Add(new Book("Darwin veszélyes ideája", "Daniel Clement Dennett", BookCategory.SCIENCE, false));
			this.lbBooks.Items.Add(new Book("A fajok eredete", "Charles Darwin", BookCategory.SCIENCE, true));
        }

        private void bAddBook_Click(object sender, RoutedEventArgs e)
        {
            BookWindow bookWindow = new BookWindow();
			bookWindow.createNewBook(this.tbBookTitle.Text);
            // bool?
            // bookWindow.DialogResult
            Nullable<Boolean> showDialogResult = bookWindow.ShowDialog();
            if (showDialogResult.HasValue && showDialogResult.Value)
            {
				this.lbBooks.Items.Add(bookWindow.Book);
            }
        }

		private void lbBooks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (this.lbBooks.SelectedItem != null && this.lbBooks.SelectedItem is Book)
			{
				BookWindow bookWindow = new BookWindow();
				bookWindow.Book = (Book)this.lbBooks.SelectedItem;
				bool? showDialogResult = bookWindow.ShowDialog();
				if (showDialogResult.HasValue && showDialogResult.Value)
				{
					this.lbBooks.Items.Refresh();
					MessageBox.Show("The book was updated ("+bookWindow.Book+").", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
				}
			}
		}
    }
}
