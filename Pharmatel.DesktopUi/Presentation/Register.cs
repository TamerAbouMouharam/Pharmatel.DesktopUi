using Pharmatel.DesktopUi.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Pharmatel.DesktopUi.Presentation
{
    public partial class Register : Form
    {
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

            RegisterRequest request = new(txtUsername.Text, txtPassword.Text, "PHARMACY", txtEmail.Text, txtPhone.Text, txtPharmacy.Text, txtPharmacist.Text, 0, 0);

            HttpRequestMessage message = new(HttpMethod.Post, ApiDomain.Domain + "/auth/register");

            message.Content = JsonContent.Create(request);

            HttpResponseMessage response = await new HttpClient().SendAsync(message);

            if(response.StatusCode != HttpStatusCode.Created)
            {
                MessageBox.Show("تحقق من البيانات المدخلة و ادخل اسم مستخدم فريد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AuthResponse? authResponse = await response.Content.ReadFromJsonAsync<AuthResponse>();

            SessionInfo.AuthInfo = authResponse;

            new Dashboard().Show();
            this.Close();
        }
    }
}
