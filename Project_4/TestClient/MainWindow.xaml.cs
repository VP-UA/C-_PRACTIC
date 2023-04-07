using System;
using System.Collections.Generic;
using System.Dynamic;
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

namespace TestClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //gt - group tourist
        //gr - group
        //tri - tourist rich
        //tst - tourist standart
        //cth - contract tour havai
        //ctj - contract tour japan
        //ctg - contract tour germany
        //cta - contract tour africa
        //ctb - contract tour bali
        //n - name
        //contr - contract
        //sm - spivrobitnyk manager
        //sa - spivrobitnyk administrator
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dynamic data = new ExpandoObject();
            var wc = new dynamic[9];
            var gt = new dynamic[13];
            for (int i = 0; i < 9; i++)
            {
                dynamic sm = new ExpandoObject(); sm.n = "Spivrobitnyk" + " " +(i * (2 - 1)+ " " + "Class A");
                dynamic sa = new ExpandoObject(); sa.n = "Spivrobitnyk" + " " + (i * (2 - 2)+ " " + "Class B");

                dynamic gr = new ExpandoObject(); gr.n = "Group" + " " + (i * 1) ;
                gr.contr = new dynamic[] { sm, sa };
                wc[i] = gr;
            }
            dynamic ctwm = new ExpandoObject(); ctwm.n = "Contract to work manager"; ctwm.contr = new dynamic[] {wc[1],wc[2] };
            dynamic ctwa = new ExpandoObject(); ctwa.n = "Contract to work administrator"; ctwa.contr = new dynamic[] { wc[3], wc[4] };
            dynamic ctwsa = new ExpandoObject(); ctwsa.n = "Contract to work system administrator"; ctwsa.contr = new dynamic[] { wc[5], wc[6] };
            dynamic ctw = new ExpandoObject(); ctwsa.n = "Contract to work system administrator"; ctwsa.contr = new dynamic[] { wc[7], wc[8] };


            dynamic br = new ExpandoObject(); br.n = "Not full day work"; br.contr = new dynamic[] { ctwm, ctwa, ctwsa };
            dynamic or = new ExpandoObject(); or.n = "Full day work"; or.contr = new dynamic[] { ctwm, ctwa,ctwsa };
            var cs_av = new dynamic[] { br,or};
            data.project_spivrobitnyky = cs_av; 

           
            for (int i = 0; i < 13; i++)
            {
                dynamic tri = new ExpandoObject(); tri.n = "Tourtist" + " " + (i * 2 - 1)+" " ;
                dynamic tst = new ExpandoObject(); tst.n= "Tourtist" + " " + (i * 2 - 2) + " ";

                //dynamic sm = new ExpandoObject(); sm.n = "Spivrobitnyk" + (i * (2 - 1));
                //dynamic sa = new ExpandoObject(); sa.n = "Spivrobitnyk" + (i * (2 - 2));


                dynamic go = new ExpandoObject(); go.n = "Group" + i;
                go.contr = new dynamic[] {tri,tst};
                gt[i] = go;
            }

            dynamic cth = new ExpandoObject(); cth.n = "Contract Tour Havai";cth.contr = new dynamic[] { gt[1], gt[2] };
            dynamic ctj = new ExpandoObject(); ctj.n = "Contract Tour Japan";ctj.contr = new dynamic[] { gt[3], gt[4] };
            dynamic ctg = new ExpandoObject();ctg.n = "Contract Tour Germany"; ctg.contr = new dynamic[] { gt[5], gt[6] };
            dynamic cta = new ExpandoObject();cta.n = "Contract Tour Africa";cta.contr = new dynamic[] { gt[7], gt[8] };
            dynamic ctb = new ExpandoObject();ctb.n = "Contract Tour Bali";ctb.contr = new dynamic[] { gt[9], gt[10] };
            dynamic ctk = new ExpandoObject(); ctk.n = "Contract Tour Korea"; ctk.contr = new dynamic[] { gt[11], gt[12] };

           


            dynamic pr = new ExpandoObject(); pr.n = "Premium"; pr.contr = new dynamic[] { cth,ctj,ctg,cta,ctb,ctk };  
            dynamic st = new ExpandoObject(); st.n = "Standart"; st.contr = new dynamic[] { cth, ctj, ctg, cta, ctb, ctk };
            dynamic ec = new ExpandoObject(); ec.n = "Economical"; ec.contr = new dynamic[] { cth, ctj, ctg, cta, ctb, ctk };
            var ct_av = new dynamic[] {pr,st,ec};

 
            data.project_tyristi = ct_av;
            
           // project_spivrobitnyky

            DataContext = data;
        }


        private void TreeView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var obj = (sender as TreeView).SelectedItem as ExpandoObject;
            if (obj == null) return;
            if(obj.Where(x => x.Key == "contr").Count() == 0)
                new Dovidnik_Turisti(obj).Show();
                
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var tag = ((FrameworkElement)sender).Tag;
            if ((tag as string)==null) return;
            var cls = tag + "";
            var type = Type.GetType("TestClient."+cls);
            if (type == null) return;
            var window = Activator.CreateInstance(type) as Window;
            window.ShowDialog();
            
        }

    }
}
