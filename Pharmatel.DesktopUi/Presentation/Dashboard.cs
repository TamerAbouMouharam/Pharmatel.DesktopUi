using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;
using Pharmatel.DesktopUi.Dto;

namespace Pharmatel.DesktopUi.Presentation
{
    public partial class Dashboard : Form
    {
        private DataTable Medicines { get; set; } = new DataTable();
        private int AllMedicinesPage { get; set; } = 0;
        private int AllMedicinesPageSize { get; set; } = 0;
        private bool IsLastPageAllMedicines { get; set; } = false;
        private string AllMedicinesName { get; set; } = string.Empty;

        private int PharmacyMedicinesPage { get; set; } = 0;
        private int PharmacyMedicinesPageSize { get; set; } = 0;
        private bool IsLastPagePharmacyMedicines { get; set; } = false;
        private string PharmacyMedicinesName { get; set; } = string.Empty;

        public Dashboard()
        {
            InitializeComponent();

            GetMedicines();
            GetPharmacyMedicines();

            btnPre.Enabled = false;
            btnPrePharm.Enabled = false;

            foreach (var row in allMedicinesList.Rows)
            {
                ((DataGridViewRow)row).Height = allMedicinesList.Size.Height / AllMedicinesPageSize;
            }

            foreach (var row in medicineList.Rows)
            {
                ((DataGridViewRow)row).Height = medicineList.Size.Height / PharmacyMedicinesPageSize;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            HttpRequestMessage request = new(HttpMethod.Get, ApiDomain.Domain + $"/pharmacies/{SessionInfo.AuthInfo!.PharmacyId}");

            HttpResponseMessage response = await new HttpClient().SendAsync(request);

            Pharmacy? pharmacy = await response.Content.ReadFromJsonAsync<Pharmacy>();

            this.lblPharmacy.Text = pharmacy!.Name;
        }

        public async void GetMedicines()
        {
            btnPre.Enabled = true;
            btnNext.Enabled = true;

            HttpRequestMessage message = new(HttpMethod.Get, ApiDomain.Domain + $"/medicines?page={AllMedicinesPage}&name={AllMedicinesName}");

            HttpResponseMessage response = await new HttpClient().SendAsync(message);

            MedicinesPage? medicines = await response.Content.ReadFromJsonAsync<MedicinesPage>();

            Medicines = new();
            Medicines.Columns.Add("المعرف");
            Medicines.Columns.Add("الاسم");
            Medicines.Columns.Add("سعر الشراء");
            Medicines.Columns.Add("سعر البيع");
            Medicines.Columns.Add("التركيبة الدوائية");
            Medicines.Columns.Add("المصنع");

            medicines!.Content.ForEach(m => Medicines.Rows.Add(m.Id, m.Name, m.BuyPrice, m.SellPrice, m.DrugComposition, m.Factory));

            allMedicinesList.DataSource = Medicines;

            AllMedicinesPageSize = medicines.Size;

            IsLastPageAllMedicines = medicines.Last;

            if (IsLastPageAllMedicines)
            {
                btnNext.Enabled = false;
            }

            AllMedicinesPage = medicines.Page;

            if (AllMedicinesPage == 0)
            {
                btnPre.Enabled = false;
            }

            foreach (var row in allMedicinesList.Rows)
            {
                ((DataGridViewRow)row).Height = allMedicinesList.Size.Height / AllMedicinesPageSize;
            }
        }

        private void allMedicnesList_SizeChanged(object sender, EventArgs e)
        {
            foreach (var row in allMedicinesList.Rows)
            {
                ((DataGridViewRow)row).Height = allMedicinesList.Size.Height / AllMedicinesPageSize;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!IsLastPageAllMedicines)
            {
                AllMedicinesPage++;
            }

            GetMedicines();

            btnPre.Enabled = true;

            if (IsLastPageAllMedicines)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {

            if (AllMedicinesPage > 0)
            {
                AllMedicinesPage--;
            }

            GetMedicines();

            btnNext.Enabled = true;

            if (AllMedicinesPage == 0)
            {
                btnPre.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AllMedicinesName = txtSearch.Text;

            GetMedicines();
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            AllMedicinesName = string.Empty;

            GetMedicines();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            new MedcineInfo(Convert.ToInt32(allMedicinesList.SelectedRows[0].Cells["المعرف"].Value), this).Show();
        }

        public async void GetPharmacyMedicines()
        {
            btnPrePharm.Enabled = true;
            btnNextPharm.Enabled = true;


            HttpRequestMessage message = new(HttpMethod.Get, ApiDomain.Domain + $"/pharmacies/{SessionInfo.AuthInfo!.PharmacyId}/medicines?page={PharmacyMedicinesPage}&name={PharmacyMedicinesName}");

            HttpResponseMessage response = await new HttpClient().SendAsync(message);

            PharmacyMedicinesPage? medicines = await response.Content.ReadFromJsonAsync<PharmacyMedicinesPage>();

            Medicines = new();
            Medicines.Columns.Add("المعرف");
            Medicines.Columns.Add("المعرف العام");
            Medicines.Columns.Add("الاسم");
            Medicines.Columns.Add("الكمية");

            medicines!.Content.ForEach(m => Medicines.Rows.Add(m.PharmacyMedicineId, m.MedicineId, m.MedicineName, m.Quantity));

            medicineList.DataSource = Medicines;

            PharmacyMedicinesPageSize = medicines.Size;

            IsLastPagePharmacyMedicines = medicines.Last;

            if (IsLastPagePharmacyMedicines)
            {
                btnNextPharm.Enabled = false;
            }

            PharmacyMedicinesPage = medicines.Page;

            if (PharmacyMedicinesPage == 0)
            {
                btnPrePharm.Enabled = false;
            }

            foreach (var row in medicineList.Rows)
            {
                ((DataGridViewRow)row).Height = medicineList.Size.Height / PharmacyMedicinesPageSize;
            }
        }

        private void btnShowPharm_Click(object sender, EventArgs e)
        {
            new MedcineInfo(Convert.ToInt32(medicineList.SelectedRows[0].Cells["المعرف العام"].Value), this).Show();
        }

        private void btnNextPharm_Click(object sender, EventArgs e)
        {
            if (!IsLastPagePharmacyMedicines)
            {
                PharmacyMedicinesPage++;
            }

            GetPharmacyMedicines();

            btnPrePharm.Enabled = true;

            if (IsLastPagePharmacyMedicines)
            {
                btnNextPharm.Enabled = false;
            }
        }

        private void btnPrePharm_Click(object sender, EventArgs e)
        {
            if (PharmacyMedicinesPage > 0)
            {
                PharmacyMedicinesPage--;
            }

            GetPharmacyMedicines();

            btnNextPharm.Enabled = true;

            if (PharmacyMedicinesPage == 0)
            {
                btnPrePharm.Enabled = false;
            }
        }

        private void medicineList_SizeChanged(object sender, EventArgs e)
        {
            foreach (var row in medicineList.Rows)
            {
                ((DataGridViewRow)row).Height = medicineList.Size.Height / PharmacyMedicinesPageSize;
            }
        }

        private void btnSearchPharm_Click(object sender, EventArgs e)
        {
            PharmacyMedicinesName = txtSearchPharm.Text;

            GetPharmacyMedicines();
        }

        private void btnCancelSearchPharm_Click(object sender, EventArgs e)
        {
            PharmacyMedicinesName = string.Empty;

            GetPharmacyMedicines();
        }
    }
}
