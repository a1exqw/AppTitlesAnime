namespace AppTitlesAnime
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnShowTypes_Click(object sender, EventArgs e)
        {
            FormListTypes formListTypes = new FormListTypes();
            formListTypes.Show();
        }
        private void btnShowStatuses_Click(object sender, EventArgs e)
        {
            FormListStatuses formListStatuses = new FormListStatuses();
            formListStatuses.Show();
        }

        private void btnShowGenres_Click(object sender, EventArgs e)
        {
            FormListGenres formListGenres = new FormListGenres();
            formListGenres.Show();
        }
    }
}
