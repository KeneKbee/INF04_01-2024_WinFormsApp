namespace Egzamin
{
    public partial class Passports : Form
    {
        public Passports()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            numberTextBox.Leave += changeImages;
            submitButton.Click += submitData;
        }

        private void changeImages(object sender, EventArgs e)
        {
            if (numberTextBox.Text == "000")
            {
                picturePictureBox.BackgroundImage = Image.FromFile("../../../images/000-zdjecie.jpg");
                fingerprintPictureBox.BackgroundImage = Image.FromFile("../../../images/000-odcisk.jpg");
            }
            else if (numberTextBox.Text == "111")
            {
                picturePictureBox.BackgroundImage = Image.FromFile("../../../images/111-zdjecie.jpg");
                fingerprintPictureBox.BackgroundImage = Image.FromFile("../../../images/111-odcisk.jpg");
            }
            else if(numberTextBox.Text == "333")
            {
                picturePictureBox.BackgroundImage = Image.FromFile("../../../images/333-zdjecie.jpg");
                fingerprintPictureBox.BackgroundImage = Image.FromFile("../../../images/333-odcisk.jpg");
            }
            else
            {
                picturePictureBox.BackgroundImage = null;
                fingerprintPictureBox.BackgroundImage = null;
            }
        }

        private void submitData(object sender, EventArgs e)
        {
            if(numberTextBox.Text != "" && nameTextBox.Text != "" && surnameTextBox.Text != "" && (blueEyesRadio.Checked || greenEyesRadio.Checked || beerEyesRadio.Checked))
            {
                string eyeColor = blueEyesRadio.Checked ? "niebieskie" : greenEyesRadio.Checked ? "zielone" : beerEyesRadio.Checked ? "piwne" : "";
                MessageBox.Show($"{nameTextBox.Text} {surnameTextBox.Text} kolor oczu {eyeColor}");
            }
            else
            {
                MessageBox.Show("Wprowadü dane");
            }
        }
    }
}
