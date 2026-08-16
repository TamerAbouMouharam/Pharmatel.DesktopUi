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



        public Dashboard()
        {
            InitializeComponent();
            GetMedicines();
            btnPre.Enabled = false;
            foreach (var row in allMedicnesList.Rows)
            {
                ((DataGridViewRow)row).Height = allMedicnesList.Size.Height / AllMedicinesPageSize;
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

        private async void GetMedicines()
        {
            HttpRequestMessage message = new(HttpMethod.Get, ApiDomain.Domain + $"/medicines?page={AllMedicinesPage}");

            HttpResponseMessage response = await new HttpClient().SendAsync(message);

            MedicinesPage? medicines = await response.Content.ReadFromJsonAsync<MedicinesPage>();

            Medicines = new();
            Medicines.Columns.Add("Id");
            Medicines.Columns.Add("Name");
            Medicines.Columns.Add("Buy Price");
            Medicines.Columns.Add("Sell Price");
            Medicines.Columns.Add("Drug Composition");
            Medicines.Columns.Add("Factory");

            medicines!.Content.ForEach(m => Medicines.Rows.Add(m.Id, m.Name, m.BuyPrice, m.SellPrice, m.DrugComposition, m.Factory));

            allMedicnesList.DataSource = Medicines;

            AllMedicinesPageSize = medicines.Size;

            foreach (var row in allMedicnesList.Rows)
            {
                ((DataGridViewRow)row).Height = allMedicnesList.Size.Height / AllMedicinesPageSize;
            }
        }

        private void allMedicnesList_SizeChanged(object sender, EventArgs e)
        {
            foreach (var row in allMedicnesList.Rows)
            {
                ((DataGridViewRow)row).Height = allMedicnesList.Size.Height / AllMedicinesPageSize;
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

            if(AllMedicinesPage > 0)
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
    }
}
