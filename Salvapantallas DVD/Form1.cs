namespace Salvapantallas_DVD
{
    public partial class Form1 : Form
    {
        Obrero _obrero;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _obrero.Avanzar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obrero = new Obrero(uc_dvd_icon, this, new Point(4, 4));

            _obrero.EsquinaTocada += Sorpresa;
        }

        private bool _sorpresa = false;

        private void Sorpresa (Object? sender, EventArgs a)
        {
            _sorpresa = !_sorpresa;
            if (_sorpresa)
            {
                this.BackgroundImage = Properties.Resources.gatete01;
                nyancat.PlaySorpresa();
            }
            else
            {
                this.BackgroundImage = null;
                nyancat.StopPlaySorpresa();
            }

        }
    }
}