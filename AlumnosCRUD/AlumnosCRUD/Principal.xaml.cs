using AlumnosCRUD.Alumnos_5B;
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
using SQLite;

namespace AlumnosCRUD
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        List<Alumnos> alumnos;
        public Principal()
        {
            InitializeComponent();
            alumnos = new List<Alumnos>();
            LeerBaseDatos();
        }
        void LeerBaseDatos()
        {
            using (SQLite.SQLiteConnection conn =
                new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Alumnos>();
                alumnos = (conn.Table<Alumnos>().ToList()).
                    OrderBy(c => c.Nombre).ToList();
            }
            if (alumnos != null)
            {
                lvAlumnos.ItemsSource = alumnos;
            }
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AlumnosCRUD.MainWindow form = new AlumnosCRUD.MainWindow();
            form.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AlumnosCRUD.EliminarDatos form = new AlumnosCRUD.EliminarDatos();
            form.ShowDialog();
        }
    }
}
