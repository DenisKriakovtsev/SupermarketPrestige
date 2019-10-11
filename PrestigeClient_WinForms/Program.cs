using PrestigeClient_WinForms.PrestigeServiceReference;
using System; 
using System.Windows.Forms;

namespace PrestigeClient_WinForms
{
    static class Program
    {
        public static int Id_Cashier { get; set; }
        public static string Name_Cashier { get; set; }
        public static string Surname_Cashier { get; set; }
        public static string Patronymic_Cashier { get; set; }            

        public static int Id_WareWork { get; set; }
        public static string Name_WareWork { get; set; }
        public static string Surname_WareWork { get; set; }
        public static string Patronymic_WareWork { get; set; }
        public static DateTime  DateBeginWork_WareWork { get; set; }

        public static int Id_Admin {get; set; }
        public static string Name_Admin { get; set; }
        public static string Surname_Admin { get; set; }

        public static PrestigeServicesClient servicesClient = new PrestigeServicesClient();  

        [STAThread]
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autorization());
        }
    }
}
