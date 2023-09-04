using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr4x
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        public string Number { get; private set; }
        public string Departure { get; private set; }
        public string Arrival { get; private set; }
        public string Departure_time { get; private set; }
        public string Arrival_time { get; private set; }

        private void Save_Click(object sender, EventArgs e)
        {
            Number = NumberMasked.Text;
            Departure = DepartureMasked.Text;
            Arrival = ArrivalMasked.Text;
            Departure_time = Departure_TimePicker.Text;
            Arrival_time = Arrival_TimePicker.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            Form1 data = this.Owner as Form1;
            if (data != null)
            {

                NumberMasked.Text = data.data_edit[1];
                DepartureMasked.Text = data.data_edit[2];
                ArrivalMasked.Text = data.data_edit[3];
                Departure_TimePicker.Text = data.data_edit[4];
                Arrival_TimePicker.Text = data.data_edit[5];
            }
        }
    }
}
