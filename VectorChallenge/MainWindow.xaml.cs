using System.Windows;
using System.Windows.Input;
using VectorChallenge;
using System.Text.RegularExpressions;

namespace VectorGUI
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

        
        /// <summary>
        /// This is the Backbone for Usererror avoidance for UI - only accept Numbers and minus char
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            //Eingabe von Text in Input verbieten. Achtung Eingabe von negativen Werten muss moeglich sein. Minus in RegEx beruecksichtigen.
            Regex regex = new Regex("[^0-9-]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// This will be executed by pressing btnCalcCrossProduct on UI.
        /// It calculates the Crossproduct of the two given vectors.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcCrossProduct_Click(object sender, RoutedEventArgs e)
        {
            //Pruefen, ob User einfach nichts eingegeben hat.
            if (txtBoxVector1X.Text != "" && txtBoxVector1Y.Text != "" && txtBoxVector1Z.Text != "" && txtBoxVector2X.Text != "" && txtBoxVector2Y.Text != "" && txtBoxVector2Z.Text != "")
            {
                //Vektoren erstellen aus GUIinputs
                VectorChallenge.Vector VectorA = new VectorChallenge.Vector(double.Parse(txtBoxVector1X.Text), double.Parse(txtBoxVector1Y.Text), double.Parse(txtBoxVector1Z.Text));
                VectorChallenge.Vector VectorB = new VectorChallenge.Vector(double.Parse(txtBoxVector2X.Text), double.Parse(txtBoxVector2Y.Text), double.Parse(txtBoxVector2Z.Text));

                //Neuen Vektor erstellen aus Kreuzprodukt
                VectorChallenge.Vector CrossProdVector = VectorComplexMath.CrossProductVector(VectorA, VectorB);

                //Daten in GUI eintragen
                txtBoxVector3X.Text = CrossProdVector.VectorX.ToString();
                txtBoxVector3Y.Text = CrossProdVector.VectorY.ToString();
                txtBoxVector3Z.Text = CrossProdVector.VectorZ.ToString();
            }
            else
            {
                MessageBox.Show("Eingabe fehlerhaft! - Bitte Eingaben korregieren.");
            }

        }

        /// <summary>
        /// This closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult DialogResult= MessageBox.Show("Wollen Sie die Anwendung wirklich beenden ?", "VectorChallenge", MessageBoxButton.YesNo);
            
            if (DialogResult == MessageBoxResult.Yes)
            {
                Close();
            }
        }
    }
}
