using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmatel.DesktopUi.Dto
{
    internal record PharmacyMedicine
    (
        int PharmacyMedicineId,
        int MedicineId,
        string MedicineName,
        int Quantity
    );
}
