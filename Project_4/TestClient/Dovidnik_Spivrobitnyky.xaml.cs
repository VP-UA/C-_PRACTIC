using Project_Library_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace TestClient
{
    /// <summary>
    /// Логика взаимодействия для Dovidnik_Spivrobitnyky.xaml
    /// </summary>
    public partial class Dovidnik_Spivrobitnyky : Window
    {
        SPDC spdc;

        public Dovidnik_Spivrobitnyky()
         {
            InitializeComponent();
          
        }
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            spdc = new SPDC(Properties.Settings.Default.dbspconect);
            try
            {
                if (!spdc.DatabaseExists()) spdc.CreateDatabase();
                dg_countr.ItemsSource = spdc.Country.GetNewBindingList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void s_add_verf_data_click(object sender, RoutedEventArgs e)
        {
            var c = (dg_countr.ItemsSource as IBindingList);
            c.Add(new Country { name_c = "Germany" });
            c.Add(new Country { name_c = "Havai" });
            c.Add(new Country { name_c = "Japan" });
            c.Add(new Country { name_c = "Korea" });
            c.Add(new Country { name_c = "Africa" });
            c.Add(new Country { name_c = "Bali" });
        }

        private void s_delete_verf_data_click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("All data and file will be destroyed! Are u sure about that?", "Accept delete data", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                return;
            try
            {
                spdc.DeleteDatabase();
                MessageBox.Show("File data base delete, open this window again for create new data base.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void s_submit_changes_click(object sender, RoutedEventArgs e)
        {
            try
            {
                spdc.SubmitChanges();
                MessageBox.Show("All changes saved to database" + Properties.Settings.Default.dbspconect, "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            var set = spdc.GetChangeSet();
            if (set.Deletes.Count > 0 || set.Inserts.Count > 0 || set.Updates.Count > 0)
                if (MessageBox.Show("There are unsaved actions! Are u sure u want close window?", "Possible loss of action", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    e.Cancel = true;
            spdc.Dispose();
        }
        private void button_get_changes(object sender, RoutedEventArgs e)
        {
            s_ch.Header = "Changes:" + spdc.GetChangeSet();
        }


    }
}
