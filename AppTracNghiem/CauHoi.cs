using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTracNghiem
{
    class CauHoi
    {
        public int STT { get; set; }
        public string CauHoiText { get; set; }
        public string DapAnA { get; set; }
        public string DapAnB { get; set; }
        public string DapAnC { get; set; }
        public string DapAnD { get; set; }
        public string DapAnDung { get; set; }
        public string DapAnChon { get; set;}

        public CauHoi() { }
        public CauHoi(int stt, string ch, string a, string b, string c, string d, string da)
        {
            this.STT = stt;
            this.CauHoiText = ch;
            this.DapAnA = a;
            this.DapAnB = b;
            this.DapAnC = c;
            this.DapAnD = d;
            this.DapAnDung = da;
        }

    }
}
