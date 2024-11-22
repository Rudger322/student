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
                 "�����������", "�����������", "����������", "�������", "�������", "��������", "���������", "�������","������"
            });
            cmbPurpose.Items.AddRange(Enum.GetNames(typeof(Purpose)));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cmbCitizenship.SelectedItem == null)
            {
                MessageBox.Show("��������� ���� '�����������'.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPurpose.SelectedItem == null)
            {
                MessageBox.Show("��������� ���� '���� �������'.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string citizenship = cmbCitizenship.SelectedItem.ToString();
            Purpose purpose = (Purpose)Enum.Parse(typeof(Purpose), cmbPurpose.SelectedItem.ToString());
            DateTime dateOfEntry = dtpDateOfEntry.Value;
            string policy = chkPolicy.Checked ? "��" : "���";

            User user = new User(citizenship, purpose, dateOfEntry, policy)
            {
                IsLongStay = chkLongStay.Checked
            };
            controller.RegisterUser(user);

            MessageBox.Show("������������ ���������������!\n������ �� ������ ���������� �������� �����!");
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
            // �������� �� ����� ����������� ����� �������!! � ���� �Ѩ
            if (cmbCitizenship.SelectedItem == null)
            {
                //MessageBox.Show("����������, �������� �����������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // �������� �� ����� �������
           if (cmbPurpose.SelectedItem == null)
            {
                //MessageBox.Show("����������, �������� ������� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

             //��������� �������� �����
            string roadMap = controller.GetRoadMap();
            MessageBox.Show(roadMap, "�������� �����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
