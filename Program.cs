using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Security.Cryptography;

namespace Encryptor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static int xx;

        public static string Encrypt(string txt) {
            string output = "";
            using(SHA512 sha256 = SHA512.Create()) {
                var a = Encoding.UTF8.GetBytes(Environment.UserDomainName + txt + Environment.UserName);
                var d = sha256.ComputeHash(Encoding.UTF8.GetBytes(Convert.ToBase64String(a)));
                StringBuilder s = new StringBuilder();
                for(int i = 0; i < d.Length; i++) {
                    s.Append(d[i].ToString("x2"));
                }
                var e = Encoding.UTF8.GetBytes(s.ToString());
                var f = Convert.ToBase64String(e);
                var x = Encoding.UTF8.GetBytes(Environment.UserDomainName + Environment.UserName);
                xx = GetInt(x);
                Random r = new Random(xx);
                string ra = new string(f.ToCharArray().OrderBy(_s => (r.Next(2) % 2) == 0).ToArray());
                string rb = new string(f.ToCharArray().OrderBy(_s => (r.Next(2) % 2) == 0).ToArray());
                string rc = new string(f.ToCharArray().OrderBy(_s => (r.Next(2) % 2) == 0).ToArray());

                var raH = sha256.ComputeHash(Encoding.UTF8.GetBytes(ra));
                var rbH = sha256.ComputeHash(Encoding.UTF8.GetBytes(rb));
                var rcH = sha256.ComputeHash(Encoding.UTF8.GetBytes(rc));

                StringBuilder raS = new StringBuilder();
                for(int i = 0; i < raH.Length; i++) {
                    raS.Append(d[i].ToString("x2"));
                }

                StringBuilder rbS = new StringBuilder();
                for(int i = 0; i < rbH.Length; i++) {
                    rbS.Append(d[i].ToString("x2"));
                }
                StringBuilder rcS = new StringBuilder();
                for(int i = 0; i < rcH.Length; i++) {
                    rcS.Append(d[i].ToString("x2"));
                }

                var raO = Convert.ToBase64String(Encoding.UTF8.GetBytes(raS.ToString()));
                var rbO = Convert.ToBase64String(Encoding.UTF8.GetBytes(rbS.ToString()));
                var rcO = Convert.ToBase64String(Encoding.UTF8.GetBytes(rcS.ToString()));

                output = raO + rbO + rcO;
            }
            return output;
        }

        static int GetInt(byte[] b) {
            int _x = 0;
            foreach(byte by in b) {
                if(_x == 0) {
                    _x = by;
                } else {
                    _x += by;
                }
            }
            Random r = new Random(_x);
            r.Next(int.MinValue, int.MaxValue);
            return r.Next(int.MinValue, int.MaxValue);
        }
    }
}
