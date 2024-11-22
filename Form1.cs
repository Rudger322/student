namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private Controller controller;

        public Form1()
        {
            InitializeComponent();
            controller = new Controller();

            cmbCitizenship.Items.AddRange(new string[]
            {
                 "Азербайджан", "Таджикистан", "Узбекистан", "Молдова", "Украина", "Киргизия", "Казахстан", "Армения","Другая"
            });
            cmbPurpose.Items.AddRange(Enum.GetNames(typeof(Purpose)));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cmbCitizenship.SelectedItem == null)
            {
                MessageBox.Show("Заполните поле 'Гражданство'.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPurpose.SelectedItem == null)
            {
                MessageBox.Show("Заполните поле 'Цель поездки'.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string citizenship = cmbCitizenship.SelectedItem.ToString();
            Purpose purpose = (Purpose)Enum.Parse(typeof(Purpose), cmbPurpose.SelectedItem.ToString());
            DateTime dateOfEntry = dtpDateOfEntry.Value;
            string policy = chkPolicy.Checked ? "Да" : "Нет";

            User user = new User(citizenship, purpose, dateOfEntry, policy)
            {
                IsLongStay = chkLongStay.Checked
            };
            controller.RegisterUser(user);

            MessageBox.Show("Пользователь зарегистрирован!\nТеперь Вы можете посмотреть дорожную карту!");
        }


        private void btnViewRoadmap_Click(object sender, EventArgs e)
        {
            string roadmap = controller.GetRoadMap();
            MessageBox.Show(roadmap);
        }

        private void chkPolicy_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void chkLongStay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GenerateRoadMapButton_Click(object sender, EventArgs e)
        {
            // проверка на выбор гражданства МОЖНО УДАЛИТЬ!! И НИЖЕ ВСЁ
            if (cmbCitizenship.SelectedItem == null)
            {
                //MessageBox.Show("Пожалуйста, выберите гражданство.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // проверка на выбор причины
           if (cmbPurpose.SelectedItem == null)
            {
                //MessageBox.Show("Пожалуйста, выберите причину прибытия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

             //генерация дорожной карты
            string roadMap = controller.GetRoadMap();
            MessageBox.Show(roadMap, "Дорожная карта", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
