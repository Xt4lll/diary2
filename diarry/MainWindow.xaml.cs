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

namespace diarry
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private note n = new note();
        private List<note> notes = new List<note>();
        private List<string> names = new List<string>();
        private List<string> descriptions = new List<string>();
        private string selected;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            n.name = name.Text.ToString();
            n.description = description.Text.ToString();
            n.date = datePicker.DisplayDate;
            notes.Add(n);
            names.Add(n.name);
            descriptions.Add(n.description);
            notesField.ItemsSource = null;
            notesField.ItemsSource = names;
            n.name = "";
            n.description = "";
            name.Text = "";
            description.Text = "";
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            selected = notesField.SelectedItem.ToString();
            names.Remove(selected);
            descriptions.Remove(selected);
            name.Text = "";
            description.Text = "";
            notesField.ItemsSource = null;
            notesField.ItemsSource = names;
        }

        private void notesField_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if(selected == names[i].ToString())
                {
                    name.Text = names[i].ToString();
                    description.Text = descriptions[i].ToString();
                }
            }
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (selected == names[i])
                {
                    names[i] = name.Text;
                    descriptions[i] = description.Text;
                }
            }
        }
    }
}
