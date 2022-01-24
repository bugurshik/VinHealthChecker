using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using VinHealthChecker.Models;

namespace VinHealthChecker
{
    public partial class Form1 : Form
    {
        private VinWrapper wrapper;
        private Config Config;
        private EtkaApiProvider ApiProvider;

        public Form1()
        {
            InitializeComponent();
            try
            {
                using StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Test.txt");
                Config = JsonConvert.DeserializeObject<Config>(Encrypt.DecryptString(sr.ReadToEnd(), "jojo"));
                ApiProvider = new EtkaApiProvider(Config);
            }
            catch
            {
                Config = new Config();
            }

            UpdatePages();
        }

        private void FindVinBtn_buttonClick(object sender, EventArgs e)
        {
            SendRequestToApi();
        }

        private void vinInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendRequestToApi();
            }
        }

        private void SendRequestToApi()
        {
            wrapper = ApiProvider.TryGetVins(vinInput.Text);
            if (wrapper != null)
            {
                DrawVinResult();
            }
        }

        private void DrawVinResult()
        {
            labelResult.Text = $@"Результат поиска по vin: {vinInput.Text}";
            UpdatePages();
        }

        private void UpdatePages()
        {
            EtkPageChangeStatus(enable: wrapper?.ETKAVin != null);
            PetPageChangeStatus(enable: wrapper?.PetVin != null);
            WrongPageChangeStatus(enable: wrapper?.WrongVin != null);
        }

        private void EtkPageChangeStatus(bool enable)
        {
            etkPage.Text = enable ? "ETKA" : "ETKA (пусто)";
            etkVinDataOutput.Text = enable ? $"Дата: {wrapper.ETKAVin.Date}\n\n{wrapper.ETKAVin.VinData}" : string.Empty;
            DeleteEtkVinBtn.Enabled = enable;
        }

        private void PetPageChangeStatus(bool enable)
        {
            petPage.Text = enable ? "PET" : "PET (пусто)";
            petVinDataOutput.Text = enable ? $"Дата: {wrapper.PetVin.Date}\n\n{wrapper.PetVin.VinData}" : string.Empty;
            DeletePetVinBtn.Enabled = enable;
        }

        private void WrongPageChangeStatus(bool enable)
        {
            wrongPage.Text = enable ? "Wrong" : "Wrong (пусто)";
            wrongVinDataOutput.Text = enable ? $"Дата: {wrapper.WrongVin.Date}\n\n{ wrapper.WrongVin.VinData}" : string.Empty;
            DeleteWrongVinBtn.Enabled = enable;
        }

        private void DeleteEtkVinBtn_buttonClick(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверенны что хотите удалить vin из базы ETK?");
            if (confirmResult == DialogResult.OK)
            {
                if (wrapper.ETKAVin == null)
                    return;

                var success = ApiProvider.TryDeleteVin(wrapper.ETKAVin.Id, "etka");
                if (success)
                    EtkPageChangeStatus(enable: false);

                wrapper.ETKAVin = null;
            }
        }
        private void DeletePetVinBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверенны что хотите удалить vin из базы Pet?");
            if (confirmResult == DialogResult.OK)
            {
                if (wrapper.PetVin == null)
                    return;

                var success = ApiProvider.TryDeleteVin(wrapper.PetVin.Id, "pet");
                if (success)
                    PetPageChangeStatus(enable: false);

                wrapper.PetVin = null;
            }
        }
        private void DeleteWrongVinBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверенны что хотите удалить vin из базы Wrong?");
            if (confirmResult == DialogResult.OK)
            {
                if (wrapper.WrongVin == null)
                    return;

                var success = ApiProvider.TryDeleteVin(wrapper.WrongVin.Id, "wrong");
                if (success)
                    WrongPageChangeStatus(enable: false);

                wrapper.WrongVin = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox();
            inputBox.ipAdress.Text = Config.IpAdress;
            inputBox.login.Text = Config.Login;
            inputBox.password.PlaceholderText = "*******";

            if (inputBox.ShowDialog(this) == DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(inputBox.ipAdress.Text))
                    Config.IpAdress = inputBox.ipAdress.Text;

                if (!string.IsNullOrWhiteSpace(inputBox.login.Text))
                    Config.Login = inputBox.login.Text;

                if (!string.IsNullOrWhiteSpace(inputBox.password.Text))
                    Config.Password = inputBox.password.Text;

                using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Test.txt"))
                {
                    sw.WriteLine(Encrypt.EncryptString(JsonConvert.SerializeObject(Config), "jojo"));
                }

                inputBox.Dispose();
                return;
            }
        }
    }
}
