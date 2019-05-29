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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Transformacoes.CG.Uni7.VF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var x = !string.IsNullOrEmpty(eixo_x.Text) ? Convert.ToDouble(eixo_x.Text) : 0;
            var y = !string.IsNullOrEmpty(eixo_y.Text) ? Convert.ToDouble(eixo_y.Text) : 0;
            var z = !string.IsNullOrEmpty(eixo_z.Text) ? Convert.ToDouble(eixo_z.Text) : 0;
            var a = !string.IsNullOrEmpty(angulo.Text) ? Convert.ToDouble(angulo.Text) : 0;

            if (rotacao.IsChecked.Equals(true))
            {
                Cube.Transform = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(x, y, z), a));
            }

            else if (translacao.IsChecked.Equals(true))
            {
                Cube.Transform = new TranslateTransform3D
                {
                    OffsetX = x,
                    OffsetY = y,
                    OffsetZ = z
                };
            }

            else if (escala.IsChecked.Equals(true))
            {
                Cube.Transform = new ScaleTransform3D
                {
                    ScaleX = x,
                    ScaleY = y,
                    ScaleZ = z
                };
            }

            else
                MessageBox.Show("Nenhuma transformação foi escolhida. Favor, checar.");
        }

        private void RecriarCubo(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnLastWindowClose;
            new MainWindow().Show();
            this.Close();
        }
    }
}
