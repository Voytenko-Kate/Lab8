using System;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Lab8
{
    static class Program
    {

        private static StudentData student = new StudentData();

        static void OnShutdown(object sender, EventArgs args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(StudentData));
            var stream = new StreamWriter("test.xml");
            serializer.Serialize(stream, student);
            stream.Close();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);         
            
            Application.Run(new MainForm());
        }

    }
}
