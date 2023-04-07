using Project_Library_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
    /// Логика взаимодействия для Dovidnik_Posadi.xaml
    /// </summary>
    public partial class Dovidnik_Posadi : Window
    {
        PODC podc;
        public Dovidnik_Posadi()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            podc = new PODC(Properties.Settings.Default.dblocal);
            try 
            {
                if (!podc.DatabaseExists()) podc.CreateDatabase();
                dg_groups.ItemsSource=podc.Position.GetNewBindingList();
            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex+"");
            }
        }

        private void p_add_verf_data_click(object sender, RoutedEventArgs e)
        {
            var l = (dg_groups.ItemsSource as IBindingList);
            l.Add(new Position { name = "Administrator" , name_surname = "Eugen Zviniy"});
            l.Add(new Position { name = "SystemAdministrator", name_surname = "Maks Tihiy" });
            l.Add(new Position { name = "Manager", name_surname = "Alex Nizhin" });
            l.Add(new Position { name = "Architector", name_surname = "Ivan Kalnysh" });
            
        }

        private void p_delete_verf_data_click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("All data and file will be destroyed! Are u sure about that?", "Accept delete data", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                return;
            try
            {
                podc.DeleteDatabase();
                MessageBox.Show("File data base delete, open this window again for create new data base.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void p_submit_changes_click(object sender, RoutedEventArgs e)
        {
            try
            {
                podc.SubmitChanges();
                MessageBox.Show("All changes saved to database"+ Properties.Settings.Default.dblocal,"Message",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void btn_get_changes(object sender, RoutedEventArgs e)
        {
            p_ch.Header = "Changes:" + podc.GetChangeSet();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            var set = podc.GetChangeSet();
            if (set.Deletes.Count > 0 || set.Inserts.Count > 0 || set.Updates.Count > 0)
                if (MessageBox.Show("There are unsaved actions! Are u sure u want close window?", "Possible loss of action",MessageBoxButton.YesNo,MessageBoxImage.Warning) == MessageBoxResult.No)
                    e.Cancel = true;
            podc.Dispose();
        }
    }
}
