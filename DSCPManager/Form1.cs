using System.Security.Cryptography;

namespace DSCPManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = QosOps.qosPoliciesNameList;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QosOps.UpdateQosPolicy(textBox8.Text, "AppPathNameMatchCondition", textBox7.Text);
            QosOps.UpdateQosPolicy(textBox8.Text, "DSCPAction", textBox5.Text);
            RefreshList();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null)
            {
                var policy = QosOps.qosPoliciesList.First(x => x.PolicyName == comboBox2.SelectedValue);
                textBox8.Text = policy.PolicyName;
                textBox7.Text = policy.AppPathName;
                textBox5.Text = policy.DSCPValue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QosPolicy newPolicy = new QosPolicy(textBox1.Text, textBox2.Text, textBox3.Text);
            QosOps.CreateQosPolicy(newPolicy);
            RefreshList();
        }
        private void RefreshList()
        {
            QosOps.ReadQosPolicy();
            comboBox2.DataSource = null;
            comboBox2.DataSource = QosOps.qosPoliciesNameList;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QosOps.DeleteQosPolicy(textBox8.Text);
            RefreshList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择一个目录作为路径：";
            dialog.ShowNewFolderButton = true;
            dialog.RootFolder = Environment.SpecialFolder.ApplicationData;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedPath = dialog.SelectedPath;
                string[] files = Directory.GetFiles(selectedPath, "*.exe", SearchOption.AllDirectories);
                HashSet<string> list = [.. files];
                richTextBox1.Text = "";
                foreach (string file in list)
                {
                    int lastBackslashIndex = file.LastIndexOf('\\');
                    string fileName = file.Substring(lastBackslashIndex + 1);
                    richTextBox1.Text += fileName;
                    richTextBox1.Text += "\n";
                }
            }

        }

        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] data = new byte[length];
                rng.GetBytes(data);
                return new string(data.Select(b => chars[b % chars.Length]).ToArray());
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            var files = richTextBox1.Text.Split("\n");
            foreach (string file in files)
            {
                if (file == "")
                {
                    continue;
                }
                QosPolicy newPolicy = new QosPolicy(textBox6.Text + GenerateRandomString(8), file, textBox4.Text);
                QosOps.CreateQosPolicy(newPolicy);
            }
            RefreshList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QosOps.ReadQosPolicy();
            foreach (var i in QosOps.qosPoliciesNameList)
            {
                if (i.StartsWith(textBox10.Text))
                {
                    QosOps.DeleteQosPolicy(i);
                }
            }
            RefreshList();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            QosOps.ReadQosPolicy();
            foreach (var i in QosOps.qosPoliciesNameList)
            {
                if (i.StartsWith(textBox10.Text))
                {
                    QosOps.UpdateQosPolicy(i, "DSCPAction", textBox11.Text);
                }
            }
            RefreshList();
        }
    }
}
