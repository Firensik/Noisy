using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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

namespace Noisy
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void CBA(object sender, RoutedEventArgs e)
        {
            string ConnectionString = "Server=DESKTOP-OGQBS2U;Database=E_muzykaEF;Trusted_Connection=True";

            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlDataAdapter da;
            DataSet ds;
          
            da = new SqlDataAdapter("Select * from Albums",connection);
            ds = new DataSet();
            da.Fill(ds);
            dtGrid.ItemsSource = ds.Tables[0].DefaultView;

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            /*SqlConnection con = new SqlConnection("Server = DESKTOP - OGQBS2U; Database = E_muzykaEF; Trusted_Connection = True");
            SqlDataAdapter data = new SqlDataAdapter("Select * from Songs" + Search.Text + "desc", con);
            DataTable dt = new DataTable();
            data.Fill(dt);*/
  
        }

        private void dtGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender; 
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null) 
            {
               
            }
        }
    }
}
