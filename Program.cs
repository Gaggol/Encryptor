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
            Application.Run(new Encryptor());
        }

        static int xx;

        public static string Encrypt(string txt, bool muteErrors) {
            string output = "";
            string errorList = "";
            using(SHA512 sha256 = SHA512.Create()) {
                byte[] a;
                try {
                    a = Encoding.UTF8.GetBytes(Environment.UserDomainName + txt + Environment.UserName);
                }
                catch(Exception ex) {
                    if(ex is PlatformNotSupportedException || ex is InvalidOperationException) {
                        a = Encoding.UTF8.GetBytes(txt + Environment.UserName);
                        errorList += "Your platform does not support Environment.UserDomainNames, skipping!" + Environment.NewLine;
                    } else {
                        throw;
                    }
                }
                byte[] d = sha256.ComputeHash(Encoding.UTF8.GetBytes(Convert.ToBase64String(a)));
                StringBuilder s = new StringBuilder();
                for(int i = 0; i < d.Length; i++) {
                    s.Append(d[i].ToString("x2"));
                }
                byte[] e = Encoding.UTF8.GetBytes(s.ToString());
                string f = Convert.ToBase64String(e);
                byte[] x;
                try {
                    x = Encoding.UTF8.GetBytes(Environment.UserDomainName + Environment.UserName);
                }
                catch(Exception ex) {
                    if(ex is PlatformNotSupportedException || ex is InvalidOperationException) {
                        x = Encoding.UTF8.GetBytes(Environment.UserName);
                        errorList += "Your platform does not support Environment.UserDomainNames, skipping!" + Environment.NewLine;
                    } else {
                        throw;
                    }
                }
                xx = GetInt(x);
                Random r = new Random(xx);
                string ra = new string(f.ToCharArray().OrderBy(_s => (r.Next(2) % 2) == 0).ToArray());
                string rb = new string(f.ToCharArray().OrderBy(_s => (r.Next(2) % 2) == 0).ToArray());
                string rc = new string(f.ToCharArray().OrderBy(_s => (r.Next(2) % 2) == 0).ToArray());

                byte[] raH = sha256.ComputeHash(Encoding.UTF8.GetBytes(ra));
                byte[] rbH = sha256.ComputeHash(Encoding.UTF8.GetBytes(rb));
                byte[] rcH = sha256.ComputeHash(Encoding.UTF8.GetBytes(rc));

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

                string raO = Convert.ToBase64String(Encoding.UTF8.GetBytes(raS.ToString()));
                string rbO = Convert.ToBase64String(Encoding.UTF8.GetBytes(rbS.ToString()));
                string rcO = Convert.ToBase64String(Encoding.UTF8.GetBytes(rcS.ToString()));

                output = raO + rbO + rcO;
            }
            if(muteErrors) {
                return output;
            } else {
                if(string.IsNullOrEmpty(errorList)) {
                    return output + Environment.NewLine + Environment.NewLine + "===== Errors =====" + Environment.NewLine + errorList;
                }
                return output;
            }
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
