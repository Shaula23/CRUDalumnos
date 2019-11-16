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
using AlumnosCRUD.Alumnos_5B;
using SQLite;

namespace AlumnosCRUD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Alumnos alumnos = new Alumnos()
            {
                Nombre = tBoxNombre.Text,
                Area = tBoxArea.Text,
                Edad = tBoxEdad.Text,
                Sexo = tBoxSexo.Text
            };
            using (SQLiteConnection conexion = new SQLiteConnection(App.databasePath))
            {
                conexion.CreateTable<Alumnos>();
                conexion.Insert(alumnos);
            }
            Close();
        }
    }
}
