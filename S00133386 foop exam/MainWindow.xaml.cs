using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

namespace S00133386_foop_exam
{
   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ArrayList musicList = new ArrayList(); // the list of music
        public Random rnd = new Random(System.Environment.TickCount);// the random objects
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            double total = 0;// find the total

           
            
            
            

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Music a = new Music("Just do it", "50 Cent", 25);// add into the list box
            lbxMusic.Items.Add(a);

            a = new Music("From the bottom", "Drake", 28);// add into the list box
            lbxMusic.Items.Add(a);

            a = new Music("Paris", "Kanye", 101); // add into the list box
            lbxMusic.Items.Add(a);

            
          
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            Music b = (Music)lbxMusic.SelectedItem;
            lbxMusic.Items.Remove (b);// on click b is removed from list box
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = File.ReadAllLines("musicfile.txt");// read in all lines of file
            foreach (var line in lines)
            {
                string[] pieces = line.Split(','); // split them with a seperator

                double cost = Convert.ToDouble(pieces[2]);// convert the cost into a double

                lbxMusic.Items.Add(new Music(pieces[0], pieces[1], cost));// add the album name, album artist and cost into listbox
                  double total = 0;
                  total += cost;

                 
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            int collection = lbxMusic.Items.Count;
            string[] output = new string[collection];
            for (int i = 0; i < collection; i++)
            {

                output[i] = lbxMusic.Items[i].ToString();

            }
            File.WriteAllLines("musicfileupdate.txt", output);// output the saved collection
        }



    }
}
