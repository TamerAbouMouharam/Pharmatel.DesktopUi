using Pharmatel.DesktopUi.Dto;
using System.Net;
using System.Net.Http.Json;

namespace Pharmatel.DesktopUi.Presentation
{
    public partial class Register : Form
    {
        double lat, lng;

        public void SetLatLng(double lat, double lng)
        {
            this.lat = lat;
            this.lng = lng;
        }

        public Register()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("الرجاء تأكيد كلمة المرور بشكل صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RegisterRequest request = new(txtUsername.Text, txtPassword.Text, "PHARMACY", txtEmail.Text, txtPhone.Text, txtPharmacy.Text, txtPharmacist.Text, lat, lng);

            HttpRequestMessage message = new(HttpMethod.Post, ApiDomain.Domain + "/auth/register");

            message.Content = JsonContent.Create(request);

            HttpResponseMessage response = await new HttpClient().SendAsync(message);

            if (response.StatusCode != HttpStatusCode.Created)
            {
                MessageBox.Show("تحقق من البيانات المدخلة و ادخل اسم مستخدم فريد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AuthResponse? authResponse = await response.Content.ReadFromJsonAsync<AuthResponse>();

            SessionInfo.AuthInfo = authResponse;

            new Dashboard().Show();
            this.Close();
        }

        private void btnGeo_Click(object sender, EventArgs e)
        {
            new MapForm(this, null).Show();
        }
    }
}

