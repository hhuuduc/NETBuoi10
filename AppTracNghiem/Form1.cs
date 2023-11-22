using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppTracNghiem
{
    public partial class Form1 : Form
    {
        public string conStr = "Data Source=A209PC39;Initial Catalog=TN;Integrated Security=True";

        List<CauHoi> dsch = new List<CauHoi>();
        public int sch = 0;

        public Form1()
        {
            SqlConnection conn = new SqlConnection(conStr);
            string sql = "select * from CAUHOIS";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                int STT = Convert.ToInt32(rdr.GetValue(0).ToString());
                string CauHoiText = rdr.GetValue(1).ToString();
                string DapAnA = rdr.GetValue(2).ToString();
                string DapAnB = rdr.GetValue(3).ToString();
                string DapAnC = rdr.GetValue(4).ToString();
                string DapAnD = rdr.GetValue(5).ToString();
                string DapAnDung = rdr.GetValue(6).ToString();
                dsch.Add(new CauHoi(STT, CauHoiText, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung));
            }
           
            InitializeComponent();
            ShowCauHoi();

        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (sch >= 1)
            {
                sch--;
            }

            if (sch < dsch.Count)
            {
                ShowCauHoi();
            }
        }

        public void ShowCauHoi()
        {
            CauHoi ch = dsch[sch];
            lb_CauHoi.Text = ch.CauHoiText;
            rdbt_A.Text = ch.DapAnA;
            rdbt_B.Text = ch.DapAnB;
            rdbt_C.Text = ch.DapAnC;
            rdbt_D.Text = ch.DapAnD;
            if (String.Compare(ch.DapAnChon, "A") == 0)
                rdbt_A.Checked = true;
            else if (String.Compare(ch.DapAnChon, "B") == 0)
                rdbt_B.Checked = true;
            else if (String.Compare(ch.DapAnChon, "C") == 0)
                rdbt_C.Checked = true;
            else if (String.Compare(ch.DapAnChon, "D") == 0)
                rdbt_D.Checked = true;
            else
            {
                rdbt_A.Checked = false;
                rdbt_B.Checked = false;
                rdbt_C.Checked = false;
                rdbt_D.Checked = false;
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (sch != dsch.Count - 1)
                sch++;

            if (sch < dsch.Count)
            {
                ShowCauHoi();
            }
        }

        private void rdbt_A_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbt_A.Checked == true)
            {
                CauHoi ch = dsch[sch];
                ch.DapAnChon = "A";
            }
        }

        private void rdbt_B_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbt_B.Checked == true)
            {
                CauHoi ch = dsch[sch];
                ch.DapAnChon = "B";
            }
        }

        private void rdbt_C_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbt_C.Checked == true)
            {
                CauHoi ch = dsch[sch];
                ch.DapAnChon = "C";
            }
        }

        private void rdbt_D_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbt_D.Checked == true)
            {
                CauHoi ch = dsch[sch];
                ch.DapAnChon = "D";
            }
        }

        private void btn_Nop_Click(object sender, EventArgs e)
        {
            int soCauDung = 0;
            for(int i = 0; i < dsch.Count; i++)
            {
                
                CauHoi ch = dsch[i];
                if (String.Compare(ch.DapAnChon, ch.DapAnDung, true) == 0)
                    soCauDung++;
            }
            string text = "Đúng " + soCauDung + "/" + dsch.Count;
            MessageBox.Show(text);
        }
    }
}
